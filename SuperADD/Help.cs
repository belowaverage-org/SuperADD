using System.Windows.Forms;
using Microsoft.BDD.TaskSequenceModule;

namespace SuperADD
{
    public partial class Help : Form
    {
        public Help(int task = 0)
        {
            InitializeComponent();
            Icon = Properties.Resources.superadd;
            if (task == 1)
            {
                Text = "SuperADD: MDT Variables Dump";
                commandList.Items.Clear();
                TSEnvironment tsEnv = new TSEnvironment();
                foreach (string key in tsEnv.Variables)
                {
                    commandList.Items.Add("Key: " + key + " Value: " + tsEnv[key]);
                }
            }
        }
    }
}
