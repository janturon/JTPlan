using System;
using System.Windows.Forms;

namespace JTPlan {
	public partial class ContactUpdate : Form {
		ContactRecord data;
		
		public ContactUpdate(int id) {
			InitializeComponent();
			data = id==0 ? new ContactRecord() : Model.contacts[id];
		}
		
		void ContactUpdateLoad(object sender, EventArgs e) {
			Text = data.id==0 ? "Přidat kontakt" : "Upravit kontakt";
			ButtonSave.Text = data.id==0 ? "Vytvořit" : "Uložit";
			textBoxName.Text = data.name;
			textBoxContact.Text = data.contact;	
		}

		void ButtonSaveClick(object sender, EventArgs e) {
			data.name = textBoxName.Text;
			data.contact = textBoxContact.Text;
			var src = Owner as MainForm;
			src.SaveContact(data);
			Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e) {
			Close();
		}
	}
}
