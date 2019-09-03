using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SuperADD
{
    class HTTP
    {
        private static HttpClient client = new HttpClient();
        public async static Task<string> Post(Dictionary<string, string> formData)
        {
            XElement DomainController = Config.Current.Element("DomainController");
            if (DomainController != null)
            {
                formData.Add("domaincontroller", DomainController.Value);
            }
            else
            {
                return "Warning: \"DomainController\" element missing in SuperADD.xml";
            }
            formData.Add("username", Program.MainForm.adUserName);
            formData.Add("password", Program.MainForm.adPassword);
            formData.Add("domainname", Program.MainForm.adDomainName);
            formData.Add("superadd", "");
            FormUrlEncodedContent encodedFormData = new FormUrlEncodedContent(formData);
            HttpResponseMessage httpMessage = await client.PostAsync("http://127.0.0.1:2234/", encodedFormData);
            string content = await httpMessage.Content.ReadAsStringAsync();
            if(content == "authenticate")
            {
                Program.MainForm.showPassPrompt();
                content = "Authentication Failure!";
            }
            return content;
        }
    }
}