/*
 * Created by SharpDevelop.
 * User: main
 * Date: 25.11.2019
 * Time: 20:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JTPlan
{
	partial class EventUpdate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown SinceH;
		private System.Windows.Forms.ListBox SinceM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox LengthM;
		private System.Windows.Forms.NumericUpDown LengthH;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Button ButtonCancel;
		
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
			this.textBoxData = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SinceH = new System.Windows.Forms.NumericUpDown();
			this.SinceM = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LengthM = new System.Windows.Forms.ListBox();
			this.LengthH = new System.Windows.Forms.NumericUpDown();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SinceH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LengthH)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxData
			// 
			this.textBoxData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxData.Location = new System.Drawing.Point(124, 27);
			this.textBoxData.Name = "textBoxData";
			this.textBoxData.Size = new System.Drawing.Size(247, 23);
			this.textBoxData.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(124, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Popis události";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// SinceH
			// 
			this.SinceH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SinceH.Location = new System.Drawing.Point(7, 27);
			this.SinceH.Maximum = new decimal(new int[] {
			24,
			0,
			0,
			0});
			this.SinceH.Name = "SinceH";
			this.SinceH.Size = new System.Drawing.Size(46, 23);
			this.SinceH.TabIndex = 2;
			// 
			// SinceM
			// 
			this.SinceM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SinceM.FormattingEnabled = true;
			this.SinceM.ItemHeight = 17;
			this.SinceM.Items.AddRange(new object[] {
			"00",
			"45",
			"30",
			"15",
			"00"});
			this.SinceM.Location = new System.Drawing.Point(59, 27);
			this.SinceM.Name = "SinceM";
			this.SinceM.Size = new System.Drawing.Size(43, 21);
			this.SinceM.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(7, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Začátek události";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(6, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Délka události";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// LengthM
			// 
			this.LengthM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LengthM.FormattingEnabled = true;
			this.LengthM.ItemHeight = 17;
			this.LengthM.Items.AddRange(new object[] {
			"00",
			"45",
			"30",
			"15",
			"00"});
			this.LengthM.Location = new System.Drawing.Point(58, 73);
			this.LengthM.Name = "LengthM";
			this.LengthM.Size = new System.Drawing.Size(43, 21);
			this.LengthM.TabIndex = 5;
			// 
			// LengthH
			// 
			this.LengthH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LengthH.Location = new System.Drawing.Point(6, 73);
			this.LengthH.Maximum = new decimal(new int[] {
			24,
			0,
			0,
			0});
			this.LengthH.Name = "LengthH";
			this.LengthH.Size = new System.Drawing.Size(46, 23);
			this.LengthH.TabIndex = 4;
			// 
			// ButtonSave
			// 
			this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ButtonSave.Location = new System.Drawing.Point(214, 74);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(75, 23);
			this.ButtonSave.TabIndex = 6;
			this.ButtonSave.Text = "Uložit";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ButtonCancel.Location = new System.Drawing.Point(295, 74);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
			this.ButtonCancel.TabIndex = 7;
			this.ButtonCancel.Text = "Zrušit";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// EventUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::JTPlan.gfx.bg;
			this.ClientSize = new System.Drawing.Size(385, 108);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LengthM);
			this.Controls.Add(this.LengthH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SinceM);
			this.Controls.Add(this.SinceH);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxData);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "EventUpdate";
			this.ShowIcon = false;
			this.Load += new System.EventHandler(this.EventUpdateLoad);
			((System.ComponentModel.ISupportInitialize)(this.SinceH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LengthH)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
