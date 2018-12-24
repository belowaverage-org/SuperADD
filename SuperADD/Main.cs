using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;


namespace SuperADD
{
    public partial class Main : Form
    {
        public static FlowLayoutPanel pubFlowLayout = null;

        public static TextBox pubDescTextBox = null;

        public static Dictionary<string, string> descriptions = new Dictionary<string, string>();
        

        private static Dictionary<string, string> dirList = new Dictionary<string, string>();
        private static string currentOU = "";
        private static bool msgDismissable = false;
        private static Image loadImg = Properties.Resources.loading;
        private static Image warnImg = Properties.Resources.warning.ToBitmap();

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
            foreach(XElement elm in Config.Current.Element("OrganizationalUnits").Elements("OrganizationalUnit"))
            {
                if(elm.Element("Name").Value == (string)lv.SelectedItem)
                {
                    currentOU = elm.Element("DistinguishedName").Value;
                    break;
                }
            }
            if(lv == OUList && tabControl.SelectedTab == compNameTab)
            {
                if (!OUChangeDL.IsBusy)
                {
                    lv.Enabled = false;
                    OUChangeDL.RunWorkerAsync();
                }
            }
            else if(lv == dirlookOUList)
            {
                if(!OUChangeDL.IsBusy)
                {
                    lv.Enabled = false;
                    OUChangeDL.RunWorkerAsync();
                }
            }
        }

