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
            this.findOldNameBtn = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.computerObjectBox = new System.Windows.Forms.GroupBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tempExit = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.compNameTab = new System.Windows.Forms.TabPage();
            this.compSearchPage = new System.Windows.Forms.TabPage();
            this.directorySearchTb = new System.Windows.Forms.TextBox();
            this.dirlookOUList = new System.Windows.Forms.ListBox();
            this.computerLookList = new System.Windows.Forms.ListView();
            this.compColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OUChangeDL = new System.ComponentModel.BackgroundWorker();
            this.CreateComputer = new System.ComponentModel.BackgroundWorker();
            this.msgPanel = new System.Windows.Forms.Panel();
            this.msgLbl = new System.Windows.Forms.Label();
            this.msgPic = new System.Windows.Forms.PictureBox();
            this.msgShadow = new System.Windows.Forms.Panel();
            this.OUBox.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.computerObjectBox.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.compNameTab.SuspendLayout();
            this.compSearchPage.SuspendLayout();
            this.msgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleText.Enabled = false;
            this.titleText.Location = new System.Drawing.Point(586, 9);
            this.titleText.Margin = new System.Windows.Forms.Padding(0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(99, 16);
            this.titleText.TabIndex = 2;
            this.titleText.Text = "SuperADD";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleText.Click += new System.EventHandler(this.TitleText_Click);
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
            this.saveNextBtn.Location = new System.Drawing.Point(573, 394);
            this.saveNextBtn.Name = "saveNextBtn";
            this.saveNextBtn.Size = new System.Drawing.Size(89, 29);
            this.saveNextBtn.TabIndex = 9;
            this.saveNextBtn.Text = "Save";
            this.saveNextBtn.UseVisualStyleBackColor = true;
            this.saveNextBtn.Click += new System.EventHandler(this.saveNextBtn_Click);
            // 
            // findOldNameBtn
            // 
            this.findOldNameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findOldNameBtn.Location = new System.Drawing.Point(5, 394);
            this.findOldNameBtn.Name = "findOldNameBtn";
            this.findOldNameBtn.Size = new System.Drawing.Size(143, 29);
            this.findOldNameBtn.TabIndex = 10;
            this.findOldNameBtn.Text = "Find old name...";
            this.findOldNameBtn.UseVisualStyleBackColor = true;
            this.findOldNameBtn.Click += new System.EventHandler(this.findOldNameBtn_Click);
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
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(10, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(280, 22);
            this.nameTextBox.TabIndex = 1;
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
            // tempExit
            // 
            this.tempExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tempExit.Location = new System.Drawing.Point(673, 458);
            this.tempExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tempExit.Name = "tempExit";
            this.tempExit.Size = new System.Drawing.Size(20, 19);
            this.tempExit.TabIndex = 1;
            this.tempExit.UseVisualStyleBackColor = true;
            this.tempExit.Click += new System.EventHandler(this.button1_Click);
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
            this.compNameTab.Controls.Add(this.tablePanel);
            this.compNameTab.Controls.Add(this.saveNextBtn);
            this.compNameTab.Controls.Add(this.findOldNameBtn);
            this.compNameTab.Location = new System.Drawing.Point(4, 25);
            this.compNameTab.Name = "compNameTab";
            this.compNameTab.Padding = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.compNameTab.Size = new System.Drawing.Size(667, 428);
            this.compNameTab.TabIndex = 0;
            this.compNameTab.Text = "Computer Name";
            this.compNameTab.UseVisualStyleBackColor = true;
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
            // OUChangeDL
            // 
            this.OUChangeDL.WorkerSupportsCancellation = true;
            this.OUChangeDL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OUChangeDL_DoWork);
            this.OUChangeDL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OUChangeDL_RunWorkerCompleted);
            // 
            // CreateComputer
            // 
            this.CreateComputer.WorkerSupportsCancellation = true;
            this.CreateComputer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CreateComputer_DoWork);
            this.CreateComputer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CreateComputer_RunWorkerCompleted);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(695, 477);
            this.Controls.Add(this.tempExit);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.msgPanel);
            this.Controls.Add(this.msgShadow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(695, 477);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "SuperADD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.OUBox.ResumeLayout(false);
            this.flowPanel.ResumeLayout(false);
            this.computerObjectBox.ResumeLayout(false);
            this.computerObjectBox.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.compNameTab.ResumeLayout(false);
            this.compSearchPage.ResumeLayout(false);
            this.compSearchPage.PerformLayout();
            this.msgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msgPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.ListBox OUList;
        private System.Windows.Forms.GroupBox OUBox;
        private System.Windows.Forms.Button saveNextBtn;
        private System.Windows.Forms.Button findOldNameBtn;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.GroupBox descListItem;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.GroupBox computerObjectBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Button tempExit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage compNameTab;
        private System.Windows.Forms.TabPage compSearchPage;
        private System.Windows.Forms.ListView computerLookList;
        private System.Windows.Forms.ColumnHeader compColumn;
        private System.Windows.Forms.ColumnHeader descColumn;
        private System.Windows.Forms.ListBox dirlookOUList;
        private System.ComponentModel.BackgroundWorker OUChangeDL;
        private System.Windows.Forms.TextBox directorySearchTb;
        private System.ComponentModel.BackgroundWorker CreateComputer;
        private System.Windows.Forms.Panel msgPanel;
        private System.Windows.Forms.PictureBox msgPic;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Panel msgShadow;
    }
}

