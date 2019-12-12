/*
 * Created by SharpDevelop.
 * User: main
 * Date: 30.11.2019
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JTPlan
{
	partial class ActivityUpdate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxData;
		private System.Windows.Forms.DateTimePicker dateFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkDeadline;
		private System.Windows.Forms.DateTimePicker dateTo;
		private System.Windows.Forms.CheckBox chMo;
		private System.Windows.Forms.CheckBox chTu;
		private System.Windows.Forms.CheckBox chWe;
		private System.Windows.Forms.CheckBox chTh;
		private System.Windows.Forms.CheckBox chFr;
		private System.Windows.Forms.CheckBox chSa;
		private System.Windows.Forms.CheckBox chSu;
		private System.Windows.Forms.CheckBox checkMemo;
		private System.Windows.Forms.TextBox textBoxMemo;
		
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
			this.textBoxData = new System.Windows.Forms.TextBox();
			this.dateFrom = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.checkDeadline = new System.Windows.Forms.CheckBox();
			this.dateTo = new System.Windows.Forms.DateTimePicker();
			this.chMo = new System.Windows.Forms.CheckBox();
			this.chTu = new System.Windows.Forms.CheckBox();
			this.chWe = new System.Windows.Forms.CheckBox();
			this.chTh = new System.Windows.Forms.CheckBox();
			this.chFr = new System.Windows.Forms.CheckBox();
			this.chSa = new System.Windows.Forms.CheckBox();
			this.chSu = new System.Windows.Forms.CheckBox();
			this.checkMemo = new System.Windows.Forms.CheckBox();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ButtonCancel.Location = new System.Drawing.Point(347, 125);
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
			this.ButtonSave.Location = new System.Drawing.Point(266, 125);
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
			this.label1.Location = new System.Drawing.Point(175, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 21);
			this.label1.TabIndex = 11;
			this.label1.Text = "Popis aktivity";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// textBoxData
			// 
			this.textBoxData.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxData.Location = new System.Drawing.Point(175, 26);
			this.textBoxData.Name = "textBoxData";
			this.textBoxData.Size = new System.Drawing.Size(247, 23);
			this.textBoxData.TabIndex = 10;
			// 
			// dateFrom
			// 
			this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dateFrom.Location = new System.Drawing.Point(12, 26);
			this.dateFrom.Name = "dateFrom";
			this.dateFrom.Size = new System.Drawing.Size(146, 23);
			this.dateFrom.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 15;
			this.label2.Text = "Začátek aktivity";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// checkDeadline
			// 
			this.checkDeadline.BackColor = System.Drawing.Color.Transparent;
			this.checkDeadline.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkDeadline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkDeadline.Location = new System.Drawing.Point(70, 56);
			this.checkDeadline.Name = "checkDeadline";
			this.checkDeadline.Size = new System.Drawing.Size(88, 24);
			this.checkDeadline.TabIndex = 16;
			this.checkDeadline.Text = "Deadline";
			this.checkDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkDeadline.UseVisualStyleBackColor = false;
			this.checkDeadline.CheckedChanged += new System.EventHandler(this.CheckDeadlineCheckedChanged);
			// 
			// dateTo
			// 
			this.dateTo.CalendarMonthBackground = System.Drawing.SystemColors.Control;
			this.dateTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dateTo.Location = new System.Drawing.Point(175, 56);
			this.dateTo.Name = "dateTo";
			this.dateTo.Size = new System.Drawing.Size(146, 23);
			this.dateTo.TabIndex = 17;
			this.dateTo.Visible = false;
			// 
			// chMo
			// 
			this.chMo.BackColor = System.Drawing.Color.Transparent;
			this.chMo.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.chMo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chMo.Location = new System.Drawing.Point(10, 117);
			this.chMo.Name = "chMo";
			this.chMo.Size = new System.Drawing.Size(26, 30);
			this.chMo.TabIndex = 18;
			this.chMo.Text = "Po";
			this.chMo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.chMo.UseVisualStyleBackColor = false;
			// 
			// chTu
			// 
			this.chTu.BackColor = System.Drawing.Color.Transparent;
			this.chTu.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.chTu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chTu.Location = new System.Drawing.Point(30, 117);
			this.chTu.Name = "chTu";
			this.chTu.Size = new System.Drawing.Size(26, 30);
			this.chTu.TabIndex = 19;
			this.chTu.Text = "Út";
			this.chTu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.chTu.UseVisualStyleBackColor = false;
			// 
			// chWe
			// 
			this.chWe.BackColor = System.Drawing.Color.Transparent;
			this.chWe.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.chWe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chWe.Location = new System.Drawing.Point(50, 117);
			this.chWe.Name = "chWe";
			this.chWe.Size = new System.Drawing.Size(26, 30);
			this.chWe.TabIndex = 20;
			this.chWe.Text = "St";
			this.chWe.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.chWe.UseVisualStyleBackColor = false;
			// 
			// chTh
			// 
			this.chTh.BackColor = System.Drawing.Color.Transparent;
			this.chTh.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.chTh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chTh.Location = new System.Drawing.Point(70, 117);
			this.chTh.Name = "chTh";
			this.chTh.Size = new System.Drawing.Size(26, 30);
			this.chTh.TabIndex = 21;
			this.chTh.Text = "Čt";
			this.chTh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.chTh.UseVisualStyleBackColor = false;
			// 
			// chFr
			// 
			this.chFr.BackColor = System.Drawing.Color.Transparent;
			this.chFr.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.chFr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chFr.Location = new System.Drawing.Point(90, 117);
			this.chFr.Name = "chFr";
			this.chFr.Size = new System.Drawing.Size(26, 30);
			this.chFr.TabIndex = 22;
			this.chFr.Text = "Pá";
			this.chFr.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.chFr.UseVisualStyleBackColor = false;
			// 
			// chSa
			// 
			this.chSa.BackColor = System.Drawing.Color.Transparent;
			this.chSa.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.chSa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chSa.Location = new System.Drawing.Point(118, 117);
			this.chSa.Name = "chSa";
			this.chSa.Size = new System.Drawing.Size(26, 30);
			this.chSa.TabIndex = 23;
			this.chSa.Text = "So";
			this.chSa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.chSa.UseVisualStyleBackColor = false;
			// 
			// chSu
			// 
			this.chSu.BackColor = System.Drawing.Color.Transparent;
			this.chSu.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.chSu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chSu.Location = new System.Drawing.Point(138, 117);
			this.chSu.Name = "chSu";
			this.chSu.Size = new System.Drawing.Size(26, 30);
			this.chSu.TabIndex = 24;
			this.chSu.Text = "Ne";
			this.chSu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.chSu.UseVisualStyleBackColor = false;
			// 
			// checkMemo
			// 
			this.checkMemo.BackColor = System.Drawing.Color.Transparent;
			this.checkMemo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkMemo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkMemo.Location = new System.Drawing.Point(12, 86);
			this.checkMemo.Name = "checkMemo";
			this.checkMemo.Size = new System.Drawing.Size(146, 24);
			this.checkMemo.TabIndex = 25;
			this.checkMemo.Text = "Poznámka";
			this.checkMemo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkMemo.UseVisualStyleBackColor = false;
			this.checkMemo.CheckedChanged += new System.EventHandler(this.CheckMemoCheckedChanged);
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxMemo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxMemo.Location = new System.Drawing.Point(175, 85);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(247, 23);
			this.textBoxMemo.TabIndex = 26;
			this.textBoxMemo.Visible = false;
			// 
			// ActivityUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::JTPlan.gfx.bg;
			this.ClientSize = new System.Drawing.Size(434, 160);
			this.Controls.Add(this.textBoxMemo);
			this.Controls.Add(this.checkMemo);
			this.Controls.Add(this.chSu);
			this.Controls.Add(this.chSa);
			this.Controls.Add(this.chFr);
			this.Controls.Add(this.chTh);
			this.Controls.Add(this.chWe);
			this.Controls.Add(this.chTu);
			this.Controls.Add(this.chMo);
			this.Controls.Add(this.dateTo);
			this.Controls.Add(this.checkDeadline);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateFrom);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxData);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "ActivityUpdate";
			this.ShowIcon = false;
			this.Load += new System.EventHandler(this.ActivityUpdateLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
