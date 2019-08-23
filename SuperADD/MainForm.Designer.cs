namespace SuperADD
{
    partial class Main
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
            this.titleText = new System.Windows.Forms.Label();
            this.OUList = new System.Windows.Forms.ListBox();
            this.OUBox = new System.Windows.Forms.GroupBox();
            this.saveNextBtn = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.computerObjectBox = new System.Windows.Forms.GroupBox();
            this.SearchADBtn = new System.Windows.Forms.Button();
            this.findCurrentNameBtn = new System.Windows.Forms.Button();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.compNameTab = new System.Windows.Forms.TabPage();
            this.skipJoinBtn = new System.Windows.Forms.Button();
            this.spookyBoi = new System.Windows.Forms.PictureBox();
            this.dirLookTab = new System.Windows.Forms.TabPage();
            this.directorySearchTb = new System.Windows.Forms.TextBox();
            this.dirLookOUList = new System.Windows.Forms.ListBox();
            this.computerLookList = new System.Windows.Forms.ListView();
            this.compColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgPanel = new System.Windows.Forms.Panel();
            this.msgLbl = new System.Windows.Forms.Label();
            this.msgPic = new System.Windows.Forms.PictureBox();
            this.msgShadow = new System.Windows.Forms.Panel();
            this.promptPanel = new System.Windows.Forms.Panel();
            this.promptLbl3 = new System.Windows.Forms.Label();
            this.promptLbl2 = new System.Windows.Forms.Label();
            this.promptLbl1 = new System.Windows.Forms.Label();
            this.promptSubmitBtn = new System.Windows.Forms.Button();
            this.promptUsrTxt = new System.Windows.Forms.TextBox();
            this.promptPasTxt = new System.Windows.Forms.TextBox();
            this.promptDomTxt = new System.Windows.Forms.TextBox();
            this.promptShadowPanel = new System.Windows.Forms.Panel();
            this.SGBox = new System.Windows.Forms.GroupBox();
            this.SGList = new System.Windows.Forms.ListBox();
            this.OUBox.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.computerObjectBox.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.compNameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spookyBoi)).BeginInit();
            this.dirLookTab.SuspendLayout();
            this.msgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgPic)).BeginInit();
            this.promptPanel.SuspendLayout();
            this.SGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleText.Enabled = false;
            this.titleText.Location = new System.Drawing.Point(1208, 8);
            this.titleText.Margin = new System.Windows.Forms.Padding(0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(122, 29);
            this.titleText.TabIndex = 2;
            this.titleText.Text = "SuperADD";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleText_Click);
            // 
            // OUList
            // 
            this.OUList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OUList.FormattingEnabled = true;
            this.OUList.IntegralHeight = false;
            this.OUList.ItemHeight = 20;
            this.OUList.Location = new System.Drawing.Point(12, 31);
            this.OUList.Margin = new System.Windows.Forms.Padding(4);
            this.OUList.Name = "OUList";
            this.OUList.Size = new System.Drawing.Size(351, 207);
            this.OUList.TabIndex = 3;
            this.OUList.SelectedIndexChanged += new System.EventHandler(this.OUList_SelectedIndexChanged);
            // 
            // OUBox
            // 
            this.OUBox.Controls.Add(this.OUList);
            this.OUBox.Location = new System.Drawing.Point(411, 0);
            this.OUBox.Margin = new System.Windows.Forms.Padding(12, 0, 12, 12);
            this.OUBox.Name = "OUBox";
            this.OUBox.Padding = new System.Windows.Forms.Padding(12);
            this.OUBox.Size = new System.Drawing.Size(375, 250);
            this.OUBox.TabIndex = 7;
            this.OUBox.TabStop = false;
            this.OUBox.Text = "Organizational Unit";
            // 
            // saveNextBtn
            // 
            this.saveNextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveNextBtn.Location = new System.Drawing.Point(1161, 487);
            this.saveNextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveNextBtn.Name = "saveNextBtn";
            this.saveNextBtn.Size = new System.Drawing.Size(141, 42);
            this.saveNextBtn.TabIndex = 9;
            this.saveNextBtn.Text = "Join Domain";
            this.saveNextBtn.UseVisualStyleBackColor = true;
            this.saveNextBtn.Click += new System.EventHandler(this.saveNextBtn_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowPanel.AutoSize = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.computerObjectBox);
            this.flowPanel.Controls.Add(this.OUBox);
            this.flowPanel.Controls.Add(this.SGBox);
            this.flowPanel.Location = new System.Drawing.Point(52, 0);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1197, 262);
            this.flowPanel.TabIndex = 13;
            // 
            // computerObjectBox
            // 
            this.computerObjectBox.Controls.Add(this.SearchADBtn);
            this.computerObjectBox.Controls.Add(this.findCurrentNameBtn);
            this.computerObjectBox.Controls.Add(this.descTextBox);
            this.computerObjectBox.Controls.Add(this.descLbl);
            this.computerObjectBox.Controls.Add(this.nameTextBox);
            this.computerObjectBox.Controls.Add(this.nameLbl);
            this.computerObjectBox.Location = new System.Drawing.Point(12, 0);
            this.computerObjectBox.Margin = new System.Windows.Forms.Padding(12, 0, 12, 12);
            this.computerObjectBox.Name = "computerObjectBox";
            this.computerObjectBox.Padding = new System.Windows.Forms.Padding(12);
            this.computerObjectBox.Size = new System.Drawing.Size(375, 250);
            this.computerObjectBox.TabIndex = 16;
            this.computerObjectBox.TabStop = false;
            this.computerObjectBox.Text = "Computer Object";
            // 
            // SearchADBtn
            // 
            this.SearchADBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchADBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchADBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchADBtn.Location = new System.Drawing.Point(291, 70);
            this.SearchADBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchADBtn.Name = "SearchADBtn";
            this.SearchADBtn.Size = new System.Drawing.Size(71, 26);
            this.SearchADBtn.TabIndex = 19;
            this.SearchADBtn.Text = "Lookup";
            this.SearchADBtn.UseVisualStyleBackColor = true;
            this.SearchADBtn.Click += new System.EventHandler(this.SearchADBtn_Click);
            // 
            // findCurrentNameBtn
            // 
            this.findCurrentNameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findCurrentNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.findCurrentNameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findCurrentNameBtn.Location = new System.Drawing.Point(12, 202);
            this.findCurrentNameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.findCurrentNameBtn.Name = "findCurrentNameBtn";
            this.findCurrentNameBtn.Size = new System.Drawing.Size(75, 34);
            this.findCurrentNameBtn.TabIndex = 18;
            this.findCurrentNameBtn.Text = "Discover";
            this.findCurrentNameBtn.UseVisualStyleBackColor = true;
            this.findCurrentNameBtn.Click += new System.EventHandler(this.findCurrentNameBtn_Click);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(12, 145);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(349, 26);
            this.descTextBox.TabIndex = 4;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(9, 116);
            this.descLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(95, 20);
            this.descLbl.TabIndex = 3;
            this.descLbl.Text = "Description";
            this.descLbl.Click += new System.EventHandler(this.TitleText_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 70);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(270, 26);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(9, 41);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(53, 20);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            // 
            // tablePanel
            // 
            this.tablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel.AutoScroll = true;
            this.tablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel.ColumnCount = 1;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.Controls.Add(this.flowPanel, 0, 0);
            this.tablePanel.Location = new System.Drawing.Point(4, 25);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 2;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tablePanel.Size = new System.Drawing.Size(1301, 452);
            this.tablePanel.TabIndex = 15;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.compNameTab);
            this.tabControl.Controls.Add(this.dirLookTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1319, 572);
            this.tabControl.TabIndex = 16;
            // 
            // compNameTab
            // 
            this.compNameTab.Controls.Add(this.skipJoinBtn);
            this.compNameTab.Controls.Add(this.tablePanel);
            this.compNameTab.Controls.Add(this.saveNextBtn);
            this.compNameTab.Controls.Add(this.spookyBoi);
            this.compNameTab.Location = new System.Drawing.Point(4, 29);
            this.compNameTab.Margin = new System.Windows.Forms.Padding(4);
            this.compNameTab.Name = "compNameTab";
            this.compNameTab.Padding = new System.Windows.Forms.Padding(4, 25, 4, 4);
            this.compNameTab.Size = new System.Drawing.Size(1311, 539);
            this.compNameTab.TabIndex = 0;
            this.compNameTab.Text = "Computer Name";
            this.compNameTab.UseVisualStyleBackColor = true;
            // 
            // skipJoinBtn
            // 
            this.skipJoinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skipJoinBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.skipJoinBtn.Location = new System.Drawing.Point(6, 487);
            this.skipJoinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.skipJoinBtn.Name = "skipJoinBtn";
            this.skipJoinBtn.Size = new System.Drawing.Size(141, 42);
            this.skipJoinBtn.TabIndex = 17;
            this.skipJoinBtn.Text = "Join Workgroup";
            this.skipJoinBtn.UseVisualStyleBackColor = true;
            this.skipJoinBtn.Click += new System.EventHandler(this.skipJoinBtn_Click);
            // 
            // spookyBoi
            // 
            this.spookyBoi.Enabled = false;
            this.spookyBoi.Image = global::SuperADD.Properties.Resources.spooky;
            this.spookyBoi.Location = new System.Drawing.Point(8, 9);
            this.spookyBoi.Margin = new System.Windows.Forms.Padding(4);
            this.spookyBoi.Name = "spookyBoi";
            this.spookyBoi.Size = new System.Drawing.Size(250, 250);
            this.spookyBoi.TabIndex = 16;
            this.spookyBoi.TabStop = false;
            this.spookyBoi.Click += new System.EventHandler(this.spookyBoi_Click);
            // 
            // dirLookTab
            // 
            this.dirLookTab.Controls.Add(this.directorySearchTb);
            this.dirLookTab.Controls.Add(this.dirLookOUList);
            this.dirLookTab.Controls.Add(this.computerLookList);
            this.dirLookTab.Location = new System.Drawing.Point(4, 29);
            this.dirLookTab.Margin = new System.Windows.Forms.Padding(4);
            this.dirLookTab.Name = "dirLookTab";
            this.dirLookTab.Padding = new System.Windows.Forms.Padding(4);
            this.dirLookTab.Size = new System.Drawing.Size(837, 539);
            this.dirLookTab.TabIndex = 1;
            this.dirLookTab.Text = "Directory Lookup";
            this.dirLookTab.UseVisualStyleBackColor = true;
            // 
            // directorySearchTb
            // 
            this.directorySearchTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directorySearchTb.Location = new System.Drawing.Point(251, 5);
            this.directorySearchTb.Margin = new System.Windows.Forms.Padding(4);
            this.directorySearchTb.Multiline = true;
            this.directorySearchTb.Name = "directorySearchTb";
            this.directorySearchTb.Size = new System.Drawing.Size(579, 30);
            this.directorySearchTb.TabIndex = 3;
            this.directorySearchTb.TextChanged += new System.EventHandler(this.directorySearchTb_TextChanged);
            // 
            // dirLookOUList
            // 
            this.dirLookOUList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dirLookOUList.FormattingEnabled = true;
            this.dirLookOUList.IntegralHeight = false;
            this.dirLookOUList.ItemHeight = 20;
            this.dirLookOUList.Location = new System.Drawing.Point(2, 5);
            this.dirLookOUList.Margin = new System.Windows.Forms.Padding(4);
            this.dirLookOUList.Name = "dirLookOUList";
            this.dirLookOUList.Size = new System.Drawing.Size(243, 526);
            this.dirLookOUList.TabIndex = 2;
            this.dirLookOUList.SelectedIndexChanged += new System.EventHandler(this.OUList_SelectedIndexChanged);
            // 
            // computerLookList
            // 
            this.computerLookList.AllowColumnReorder = true;
            this.computerLookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.computerLookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.compColumn,
            this.descColumn});
            this.computerLookList.FullRowSelect = true;
            this.computerLookList.HideSelection = false;
            this.computerLookList.Location = new System.Drawing.Point(251, 42);
            this.computerLookList.Margin = new System.Windows.Forms.Padding(4);
            this.computerLookList.MultiSelect = false;
            this.computerLookList.Name = "computerLookList";
            this.computerLookList.Size = new System.Drawing.Size(579, 489);
            this.computerLookList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.computerLookList.TabIndex = 1;
            this.computerLookList.UseCompatibleStateImageBehavior = false;
            this.computerLookList.View = System.Windows.Forms.View.Details;
            this.computerLookList.DoubleClick += new System.EventHandler(this.computerLookList_DoubleClick);
            // 
            // compColumn
            // 
            this.compColumn.Text = "Computer Name";
            this.compColumn.Width = 117;
            // 
            // descColumn
            // 
            this.descColumn.Text = "Description";
            this.descColumn.Width = 289;
            // 
            // msgPanel
            // 
            this.msgPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgPanel.BackColor = System.Drawing.Color.White;
            this.msgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgPanel.Controls.Add(this.msgLbl);
            this.msgPanel.Controls.Add(this.msgPic);
            this.msgPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgPanel.Location = new System.Drawing.Point(451, 196);
            this.msgPanel.Margin = new System.Windows.Forms.Padding(4);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Size = new System.Drawing.Size(438, 78);
            this.msgPanel.TabIndex = 17;
            this.msgPanel.Click += new System.EventHandler(this.msgPanel_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgLbl.AutoEllipsis = true;
            this.msgLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgLbl.Location = new System.Drawing.Point(80, 0);
            this.msgLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(356, 76);
            this.msgLbl.TabIndex = 1;
            this.msgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgLbl.Click += new System.EventHandler(this.msgPanel_Click);
            // 
            // msgPic
            // 
            this.msgPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgPic.Enabled = false;
            this.msgPic.Location = new System.Drawing.Point(19, 19);
            this.msgPic.Margin = new System.Windows.Forms.Padding(4);
            this.msgPic.Name = "msgPic";
            this.msgPic.Size = new System.Drawing.Size(40, 40);
            this.msgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.msgPic.TabIndex = 0;
            this.msgPic.TabStop = false;
            this.msgPic.Click += new System.EventHandler(this.msgPanel_Click);
            // 
            // msgShadow
            // 
            this.msgShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgShadow.BackColor = System.Drawing.Color.DarkGray;
            this.msgShadow.Location = new System.Drawing.Point(456, 201);
            this.msgShadow.Margin = new System.Windows.Forms.Padding(4);
            this.msgShadow.Name = "msgShadow";
            this.msgShadow.Size = new System.Drawing.Size(439, 79);
            this.msgShadow.TabIndex = 18;
            // 
            // promptPanel
            // 
            this.promptPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.promptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.promptPanel.Controls.Add(this.promptLbl3);
            this.promptPanel.Controls.Add(this.promptLbl2);
            this.promptPanel.Controls.Add(this.promptLbl1);
            this.promptPanel.Controls.Add(this.promptSubmitBtn);
            this.promptPanel.Controls.Add(this.promptUsrTxt);
            this.promptPanel.Controls.Add(this.promptPasTxt);
            this.promptPanel.Controls.Add(this.promptDomTxt);
            this.promptPanel.Location = new System.Drawing.Point(468, 152);
            this.promptPanel.Margin = new System.Windows.Forms.Padding(4);
            this.promptPanel.Name = "promptPanel";
            this.promptPanel.Size = new System.Drawing.Size(404, 183);
            this.promptPanel.TabIndex = 19;
            // 
            // promptLbl3
            // 
            this.promptLbl3.AutoSize = true;
            this.promptLbl3.Location = new System.Drawing.Point(51, 96);
            this.promptLbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptLbl3.Name = "promptLbl3";
            this.promptLbl3.Size = new System.Drawing.Size(57, 20);
            this.promptLbl3.TabIndex = 6;
            this.promptLbl3.Text = "FQDN";
            // 
            // promptLbl2
            // 
            this.promptLbl2.AutoSize = true;
            this.promptLbl2.Location = new System.Drawing.Point(24, 62);
            this.promptLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptLbl2.Name = "promptLbl2";
            this.promptLbl2.Size = new System.Drawing.Size(83, 20);
            this.promptLbl2.TabIndex = 5;
            this.promptLbl2.Text = "Password";
            // 
            // promptLbl1
            // 
            this.promptLbl1.AutoSize = true;
            this.promptLbl1.Location = new System.Drawing.Point(12, 26);
            this.promptLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptLbl1.Name = "promptLbl1";
            this.promptLbl1.Size = new System.Drawing.Size(94, 20);
            this.promptLbl1.TabIndex = 4;
            this.promptLbl1.Text = "User Name";
            // 
            // promptSubmitBtn
            // 
            this.promptSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.promptSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptSubmitBtn.Location = new System.Drawing.Point(289, 138);
            this.promptSubmitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.promptSubmitBtn.Name = "promptSubmitBtn";
            this.promptSubmitBtn.Size = new System.Drawing.Size(94, 29);
            this.promptSubmitBtn.TabIndex = 4;
            this.promptSubmitBtn.Text = "Save";
            this.promptSubmitBtn.UseVisualStyleBackColor = false;
            this.promptSubmitBtn.Click += new System.EventHandler(this.promptSubmitBtn_Click);
            // 
            // promptUsrTxt
            // 
            this.promptUsrTxt.Location = new System.Drawing.Point(130, 22);
            this.promptUsrTxt.Margin = new System.Windows.Forms.Padding(4);
            this.promptUsrTxt.Name = "promptUsrTxt";
            this.promptUsrTxt.Size = new System.Drawing.Size(252, 26);
            this.promptUsrTxt.TabIndex = 1;
            this.promptUsrTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prompt_KeyPress);
            // 
            // promptPasTxt
            // 
            this.promptPasTxt.Location = new System.Drawing.Point(130, 58);
            this.promptPasTxt.Margin = new System.Windows.Forms.Padding(4);
            this.promptPasTxt.Name = "promptPasTxt";
            this.promptPasTxt.Size = new System.Drawing.Size(252, 26);
            this.promptPasTxt.TabIndex = 2;
            this.promptPasTxt.UseSystemPasswordChar = true;
            this.promptPasTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prompt_KeyPress);
            // 
            // promptDomTxt
            // 
            this.promptDomTxt.Location = new System.Drawing.Point(130, 92);
            this.promptDomTxt.Margin = new System.Windows.Forms.Padding(4);
            this.promptDomTxt.Name = "promptDomTxt";
            this.promptDomTxt.Size = new System.Drawing.Size(252, 26);
            this.promptDomTxt.TabIndex = 3;
            this.promptDomTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prompt_KeyPress);
            // 
            // promptShadowPanel
            // 
            this.promptShadowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.promptShadowPanel.BackColor = System.Drawing.Color.DarkGray;
            this.promptShadowPanel.Location = new System.Drawing.Point(473, 159);
            this.promptShadowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.promptShadowPanel.Name = "promptShadowPanel";
            this.promptShadowPanel.Size = new System.Drawing.Size(405, 184);
            this.promptShadowPanel.TabIndex = 20;
            // 
            // SGBox
            // 
            this.SGBox.Controls.Add(this.SGList);
            this.SGBox.Location = new System.Drawing.Point(810, 0);
            this.SGBox.Margin = new System.Windows.Forms.Padding(12, 0, 12, 12);
            this.SGBox.Name = "SGBox";
            this.SGBox.Padding = new System.Windows.Forms.Padding(12);
            this.SGBox.Size = new System.Drawing.Size(375, 250);
            this.SGBox.TabIndex = 17;
            this.SGBox.TabStop = false;
            this.SGBox.Text = "Security Groups";
            // 
            // SGList
            // 
            this.SGList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SGList.FormattingEnabled = true;
            this.SGList.IntegralHeight = false;
            this.SGList.ItemHeight = 20;
            this.SGList.Location = new System.Drawing.Point(12, 31);
            this.SGList.Margin = new System.Windows.Forms.Padding(4);
            this.SGList.Name = "SGList";
            this.SGList.Size = new System.Drawing.Size(351, 207);
            this.SGList.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1343, 596);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.msgShadow);
            this.Controls.Add(this.promptPanel);
            this.Controls.Add(this.promptShadowPanel);
            this.Controls.Add(this.msgPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(869, 596);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowIcon = false;
            this.Text = "SuperADD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.OUBox.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.computerObjectBox.ResumeLayout(false);
            this.computerObjectBox.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.compNameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spookyBoi)).EndInit();
            this.dirLookTab.ResumeLayout(false);
            this.dirLookTab.PerformLayout();
            this.msgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msgPic)).EndInit();
            this.promptPanel.ResumeLayout(false);
            this.promptPanel.PerformLayout();
            this.SGBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.ListBox OUList;
        private System.Windows.Forms.GroupBox OUBox;
        private System.Windows.Forms.Button saveNextBtn;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.GroupBox descListItem;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.GroupBox computerObjectBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage compNameTab;
        private System.Windows.Forms.TabPage dirLookTab;
        private System.Windows.Forms.ListView computerLookList;
        private System.Windows.Forms.ColumnHeader compColumn;
        private System.Windows.Forms.ColumnHeader descColumn;
        private System.Windows.Forms.ListBox dirLookOUList;
        private System.Windows.Forms.TextBox directorySearchTb;
        private System.Windows.Forms.Panel msgPanel;
        private System.Windows.Forms.PictureBox msgPic;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Panel msgShadow;
        private System.Windows.Forms.PictureBox spookyBoi;
        private System.Windows.Forms.Button skipJoinBtn;
        private System.Windows.Forms.Panel promptPanel;
        private System.Windows.Forms.Label promptLbl3;
        private System.Windows.Forms.Label promptLbl2;
        private System.Windows.Forms.Label promptLbl1;
        private System.Windows.Forms.Button promptSubmitBtn;
        private System.Windows.Forms.TextBox promptUsrTxt;
        private System.Windows.Forms.TextBox promptPasTxt;
        private System.Windows.Forms.TextBox promptDomTxt;
        private System.Windows.Forms.Panel promptShadowPanel;
        private System.Windows.Forms.Button findCurrentNameBtn;
        private System.Windows.Forms.Button SearchADBtn;
        private System.Windows.Forms.GroupBox SGBox;
        private System.Windows.Forms.ListBox SGList;
    }
}

