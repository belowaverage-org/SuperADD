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
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tempExit = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.compNameTab = new System.Windows.Forms.TabPage();
            this.compSearchPage = new System.Windows.Forms.TabPage();
            this.dirlookOUList = new System.Windows.Forms.ListBox();
            this.computerLookList = new System.Windows.Forms.ListView();
            this.compColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OUChangeDL = new System.ComponentModel.BackgroundWorker();
            this.directorySearchTb = new System.Windows.Forms.TextBox();
            this.OUBox.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.computerObjectBox.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.compNameTab.SuspendLayout();
            this.compSearchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(1225, 56);
            this.titleText.TabIndex = 2;
            this.titleText.Text = "Active Directory Join";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleText.Click += new System.EventHandler(this.TitleText_Click);
            // 
            // OUList
            // 
            this.OUList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OUList.FormattingEnabled = true;
            this.OUList.IntegralHeight = false;
            this.OUList.ItemHeight = 17;
            this.OUList.Location = new System.Drawing.Point(10, 28);
            this.OUList.Name = "OUList";
            this.OUList.Size = new System.Drawing.Size(280, 162);
            this.OUList.TabIndex = 3;
            this.OUList.SelectedIndexChanged += new System.EventHandler(this.OUList_SelectedIndexChanged);
            // 
            // OUBox
            // 
            this.OUBox.Controls.Add(this.OUList);
            this.OUBox.Location = new System.Drawing.Point(340, 20);
            this.OUBox.Margin = new System.Windows.Forms.Padding(10);
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
            this.saveNextBtn.Location = new System.Drawing.Point(1125, 477);
            this.saveNextBtn.Name = "saveNextBtn";
            this.saveNextBtn.Size = new System.Drawing.Size(89, 29);
            this.saveNextBtn.TabIndex = 9;
            this.saveNextBtn.Text = "Save";
            this.saveNextBtn.UseVisualStyleBackColor = true;
            // 
            // findOldNameBtn
            // 
            this.findOldNameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findOldNameBtn.Location = new System.Drawing.Point(1004, 477);
            this.findOldNameBtn.Name = "findOldNameBtn";
            this.findOldNameBtn.Size = new System.Drawing.Size(115, 29);
            this.findOldNameBtn.TabIndex = 10;
            this.findOldNameBtn.Text = "Find old name...";
            this.findOldNameBtn.UseVisualStyleBackColor = true;
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowPanel.AutoSize = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.computerObjectBox);
            this.flowPanel.Controls.Add(this.OUBox);
            this.flowPanel.Location = new System.Drawing.Point(268, 3);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.flowPanel.Size = new System.Drawing.Size(660, 240);
            this.flowPanel.TabIndex = 13;
            // 
            // computerObjectBox
            // 
            this.computerObjectBox.Controls.Add(this.descTextBox);
            this.computerObjectBox.Controls.Add(this.descLbl);
            this.computerObjectBox.Controls.Add(this.nameLbl);
            this.computerObjectBox.Controls.Add(this.nameTextBox);
            this.computerObjectBox.Location = new System.Drawing.Point(20, 20);
            this.computerObjectBox.Margin = new System.Windows.Forms.Padding(10);
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
            this.descTextBox.Size = new System.Drawing.Size(280, 25);
            this.descTextBox.TabIndex = 4;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(7, 92);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(74, 17);
            this.descLbl.TabIndex = 3;
            this.descLbl.Text = "Description";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(7, 32);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(43, 17);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(10, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(280, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // tablePanel
            // 
            this.tablePanel.AutoScroll = true;
            this.tablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel.ColumnCount = 1;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanel.Controls.Add(this.flowPanel, 0, 0);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(3, 3);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 2;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tablePanel.Size = new System.Drawing.Size(1197, 383);
            this.tablePanel.TabIndex = 15;
            // 
            // tempExit
            // 
            this.tempExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tempExit.Location = new System.Drawing.Point(1205, 0);
            this.tempExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tempExit.Name = "tempExit";
            this.tempExit.Size = new System.Drawing.Size(20, 19);
            this.tempExit.TabIndex = 1;
            this.tempExit.UseVisualStyleBackColor = true;
            this.tempExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.compNameTab);
            this.tabControl.Controls.Add(this.compSearchPage);
            this.tabControl.Location = new System.Drawing.Point(6, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1211, 419);
            this.tabControl.TabIndex = 16;
            // 
            // compNameTab
            // 
            this.compNameTab.Controls.Add(this.tablePanel);
            this.compNameTab.Location = new System.Drawing.Point(4, 26);
            this.compNameTab.Name = "compNameTab";
            this.compNameTab.Padding = new System.Windows.Forms.Padding(3);
            this.compNameTab.Size = new System.Drawing.Size(1203, 389);
            this.compNameTab.TabIndex = 0;
            this.compNameTab.Text = "Computer Name";
            this.compNameTab.UseVisualStyleBackColor = true;
            // 
            // compSearchPage
            // 
            this.compSearchPage.Controls.Add(this.directorySearchTb);
            this.compSearchPage.Controls.Add(this.dirlookOUList);
            this.compSearchPage.Controls.Add(this.computerLookList);
            this.compSearchPage.Location = new System.Drawing.Point(4, 26);
            this.compSearchPage.Name = "compSearchPage";
            this.compSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.compSearchPage.Size = new System.Drawing.Size(1203, 389);
            this.compSearchPage.TabIndex = 1;
            this.compSearchPage.Text = "Directory Lookup";
            this.compSearchPage.UseVisualStyleBackColor = true;
            // 
            // dirlookOUList
            // 
            this.dirlookOUList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dirlookOUList.FormattingEnabled = true;
            this.dirlookOUList.IntegralHeight = false;
            this.dirlookOUList.ItemHeight = 17;
            this.dirlookOUList.Location = new System.Drawing.Point(0, 2);
            this.dirlookOUList.Name = "dirlookOUList";
            this.dirlookOUList.Size = new System.Drawing.Size(197, 391);
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
            this.computerLookList.Location = new System.Drawing.Point(200, 30);
            this.computerLookList.MultiSelect = false;
            this.computerLookList.Name = "computerLookList";
            this.computerLookList.Size = new System.Drawing.Size(1004, 363);
            this.computerLookList.TabIndex = 1;
            this.computerLookList.UseCompatibleStateImageBehavior = false;
            this.computerLookList.View = System.Windows.Forms.View.Details;
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
            // directorySearchTb
            // 
            this.directorySearchTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directorySearchTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.directorySearchTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.directorySearchTb.Location = new System.Drawing.Point(200, 2);
            this.directorySearchTb.Name = "directorySearchTb";
            this.directorySearchTb.Size = new System.Drawing.Size(1004, 25);
            this.directorySearchTb.TabIndex = 3;
            this.directorySearchTb.TextChanged += new System.EventHandler(this.directorySearchTb_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1225, 513);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.findOldNameBtn);
            this.Controls.Add(this.saveNextBtn);
            this.Controls.Add(this.tempExit);
            this.Controls.Add(this.titleText);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(695, 477);
            this.Name = "Main";
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
    }
}

