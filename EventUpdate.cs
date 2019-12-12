using System;
using System.Windows.Forms;

namespace JTPlan {
	public partial class EventUpdate : Form {
		EventRecord data;
		
		public EventUpdate(int id) {
			InitializeComponent();
			data = id==0 ? new EventRecord() : Model.allEvents[id];
			SinceM.SelectedIndex = 4;
			LengthM.SelectedIndex = 4;
		}
		
		void EventUpdateLoad(object sender, EventArgs e) {
			Text = data.id==0 ? "Přidat událost" : "Upravit událost";
			ButtonSave.Text = data.id==0 ? "Vytvořit" : "Uložit";
			textBoxData.Text = data.data;
			SinceH.Value = (int)data.since;
			SinceM.SelectedItem = Extensions.Float2Minutes(data.since).ToString();
			LengthH.Value = (int)data.length;
			LengthM.SelectedItem = Extensions.Float2Minutes(data.length).ToString();				
		}
		
		void ButtonSaveClick(object sender, EventArgs e) {
			SinceM.SelectedIndex = SinceM.TopIndex;
			string since = String.Format("{0}:{1}", SinceH.Value, SinceM.SelectedItem);
			data.since = Extensions.Time2Float(since);
			LengthM.SelectedIndex = LengthM.TopIndex;
			string length = String.Format("{0}:{1}", LengthH.Value, LengthM.SelectedItem);
			data.length = Extensions.Time2Float(length);
			data.data = textBoxData.Text;
			var src = Owner as MainForm;
			src.saveEvent(data);
			Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e) {
			Close();
		}
		
	}
}
