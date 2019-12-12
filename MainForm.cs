using System;
using System.Drawing;
using System.Windows.Forms;

namespace JTPlan {
	public partial class MainForm : Form {
		Label nullDay = new Label();
		Label activeDay;
		const string font = "Segoe UI";
		const int fontSize = 11;
		public int month, year;
		public int day {
			get { return Convert.ToInt32(activeDay.Text); }
		}
		Properties.Settings Data = Properties.Settings.Default;
		Remote remote = new Remote();
		
		public MainForm() {
			activeDay = nullDay;
			nullDay.Text = "0";
			InitializeComponent();
			InitializeData();
			InitializeHeader();
			InitializeMonth();
			InitializeContacts();
		}
		
		void InitializeData() {
			remote.dbName = textBoxDB.Text = Data.Database.Trim();
			remote.server = textBoxServer.Text = Data.Server.Trim();
			remote.login = textBoxLogin.Text = Data.Login.Trim();
			Data.Password = Data.Password.Trim();
			textBoxPassword.Text = "";
			remote.password = Extensions.Decrypt(Data.Password);
			textBoxScratch.Text = Data.Scratch.Trim();
			bool dbExists = LoadData();
			if(dbExists && !Model.Check()) {
				Model.FixDB();
				Info.Text+= " Struktura databáze opravena.";
			}
			if(Model.opened) Model.Load();
		}
		
		bool LoadData() {
			if(textBoxDB.Text.Length==0) remote.dbName = textBoxDB.Text = "calendar.db";
			var db = remote.dbName;
			Model.Open(db);
			// 1: try to open local db
			if(Model.opened) {
				Info.Text = "Pracuji s místní databází.";
				return true;                  
			}
			// 2: if FTP is not provided, create empty db
			if(!Model.opened && Data.Server.Length==0) {
				Model.Open(db, true);
				Info.Text = "Vytvořena místní databáze.";
				return false;
			}
			// 3: if FTP is provided, try to download remote db
			else if(!Model.opened && remote.DownloadDB()) {
				Model.Open(db);
				if(Model.opened) {
					Data.RemoteChanged = remote.GetDBDate() ?? DateTime.MinValue;
					Info.Text = "Stažena databáze ze serveru.";
					return true;
				}
			}
			// 4: stil no success, create empty db
			else {
				Model.Open(db, true);
				Info.Text = "Databázi ze serveru nelze stáhnout, vytvořena místní databáze.";
				return false;
			}
			return true;
		}
		
		void InitializeHeader() {
			string[] days = Data.Days.Split(',');
			for(int i = 0; i < 7; i++) {
				Label dayLabel = DayLabel(days[i]);
				PanelMonthHeader.Controls.Add(dayLabel);
			}
			ButtonMonthBack.BackColor = Color.FromArgb(200, 230, 240);
			ButtonMonthNext.BackColor = Color.FromArgb(200, 230, 240);
		}
		
		void InitializeMonth(int year=0, int month=0) {
			if(year==0) {
				if(month==0) month = DateTime.Today.Month;
				if(year==0) year = DateTime.Today.Year;
			}
			this.month = month;
			this.year = year;
			string[] months = Data.Months.Split(',');
			LabelMonth.Text = months[month-1] + " " + year;
			Model.loadMonthEvents(year, month);
			PanelMonth.SuspendLayout();
			PanelMonth.Controls.Clear();
			var date = new DateTime(year, month, 1);
			var end = DateTime.DaysInMonth(year, month);
			var clickLabel = nullDay;
			int first = date.WeekDay();
			for(int i=0; i<first; ++i) PanelMonth.Controls.Add(DayLabel(""));
			for(int i=0; i<end; i++) {
				int flowDay = i+1;
				Label dayLabel = DayLabel(flowDay.ToString());
				var flowDate = new DateTime(year, month, flowDay);
				if(flowDate == DateTime.Today) clickLabel = dayLabel;
				dayLabel.Cursor = Cursors.Hand;
				dayLabel.MouseHover+= Hover_Day;
				dayLabel.Click+= Click_Day;
				dayLabel.ContextMenuStrip = ContextMenuPanelDay;
				if(Model.events.ContainsKey(flowDay)) dayLabel.Font = new Font(dayLabel.Font, FontStyle.Bold);
				PanelMonth.Controls.Add(dayLabel);
			}
			for(int i=first+end; i<42; ++i) PanelMonth.Controls.Add(DayLabel(""));
			DayClick(clickLabel);
			PanelMonth.ResumeLayout();
		}
		
