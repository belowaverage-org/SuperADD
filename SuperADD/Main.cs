using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.BDD.TaskSequenceModule;
using Interop.TsProgressUI;
using System.Runtime.InteropServices;

namespace SuperADD
{
    public partial class Main : Form
    {
        public static FlowLayoutPanel pubFlowLayout = null;

        public static TextBox pubDescTextBox = null;

        public static Dictionary<string, string> descriptions = new Dictionary<string, string>();

        private static string adDomain = "";
        private static string adUser = "";
        private static string adPass = "";

        private static Dictionary<string, string> dirList = new Dictionary<string, string>();
        private static string currentOU = "";
        private static bool msgDismissable = false;
        private static Image loadImg = Properties.Resources.loading;
        private static Image warnImg = Properties.Resources.warning.ToBitmap();
        private static bool computerOverwriteConfirmed = false;
        private static TSEnvironment env = null;
        private static bool desktopMode = false;

        public Main()
        {
            InitializeComponent();
            try
            {
                new ProgressUI().CloseProgressDialog();
                env = new TSEnvironment();
                foreach(string key in env.Variables)
                {
                    if (key == "USERDOMAIN")
                    {
                        byte[] var = Convert.FromBase64String(env[key]);
                        adDomain = Encoding.UTF8.GetString(var);
                    }
                    if (key == "USERID")
                    {
                        byte[] var = Convert.FromBase64String(env[key]);
                        adUser = Encoding.UTF8.GetString(var);
                    }
                    if (key == "USERPASSWORD")
                    {
                        byte[] var = Convert.FromBase64String(env[key]);
                        adPass = Encoding.UTF8.GetString(var);
                    }
                }
            }
            catch(COMException)
            {
                desktopMode = true;
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
                showMsg("SuperADD was not launched by a task sequence!", warnImg);
            }

            if (!File.Exists("SuperADD.xml"))
            {
                Config.GenerateConfig();
            }
            try
            {
                Config.ReadConfig();
            }
            catch (Exception e)
            {
                showMsg("SSuperADD.xml: " + e.Message, warnImg);
                return;
            }

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
                if (descItem.Element("Type").Value == "List")
                {
                    DescriptListItem listUnit = new DescriptListItem(descItem.Element("Name").Value);
                    foreach (XElement listItem in descItem.Element("ListItems").Elements("ListItem"))
                    {
                        listUnit.listBox.Items.Add(listItem.Value);
                    }
                }
                else if (descItem.Element("Type").Value == "Text")
                {
                    DescriptTextItem listUnit = new DescriptTextItem(descItem.Element("Name").Value);
                }
            }
        }

