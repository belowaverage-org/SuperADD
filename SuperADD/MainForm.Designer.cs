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
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.compNameTab = new System.Windows.Forms.TabPage();
            this.skipJoinBtn = new System.Windows.Forms.Button();
            this.spookyBoi = new System.Windows.Forms.PictureBox();
            this.compSearchPage = new System.Windows.Forms.TabPage();
            this.directorySearchTb = new System.Windows.Forms.TextBox();
            this.dirlookOUList = new System.Windows.Forms.ListBox();
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
            this.OUBox.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.computerObjectBox.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.compNameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spookyBoi)).BeginInit();
            this.compSearchPage.SuspendLayout();
            this.msgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgPic)).BeginInit();
            this.promptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleText.Enabled = false;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(587, 1);
            this.titleText.Margin = new System.Windows.Forms.Padding(0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(98, 31);
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
            this.OUList.ItemHeight = 16;
            this.OUList.Location = new System.Drawing.Point(10, 25);
            this.OUList.Name = "OUList";
            this.OUList.Size = new System.Drawing.Size(280, 165);
            this.OUList.TabIndex = 3;
            this.OUList.SelectedIndexChanged += new System.EventHandler(this.OUList_SelectedIndexChanged);
            // 
            // OUBox
            // 
            this.OUBox.Controls.Add(this.OUList);
            this.OUBox.Location = new System.Drawing.Point(330, 0);
            this.OUBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.OUBox.Name = "OUBox";
            this.OUBox.Padding = new System.Windows.Forms.Padding(10);
            this.OUBox.Size = new System.Drawing.Size(300, 200);
            this.OUBox.TabIndex = 7;
            this.OUBox.TabStop = false;
            this.OUBox.Text = "Organizational Unit";
            // 
            // saveNextBtn
            // 
            this.saveNextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveNextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNextBtn.Location = new System.Drawing.Point(541, 389);
            this.saveNextBtn.Name = "saveNextBtn";
            this.saveNextBtn.Size = new System.Drawing.Size(121, 34);
            this.saveNextBtn.TabIndex = 9;
            this.saveNextBtn.Text = "Join DOMAIN";
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
            this.flowPanel.Location = new System.Drawing.Point(10, 0);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(640, 210);
            this.flowPanel.TabIndex = 13;
            // 
            // computerObjectBox
            // 
            this.computerObjectBox.Controls.Add(this.descTextBox);
            this.computerObjectBox.Controls.Add(this.descLbl);
            this.computerObjectBox.Controls.Add(this.nameTextBox);
            this.computerObjectBox.Controls.Add(this.nameLbl);
            this.computerObjectBox.Location = new System.Drawing.Point(10, 0);
            this.computerObjectBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.computerObjectBox.Name = "computerObjectBox";
            this.computerObjectBox.Padding = new System.Windows.Forms.Padding(10);
            this.computerObjectBox.Size = new System.Drawing.Size(300, 200);
            this.computerObjectBox.TabIndex = 16;
            this.computerObjectBox.TabStop = false;
            this.computerObjectBox.Text = "Computer Object";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(10, 115);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(280, 22);
            this.descTextBox.TabIndex = 4;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(7, 92);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(76, 16);
            this.descLbl.TabIndex = 3;
            this.descLbl.Text = "Description";
            this.descLbl.Click += new System.EventHandler(this.TitleText_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(10, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(280, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(7, 32);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 16);
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
            this.tablePanel.Location = new System.Drawing.Point(3, 20);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 2;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tablePanel.Size = new System.Drawing.Size(661, 364);
            this.tablePanel.TabIndex = 15;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.compNameTab);
            this.tabControl.Controls.Add(this.compSearchPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(675, 457);
            this.tabControl.TabIndex = 16;
            // 
            // compNameTab
            // 
            this.compNameTab.Controls.Add(this.skipJoinBtn);
            this.compNameTab.Controls.Add(this.tablePanel);
            this.compNameTab.Controls.Add(this.saveNextBtn);
            this.compNameTab.Controls.Add(this.spookyBoi);
            this.compNameTab.Location = new System.Drawing.Point(4, 25);
            this.compNameTab.Name = "compNameTab";
            this.compNameTab.Padding = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.compNameTab.Size = new System.Drawing.Size(667, 428);
            this.compNameTab.TabIndex = 0;
            this.compNameTab.Text = "Computer Name";
            this.compNameTab.UseVisualStyleBackColor = true;
            // 
            // skipJoinBtn
            // 
            this.skipJoinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skipJoinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipJoinBtn.Location = new System.Drawing.Point(5, 389);
            this.skipJoinBtn.Name = "skipJoinBtn";
            this.skipJoinBtn.Size = new System.Drawing.Size(121, 34);
            this.skipJoinBtn.TabIndex = 17;
            this.skipJoinBtn.Text = "Join WORKGROUP";
            this.skipJoinBtn.UseVisualStyleBackColor = true;
            this.skipJoinBtn.Click += new System.EventHandler(this.skipJoinBtn_Click);
            // 
            // spookyBoi
            // 
            this.spookyBoi.Enabled = false;
            this.spookyBoi.Image = global::SuperADD.Properties.Resources.spooky;
            this.spookyBoi.Location = new System.Drawing.Point(6, 7);
            this.spookyBoi.Name = "spookyBoi";
            this.spookyBoi.Size = new System.Drawing.Size(200, 200);
            this.spookyBoi.TabIndex = 16;
            this.spookyBoi.TabStop = false;
            this.spookyBoi.Click += new System.EventHandler(this.spookyBoi_Click);
            // 
            // compSearchPage
            // 
            this.compSearchPage.Controls.Add(this.directorySearchTb);
            this.compSearchPage.Controls.Add(this.dirlookOUList);
            this.compSearchPage.Controls.Add(this.computerLookList);
            this.compSearchPage.Location = new System.Drawing.Point(4, 25);
            this.compSearchPage.Name = "compSearchPage";
            this.compSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.compSearchPage.Size = new System.Drawing.Size(667, 428);
            this.compSearchPage.TabIndex = 1;
            this.compSearchPage.Text = "Directory Lookup";
            this.compSearchPage.UseVisualStyleBackColor = true;
            // 
            // directorySearchTb
            // 
            this.directorySearchTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directorySearchTb.Location = new System.Drawing.Point(201, 4);
            this.directorySearchTb.Multiline = true;
            this.directorySearchTb.Name = "directorySearchTb";
            this.directorySearchTb.Size = new System.Drawing.Size(464, 25);
            this.directorySearchTb.TabIndex = 3;
            this.directorySearchTb.TextChanged += new System.EventHandler(this.directorySearchTb_TextChanged);
            // 
            // dirlookOUList
            // 
            this.dirlookOUList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dirlookOUList.FormattingEnabled = true;
            this.dirlookOUList.IntegralHeight = false;
            this.dirlookOUList.ItemHeight = 16;
            this.dirlookOUList.Location = new System.Drawing.Point(2, 4);
            this.dirlookOUList.Name = "dirlookOUList";
            this.dirlookOUList.Size = new System.Drawing.Size(195, 422);
            this.dirlookOUList.TabIndex = 2;
            this.dirlookOUList.SelectedIndexChanged += new System.EventHandler(this.OUList_SelectedIndexChanged);
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
            this.computerLookList.Location = new System.Drawing.Point(201, 34);
            this.computerLookList.MultiSelect = false;
            this.computerLookList.Name = "computerLookList";
            this.computerLookList.Size = new System.Drawing.Size(464, 392);
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
            this.msgPanel.Location = new System.Drawing.Point(171, 157);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Size = new System.Drawing.Size(351, 63);
            this.msgPanel.TabIndex = 17;
            this.msgPanel.Click += new System.EventHandler(this.msgPanel_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoEllipsis = true;
            this.msgLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgLbl.Location = new System.Drawing.Point(62, 0);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(287, 59);
            this.msgLbl.TabIndex = 1;
            this.msgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgLbl.Click += new System.EventHandler(this.msgPanel_Click);
            // 
            // msgPic
            // 
            this.msgPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgPic.Enabled = false;
            this.msgPic.Location = new System.Drawing.Point(15, 14);
            this.msgPic.Name = "msgPic";
            this.msgPic.Size = new System.Drawing.Size(32, 32);
            this.msgPic.TabIndex = 0;
            this.msgPic.TabStop = false;
            this.msgPic.Click += new System.EventHandler(this.msgPanel_Click);
            // 
            // msgShadow
            // 
            this.msgShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgShadow.BackColor = System.Drawing.Color.Gainsboro;
            this.msgShadow.Location = new System.Drawing.Point(175, 161);
            this.msgShadow.Name = "msgShadow";
            this.msgShadow.Size = new System.Drawing.Size(351, 63);
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
            this.promptPanel.Location = new System.Drawing.Point(185, 122);
            this.promptPanel.Name = "promptPanel";
            this.promptPanel.Size = new System.Drawing.Size(324, 147);
            this.promptPanel.TabIndex = 19;
            // 
            // promptLbl3
            // 
            this.promptLbl3.AutoSize = true;
            this.promptLbl3.Location = new System.Drawing.Point(41, 77);
            this.promptLbl3.Name = "promptLbl3";
            this.promptLbl3.Size = new System.Drawing.Size(46, 16);
            this.promptLbl3.TabIndex = 6;
            this.promptLbl3.Text = "FQDN";
            // 
            // promptLbl2
            // 
            this.promptLbl2.AutoSize = true;
            this.promptLbl2.Location = new System.Drawing.Point(19, 50);
            this.promptLbl2.Name = "promptLbl2";
            this.promptLbl2.Size = new System.Drawing.Size(68, 16);
            this.promptLbl2.TabIndex = 5;
            this.promptLbl2.Text = "Password";
            // 
            // promptLbl1
            // 
            this.promptLbl1.AutoSize = true;
            this.promptLbl1.Location = new System.Drawing.Point(10, 21);
            this.promptLbl1.Name = "promptLbl1";
            this.promptLbl1.Size = new System.Drawing.Size(77, 16);
            this.promptLbl1.TabIndex = 4;
            this.promptLbl1.Text = "User Name";
            // 
            // promptSubmitBtn
            // 
            this.promptSubmitBtn.Location = new System.Drawing.Point(231, 110);
            this.promptSubmitBtn.Name = "promptSubmitBtn";
            this.promptSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.promptSubmitBtn.TabIndex = 4;
            this.promptSubmitBtn.Text = "Save";
            this.promptSubmitBtn.UseVisualStyleBackColor = false;
            this.promptSubmitBtn.Click += new System.EventHandler(this.promptSubmitBtn_Click);
            // 
            // promptUsrTxt
            // 
            this.promptUsrTxt.Location = new System.Drawing.Point(104, 18);
            this.promptUsrTxt.Name = "promptUsrTxt";
            this.promptUsrTxt.Size = new System.Drawing.Size(202, 22);
            this.promptUsrTxt.TabIndex = 1;
            // 
            // promptPasTxt
            // 
            this.promptPasTxt.Location = new System.Drawing.Point(104, 46);
            this.promptPasTxt.Name = "promptPasTxt";
            this.promptPasTxt.Size = new System.Drawing.Size(202, 22);
            this.promptPasTxt.TabIndex = 2;
            this.promptPasTxt.UseSystemPasswordChar = true;
            // 
            // promptDomTxt
            // 
            this.promptDomTxt.Location = new System.Drawing.Point(104, 74);
            this.promptDomTxt.Name = "promptDomTxt";
            this.promptDomTxt.Size = new System.Drawing.Size(202, 22);
            this.promptDomTxt.TabIndex = 3;
            // 
            // promptShadowPanel
            // 
            this.promptShadowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.promptShadowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.promptShadowPanel.Location = new System.Drawing.Point(189, 127);
            this.promptShadowPanel.Name = "promptShadowPanel";
            this.promptShadowPanel.Size = new System.Drawing.Size(324, 147);
            this.promptShadowPanel.TabIndex = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(695, 477);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.msgPanel);
            this.Controls.Add(this.msgShadow);
            this.Controls.Add(this.promptPanel);
            this.Controls.Add(this.promptShadowPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(695, 477);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "SuperADD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.compSearchPage.ResumeLayout(false);
            this.compSearchPage.PerformLayout();
            this.msgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msgPic)).EndInit();
            this.promptPanel.ResumeLayout(false);
            this.promptPanel.PerformLayout();
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
        private System.Windows.Forms.TabPage compSearchPage;
        private System.Windows.Forms.ListView computerLookList;
        private System.Windows.Forms.ColumnHeader compColumn;
        private System.Windows.Forms.ColumnHeader descColumn;
        private System.Windows.Forms.ListBox dirlookOUList;
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
    }
}