		/*
		void InitializeDays() {
			foreach(var obj in PanelMonth.Controls) {
				var src = obj as Label;
				if(src==null || src.Text=="") continue; // breaks?
				var key = Convert.ToInt32(src.Text);
				if(key>0) {
					var style = Model.events.ContainsKey(key) ? FontStyle.Bold : FontStyle.Regular;
					src.Font = new Font(src.Font, style);
				}
			}
		}
		*/
		
		void InitializeContacts() {
			PanelContacts.ContextMenuStrip = ContextMenuPanelContact;
			ShowContactsLog();
		}
		
		Label DayLabel(string dayLabel) {
			var result = new Label();
			result.Image = gfx.day;
			result.BorderStyle = BorderStyle.None;
			result.Font = new Font(font, fontSize);
			result.Margin = new Padding(0);
			result.Size = new Size(30, 20);
			result.Text = dayLabel;
			result.TextAlign = ContentAlignment.MiddleCenter;
			return result;
		}
		
		void ShowDayLog(int dayIndex) {
			PanelDay.Controls.Clear();
			if(Model.events.ContainsKey(dayIndex))
			foreach(EventRecord rec in Model.events[dayIndex]) {
				var item = new Label();
				item.AutoSize = true;
				item.Font = new Font(font, fontSize);
				item.Tag = rec.id;
				item.Text = EventLine(rec);
				item.ContextMenuStrip = ContextMenuEvent;
				item.Click+= LabelEventModifyClick;
				PanelDay.Controls.Add(item);
				PanelDay.SetFlowBreak(item, true);
			}
			if(activeDay!=nullDay)
			foreach(var kv in Model.activities) {
				var flowDay = new DateTime(year, month, dayIndex);
				var dow = flowDay.DayOfWeek;
				if(dow==DayOfWeek.Monday && !kv.Value.Mo) continue;
				if(dow==DayOfWeek.Tuesday && !kv.Value.Tu) continue;
				if(dow==DayOfWeek.Wednesday && !kv.Value.We) continue;
				if(dow==DayOfWeek.Thursday && !kv.Value.Th) continue;
				if(dow==DayOfWeek.Friday && !kv.Value.Fr) continue;
				if(dow==DayOfWeek.Saturday && !kv.Value.Sa) continue;
				if(dow==DayOfWeek.Sunday && !kv.Value.Su) continue;
				var item = new Label();
				item.AutoSize = true;
				item.Font = new Font(font, fontSize);
				item.Tag = kv.Value.id;
				item.Text = ActivityLine(kv.Value);
				item.ContextMenuStrip = ContextMenuActivity;
				item.Click+= LabelActivityModifyClick;
				PanelDay.Controls.Add(item);
				PanelDay.SetFlowBreak(item, true);
			}
		}
		
		void ShowContactsLog() {
			PanelContacts.Controls.Clear();
			foreach(var kv in Model.contacts) {
				var item = new Label();
				item.AutoSize = true;
				item.Font = new Font(font, fontSize);
				item.Tag = kv.Value.id;
				item.Text = String.Format("• {0}: {1}", kv.Value.name, kv.Value.contact);
				item.ContextMenuStrip = ContextMenuContact;
				item.Click+= LabelContactModifyClick;
				PanelContacts.Controls.Add(item);
				PanelContacts.SetFlowBreak(item, true);
			}			
		}
		
