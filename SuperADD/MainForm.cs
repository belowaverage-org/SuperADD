using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SuperADD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if(!File.Exists("SuperADD.xml"))
            {
                Config.GenerateConfig();
            }
            Config.ReadConfig();

            foreach(XElement descItem in Config.Current.Element("DescriptionItems").Elements("DescriptionItem"))
            {
                CatType.Items.Add(descItem.Element("Name").Value);
            }

            foreach (XElement element in Config.Current.Elements())
            {
                tempDebugLog.AppendText("Key: " + element.Name.LocalName + " Value: \n\r");
            }

            /*new Interop.TsProgressUI.ProgressUI().CloseProgressDialog();
            Microsoft.BDD.TaskSequenceModule.TSEnvironment env = new Microsoft.BDD.TaskSequenceModule.TSEnvironment();
            foreach(string key in env.Variables)
            {
                richTextBox1.AppendText("Key: " + key + " Value: " + env[key] + "\n\r");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private int spookyCount = 20;

        private void TitleText_Click(object sender, EventArgs e)
        {
            if(--spookyCount == 0)
            {
                spookyBoi.BringToFront();
                spookyBoi.Enabled = true;
            }
            Console.WriteLine(spookyCount);
        }

        private void CatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(CatType.SelectedItem);
            CatName.Items.Clear();
            foreach (XElement descItem in Config.Current.Element("DescriptionItems").Elements("DescriptionItem"))
            {
                if(descItem.Element("Name").Value == (string)CatType.SelectedItem)
                {
                    if (descItem.Element("Type").Value == "List")
                    {
                        foreach (XElement listItem in descItem.Element("ListItems").Elements("ListItem"))
                        {
                            CatName.Items.Add(listItem.Value);
                        }
                    }
                    else if(descItem.Element("Type").Value == "Text")
                    {

                    }
                    break;
                }
                
            }
        }
    }
}