        public static void updateDescription()
        {
            string description = "";
            int index = 0;
            foreach (KeyValuePair<string, string> desc in descriptions)
            {
                if (desc.Value != null && desc.Value != "")
                {
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

        private int spookyCount = 5;

        private void TitleText_Click(object sender, EventArgs e)
        {
            if (--spookyCount == 0)
            {
                spookyBoi.BringToFront();
                spookyBoi.Enabled = true;
            }
        }

        private void OUList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lv = (ListBox)sender;
            foreach (XElement elm in Config.Current.Element("OrganizationalUnits").Elements("OrganizationalUnit"))
            {
                if (elm.Element("Name").Value == (string)lv.SelectedItem)
                {
                    currentOU = elm.Element("DistinguishedName").Value;
                    break;
                }
            }
            if ((lv == OUList && tabControl.SelectedTab == compNameTab) || lv == dirlookOUList)
            {
                lv.Enabled = false;
                RetrieveOUList();
            }
        }

        private async void RetrieveOUList()
        {
            string rawResults = "";
            try
            {
                dirList.Clear();
                showMsg("Retrieving a list of computer objects in this Organizational Unit...", loadImg, dismissable: false);
                Dictionary<string, string> postData = new Dictionary<string, string>();
                postData.Add("domain", adDomain);
                postData.Add("basedn", currentOU);
                postData.Add("username", adUser);
                postData.Add("password", adPass);
                postData.Add("function", "list");
                postData.Add("filter", "objectClass=computer");
                rawResults = await HTTP.Post(Config.Current.Element("SuperADDServer").Value, postData);
                var results = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(rawResults);
                foreach (Dictionary<string, string> computer in results)
                {
                    dirList.Add(computer["cn"], computer["description"]);
                }
                hideMsg();
            }
            catch (HttpRequestException e)
            {
                showMsg(e.Message + ": " + e.InnerException.Message, warnImg);
            }
            catch (JsonReaderException)
            {
                showMsg("API Response Invalid: " + rawResults, warnImg);
            }
            catch (Exception e)
            {
                showMsg(e.Message, warnImg);
            }
            dirListUpdated();
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
            else if (tabControl.SelectedTab == compNameTab)
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
                if (comp.Key.ToLower().StartsWith(prefix.ToLower()))
                {
                    int number = int.Parse(comp.Key.ToLower().Replace(prefix.ToLower(), ""));
                    if (number >= count)
                    {
                        count = number + 1;
                    }
                }
            }
            nameTextBox.Text = prefix + count.ToString().PadLeft(splits.Length - 1).Replace(" ", "0");
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
            computerOverwriteConfirmed = true;
            tabControl.SelectedTab = compNameTab;
        }

        private void showMsg(string message, Image image, bool disableForm = true, bool dismissable = true)
        {
            void sMsg()
            {
                if (disableForm)
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
            }
            msgDismissable = dismissable;
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate {
                    sMsg();
                }));
            }
            else
            {
                sMsg();
            }
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
            createComputer();
        }

        private async void createComputer()
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
            showMsg("Adding computer to Active Directory...", loadImg, dismissable: false);
            Dictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("domain", adDomain);
            postData.Add("basedn", currentOU);
            postData.Add("username", adUser);
            postData.Add("password", adPass);
            postData.Add("function", "update");
            postData.Add("cn", nameTextBox.Text);
            postData.Add("description", descTextBox.Text);
            if(computerOverwriteConfirmed)
            {
                postData.Add("confirm", "");
            }
            try
            {
                string error = await HTTP.Post(Config.Current.Element("SuperADDServer").Value, postData);
                if (error != "")
                {
                    if (error == "confirm")
                    {
                        showMsg("This computer object already exists!\nPress \"Save\" again to confirm.", warnImg, disableForm: false);
                        computerOverwriteConfirmed = true;
                    }
                    else
                    {
                        showMsg("API Error: " + error, warnImg);
                    }
                }
                else
                {
                    if(desktopMode)
                    {
                        hideMsg();
                    }
                    else
                    {
                        setTSVariables();
                    }
                }
            }
            catch (HttpRequestException e)
            {
                showMsg(e.Message + ": " + e.InnerException.Message, warnImg);
            }
            catch (Exception e)
            {
                showMsg(e.Message, warnImg);
            }
        }

        private void setTSVariables(bool joinDomain = true, bool exitSuperADD = true)
        {
            if (!desktopMode)
            {
                try
                {
                    if (joinDomain)
                    {
                        env["OSDCOMPUTERNAME"] = nameTextBox.Text;
                        env["DOMAINADMIN"] = env["USERID"];
                        env["DOMAINADMINDOMAIN"] = env["USERDOMAIN"];
                        env["DOMAINADMINPASSWORD"] = env["USERPASSWORD"];
                        env["JOINDOMAIN"] = adDomain;
                        env["OSDDOMAINNAME"] = adDomain;
                        env["MACHINEOBJECTOU"] = currentOU;
                        env["OSDNETWORKJOINTYPE"] = "0";
                    }
                    else
                    {
                        env["OSDCOMPUTERNAME"] = nameTextBox.Text;
                        env["JOINWORKGROUP"] = "WORKGROUP";
                        env["OSDNETWORKJOINTYPE"] = "1";
                    }
                    if (exitSuperADD)
                    {
                        Application.Exit();
                    }
                }
                catch(Exception e)
                {
                    showMsg("Error setting TS Variables: " + e.Message, warnImg);
                }
            }
        }

        private void msgPanel_Click(object sender, EventArgs e)
        {
            if (msgDismissable)
            {
                hideMsg();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            computerOverwriteConfirmed = false;
        }

        private void spookyBoi_Click(object sender, EventArgs e)
        {
            spookyBoi.SendToBack();
            spookyBoi.Enabled = false;
            spookyCount = 5;
        }

        private void skipJoinBtn_Click(object sender, EventArgs e)
        {
            setTSVariables(false);
        }
    }
}