        private void OUChangeDL_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            dirList.Clear();
            showMsg("Retrieving a list of computer objects in this Organizational Unit...", loadImg, dismissable: false);
            DirectoryEntry de = new DirectoryEntry("LDAP://" + adDomain + "/" + currentOU, adUser, adPass);
            DirectorySearcher ds = new DirectorySearcher(de);
            ds.Filter = "objectClass=computer";
            try
            {
                foreach (SearchResult computer in ds.FindAll())
                {
                    string desc = "";
                    if (computer.Properties["description"].Count != 0)
                    {
                        desc = computer.Properties["description"][0].ToString();
                    }
                    dirList.Add(computer.Properties["CN"][0].ToString(), desc);
                }
                e.Result = "success";
            }
            catch(Exception exc)
            {
                e.Result = exc.Message;
            }
        }

        private void dirListUpdated()
        {
            if (tabControl.SelectedTab == compSearchPage)
            {
                string filter = directorySearchTb.Text;
                computerLookList.BeginUpdate();
                computerLookList.Items.Clear();
                foreach (KeyValuePair<string, string> result in dirList)
                {
                    if (filter == "" || result.Key.ToLower().Contains(filter.ToLower()) || result.Value.ToLower().Contains(filter.ToLower()))
                    {
                        computerLookList.Items.Add(result.Key).SubItems.Add(result.Value);
                    }
                }
                computerLookList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                computerLookList.EndUpdate();
                dirlookOUList.Enabled = true;
            }
            else if(tabControl.SelectedTab == compNameTab)
            {
                FindNextName();
                OUList.Enabled = true;
            }
        }

        private void FindNextName()
        {
            string AutoName = "";
            foreach (XElement element in Config.Current.Element("OrganizationalUnits").Elements("OrganizationalUnit"))
            {
                if (element.Element("Name").Value == OUList.Text)
                {
                    if (element.Element("AutoName") != null && element.Element("AutoName").Value != "")
                    {
                        AutoName = element.Element("AutoName").Value;
                    }
                    else
                    {
                        return;
                    }
                    break;
                }
            }

            string[] splits = AutoName.Split('#');
            string prefix = splits[0];

            int count = 0;

            foreach (KeyValuePair<string, string> comp in dirList)
            {
                if(comp.Key.ToLower().StartsWith(prefix.ToLower()))
                {
                    int number = int.Parse(comp.Key.ToLower().Replace(prefix.ToLower(), ""));
                    if(number >= count)
                    {
                        count = number + 1;
                    }
                }
            }
            nameTextBox.Text = prefix + count.ToString().PadLeft(splits.Length - 1).Replace(" ", "0");
        }
        private void OUChangeDL_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if((string)e.Result == "success")
            {
                hideMsg();
                dirListUpdated();
            }
            else
            {
                showMsg("Could not retrieve a list of computer objects in this Organizational Unit: " + e.Result, warnImg);
                dirlookOUList.Enabled = true;
                OUList.Enabled = true;
            }
        }

        private void directorySearchTb_TextChanged(object sender, EventArgs e)
        {
            dirListUpdated();
        }

        private void computerLookList_DoubleClick(object sender, EventArgs e)
        {
            OUList.SelectedIndex = dirlookOUList.SelectedIndex;
            nameTextBox.Text = computerLookList.SelectedItems[0].Text;
            descTextBox.Text = computerLookList.SelectedItems[0].SubItems[1].Text;
            tabControl.SelectedTab = compNameTab;
        }

        private void CreateComputer_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://" + adDomain + "/" + currentOU, adUser, adPass);
            showMsg("Checking if computer object already exists...", loadImg, dismissable: false);
            DirectorySearcher ds = new DirectorySearcher(de, "(&(objectClass=computer)(CN=" + nameTextBox.Text + "))");
            SearchResult sr = null;
            try
            {
                sr = ds.FindOne();
            }
            catch(Exception exc)
            {
                e.Result = exc.Message;
                return;
            }
            showMsg("Saving changes to Active Directory...", loadImg, dismissable: false);
            try
            {
                if (sr == null)
                {
                    DirectoryEntry computer = de.Children.Add("CN=" + nameTextBox.Text, "computer");
                    if (descTextBox.Text != "")
                    {
                        computer.Properties["description"].Value = descTextBox.Text;
                    }
                    computer.CommitChanges();
                }
                else
                {
                    Console.WriteLine(sr.Path);
                    de.Path = sr.Path;
                    if (descTextBox.Text == "")
                    {
                        de.Properties["description"].Value = null;
                    }
                    else
                    {
                        de.Properties["description"].Value = descTextBox.Text;
                    }
                    de.CommitChanges();
                }
                e.Result = "success";
            }
            catch(UnauthorizedAccessException exc)
            {
                e.Result = exc.Message;
            }
        }

        private void showMsg(string message, Image image, bool disableForm = true, bool dismissable = true)
        {
            msgDismissable = dismissable;
            Invoke(new MethodInvoker(delegate {
                if(disableForm)
                {
                    tabControl.Enabled = false;
                }
                else
                {
                    tabControl.Enabled = true;
                }
                msgShadow.BringToFront();
                msgPanel.BringToFront();
                msgLbl.Text = message;
                msgPic.Enabled = true;
                msgPic.Image = image;
            }));
        }

        private void hideMsg()
        {
            tabControl.Enabled = true;
            msgPanel.SendToBack();
            msgShadow.SendToBack();
            msgPic.Enabled = false;
        }

        private void saveNextBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                showMsg("Computer Name is empty.", warnImg);
                return;
            }
            if (OUList.SelectedItem == null)
            {
                showMsg("No Organizational Unit is selected.", warnImg);
                return;
            }
            if (!CreateComputer.IsBusy)
            {
                CreateComputer.RunWorkerAsync();
            }
        }

        private void findOldNameBtn_Click(object sender, EventArgs e)
        {
            showMsg("You are about to overwrite another computer object! Press save again to continue...", warnImg);
        }

        private void msgPanel_Click(object sender, EventArgs e)
        {
            if(msgDismissable)
            {
                hideMsg();
            }
        }

        private void CreateComputer_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if((string)e.Result == "success")
            {
                hideMsg();
            }
            else
            {
                showMsg("Failed to commit to Active Directory. Message: " + e.Result, warnImg);
            }
        }
    }
}
