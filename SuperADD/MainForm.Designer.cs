namespace SuperADD
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("CP-PC-1135");
            this.tempDebugLog = new System.Windows.Forms.RichTextBox();
            this.tempExit = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.Label();
            this.OUList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CatType = new System.Windows.Forms.ListBox();
            this.CatName = new System.Windows.Forms.ListBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.computerNameTBox = new System.Windows.Forms.TextBox();
            this.ComputerName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComputerList = new System.Windows.Forms.ListView();
            this.ComputerNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descriptions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spookyBoi = new System.Windows.Forms.PictureBox();
            this.SaveNextBtn = new System.Windows.Forms.Button();
            this.findOldNameBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UsernameLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spookyBoi)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempDebugLog
            // 
            this.tempDebugLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tempDebugLog.Location = new System.Drawing.Point(123, 74);
            this.tempDebugLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tempDebugLog.Name = "tempDebugLog";
            this.tempDebugLog.Size = new System.Drawing.Size(554, 284);
            this.tempDebugLog.TabIndex = 0;
            this.tempDebugLog.Text = "";
            // 
            // tempExit
            // 
            this.tempExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tempExit.Location = new System.Drawing.Point(871, 0);
            this.tempExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tempExit.Name = "tempExit";
            this.tempExit.Size = new System.Drawing.Size(20, 19);
            this.tempExit.TabIndex = 1;
            this.tempExit.UseVisualStyleBackColor = true;
            this.tempExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleText
            // 
            this.TitleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.Location = new System.Drawing.Point(0, 0);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(891, 35);
            this.TitleText.TabIndex = 2;
            this.TitleText.Text = "Active Directory Join";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleText.Click += new System.EventHandler(this.TitleText_Click);
            // 
            // OUList
            // 
            this.OUList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OUList.FormattingEnabled = true;
            this.OUList.IntegralHeight = false;
            this.OUList.ItemHeight = 17;
            this.OUList.Items.AddRange(new object[] {
            "CF Laptop",
            "CF Desktop",
            "CP Laptop",
            "CP Desktop",
            "CP GateCentral"});
            this.OUList.Location = new System.Drawing.Point(5, 23);
            this.OUList.Name = "OUList";
            this.OUList.Size = new System.Drawing.Size(166, 339);
            this.OUList.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.descLbl);
            this.groupBox1.Controls.Add(this.nameLbl);
            this.groupBox1.Controls.Add(this.computerNameTBox);
            this.groupBox1.Controls.Add(this.ComputerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(867, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Computer Object";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CatType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CatName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 112);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // CatType
            // 
            this.CatType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatType.FormattingEnabled = true;
            this.CatType.IntegralHeight = false;
            this.CatType.ItemHeight = 17;
            this.CatType.Location = new System.Drawing.Point(5, 5);
            this.CatType.Margin = new System.Windows.Forms.Padding(5);
            this.CatType.Name = "CatType";
            this.CatType.Size = new System.Drawing.Size(168, 102);
            this.CatType.TabIndex = 7;
            this.CatType.SelectedIndexChanged += new System.EventHandler(this.CatType_SelectedIndexChanged);
            // 
            // CatName
            // 
            this.CatName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatName.FormattingEnabled = true;
            this.CatName.IntegralHeight = false;
            this.CatName.ItemHeight = 17;
            this.CatName.Location = new System.Drawing.Point(183, 5);
            this.CatName.Margin = new System.Windows.Forms.Padding(5);
            this.CatName.Name = "CatName";
            this.CatName.Size = new System.Drawing.Size(169, 102);
            this.CatName.TabIndex = 6;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(359, 78);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(74, 17);
            this.descLbl.TabIndex = 10;
            this.descLbl.Text = "Description";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(358, 22);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(43, 17);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Name";
            // 
            // computerNameTBox
            // 
            this.computerNameTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.computerNameTBox.Location = new System.Drawing.Point(361, 45);
            this.computerNameTBox.Name = "computerNameTBox";
            this.computerNameTBox.Size = new System.Drawing.Size(501, 25);
            this.computerNameTBox.TabIndex = 8;
            // 
            // ComputerName
            // 
            this.ComputerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerName.Location = new System.Drawing.Point(361, 102);
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Size = new System.Drawing.Size(501, 25);
            this.ComputerName.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.OUList);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(176, 367);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Organizational Unit";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tempDebugLog);
            this.groupBox3.Controls.Add(this.ComputerList);
            this.groupBox3.Controls.Add(this.spookyBoi);
            this.groupBox3.Location = new System.Drawing.Point(194, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(685, 367);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Computers";
            // 
            // ComputerList
            // 
            this.ComputerList.AllowColumnReorder = true;
            this.ComputerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ComputerNames,
            this.Descriptions});
            this.ComputerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComputerList.FullRowSelect = true;
            this.ComputerList.HideSelection = false;
            this.ComputerList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ComputerList.Location = new System.Drawing.Point(5, 23);
            this.ComputerList.MultiSelect = false;
            this.ComputerList.Name = "ComputerList";
            this.ComputerList.Size = new System.Drawing.Size(675, 339);
            this.ComputerList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ComputerList.TabIndex = 5;
            this.ComputerList.UseCompatibleStateImageBehavior = false;
            this.ComputerList.View = System.Windows.Forms.View.Details;
            // 
            // ComputerNames
            // 
            this.ComputerNames.Text = "Names";
            this.ComputerNames.Width = 106;
            // 
            // Descriptions
            // 
            this.Descriptions.Text = "Descriptions";
            this.Descriptions.Width = 366;
            // 
            // spookyBoi
            // 
            this.spookyBoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spookyBoi.BackColor = System.Drawing.Color.White;
            this.spookyBoi.Enabled = false;
            this.spookyBoi.Image = global::SuperADD.Properties.Resources.ezgif_1_e366c6e037a7;
            this.spookyBoi.Location = new System.Drawing.Point(477, 159);
            this.spookyBoi.Name = "spookyBoi";
            this.spookyBoi.Size = new System.Drawing.Size(200, 200);
            this.spookyBoi.TabIndex = 12;
            this.spookyBoi.TabStop = false;
            // 
            // SaveNextBtn
            // 
            this.SaveNextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveNextBtn.Location = new System.Drawing.Point(791, 535);
            this.SaveNextBtn.Name = "SaveNextBtn";
            this.SaveNextBtn.Size = new System.Drawing.Size(89, 29);
            this.SaveNextBtn.TabIndex = 9;
            this.SaveNextBtn.Text = "Save";
            this.SaveNextBtn.UseVisualStyleBackColor = true;
            // 
            // findOldNameBtn
            // 
            this.findOldNameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findOldNameBtn.Location = new System.Drawing.Point(99, 535);
            this.findOldNameBtn.Name = "findOldNameBtn";
            this.findOldNameBtn.Size = new System.Drawing.Size(115, 29);
            this.findOldNameBtn.TabIndex = 10;
            this.findOldNameBtn.Text = "Find old name...";
            this.findOldNameBtn.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshBtn.Location = new System.Drawing.Point(11, 535);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(82, 29);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh...";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsernameLbl,
            this.ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(74, 17);
            this.UsernameLbl.Text = "Please wait...";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(891, 592);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.findOldNameBtn);
            this.Controls.Add(this.SaveNextBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tempExit);
            this.Controls.Add(this.TitleText);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(695, 477);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spookyBoi)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tempDebugLog;
        private System.Windows.Forms.Button tempExit;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.ListBox OUList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveNextBtn;
        private System.Windows.Forms.Button findOldNameBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ListView ComputerList;
        private System.Windows.Forms.ColumnHeader ComputerNames;
        private System.Windows.Forms.ColumnHeader Descriptions;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UsernameLbl;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox CatType;
        private System.Windows.Forms.ListBox CatName;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox computerNameTBox;
        private System.Windows.Forms.TextBox ComputerName;
        private System.Windows.Forms.PictureBox spookyBoi;
    }
}

