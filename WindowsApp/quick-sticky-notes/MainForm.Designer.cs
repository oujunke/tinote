namespace quick_sticky_notes
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.notesListItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.changeColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmsState = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesListEmptyContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.profileBtn = new System.Windows.Forms.Button();
            this.newNoteBtn = new System.Windows.Forms.Button();
            this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.allNotesBtn = new System.Windows.Forms.Button();
            this.pinnedNotesBtn = new System.Windows.Forms.Button();
            this.trashBtn = new System.Windows.Forms.Button();
            this.trashListEmptyContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidebarToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.trashListItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteForeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.emptyTrashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.btOpt = new System.Windows.Forms.Button();
            this.notesListItemContext.SuspendLayout();
            this.notesListEmptyContext.SuspendLayout();
            this.trayContext.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.trashListEmptyContext.SuspendLayout();
            this.trashListItemContext.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesListBox
            // 
            this.notesListBox.BackColor = System.Drawing.Color.White;
            this.notesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.notesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.IntegralHeight = false;
            this.notesListBox.ItemHeight = 64;
            this.notesListBox.Location = new System.Drawing.Point(40, 80);
            this.notesListBox.Margin = new System.Windows.Forms.Padding(0);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(359, 465);
            this.notesListBox.TabIndex = 12;
            this.notesListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.notesListBox_DrawItem);
            this.notesListBox.DoubleClick += new System.EventHandler(this.notesListBox_DoubleClick_1);
            this.notesListBox.MouseLeave += new System.EventHandler(this.notesListBox_MouseLeave);
            this.notesListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notesListBox_MouseMove);
            this.notesListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notesListBox_MouseUp);
            // 
            // notesListItemContext
            // 
            this.notesListItemContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notesListItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator3,
            this.changeColorMenuItem,
            this.toolStripSeparator2,
            this.tsmsState,
            this.toolStripSeparator6,
            this.deleteToolStripMenuItem});
            this.notesListItemContext.Name = "notesListContext";
            this.notesListItemContext.Size = new System.Drawing.Size(173, 126);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.showToolStripMenuItem.Text = "显示笔记";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // changeColorMenuItem
            // 
            this.changeColorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellowToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.whiteToolStripMenuItem});
            this.changeColorMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changeColorMenuItem.Image")));
            this.changeColorMenuItem.Name = "changeColorMenuItem";
            this.changeColorMenuItem.Size = new System.Drawing.Size(172, 26);
            this.changeColorMenuItem.Text = "改变颜色";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
            this.yellowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(219)))), ((int)(((byte)(193)))));
            this.greenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(109)))), ((int)(((byte)(96)))));
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.blueToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(97)))), ((int)(((byte)(127)))));
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(209)))));
            this.pinkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(81)))), ((int)(((byte)(104)))));
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.purpleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(82)))), ((int)(((byte)(127)))));
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.whiteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // tsmsState
            // 
            this.tsmsState.Name = "tsmsState";
            this.tsmsState.Size = new System.Drawing.Size(172, 26);
            this.tsmsState.Text = "改变状态";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(169, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.deleteToolStripMenuItem.Text = "移动到回收站";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // notesListEmptyContext
            // 
            this.notesListEmptyContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notesListEmptyContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem});
            this.notesListEmptyContext.Name = "notesListContext";
            this.notesListEmptyContext.Size = new System.Drawing.Size(210, 30);
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNoteToolStripMenuItem.Image")));
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.addNoteToolStripMenuItem.Text = "Add note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContext;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Tinote";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // trayContext
            // 
            this.trayContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notesListToolStripMenuItem,
            this.newNoteToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.trayContext.Name = "notesListContext";
            this.trayContext.Size = new System.Drawing.Size(154, 88);
            // 
            // notesListToolStripMenuItem
            // 
            this.notesListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notesListToolStripMenuItem.Image")));
            this.notesListToolStripMenuItem.Name = "notesListToolStripMenuItem";
            this.notesListToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.notesListToolStripMenuItem.Text = "Notes list";
            this.notesListToolStripMenuItem.Click += new System.EventHandler(this.notesListToolStripMenuItem_Click);
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newNoteToolStripMenuItem.Image")));
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.newNoteToolStripMenuItem.Text = "New note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.searchTextBox.Location = new System.Drawing.Point(40, 9);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(228, 22);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.Text = "搜索你的笔记...";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.profileBtn);
            this.searchPanel.Controls.Add(this.newNoteBtn);
            this.searchPanel.Location = new System.Drawing.Point(40, 40);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(309, 40);
            this.searchPanel.TabIndex = 8;
            // 
            // profileBtn
            // 
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.Location = new System.Drawing.Point(0, 0);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(40, 40);
            this.profileBtn.TabIndex = 9;
            this.infoToolTip.SetToolTip(this.profileBtn, "个人资料 (Ctrl+Shift+P)");
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.ContextMenuStrip = this.notesListEmptyContext;
            this.newNoteBtn.FlatAppearance.BorderSize = 0;
            this.newNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNoteBtn.Image = ((System.Drawing.Image)(resources.GetObject("newNoteBtn.Image")));
            this.newNoteBtn.Location = new System.Drawing.Point(268, 0);
            this.newNoteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(40, 40);
            this.newNoteBtn.TabIndex = 11;
            this.infoToolTip.SetToolTip(this.newNoteBtn, "新建笔记(Ctrl+N)");
            this.newNoteBtn.UseVisualStyleBackColor = true;
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtn.Image")));
            this.aboutBtn.Location = new System.Drawing.Point(0, 425);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(40, 40);
            this.aboutBtn.TabIndex = 6;
            this.infoToolTip.SetToolTip(this.aboutBtn, "About (F1)");
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Enabled = false;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.Location = new System.Drawing.Point(0, 465);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(40, 40);
            this.settingsBtn.TabIndex = 7;
            this.infoToolTip.SetToolTip(this.settingsBtn, "Settings (Ctrl+Comma)");
            this.settingsBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = global::quick_sticky_notes.Properties.Resources.black_close;
            this.closeBtn.Location = new System.Drawing.Point(359, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 1;
            this.infoToolTip.SetToolTip(this.closeBtn, "隐藏窗口 (Alt+F4)");
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(44, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 23);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Tinote";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.titlePanel.Controls.Add(this.logoPictureBox);
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(399, 40);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(40, 40);
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoPictureBox_MouseDown);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.sidePanel.Controls.Add(this.aboutBtn);
            this.sidePanel.Controls.Add(this.allNotesBtn);
            this.sidePanel.Controls.Add(this.pinnedNotesBtn);
            this.sidePanel.Controls.Add(this.trashBtn);
            this.sidePanel.Controls.Add(this.settingsBtn);
            this.sidePanel.Location = new System.Drawing.Point(0, 40);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(40, 522);
            this.sidePanel.TabIndex = 2;
            // 
            // allNotesBtn
            // 
            this.allNotesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.allNotesBtn.FlatAppearance.BorderSize = 0;
            this.allNotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allNotesBtn.Image = global::quick_sticky_notes.Properties.Resources.black_notes;
            this.allNotesBtn.Location = new System.Drawing.Point(0, 0);
            this.allNotesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.allNotesBtn.Name = "allNotesBtn";
            this.allNotesBtn.Size = new System.Drawing.Size(40, 40);
            this.allNotesBtn.TabIndex = 3;
            this.sidebarToolTip.SetToolTip(this.allNotesBtn, "笔记列表(Ctrl+U)");
            this.allNotesBtn.UseVisualStyleBackColor = false;
            this.allNotesBtn.Click += new System.EventHandler(this.allNotesBtn_Click);
            // 
            // pinnedNotesBtn
            // 
            this.pinnedNotesBtn.Enabled = false;
            this.pinnedNotesBtn.FlatAppearance.BorderSize = 0;
            this.pinnedNotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinnedNotesBtn.Image = global::quick_sticky_notes.Properties.Resources.black_pin;
            this.pinnedNotesBtn.Location = new System.Drawing.Point(0, 40);
            this.pinnedNotesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.pinnedNotesBtn.Name = "pinnedNotesBtn";
            this.pinnedNotesBtn.Size = new System.Drawing.Size(40, 40);
            this.pinnedNotesBtn.TabIndex = 4;
            this.sidebarToolTip.SetToolTip(this.pinnedNotesBtn, "固定笔记 (Ctrl+P)");
            this.pinnedNotesBtn.UseVisualStyleBackColor = true;
            // 
            // trashBtn
            // 
            this.trashBtn.ContextMenuStrip = this.trashListEmptyContext;
            this.trashBtn.FlatAppearance.BorderSize = 0;
            this.trashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trashBtn.Image = global::quick_sticky_notes.Properties.Resources.black_trash;
            this.trashBtn.Location = new System.Drawing.Point(0, 80);
            this.trashBtn.Margin = new System.Windows.Forms.Padding(0);
            this.trashBtn.Name = "trashBtn";
            this.trashBtn.Size = new System.Drawing.Size(40, 40);
            this.trashBtn.TabIndex = 5;
            this.sidebarToolTip.SetToolTip(this.trashBtn, "垃圾 (Ctrl+T)");
            this.trashBtn.UseVisualStyleBackColor = true;
            this.trashBtn.Click += new System.EventHandler(this.trashBtn_Click);
            // 
            // trashListEmptyContext
            // 
            this.trashListEmptyContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trashListEmptyContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.trashListEmptyContext.Name = "notesListContext";
            this.trashListEmptyContext.Size = new System.Drawing.Size(268, 30);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::quick_sticky_notes.Properties.Resources.black_emptytrash;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(267, 26);
            this.toolStripMenuItem3.Text = "Empty trash";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.emptyTrashToolStripMenuItem_Click);
            // 
            // sidebarToolTip
            // 
            this.sidebarToolTip.AutomaticDelay = 0;
            this.sidebarToolTip.AutoPopDelay = 0;
            this.sidebarToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(128)))));
            this.sidebarToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(115)))), ((int)(((byte)(64)))));
            this.sidebarToolTip.InitialDelay = 0;
            this.sidebarToolTip.ReshowDelay = 0;
            this.sidebarToolTip.ToolTipTitle = "Group";
            // 
            // trashListItemContext
            // 
            this.trashListItemContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trashListItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteForeverToolStripMenuItem,
            this.toolStripSeparator4,
            this.emptyTrashToolStripMenuItem});
            this.trashListItemContext.Name = "notesListContext";
            this.trashListItemContext.Size = new System.Drawing.Size(268, 94);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restoreToolStripMenuItem.Image")));
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.restoreToolStripMenuItem.Text = "Restore note";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(264, 6);
            // 
            // deleteForeverToolStripMenuItem
            // 
            this.deleteForeverToolStripMenuItem.Image = global::quick_sticky_notes.Properties.Resources.black_erase;
            this.deleteForeverToolStripMenuItem.Name = "deleteForeverToolStripMenuItem";
            this.deleteForeverToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.deleteForeverToolStripMenuItem.Text = "Delete forever";
            this.deleteForeverToolStripMenuItem.Click += new System.EventHandler(this.deleteForewerToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(264, 6);
            // 
            // emptyTrashToolStripMenuItem
            // 
            this.emptyTrashToolStripMenuItem.Image = global::quick_sticky_notes.Properties.Resources.black_emptytrash;
            this.emptyTrashToolStripMenuItem.Name = "emptyTrashToolStripMenuItem";
            this.emptyTrashToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.emptyTrashToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.emptyTrashToolStripMenuItem.Text = "Empty trash";
            this.emptyTrashToolStripMenuItem.Click += new System.EventHandler(this.emptyTrashToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripComboBox2,
            this.toolStripComboBox3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 100);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "所有",
            "已创建",
            "进行中",
            "已完成",
            "已暂停",
            "已搁置",
            "已取消"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Text = "所有";
            this.toolStripComboBox1.ToolTipText = "状态";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "默认排序",
            "时间升序",
            "时间逆序"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox2.Text = "默认排序";
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            this.toolStripComboBox2.TextChanged += new System.EventHandler(this.toolStripComboBox2_TextChanged);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "所有日期",
            "今天",
            "近两天",
            "近三天",
            "近七天",
            "近半个月",
            "近一个月",
            "近三个月",
            "近半年",
            "近一年"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox3.Text = "所有日期";
            this.toolStripComboBox3.TextChanged += new System.EventHandler(this.toolStripComboBox3_TextChanged);
            // 
            // btOpt
            // 
            this.btOpt.ContextMenuStrip = this.contextMenuStrip1;
            this.btOpt.Location = new System.Drawing.Point(349, 41);
            this.btOpt.Name = "btOpt";
            this.btOpt.Size = new System.Drawing.Size(47, 36);
            this.btOpt.TabIndex = 15;
            this.btOpt.Text = "...";
            this.btOpt.UseVisualStyleBackColor = true;
            this.btOpt.Click += new System.EventHandler(this.btOpt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.btOpt);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.notesListBox);
            this.Controls.Add(this.searchPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tinote";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.notesListItemContext.ResumeLayout(false);
            this.notesListEmptyContext.ResumeLayout(false);
            this.trayContext.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.trashListEmptyContext.ResumeLayout(false);
            this.trashListItemContext.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button profileBtn;
		private System.Windows.Forms.Button newNoteBtn;
		private System.Windows.Forms.ListBox notesListBox;
		private System.Windows.Forms.ContextMenuStrip notesListItemContext;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip notesListEmptyContext;
		private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.ContextMenuStrip trayContext;
		private System.Windows.Forms.ToolStripMenuItem notesListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Panel searchPanel;
		private System.Windows.Forms.ToolTip infoToolTip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem changeColorMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
		private System.Windows.Forms.Button settingsBtn;
		private System.Windows.Forms.Button allNotesBtn;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Button pinnedNotesBtn;
		private System.Windows.Forms.Button trashBtn;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Panel sidePanel;
		private System.Windows.Forms.Button aboutBtn;
		private System.Windows.Forms.ToolTip sidebarToolTip;
		private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip trashListItemContext;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem emptyTrashToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem deleteForeverToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip trashListEmptyContext;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.Button btOpt;
        private System.Windows.Forms.ToolStripMenuItem tsmsState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

