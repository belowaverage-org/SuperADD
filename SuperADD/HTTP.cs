using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuperADD
{
    class HTTP
    {
        private static HttpClient client = new HttpClient();
        public async static Task<string> Post(Dictionary<string, string> formData)
        {
            formData.Add("username", Program.MainForm.adUserName);
            formData.Add("password", Program.MainForm.adPassword);
            formData.Add("domainname", Program.MainForm.adDomainName);
            formData.Add("domaincontroller", Config.Current.Element("DomainController").Value);
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