		string EventLine(EventRecord rec) {
			string result = "• ";
			if(rec.since>0 && rec.length>0) {
				string since = Extensions.Float2Time(rec.since);
				string until = Extensions.Float2Time(rec.since + rec.length);
				result+= String.Format("({0} až {1}) ", since, until);
			}
			else if(rec.since>0 && rec.length<0.01) {
				result+= String.Format("(v {0}) ", Extensions.Float2Time(rec.since));
			}
			else if(rec.since<0.01 && rec.length>0) {
				result+= String.Format("(trvání {0}) ", Extensions.Float2Time(rec.length));
			}
			result+= rec.data;
			return result;
		}
		
		string ActivityLine(ActivityRecord rec) {
			string result = "• ";
			if(rec.yEnd>0) {
				var today = new DateTime(year, month, day);
				var end = new DateTime(rec.yEnd, rec.mEnd, rec.dEnd);
				int days = (end-today).Days;
				result+= String.Format("(deadline {0}) ", Extensions.DayInflex(days));
			}
			result+= rec.data;
			return result;
		}
		
		int DayRightClick() {
			var dayResult = 0;
			var clickedLabel = ContextMenuPanelDay.SourceControl as Label;
			if(clickedLabel != null) {
				dayResult = Int32.Parse(clickedLabel.Text);
				if(activeDay!=clickedLabel) DayClick(clickedLabel);
			}
			var clickedPanel = ContextMenuPanelDay.SourceControl as Panel;
			if(clickedPanel!=null && activeDay!=nullDay) {
				dayResult = day;
			}
			return dayResult;
		}
		
		void DayClick(Label src) {
			if(src==activeDay) {
				activeDay = nullDay;
				src.Image = gfx.day;
				PanelDay.ContextMenuStrip = null;
			}
			else {
				PanelDay.ContextMenuStrip = ContextMenuPanelDay;
				activeDay.Image = gfx.day;
				activeDay = src;
				src.Image = gfx.day1;
				int index = Int32.Parse(src.Text);
				ShowDayLog(index);
			}			
		}
		
		void RefreshData() {
			Model.Open();
			Model.Load();
			InitializeMonth(year, month);
			ShowDayLog(day);			
		}
		
		// EVENTS
		
		public void saveEvent(EventRecord rec) {
			if(rec.id==0) {
				rec.y = year; rec.m = month; rec.d = day;
				Model.insertEvent(rec);
				activeDay.Font = new Font(activeDay.Font, FontStyle.Bold);
			}
			else Model.updateEvent(rec);
			ShowDayLog(day);
		}
				
		public void DeleteEvent(int eventId) {
			Model.deleteEvent(eventId);
			ShowDayLog(day);
			if(Model.events.ContainsKey(day))
			if(Model.events[day].Count==0) activeDay.Font = new Font(activeDay.Font, FontStyle.Regular);
		}
		
		public void SaveActivity(ActivityRecord rec, bool noteOn, ActivityDataRecord note) {
			if(rec.id==0) {
				rec.y = year; rec.m = month; rec.d = day;
				Model.insertActivity(rec);
			}
			else Model.updateActivity(rec);
			if(noteOn) Model.setActivityData(note);
			else Model.unsetActivityData(note);
			ShowDayLog(day);			
		}
		
		public void DeleteActivity(int activityId) {
			Model.deleteActivity(activityId);
			ShowDayLog(day);
		}
		
		public void SaveContact(ContactRecord rec) {
			if(rec.id==0) Model.insertContact(rec);
			else Model.updateContact(rec);
			ShowContactsLog();
		}
		
		public void DeleteContact(int contactId) {
			Model.deleteContact(contactId);
			ShowContactsLog();			
		}

		void Click_ShiftMonth(object sender, EventArgs e) {
			var src = sender as Button;
			int dir = src.Text=="<" ? -1 : +1;
			var shiftedDate = new DateTime(year, month, 1).AddMonths(dir);
			InitializeMonth(shiftedDate.Year, shiftedDate.Month);
		}
		
		void Hover_Day(object sender, EventArgs e) {
			if(activeDay==nullDay) {
				var src = sender as Label;
				int index = Int32.Parse(src.Text);
				ShowDayLog(index);
			}
		}
		
