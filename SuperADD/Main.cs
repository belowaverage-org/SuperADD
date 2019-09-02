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
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SuperADD
{
    public partial class Main : Form
    {
        public static FlowLayoutPanel pubFlowLayout = null;
        public static TextBox pubDescTextBox = null;
        public static Dictionary<string, string> descriptions = new Dictionary<string, string>();
        public static SizeF pubAutoScaleFactor;
        public string adDomainName = "";
        public string adUserName = "";
        public string adPassword = "";
        private Dictionary<string, string> currentlySelectedOUList = new Dictionary<string, string>();
        private string currentlySelectedOU = "";
        private bool msgDismissable = false;
        private Image loadImg = Properties.Resources.loading;
        private Image warnImg = Properties.Resources.warning.ToBitmap();
        private bool computerOverwriteConfirmed = false;
        private TSEnvironment tsEnv = null;
        private bool desktopMode = false;
        private int spookyCount = 5;
        private int autoRunIndex = -1;
        private bool autoRunContinue = false;
        private bool suppressFindNextName = false;
        private string currentCreateSelectedOU = "";
        private bool initialized = false;
        List<char> invalidNameCharacters = new List<char> {
            ' ', '{', '|', '}', '~', '[', '\\', ']', '^', '\'', ':', ';', '<', '=', '>',
            '?', '@', '!', '"', '#', '$', '%', '`', '(', ')', '+', '/', '.', ',', '*', '&'
        };
        public Main(int autoIndex = -1, bool autoContinue = false)
        {
            InitializeComponent();
            titleText.Text = "SuperADD  |  v" + Application.ProductVersion.ToString();
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
                showMsg("SuperADD.xml: " + e.Message, warnImg);
                return;
            }
            try
            {
                new ProgressUI().CloseProgressDialog();
                tsEnv = new TSEnvironment();
                foreach (string key in tsEnv.Variables)
                {
                    if (key == "JOINDOMAIN")
                    {
                        adDomainName = tsEnv[key];
                    }
                    if (key == "USERID")
                    {
                        byte[] var = Convert.FromBase64String(tsEnv[key]);
                        adUserName = Encoding.UTF8.GetString(var);
                    }
                    if (key == "USERPASSWORD")
                    {
                        byte[] var = Convert.FromBase64String(tsEnv[key]);
                        adPassword = Encoding.UTF8.GetString(var);
                    }
                }
            }
            catch (COMException)
            {
                desktopMode = true;
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;
                saveNextBtn.Text = "Save";
                skipJoinBtn.Hide();
                promptUsrTxt.Text = Environment.UserName;
                XElement domain = Config.Current.Element("DomainName");
                if (domain != null)
                {
                    promptDomTxt.Text = domain.Value;
                }
                else
                {
                    promptDomTxt.Text = IPGlobalProperties.GetIPGlobalProperties().DomainName;
                }
            }
            Icon = Properties.Resources.winicon;
            autoRunIndex = autoIndex;
            autoRunContinue = autoContinue;
            pubFlowLayout = flowPanel;
            pubDescTextBox = descTextBox;
            pubAutoScaleFactor = new SizeF(
                CurrentAutoScaleDimensions.Width / 96,
                CurrentAutoScaleDimensions.Height / 96
            );
            foreach (XElement ou in Config.Current.Element("OrganizationalUnits").Elements("OrganizationalUnit"))
            {
                OUList.Items.Add(ou.Element("Name").Value);
                dirLookOUList.Items.Add(ou.Element("Name").Value);
            }
            foreach (XElement sg in Config.Current.Element("SecurityGroups").Elements("SecurityGroup"))
            {
                SGList.Items.Add(sg.Element("Name").Value);
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
            initialized = true;
        }
        private async void Main_Load(object sender, EventArgs e)
        {
            if (!initialized) return;
            showMsg("Starting SuperADD Daemon...", loadImg, true, false);
            await SuperADDDaemon.Start();
            hideMsg();
            if (desktopMode)
            {
                showPassPrompt();
            }
            if (autoRunIndex > -1 && autoRunIndex < OUList.Items.Count)
            {
                OUList.SelectedIndex = autoRunIndex;
                if (autoRunContinue)
                {
                    autoRunIndex = -2;
                }
                else
                {
                    autoRunIndex = -1;
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
        private async void retrieveCurrentlySelectedOUList()
        {
            string rawResults = "";
            if (adDomainName == "" || adUserName == "" || adPassword == "")
            {
                showPassPrompt();
                currentlySelectedOUListUpdated();
                return;
            }
            try
            {
                currentlySelectedOUList.Clear();
                showMsg("Retrieving a list of computer objects in this Organizational Unit...", loadImg, dismissable: false);
                rawResults = await HTTP.Post(new Dictionary<string, string>() {
                    { "basedn", currentlySelectedOU },
                    { "function", "list" },
                    { "filter", "objectClass=computer" }
                });
                var results = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(rawResults);
                foreach (Dictionary<string, string> computer in results)
                {
                    currentlySelectedOUList.Add(computer["cn"], computer["description"]);
                }
                hideMsg();
            }
            catch (HttpRequestException e)
            {
                showMsg(e.Message + ": " + e.InnerException.Message, warnImg);
            }
            catch (JsonReaderException)
            {
                showMsg("Daemon: " + rawResults, warnImg);
            }
            catch (Exception e)
            {
                showMsg(e.Message, warnImg);
            }
            currentlySelectedOUListUpdated();
        }
        private void currentlySelectedOUListUpdated()
        {
            if (tabControl.SelectedTab == dirLookTab)
            {
                string filter = directorySearchTb.Text;
                computerLookList.BeginUpdate();
                computerLookList.Items.Clear();
                foreach (KeyValuePair<string, string> result in currentlySelectedOUList)
                {
                    if (filter == "" || result.Key.ToLower().Contains(filter.ToLower()) || result.Value.ToLower().Contains(filter.ToLower()))
                    {
                        computerLookList.Items.Add(result.Key).SubItems.Add(result.Value);
                    }
                }
                computerLookList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                computerLookList.EndUpdate();
                dirLookOUList.Enabled = true;
            }
        }
        private async void findNextComputerName()
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
            if (adDomainName == "" || adUserName == "" || adPassword == "")
            {
                showPassPrompt();
                return;
            }
            string rawResults = "";
            try
            {
                showMsg("Searching AD for next available name...", loadImg);
                rawResults = await HTTP.Post(new Dictionary<string, string>() {
                    { "basedn", Config.Current.Element("BaseDN").Value },
                    { "function", "list" },
                    { "recurse", "" },
                    { "filter", "(&(sAMAccountName=" + prefix + "*$)(objectClass=computer))" }
                });
                var results = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(rawResults);
                foreach (Dictionary<string, string> comp in results)
                {
                    if (comp["cn"].ToLower().StartsWith(prefix.ToLower()))
                    {
                        int number = 0;
                        string suffix = comp["cn"].ToLower().Replace(prefix.ToLower(), "");
                        if (int.TryParse(suffix, out number))
                        {
                            if (number >= count)
                            {
                                count = number + 1;
                            }
                        }
                    }
                }
                nameTextBox.Text = prefix + count.ToString().PadLeft(splits.Length - 1).Replace(" ", "0");
                hideMsg();
            }
            catch (JsonReaderException)
            {
                showMsg(rawResults, warnImg);
            }
            catch (Exception e)
            {
                showMsg(e.Message, warnImg);
            }
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
            void hMsg()
            {
                tabControl.Enabled = true;
                msgPanel.SendToBack();
                msgShadow.SendToBack();
                msgPic.Enabled = false;
            }
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate {
                    hMsg();
                }));
            }
            else
            {
                hMsg();
            }
        }
        private Task<String> findCurrentComputerName()
        {
            return Task.Run(() =>
            {
                showMsg("Find Computer Name: Getting list of logical drives...", loadImg);
                string[] drives = Environment.GetLogicalDrives();
                showMsg("Find Computer Name: Searching in offline registries...", loadImg);
                foreach (string drive in drives)
                {
                    string rPath = drive + @"Windows\System32\config\SYSTEM";
                    if (File.Exists(rPath))
                    {
                        try
                        {
                            Registry.RegistryHiveOnDemand registryHive = new Registry.RegistryHiveOnDemand(rPath);
                            Registry.Abstractions.RegistryKey key = registryHive.GetKey(@"ControlSet001\Control\ComputerName\ComputerName");
                            foreach (Registry.Abstractions.KeyValue value in key.Values)
                            {
                                if (value.ValueName == "ComputerName")
                                {
                                    return value.ValueData;
                                }
                            }
                        }
                        catch (IOException) { }
                    }
                }
                showMsg("Find Computer Name: Searching in online registry...", loadImg);
                Microsoft.Win32.RegistryKey computerName = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SYSTEM\ControlSet001\Control\ComputerName\ComputerName", false);
                hideMsg();
                return (string)computerName.GetValue("ComputerName");
            });
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
            if (adDomainName == "" || adUserName == "" || adPassword == "")
            {
                showPassPrompt();
                return;
            }
            showMsg("Adding computer to Active Directory...", loadImg, dismissable: false);

            Dictionary<string, string> postData = new Dictionary<string, string>() {
                { "basedn", Config.Current.Element("BaseDN").Value },
                { "function", "update" },
                { "cn", nameTextBox.Text },
                { "description", descTextBox.Text },
                { "destinationdn", currentCreateSelectedOU }
            };
            int index = 0;
            foreach (XElement SG in Config.Current.Element("SecurityGroups").Elements())
            {
                if (SGList.SelectedItems.Contains(SG.Element("Name").Value))
                {
                    postData.Add("addgroups[" + (index++) + "]", SG.Element("DistinguishedName").Value);
                }
                else
                {
                    postData.Add("removegroups[" + (index++) + "]", SG.Element("DistinguishedName").Value);
                }
            }
            if (computerOverwriteConfirmed)
            {
                postData.Add("confirm", "");
            }
            try
            {
                string error = await HTTP.Post(postData);
                if (error != "")
                {
                    if (error == "confirm")
                    {
                        if(desktopMode)
                        {
                            showMsg("This computer object already exists!\nPress \"Save\" again to confirm.", warnImg, disableForm: false);
                        }
                        else
                        {
                            showMsg("This computer object already exists!\nPress \"Join Domain\" again to confirm.", warnImg, disableForm: false);
                        }
                        computerOverwriteConfirmed = true;
                    }
                    else
                    {
                        showMsg("Daemon: " + error, warnImg);
                    }
                }
                else
                {
                    if (desktopMode)
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
                        tsEnv["OSDCOMPUTERNAME"] = nameTextBox.Text;
                        tsEnv["DOMAINADMIN"] = tsEnv["USERID"];
                        tsEnv["DOMAINADMINDOMAIN"] = tsEnv["USERDOMAIN"];
                        tsEnv["DOMAINADMINPASSWORD"] = tsEnv["USERPASSWORD"];
                        tsEnv["MACHINEOBJECTOU"] = currentCreateSelectedOU;
                        tsEnv["JOINWORKGROUP"] = "";
                    }
                    else
                    {
                        tsEnv["OSDCOMPUTERNAME"] = nameTextBox.Text;
                        tsEnv["JOINDOMAIN"] = "";
                        tsEnv["OSDNETWORKJOINTYPE"] = "1";
                    }
                    if (exitSuperADD)
                    {
                        Application.Exit();
                    }
                }
                catch (Exception e)
                {
                    showMsg("Error setting TS Variables: " + e.Message, warnImg);
                }
            }
        }
        private async void getCurrentComputerDetails()
        {
            if (adDomainName == "" || adUserName == "" || adPassword == "")
            {
                showPassPrompt();
                return;
            }
            string rawResults = "";
            try
            {
                showMsg("Searching AD for the current computer object...", loadImg);
                rawResults = await HTTP.Post(new Dictionary<string, string>() {
                    { "basedn", Config.Current.Element("BaseDN").Value },
                    { "function", "list" },
                    { "recurse", "" },
                    { "includegroups", "" },
                    { "filter", "(&(sAMAccountName=" + nameTextBox.Text + "$)(objectClass=computer))" }
                });
                var results = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(rawResults);
                if (results.Count != 0)
                {
                    var result = results[0];
                    string cn = (string)result["cn"];
                    nameTextBox.Text = cn;
                    descTextBox.Text = (string)result["description"];
                    foreach (XElement OU in Config.Current.Element("OrganizationalUnits").Elements())
                    {
                        if (OU.Element("DistinguishedName").Value == ((string)result["dn"]).Replace("CN=" + cn + ",", ""))
                        {
                            suppressFindNextName = true;
                            OUList.SelectedItem = OU.Element("Name").Value;
                            suppressFindNextName = false;
                            break;
                        }
                    }
                    SGList.ClearSelected();
                    foreach (string computerGroup in (JArray)results[0]["groups"])
                    {
                        foreach(XElement definedGroup in Config.Current.Element("SecurityGroups").Elements())
                        {
                            if(definedGroup.Element("DistinguishedName").Value == computerGroup)
                            {
                                SGList.SelectedItems.Add(definedGroup.Element("Name").Value);
                                break;
                            }
                        }
                    }
                    hideMsg();
                }
                else
                {
                    showMsg("Computer object not found.", warnImg);
                }
            }
            catch (JsonReaderException)
            {
                showMsg(rawResults, warnImg);
            }
            catch (Exception e)
            {
                showMsg(e.Message, warnImg);
            }
        }
        private void directorySearchTb_TextChanged(object sender, EventArgs e)
        {
            currentlySelectedOUListUpdated();
        }
        private void computerLookList_DoubleClick(object sender, EventArgs e)
        {
            nameTextBox.Text = computerLookList.SelectedItems[0].Text;
            tabControl.SelectedTab = compNameTab;
            SearchADBtn.PerformClick();
            computerOverwriteConfirmed = true;
        }
        private void msgPanel_Click(object sender, EventArgs e)
        {
            if (msgDismissable)
            {
                hideMsg();
            }
        }
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
                    currentlySelectedOU = elm.Element("DistinguishedName").Value;
                    if (lv == OUList)
                    {
                        currentCreateSelectedOU = elm.Element("DistinguishedName").Value;
                    }
                    break;
                }
            }
            if ((lv == dirLookOUList) && !suppressFindNextName)
            {
                lv.Enabled = false;
                retrieveCurrentlySelectedOUList();
            }
            if((lv == OUList && tabControl.SelectedTab == compNameTab) && !suppressFindNextName)
            {
                findNextComputerName();
            }
        }
        private void saveNextBtn_Click(object sender, EventArgs e)
        {
            createComputer();
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char character in invalidNameCharacters)
            {
                nameTextBox.Text = nameTextBox.Text.Replace(character, '\0');
            }
            if (nameTextBox.Text.Length > 15)
            {
                nameTextBox.Text = nameTextBox.Text.Substring(0, 15);
            }
            if (autoRunIndex == -2)
            {
                saveNextBtn.PerformClick();
            }
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
        private void promptSubmitBtn_Click(object sender, EventArgs e)
        {
            hidePassPrompt();
        }
        public void showPassPrompt()
        {
            tabControl.Enabled = false;
            promptShadowPanel.BringToFront();
            promptPanel.BringToFront();
            promptPasTxt.Focus();
        }
        public void hidePassPrompt()
        {
            adUserName = promptUsrTxt.Text;
            adPassword = promptPasTxt.Text;
            adDomainName = promptDomTxt.Text;
            promptShadowPanel.SendToBack();
            promptPanel.SendToBack();
            tabControl.Enabled = true;
        }
        private void prompt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                promptSubmitBtn.PerformClick();
            }
        }
        private async void findCurrentNameBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = await findCurrentComputerName();
            getCurrentComputerDetails();
        }
        private void SearchADBtn_Click(object sender, EventArgs e)
        {
            getCurrentComputerDetails();
        }
        private async void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            showMsg("Stopping SuperADD Daemon...", loadImg, true, false);
            if(SuperADDDaemon.ServerStarted)
            {
                e.Cancel = true;
                await SuperADDDaemon.Stop();
                Close();
            }
        }
        private void BtnHidden_DoubleClick(object sender, EventArgs e)
        {
            new Help(1).ShowDialog();
        }
    }
}