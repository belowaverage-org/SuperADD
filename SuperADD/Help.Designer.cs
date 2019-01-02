namespace SuperADD
{
    partial class Help
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
            this.commandList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // commandList
            // 
            this.commandList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandList.FormattingEnabled = true;
            this.commandList.HorizontalScrollbar = true;
            this.commandList.IntegralHeight = false;
            this.commandList.Items.AddRange(new object[] {
            "-/?   |  Opens this dialog.",
            "-/autorunindex:[OU Index (num)]   |  Auto creates the computer and continues. (OU" +
                " Index is the zero based index from which the computer will be created from out " +
                "of the OU list in the SuperADD.xml)",
            "-/autoselectindex:[OU Index (num)]   |  Auto selects the computer OU at startup.",
            "-/dump  |  Dumps all MDT variables into a window."});
            this.commandList.Location = new System.Drawing.Point(0, 0);
            this.commandList.Name = "commandList";
            this.commandList.Size = new System.Drawing.Size(479, 235);
            this.commandList.TabIndex = 0;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 235);
            this.Controls.Add(this.commandList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperADD: Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox commandList;
    }
}