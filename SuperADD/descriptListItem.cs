using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperADD
{
    class DescriptListItem
    {
        public DescriptListItem(string title)
        {
            groupBox.Controls.Add(listBox);
            groupBox.Margin = new Padding(10, 0, 10, 10);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(10);
            groupBox.Size = new System.Drawing.Size(300, 200);
            groupBox.TabStop = false;
            groupBox.Text = title;
            listBox.Dock = DockStyle.Fill;
            listBox.FormattingEnabled = true;
            listBox.IntegralHeight = false;
            listBox.ItemHeight = 17;
            listBox.Name = "listBox";
            listBox.Size = new System.Drawing.Size(280, 162);
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            Main.pubFlowLayout.Controls.Add(groupBox);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.descriptions[groupBox.Text] = (string)listBox.SelectedItem;
            Main.updateDescription();
        }

        public GroupBox groupBox = new GroupBox();
        public ListBox listBox = new ListBox();
    }
}
