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
            formData.Add("username", Main.adUserName);
            formData.Add("password", Main.adPassword);
            formData.Add("domainname", Main.adDomainName);
            formData.Add("domaincontroller", Config.Current.Element("DomainController").Value);
            formData.Add("superadd", "1");
            FormUrlEncodedContent encodedFormData = new FormUrlEncodedContent(formData);
            HttpResponseMessage httpMessage = await client.PostAsync("http://127.0.0.1:2234/", encodedFormData);
            return await httpMessage.Content.ReadAsStringAsync();
        }
    }
}