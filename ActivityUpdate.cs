using System;
using System.Windows.Forms;

namespace JTPlan {
	public partial class ActivityUpdate : Form {
		ActivityRecord data;
		ActivityDataRecord note;
		
		public ActivityUpdate(int id, int y, int m, int d)	{
			InitializeComponent();
			data = id==0 ? new ActivityRecord() : Model.activities[id];
			note = Model.activitiesData.Find(ad=>ad.activityId==id && ad.y==y && ad.m==m && ad.d==d);
			if(note==null) {
				note = new ActivityDataRecord();
				note.d = d;
				note.m = m;
				note.y = y;
				note.activityId = id;
			}
		}
		
		void ActivityUpdateLoad(object sender, EventArgs e) {
			var src = Owner as MainForm;
			if(data.id==0) {
				dateFrom.Value = new DateTime(src.year, src.month, src.day);
				data.days = 31; // Mo-Fr
			}
			chMo.DataBindings.Add("Checked", data, "Mo");	
			chTu.DataBindings.Add("Checked", data, "Tu");	
			chWe.DataBindings.Add("Checked", data, "We");	
			chTh.DataBindings.Add("Checked", data, "Th");	
			chFr.DataBindings.Add("Checked", data, "Fr");	
			chSa.DataBindings.Add("Checked", data, "Sa");	
			chSu.DataBindings.Add("Checked", data, "Su");
			Text = data.id==0 ? "Přidat aktivitu" : "Upravit aktivitu";
			ButtonSave.Text = data.id==0 ? "Vytvořit" : "Uložit";
			textBoxData.Text = data.data;
			if(data.id==0 || data.yEnd==0) dateTo.Value = new DateTime(src.year, src.month, src.day);
			else {
				dateTo.Value = new DateTime(data.yEnd, data.mEnd, data.dEnd);
				checkDeadline.Checked = true;
			}
			if(note.id!=0) {
				textBoxMemo.Text = note.memo;
				textBoxMemo.Show();
				checkMemo.Checked = true;
			}
			checkMemo.Text+= String.Format(" k {0}.{1}.", note.d, note.m);
		}
		
		void CheckDeadlineCheckedChanged(object sender, EventArgs e) {
			var src = sender as CheckBox;
			if(src.Checked) dateTo.Show();
			else dateTo.Hide();
		}

		void CheckMemoCheckedChanged(object sender, EventArgs e) {
			var src = sender as CheckBox;
			if(src.Checked) textBoxMemo.Show();
			else textBoxMemo.Hide();	
		}
		
		void ButtonSaveClick(object sender, EventArgs e) {
			data.d = dateFrom.Value.Day;
			data.m = dateFrom.Value.Month;
			data.y = dateFrom.Value.Year;
			if(!checkDeadline.Checked) data.dEnd = data.mEnd = data.yEnd = 0;
			else {
				data.dEnd = dateTo.Value.Day;
				data.mEnd = dateTo.Value.Month;
				data.yEnd = dateTo.Value.Year;
			}
			// data.days is bound
			data.data = textBoxData.Text;
			note.memo = textBoxMemo.Text;
			var src = Owner as MainForm;
			src.SaveActivity(data, checkMemo.Checked, note);
			Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e) {
			Close();
		}
	}
}
