using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuperADD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Config.ReadConfig();
            Config.GenerateConfig();
            new Interop.TsProgressUI.ProgressUI().CloseProgressDialog();
            Microsoft.BDD.TaskSequenceModule.TSEnvironment env = new Microsoft.BDD.TaskSequenceModule.TSEnvironment();
            foreach(string key in env.Variables)
            {
                richTextBox1.AppendText("Key: " + key + " Value: " + env[key] + "\n\r");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
