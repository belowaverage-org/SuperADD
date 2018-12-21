using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;
using System.IO;
using System.Threading.Tasks;


namespace SuperADD
{
    public partial class Main : Form
    {
        public static FlowLayoutPanel pubFlowLayout = null;

        public static TextBox pubDescTextBox = null;

        public static Dictionary<string, string> descriptions = new Dictionary<string, string>();

        private static string adDomain = "ad.contoso.com";
        private static string adUser = "user";
        private static string adPass = "pass";

        private static Dictionary<string, string> dirList = new Dictionary<string, string>();

        public Main()
        {
            InitializeComponent();
            if(!File.Exists("SuperADD.xml"))
            {
                Config.GenerateConfig();
            }
            Config.ReadConfig();


            pubFlowLayout = flowPanel;
            pubDescTextBox = descTextBox;

            foreach (XElement ou in Config.Current.Element("OrganizationalUnits").Elements("OrganizationalUnit"))
            {
                OUList.Items.Add(ou.Element("Name").Value);
                dirlookOUList.Items.Add(ou.Element("Name").Value);
            }

            foreach (XElement descItem in Config.Current.Element("DescriptionItems").Elements("DescriptionItem"))
            {
                descriptions.Add(descItem.Element("Name").Value, null);
                if(descItem.Element("Type").Value == "List")
                {
                    DescriptListItem listUnit = new DescriptListItem(descItem.Element("Name").Value);
                    foreach (XElement listItem in descItem.Element("ListItems").Elements("ListItem"))
                    {
                        listUnit.listBox.Items.Add(listItem.Value);
                    }
                }
                else if(descItem.Element("Type").Value == "Text")
                {
                    DescriptTextItem listUnit = new DescriptTextItem(descItem.Element("Name").Value);
                }
            }

            /*new Interop.TsProgressUI.ProgressUI().CloseProgressDialog();
            Microsoft.BDD.TaskSequenceModule.TSEnvironment env = new Microsoft.BDD.TaskSequenceModule.TSEnvironment();
            foreach(string key in env.Variables)
            {
                richTextBox1.AppendText("Key: " + key + " Value: " + env[key] + "\n\r");
            }*/
        }

        public static void updateDescription()
        {
            string description = "";
            int index = 0;
            foreach (KeyValuePair<string, string> desc in descriptions)
            {
                if (desc.Value != null && desc.Value != "") {
                    if (index++ == description.Length)
                    {
                        description = description + desc.Value;
                    }
                    else
                    {
                        description = description + ", " + desc.Value;
                    }
                }
            }
            pubDescTextBox.Text = description;
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
                //spookyBoi.BringToFront();
                //spookyBoi.Enabled = true;
            }
        }

        private void OUList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lv = (ListBox)sender;
            string OU = "";
            foreach(XElement elm in Config.Current.Element("OrganizationalUnits").Elements("OrganizationalUnit"))
            {
                if(elm.Element("Name").Value == (string)lv.SelectedItem)
                {
                    OU = elm.Element("DistinguishedName").Value;
                    break;
                }
            }
            if(lv == OUList)
            {
                
            }
            else if(lv == dirlookOUList)
            {
                if(!OUChangeDL.IsBusy)
                {
                    lv.Enabled = false;
                    OUChangeDL.RunWorkerAsync(OU);
                }
            }
        }

        private void OUChangeDL_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            dirList.Clear();
            DirectoryEntry de = new DirectoryEntry("LDAP://" + adDomain + "/" + (string)e.Argument, adUser, adPass);
            DirectorySearcher ds = new DirectorySearcher(de);
            ds.Filter = "objectClass=computer";
            foreach (SearchResult computer in ds.FindAll())
            {
                string desc = "";
                if (computer.Properties["description"].Count != 0)
                {
                    desc = computer.Properties["description"][0].ToString();
                }
                dirList.Add(computer.Properties["CN"][0].ToString(), desc);
            }
        }

        private void updateDirList()
        {
            string filter = directorySearchTb.Text;
            computerLookList.BeginUpdate();
            computerLookList.Items.Clear();
            foreach (KeyValuePair<string, string> result in dirList)
            {
                if(filter ==  "" || result.Key.ToLower().Contains(filter.ToLower()) || result.Value.ToLower().Contains(filter.ToLower()))
                {
                    computerLookList.Items.Add(result.Key).SubItems.Add(result.Value);
                }
            }
            computerLookList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            computerLookList.EndUpdate();
            dirlookOUList.Enabled = true;
        }

        private void OUChangeDL_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            updateDirList();
        }

        private void directorySearchTb_TextChanged(object sender, EventArgs e)
        {
            updateDirList();
        }
    }
}
