using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuperADD
{
    class HTTP
    {
        private static HttpClient client = new HttpClient();

        public async static Task<string> Post(string url, Dictionary<string, string> formData)
        {
            FormUrlEncodedContent encodedFormData = new FormUrlEncodedContent(formData);
            HttpResponseMessage httpMessage = await client.PostAsync(url, encodedFormData);
            return await httpMessage.Content.ReadAsStringAsync();
        }
    }
}