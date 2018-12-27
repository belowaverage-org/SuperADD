﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;
using System.Drawing;
using System.Net.Http;
using Newtonsoft.Json;
using System.Xml;

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
        private static bool computerOverwriteConfirmed = false;

        public Main()
        {
            InitializeComponent();
            if (!File.Exists("SuperADD.xml"))
            {
                Config.GenerateConfig();
            }
            try
            {
                Config.ReadConfig();
            }
            catch (XmlException e)
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

        private int spookyCount = 20;

        private void TitleText_Click(object sender, EventArgs e)
        {
            if (--spookyCount == 0)
            {
                //spookyBoi.BringToFront();
                //spookyBoi.Enabled = true;
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
                HttpClient client = new HttpClient();
                if (Config.Current.Element("SuperADDServer") != null)
                {
                    client.BaseAddress = new Uri(Config.Current.Element("SuperADDServer").Value);
                    List<KeyValuePair<string, string>> rawContent = new List<KeyValuePair<string, string>>();
                    rawContent.Add(new KeyValuePair<string, string>("domain", adDomain));
                    rawContent.Add(new KeyValuePair<string, string>("basedn", currentOU));
                    rawContent.Add(new KeyValuePair<string, string>("username", adUser));
                    rawContent.Add(new KeyValuePair<string, string>("password", adPass));
                    rawContent.Add(new KeyValuePair<string, string>("function", "list"));
                    rawContent.Add(new KeyValuePair<string, string>("filter", "objectClass=computer"));
                    rawContent.Add(new KeyValuePair<string, string>("function", "list"));
                    FormUrlEncodedContent encodedContent = new FormUrlEncodedContent(rawContent);
                    HttpResponseMessage message = await client.PostAsync("", encodedContent);
                    rawResults = await message.Content.ReadAsStringAsync();
                    var results = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(rawResults);
                    foreach (Dictionary<string, string> computer in results)
                    {
                        dirList.Add(computer["cn"], computer["description"]);
                    }
                    hideMsg();
                }
                else
                {
                    showMsg("SuperADDServer Element missing in SuperADD.xml", warnImg);
                }
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
            catch (Exception exc)
            {
                e.Result = exc.Message;
                return;
            }
            showMsg("Saving changes to Active Directory...", loadImg, dismissable: false);
            try
            {
                e.Result = "success";
                if (sr == null)
                {
                    DirectoryEntry computer = de.Children.Add("CN=" + nameTextBox.Text, "computer");
                    if (descTextBox.Text != "")
                    {
                        computer.Properties["description"].Value = descTextBox.Text;
                    }
                    computer.CommitChanges();
                }
                else if (computerOverwriteConfirmed)
                {
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
                else
                {
                    e.Result = "overwrite";
                }
            }
            catch (UnauthorizedAccessException exc)
            {
                e.Result = exc.Message;
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

        private void msgPanel_Click(object sender, EventArgs e)
        {
            if (msgDismissable)
            {
                hideMsg();
            }
        }

        private void CreateComputer_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if ((string)e.Result == "success")
            {
                hideMsg();
            }
            else if ((string)e.Result == "overwrite")
            {
                showMsg("You are about to overwrite this computer object! Press \"Save\" again to continue...", warnImg, disableForm: false);
                computerOverwriteConfirmed = true;
            }
            else
            {
                showMsg("Failed to commit to Active Directory. Message: " + e.Result, warnImg);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            computerOverwriteConfirmed = false;
        }
    }
}
