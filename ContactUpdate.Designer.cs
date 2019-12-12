/*
 * Created by SharpDevelop.
 * User: main
 * Date: 3.12.2019
 * Time: 20:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JTPlan
{
	partial class ContactUpdate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxContact;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxContact = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ButtonCancel.Location = new System.Drawing.Point(333, 75);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 13;
			this.ButtonCancel.Text = "Zrušit";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// ButtonSave
			// 
			this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ButtonSave.Location = new System.Drawing.Point(252, 75);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(75, 23);
			this.ButtonSave.TabIndex = 12;
			this.ButtonSave.Text = "Uložit";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(162, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "Kontakt";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// textBoxContact
			// 
			this.textBoxContact.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxContact.Location = new System.Drawing.Point(162, 28);
			this.textBoxContact.Name = "textBoxContact";
			this.textBoxContact.Size = new System.Drawing.Size(247, 23);
			this.textBoxContact.TabIndex = 10;
			// 
			// textBoxName
			// 
			this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxName.Location = new System.Drawing.Point(12, 28);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(144, 23);
			this.textBoxName.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "Jméno";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// ContactUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::JTPlan.gfx.bg;
			this.ClientSize = new System.Drawing.Size(421, 108);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxContact);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "ContactUpdate";
			this.ShowIcon = false;
			this.Load += new System.EventHandler(this.ContactUpdateLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
