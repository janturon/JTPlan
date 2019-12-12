
namespace JTPlan {
	partial class MainForm {
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel PanelMonthHeader;
		private System.Windows.Forms.Label LabelMonth;
		private System.Windows.Forms.Button ButtonMonthBack;
		private System.Windows.Forms.Button ButtonMonthNext;
		private System.Windows.Forms.FlowLayoutPanel PanelMonth;
		private System.Windows.Forms.Panel PanelMonthWrap;
		private System.Windows.Forms.FlowLayoutPanel PanelDay;
		private System.Windows.Forms.ContextMenuStrip ContextMenuEvent;
		private System.Windows.Forms.ToolStripMenuItem cme_Delete;
		private System.Windows.Forms.ToolStripMenuItem cme_Modify;
		private System.Windows.Forms.ContextMenuStrip ContextMenuPanelDay;
		private System.Windows.Forms.ToolStripMenuItem cmd_AddEvent;
		private System.Windows.Forms.Label LabelContacts;
		private System.Windows.Forms.ToolStripMenuItem cmd_AddActivity;
		private System.Windows.Forms.ContextMenuStrip ContextMenuActivity;
		private System.Windows.Forms.ToolStripMenuItem cma_Modify;
		private System.Windows.Forms.ToolStripMenuItem cma_Delete;
		private System.Windows.Forms.Panel PanelLabel1;
		private System.Windows.Forms.Panel PanelLabel2;
		private System.Windows.Forms.Panel PanelLabel3;
		private System.Windows.Forms.Label labelServer;
		private System.Windows.Forms.TextBox textBoxServer;
		private System.Windows.Forms.Button buttonUpload;
		private System.Windows.Forms.Button buttonDownload;
		private System.Windows.Forms.TextBox textBoxScratch;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonTest;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxDB;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonSync;
		private System.Windows.Forms.Button buttonHelp;
		private System.Windows.Forms.ContextMenuStrip ContextMenuPanelContact;
		private System.Windows.Forms.ToolStripMenuItem cmc_AddContact;
		private System.Windows.Forms.FlowLayoutPanel PanelContacts;
		private System.Windows.Forms.ContextMenuStrip ContextMenuContact;
		private System.Windows.Forms.ToolStripMenuItem cmc_Modify;
		private System.Windows.Forms.ToolStripMenuItem cmc_Delete;
		private System.Windows.Forms.StatusStrip MainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel Info;
		private System.Windows.Forms.ToolStripMenuItem cmd_ShowNonActivities;
		private System.Windows.Forms.ToolStripMenuItem cma_ShowNotes;
		
