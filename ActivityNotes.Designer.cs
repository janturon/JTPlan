/*
 * Created by SharpDevelop.
 * User: main
 * Date: 11.12.2019
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JTPlan
{
	partial class ActivityNotes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel panelNotes;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonExport;
		
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panelNotes = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonExport = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panelNotes);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.buttonExport);
			this.splitContainer1.Panel2.Controls.Add(this.buttonClose);
			this.splitContainer1.Size = new System.Drawing.Size(228, 262);
			this.splitContainer1.SplitterDistance = 213;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 0;
			this.splitContainer1.TabStop = false;
			// 
			// panelNotes
			// 
			this.panelNotes.BackColor = System.Drawing.SystemColors.Control;
			this.panelNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNotes.Location = new System.Drawing.Point(0, 0);
			this.panelNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelNotes.Name = "panelNotes";
			this.panelNotes.Size = new System.Drawing.Size(228, 213);
			this.panelNotes.TabIndex = 0;
			// 
			// buttonExport
			// 
			this.buttonExport.Location = new System.Drawing.Point(84, 12);
			this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(83, 23);
			this.buttonExport.TabIndex = 1;
			this.buttonExport.Text = "Export CSV";
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.ButtonExportClick);
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(12, 12);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(66, 23);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Zavřít";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// ActivityNotes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::JTPlan.gfx.bg;
			this.ClientSize = new System.Drawing.Size(228, 262);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ActivityNotes";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Poznámky aktivity";
			this.Load += new System.EventHandler(this.ActivityNotesLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