		void Click_Day(object sender, EventArgs e) {
			var src = sender as Label;
			DayClick(src);
		}
		
		void Enter_PanelEvents(object sender, EventArgs e){
			if(activeDay==nullDay) PanelDay.Controls.Clear();
		}
		
		void Cme_ModifyClick(object sender, EventArgs e) {
			var src = ContextMenuEvent.SourceControl as Label;
			var eventId = Convert.ToInt32(src.Tag);
			new EventUpdate(eventId).Show(this);
		}
		
		void Cme_DeleteClick(object sender, EventArgs e) {
			var src = ContextMenuEvent.SourceControl as Label;
			var eventId = Convert.ToInt32(src.Tag);
			var msg = String.Format("Smazat {0}?", src.Text);
			var result = MessageBox.Show(msg, "Smazat událost", MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes) DeleteEvent(eventId);
		}
		
		void Cma_ModifyClick(object sender, EventArgs e) {
			var src = ContextMenuActivity.SourceControl as Label;
			var activityId = Convert.ToInt32(src.Tag);
			new ActivityUpdate(activityId, year, month, day).Show(this);
		}
		
		void Cma_DeleteClick(object sender, EventArgs e) {
			var src = ContextMenuActivity.SourceControl as Label;
			var activityId = Convert.ToInt32(src.Tag);
			var msg = String.Format("Smazat {0}?", src.Text);
			var result = MessageBox.Show(msg, "Smazat událost", MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes) DeleteActivity(activityId);
		}

		void Cma_ShowNotesClick(object sender, EventArgs e) {
			var src = ContextMenuActivity.SourceControl as Label;
			var activityId = Convert.ToInt32(src.Tag);
			new ActivityNotes(activityId).Show(this);
		}
		
		void Cmc_ModifyClick(object sender, EventArgs e) {
			var src = ContextMenuContact.SourceControl as Label;
			var contactId = Convert.ToInt32(src.Tag);
			new ContactUpdate(contactId).Show(this);

		}
		
		void Cmc_DeleteClick(object sender, EventArgs e) {
			var src = ContextMenuContact.SourceControl as Label;
			var contactId = Convert.ToInt32(src.Tag);
			var msg = String.Format("Smazat {0}?", src.Text);
			var result = MessageBox.Show(msg, "Smazat kontakt", MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes) DeleteContact(contactId);
		}

		void Cmd_AddEventClick(object sender, EventArgs e) {
			if(DayRightClick()!=0) new EventUpdate(0).Show(this);
		}
		
		void Cmd_AddActivityClick(object sender, EventArgs e) {
			if(DayRightClick()!=0) new ActivityUpdate(0, year, month, day).Show(this);
		}
		
		void Cmd_ShowNonActivitiesClick(object sender, EventArgs e) {
			var src = Model.NonActivities();
			if(src.Length==0) {
				Info.Text = "Všechny aktivity jsou pravidelné.";
				return;
			}
			PanelDay.Controls.Clear();
			foreach(ActivityRecord ac in src) {
				var item = new Label();
				item.AutoSize = true;
				item.Font = new Font(font, fontSize);
				item.Tag = ac.id;
				item.Text = ActivityLine(ac);
				item.ContextMenuStrip = ContextMenuActivity;
				item.Click+= LabelActivityModifyClick;
				PanelDay.Controls.Add(item);
				PanelDay.SetFlowBreak(item, true);
			}
			Info.Text = "Tyto aktivity nemají nastaven žádný den zobrazování.";
		}

		void Cmc_AddContactClick(object sender, EventArgs e) {
			new ContactUpdate(0).Show(this);
		}
		
		void LabelEventModifyClick(object sender, EventArgs e) {
			var src = sender as Label;
			var eventId = Convert.ToInt32(src.Tag);
			new EventUpdate(eventId).Show(this);
		}
		
		void LabelActivityModifyClick(object sender, EventArgs e) {
			var src = sender as Label;
			var activityId = Convert.ToInt32(src.Tag);
			new ActivityUpdate(activityId, year, month, day).Show(this);

		}