		protected override void Dispose(bool disposing) {
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.PanelMonthHeader = new System.Windows.Forms.FlowLayoutPanel();
			this.PanelMonth = new System.Windows.Forms.FlowLayoutPanel();
			this.LabelMonth = new System.Windows.Forms.Label();
			this.ButtonMonthBack = new System.Windows.Forms.Button();
			this.ButtonMonthNext = new System.Windows.Forms.Button();
			this.PanelMonthWrap = new System.Windows.Forms.Panel();
			this.PanelDay = new System.Windows.Forms.FlowLayoutPanel();
			this.ContextMenuEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cme_Modify = new System.Windows.Forms.ToolStripMenuItem();
			this.cme_Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuPanelDay = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmd_AddEvent = new System.Windows.Forms.ToolStripMenuItem();
			this.cmd_AddActivity = new System.Windows.Forms.ToolStripMenuItem();
			this.cmd_ShowNonActivities = new System.Windows.Forms.ToolStripMenuItem();
			this.LabelContacts = new System.Windows.Forms.Label();
			this.ContextMenuActivity = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cma_Modify = new System.Windows.Forms.ToolStripMenuItem();
			this.cma_Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.cma_ShowNotes = new System.Windows.Forms.ToolStripMenuItem();
			this.PanelLabel1 = new System.Windows.Forms.Panel();
			this.PanelLabel2 = new System.Windows.Forms.Panel();
			this.PanelLabel3 = new System.Windows.Forms.Panel();
			this.labelServer = new System.Windows.Forms.Label();
			this.textBoxServer = new System.Windows.Forms.TextBox();
			this.buttonUpload = new System.Windows.Forms.Button();
			this.buttonDownload = new System.Windows.Forms.Button();
			this.textBoxScratch = new System.Windows.Forms.TextBox();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonTest = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxDB = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonSync = new System.Windows.Forms.Button();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.ContextMenuPanelContact = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmc_AddContact = new System.Windows.Forms.ToolStripMenuItem();
			this.PanelContacts = new System.Windows.Forms.FlowLayoutPanel();
			this.ContextMenuContact = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmc_Modify = new System.Windows.Forms.ToolStripMenuItem();
			this.cmc_Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.Info = new System.Windows.Forms.ToolStripStatusLabel();
			this.PanelMonthWrap.SuspendLayout();
			this.ContextMenuEvent.SuspendLayout();
			this.ContextMenuPanelDay.SuspendLayout();
			this.ContextMenuActivity.SuspendLayout();
			this.PanelLabel1.SuspendLayout();
			this.PanelLabel2.SuspendLayout();
			this.PanelLabel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.ContextMenuPanelContact.SuspendLayout();
			this.ContextMenuContact.SuspendLayout();
			this.MainStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelMonthHeader
			// 
			this.PanelMonthHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.PanelMonthHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelMonthHeader.Location = new System.Drawing.Point(0, 0);
			this.PanelMonthHeader.Margin = new System.Windows.Forms.Padding(0);
			this.PanelMonthHeader.Name = "PanelMonthHeader";
			this.PanelMonthHeader.Size = new System.Drawing.Size(211, 21);
			this.PanelMonthHeader.TabIndex = 0;
			// 
			// PanelMonth
			// 
			this.PanelMonth.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.PanelMonth.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PanelMonth.Location = new System.Drawing.Point(0, 24);
			this.PanelMonth.Margin = new System.Windows.Forms.Padding(0);
			this.PanelMonth.Name = "PanelMonth";
			this.PanelMonth.Size = new System.Drawing.Size(211, 121);
			this.PanelMonth.TabIndex = 4;
			// 
			// LabelMonth
			// 
			this.LabelMonth.BackColor = System.Drawing.Color.Transparent;
			this.LabelMonth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelMonth.Location = new System.Drawing.Point(0, 0);
			this.LabelMonth.Name = "LabelMonth";
			this.LabelMonth.Size = new System.Drawing.Size(143, 27);
			this.LabelMonth.TabIndex = 1;
			this.LabelMonth.Text = "(měsíc)";
			this.LabelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonMonthBack
			// 
			this.ButtonMonthBack.BackColor = System.Drawing.SystemColors.Control;
			this.ButtonMonthBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonMonthBack.Location = new System.Drawing.Point(12, 10);
			this.ButtonMonthBack.Name = "ButtonMonthBack";
			this.ButtonMonthBack.Size = new System.Drawing.Size(27, 27);
			this.ButtonMonthBack.TabIndex = 1;
			this.ButtonMonthBack.Text = "<";
			this.ButtonMonthBack.UseVisualStyleBackColor = false;
			this.ButtonMonthBack.Click += new System.EventHandler(this.Click_ShiftMonth);
			this.ButtonMonthBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonKeyDown);
			// 
			// ButtonMonthNext
			// 
			this.ButtonMonthNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonMonthNext.Location = new System.Drawing.Point(194, 10);
			this.ButtonMonthNext.Name = "ButtonMonthNext";
			this.ButtonMonthNext.Size = new System.Drawing.Size(27, 27);
			this.ButtonMonthNext.TabIndex = 2;
			this.ButtonMonthNext.Text = ">";
			this.ButtonMonthNext.UseVisualStyleBackColor = true;
			this.ButtonMonthNext.Click += new System.EventHandler(this.Click_ShiftMonth);
			this.ButtonMonthNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonKeyDown);
			// 
			// PanelMonthWrap
			// 
			this.PanelMonthWrap.BackColor = System.Drawing.Color.Transparent;
			this.PanelMonthWrap.Controls.Add(this.PanelMonth);
			this.PanelMonthWrap.Controls.Add(this.PanelMonthHeader);
			this.PanelMonthWrap.Location = new System.Drawing.Point(10, 43);
			this.PanelMonthWrap.Name = "PanelMonthWrap";
			this.PanelMonthWrap.Size = new System.Drawing.Size(211, 145);
			this.PanelMonthWrap.TabIndex = 5;
			// 
			// PanelDay
			// 
			this.PanelDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelDay.Location = new System.Drawing.Point(10, 194);
			this.PanelDay.Name = "PanelDay";
			this.PanelDay.Size = new System.Drawing.Size(462, 140);
			this.PanelDay.TabIndex = 6;
			this.PanelDay.MouseEnter += new System.EventHandler(this.Enter_PanelEvents);
			// 
			// ContextMenuEvent
			// 
			this.ContextMenuEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cme_Modify,
			this.cme_Delete});
			this.ContextMenuEvent.Name = "ContextMenuEvent";
			this.ContextMenuEvent.Size = new System.Drawing.Size(155, 48);
			// 
			// cme_Modify
			// 
			this.cme_Modify.Name = "cme_Modify";
			this.cme_Modify.Size = new System.Drawing.Size(154, 22);
			this.cme_Modify.Text = "Upravit událost";
			this.cme_Modify.Click += new System.EventHandler(this.Cme_ModifyClick);
			// 
			// cme_Delete
			// 
			this.cme_Delete.Name = "cme_Delete";
			this.cme_Delete.Size = new System.Drawing.Size(154, 22);
			this.cme_Delete.Text = "Smazat událost";
			this.cme_Delete.Click += new System.EventHandler(this.Cme_DeleteClick);
			// 
			// ContextMenuPanelDay
			// 
			this.ContextMenuPanelDay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cmd_AddEvent,
			this.cmd_AddActivity,
			this.cmd_ShowNonActivities});
			this.ContextMenuPanelDay.Name = "contextMenuDay";
			this.ContextMenuPanelDay.Size = new System.Drawing.Size(164, 70);
			// 
			// cmd_AddEvent
			// 
			this.cmd_AddEvent.Name = "cmd_AddEvent";
			this.cmd_AddEvent.Size = new System.Drawing.Size(163, 22);
			this.cmd_AddEvent.Text = "Přidat událost";
			this.cmd_AddEvent.Click += new System.EventHandler(this.Cmd_AddEventClick);
			// 
			// cmd_AddActivity
			// 
			this.cmd_AddActivity.Name = "cmd_AddActivity";
			this.cmd_AddActivity.Size = new System.Drawing.Size(163, 22);
			this.cmd_AddActivity.Text = "Přidat aktivitu";
			this.cmd_AddActivity.Click += new System.EventHandler(this.Cmd_AddActivityClick);
			// 
			// cmd_ShowNonActivities
			// 
			this.cmd_ShowNonActivities.Name = "cmd_ShowNonActivities";
			this.cmd_ShowNonActivities.Size = new System.Drawing.Size(163, 22);
			this.cmd_ShowNonActivities.Text = "Ukázat neaktivity";
			this.cmd_ShowNonActivities.Click += new System.EventHandler(this.Cmd_ShowNonActivitiesClick);
			// 
			// LabelContacts
			// 
			this.LabelContacts.BackColor = System.Drawing.Color.Transparent;
			this.LabelContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelContacts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LabelContacts.Location = new System.Drawing.Point(0, 0);
			this.LabelContacts.Name = "LabelContacts";
			this.LabelContacts.Size = new System.Drawing.Size(245, 27);
			this.LabelContacts.TabIndex = 7;
			this.LabelContacts.Text = "Kontakty";
			this.LabelContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ContextMenuActivity
			// 
			this.ContextMenuActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cma_Modify,
			this.cma_Delete,
			this.cma_ShowNotes});
			this.ContextMenuActivity.Name = "contextMenuActivity";
			this.ContextMenuActivity.Size = new System.Drawing.Size(168, 92);
			// 
			// cma_Modify
			// 
			this.cma_Modify.Name = "cma_Modify";
			this.cma_Modify.Size = new System.Drawing.Size(167, 22);
			this.cma_Modify.Text = "Upravit aktivitu";
			this.cma_Modify.Click += new System.EventHandler(this.Cma_ModifyClick);
			// 
			// cma_Delete
			// 
			this.cma_Delete.Name = "cma_Delete";
			this.cma_Delete.Size = new System.Drawing.Size(167, 22);
			this.cma_Delete.Text = "Smazat aktivitu";
			this.cma_Delete.Click += new System.EventHandler(this.Cma_DeleteClick);
			// 
			// cma_ShowNotes
			// 
			this.cma_ShowNotes.Name = "cma_ShowNotes";
			this.cma_ShowNotes.Size = new System.Drawing.Size(167, 22);
			this.cma_ShowNotes.Text = "Ukázat poznámky";
			this.cma_ShowNotes.Click += new System.EventHandler(this.Cma_ShowNotesClick);
			// 
			// PanelLabel1
			// 
			this.PanelLabel1.BackColor = System.Drawing.Color.Transparent;
			this.PanelLabel1.Controls.Add(this.LabelMonth);
			this.PanelLabel1.Location = new System.Drawing.Point(45, 10);
			this.PanelLabel1.Name = "PanelLabel1";
			this.PanelLabel1.Size = new System.Drawing.Size(143, 27);
			this.PanelLabel1.TabIndex = 9;
			// 
			// PanelLabel2
			// 
			this.PanelLabel2.BackColor = System.Drawing.Color.Transparent;
			this.PanelLabel2.Controls.Add(this.LabelContacts);
			this.PanelLabel2.Location = new System.Drawing.Point(227, 10);
			this.PanelLabel2.Name = "PanelLabel2";
			this.PanelLabel2.Size = new System.Drawing.Size(245, 27);
			this.PanelLabel2.TabIndex = 10;
			// 
			// PanelLabel3
			// 
			this.PanelLabel3.BackColor = System.Drawing.Color.Transparent;
			this.PanelLabel3.Controls.Add(this.labelServer);
			this.PanelLabel3.Location = new System.Drawing.Point(478, 10);
			this.PanelLabel3.Name = "PanelLabel3";
			this.PanelLabel3.Size = new System.Drawing.Size(245, 27);
			this.PanelLabel3.TabIndex = 11;
			// 
			// labelServer
			// 
			this.labelServer.BackColor = System.Drawing.Color.Transparent;
			this.labelServer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelServer.Location = new System.Drawing.Point(0, 0);
			this.labelServer.Name = "labelServer";
			this.labelServer.Size = new System.Drawing.Size(245, 27);
			this.labelServer.TabIndex = 7;
			this.labelServer.Text = "FTP Server";
			this.labelServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxServer
			// 
			this.textBoxServer.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxServer.Location = new System.Drawing.Point(478, 43);
			this.textBoxServer.Name = "textBoxServer";
			this.textBoxServer.Size = new System.Drawing.Size(243, 23);
			this.textBoxServer.TabIndex = 3;
			this.textBoxServer.Leave += new System.EventHandler(this.TextBoxSave);
			// 
			// buttonUpload
			// 
			this.buttonUpload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonUpload.Location = new System.Drawing.Point(542, 129);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new System.Drawing.Size(87, 27);
			this.buttonUpload.TabIndex = 8;
			this.buttonUpload.Text = "Nahrej tam";
			this.buttonUpload.UseVisualStyleBackColor = true;
			this.buttonUpload.Click += new System.EventHandler(this.ButtonUploadClick);
			this.buttonUpload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonKeyDown);
			// 
			// buttonDownload
			// 
			this.buttonDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonDownload.Location = new System.Drawing.Point(635, 129);
			this.buttonDownload.Name = "buttonDownload";
			this.buttonDownload.Size = new System.Drawing.Size(87, 27);
			this.buttonDownload.TabIndex = 9;
			this.buttonDownload.Text = "Stáhni sem";
			this.buttonDownload.UseVisualStyleBackColor = true;
			this.buttonDownload.Click += new System.EventHandler(this.ButtonDownloadClick);
			this.buttonDownload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonKeyDown);
			// 
			// textBoxScratch
			// 
			this.textBoxScratch.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxScratch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxScratch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxScratch.Location = new System.Drawing.Point(478, 194);
			this.textBoxScratch.Multiline = true;
			this.textBoxScratch.Name = "textBoxScratch";
			this.textBoxScratch.Size = new System.Drawing.Size(243, 140);
			this.textBoxScratch.TabIndex = 15;
			this.textBoxScratch.Leave += new System.EventHandler(this.TextBoxSave);
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxLogin.Location = new System.Drawing.Point(478, 93);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(72, 23);
			this.textBoxLogin.TabIndex = 4;
			this.textBoxLogin.Leave += new System.EventHandler(this.TextBoxSave);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(478, 66);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(72, 24);
			this.panel1.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "login";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(557, 66);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(72, 24);
			this.panel2.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "heslo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonTest
			// 
			this.buttonTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonTest.Location = new System.Drawing.Point(478, 129);
			this.buttonTest.Name = "buttonTest";
			this.buttonTest.Size = new System.Drawing.Size(57, 27);
			this.buttonTest.TabIndex = 7;
			this.buttonTest.Text = "Test";
			this.buttonTest.UseVisualStyleBackColor = true;
			this.buttonTest.Click += new System.EventHandler(this.ButtonTestClick);
			this.buttonTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonKeyDown);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(637, 66);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(84, 24);
			this.panel3.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "databáze";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxDB
			// 
			this.textBoxDB.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxDB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxDB.Location = new System.Drawing.Point(637, 93);
			this.textBoxDB.Name = "textBoxDB";
			this.textBoxDB.Size = new System.Drawing.Size(84, 23);
			this.textBoxDB.TabIndex = 6;
			this.textBoxDB.Leave += new System.EventHandler(this.TextBoxSave);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxPassword.Location = new System.Drawing.Point(557, 93);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(72, 23);
			this.textBoxPassword.TabIndex = 5;
			this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxSave);
			// 
			// buttonSync
			// 
			this.buttonSync.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSync.Location = new System.Drawing.Point(542, 161);
			this.buttonSync.Name = "buttonSync";
			this.buttonSync.Size = new System.Drawing.Size(87, 27);
			this.buttonSync.TabIndex = 11;
			this.buttonSync.Text = "Synchronizuj";
			this.buttonSync.UseVisualStyleBackColor = true;
			this.buttonSync.Click += new System.EventHandler(this.ButtonSyncClick);
			this.buttonSync.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonKeyDown);
			// 
			// buttonHelp
			// 
			this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonHelp.Location = new System.Drawing.Point(478, 161);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(57, 27);
			this.buttonHelp.TabIndex = 10;
			this.buttonHelp.Text = "Help";
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonKeyDown);
			// 
			// ContextMenuPanelContact
			// 
			this.ContextMenuPanelContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cmc_AddContact});
			this.ContextMenuPanelContact.Name = "ContextMenuContact";
			this.ContextMenuPanelContact.Size = new System.Drawing.Size(149, 26);
			// 
			// cmc_AddContact
			// 
			this.cmc_AddContact.Name = "cmc_AddContact";
			this.cmc_AddContact.Size = new System.Drawing.Size(148, 22);
			this.cmc_AddContact.Text = "Přidat kontakt";
			this.cmc_AddContact.Click += new System.EventHandler(this.Cmc_AddContactClick);
			// 
			// PanelContacts
			// 
			this.PanelContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelContacts.Location = new System.Drawing.Point(227, 43);
			this.PanelContacts.Name = "PanelContacts";
			this.PanelContacts.Size = new System.Drawing.Size(245, 145);
			this.PanelContacts.TabIndex = 24;
			// 
			// ContextMenuContact
			// 
			this.ContextMenuContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cmc_Modify,
			this.cmc_Delete});
			this.ContextMenuContact.Name = "ContextMenuContact";
			this.ContextMenuContact.Size = new System.Drawing.Size(156, 48);
			// 
			// cmc_Modify
			// 
			this.cmc_Modify.Name = "cmc_Modify";
			this.cmc_Modify.Size = new System.Drawing.Size(155, 22);
			this.cmc_Modify.Text = "Upravit kontakt";
			this.cmc_Modify.Click += new System.EventHandler(this.Cmc_ModifyClick);
			// 
			// cmc_Delete
			// 
			this.cmc_Delete.Name = "cmc_Delete";
			this.cmc_Delete.Size = new System.Drawing.Size(155, 22);
			this.cmc_Delete.Text = "Smazat kontakt";
			this.cmc_Delete.Click += new System.EventHandler(this.Cmc_DeleteClick);
			// 
			// MainStatusStrip
			// 
			this.MainStatusStrip.AutoSize = false;
			this.MainStatusStrip.BackColor = System.Drawing.Color.Transparent;
			this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.Info});
			this.MainStatusStrip.Location = new System.Drawing.Point(0, 343);
			this.MainStatusStrip.Name = "MainStatusStrip";
			this.MainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this.MainStatusStrip.Size = new System.Drawing.Size(732, 25);
			this.MainStatusStrip.SizingGrip = false;
			this.MainStatusStrip.TabIndex = 25;
			this.MainStatusStrip.Text = "statusStripMain";
			// 
			// Info
			// 
			this.Info.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.Info.Name = "Info";
			this.Info.Size = new System.Drawing.Size(136, 20);
			this.Info.Text = "Data uložena na počítači";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::JTPlan.gfx.bg;
			this.ClientSize = new System.Drawing.Size(732, 368);
			this.Controls.Add(this.MainStatusStrip);
			this.Controls.Add(this.PanelContacts);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.buttonSync);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.textBoxDB);
			this.Controls.Add(this.buttonTest);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.textBoxScratch);
			this.Controls.Add(this.buttonDownload);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.textBoxServer);
			this.Controls.Add(this.PanelLabel3);
			this.Controls.Add(this.PanelLabel2);
			this.Controls.Add(this.PanelLabel1);
			this.Controls.Add(this.PanelDay);
			this.Controls.Add(this.PanelMonthWrap);
			this.Controls.Add(this.ButtonMonthNext);
			this.Controls.Add(this.ButtonMonthBack);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = global::JTPlan.gfx.plan;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "JTPlan";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.PanelMonthWrap.ResumeLayout(false);
			this.ContextMenuEvent.ResumeLayout(false);
			this.ContextMenuPanelDay.ResumeLayout(false);
			this.ContextMenuActivity.ResumeLayout(false);
			this.PanelLabel1.ResumeLayout(false);
			this.PanelLabel2.ResumeLayout(false);
			this.PanelLabel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ContextMenuPanelContact.ResumeLayout(false);
			this.ContextMenuContact.ResumeLayout(false);
			this.MainStatusStrip.ResumeLayout(false);
			this.MainStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}