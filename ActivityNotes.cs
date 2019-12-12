using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace JTPlan {
	public partial class ActivityNotes : Form {
		ActivityDataRecord[] data;
		int activityId;
		
		public ActivityNotes(int activityId) {
			InitializeComponent();
			Text+= " "+Model.activities[activityId].data;
			data = Model.ActivityNotes(activityId);
			this.activityId = activityId;
		}
		
		void ActivityNotesLoad(object sender, EventArgs e) {
			foreach(ActivityDataRecord ar in data) {
				var item = new Label();
				item.AutoSize = true;
				item.Font = new Font("Segoe UI", 11);
				item.Text = String.Format("• {0}.{1}.: {2}", ar.d, ar.m, ar.memo);
				panelNotes.Controls.Add(item);
				panelNotes.SetFlowBreak(item, true);
			}
		}
		
		void ButtonExportClick(object sender, EventArgs e) {
			string file = "activity"+activityId+".csv";
			var writer = new StreamWriter(file);
			writer.WriteLine("y;m;d;memo");
			foreach(ActivityDataRecord ar in data) {
				String line = String.Format("{0};{1};{2};{3}", ar.y, ar.m, ar.d, ar.memo);
				writer.WriteLine(line);
			}
			writer.Close();
			MessageBox.Show("Data exportována do "+file);
		}

		void ButtonCloseClick(object sender, EventArgs e) {
			Close();
		}
	}
}