		void LabelContactModifyClick(object sender, EventArgs e) {
			var src = sender as Label;
			var contactId = Convert.ToInt32(src.Tag);
			new ContactUpdate(contactId).Show(this);
		}
		
		void ButtonKeyDown(object sender, KeyEventArgs e) {
			switch(e.KeyCode) {
				case Keys.T: buttonTest.Focus(); return;
				case Keys.N: buttonUpload.Focus(); return;
				case Keys.S: buttonDownload.Focus(); return;
				case Keys.H: buttonHelp.Focus(); return;
				case Keys.X: buttonSync.Focus(); return;
				case Keys.Left: ButtonMonthBack.Focus(); return;
				case Keys.Right: ButtonMonthNext.Focus(); return;
			}
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e) {
		}
		
		void TextBoxSave(object sender, EventArgs e) {
			var database = textBoxDB.Text.Trim();
			if(database.Length>0) remote.dbName = Data.Database = database;
			var server = textBoxServer.Text.Trim();
			if(server.Length>0) remote.server = Data.Server = server;
			var login = textBoxLogin.Text.Trim();
			if(login.Length>0) remote.login = Data.Login = login;
			Data.Scratch = textBoxScratch.Text.Trim();
			var password = textBoxPassword.Text.Trim();
			if(password.Length>0) {
				remote.password = password;
				Data.Password = Extensions.Encrypt(password);
				textBoxPassword.Text = "";
				Info.Text = "Heslo k serveru zašifrováno a uloženo.";
			}
			Data.Save();
		}
		
		void ButtonTestClick(object sender, EventArgs e) {
			DateTime remoteDate = remote.GetDBDate() ?? DateTime.MinValue;
			if(remoteDate!=DateTime.MinValue) {
				bool datechanged = remoteDate==Data.RemoteChanged;
				Info.Text = "Databáze na serveru od posledního testu " + (datechanged ? "nezměněna." : "změněna");
				Data.RemoteChanged = remoteDate;
			}
			else {
				Info.Text = "Databáze na serveru nenalezena.";
			}
		}
		
		void ButtonUploadClick(object sender, EventArgs e) {
			Model.Close();
			bool uploaded = remote.UploadDB();
			RefreshData();
			Info.Text = "Databáze na server " + (uploaded ? "nahrána." : "nenahrána.");
			if(uploaded) Data.RemoteChanged = remote.GetDBDate() ?? DateTime.MinValue;
		}
		
		void ButtonDownloadClick(object sender, EventArgs e) {
			if(Data.Server.Length==0) {
				Info.Text = "Server není nastaven, není odkud stahovat.";
				return;
			}
			Model.Close();
			bool downloaded = remote.DownloadDB(".download");
			Info.Text = "Databáze ze serveru " + (downloaded ? "stažena." : "nestažena.");
			if(Data.Password.Length==0) Info.Text+= " Heslo není uloženo.";
			if(downloaded) remote.ReplaceDBWith(".download");
			RefreshData();
		}
		
		void ButtonSyncClick(object sender, EventArgs e) {
			if(Data.Server.Length==0) {
				Info.Text = "Server není nastaven, není odkud stahovat.";
				return;
			}
			bool downloaded = remote.DownloadDB(".tmp");
			if(!downloaded) {
				Info.Text = "Nedaří se stáhnout databázi ze serveru.";
				return;
			}
			int[] af = Model.Merge(Data.Database+".tmp");
			Model.Close();
			System.IO.File.Delete(Data.Database+".tmp");
			Info.Text = String.Format("Ze serveru přidáno: události ({0}), aktivity ({1}), poznámky aktivit ({3}), kontakty ({2}).",
							af[0], af[1], af[2], af[3]);
			bool uploaded = false;
			if(af[0]>0 || af[1]>0 || af[2]>0) {
				uploaded = remote.UploadDB();
				Data.RemoteChanged = remote.GetDBDate() ?? DateTime.MinValue;
			}
			RefreshData();
			Info.Text+= " Databáze na serveru " + (uploaded ? "aktualizována." : "ponechána.");
		}
	}
}
