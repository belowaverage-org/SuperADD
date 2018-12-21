using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperADD
{
    class DescriptTextItem
    {
        public DescriptTextItem(string title)
        {
            groupBox.Controls.Add(textBox);
            groupBox.Margin = new Padding(10);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(10);
            groupBox.Size = new System.Drawing.Size(300, 200);
            groupBox.TabStop = false;
            groupBox.Text = title;
            textBox.Dock = DockStyle.Fill;
            textBox.Multiline = true;
            textBox.Name = "listBoxList";
            textBox.Size = new System.Drawing.Size(280, 162);
            textBox.TextChanged += TextBox_TextChanged;
            Main.pubFlowLayout.Controls.Add(groupBox);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Main.descriptions[groupBox.Text] = textBox.Text;
            Main.updateDescription();
        }

        public GroupBox groupBox = new GroupBox();
        public TextBox textBox = new TextBox();
    }
}
