using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BackEndService
{
	public class BackEndService
    {
        protected HttpClient Client { get; }

        protected BackEndService(HttpClient client, string servicePath)
        {
            var uriBuilder = new UriBuilder(client.BaseAddress);
            uriBuilder.Path += servicePath;
            client.BaseAddress = uriBuilder.Uri;

            Client = client;
        }

        public async Task<T> GetStringAsync<T>(string uri = "")
        {

            Task<string> getStringTask = Client.GetStringAsync(uri);
            string urlContents = await getStringTask;

            return JsonConvert.DeserializeObject<T>(urlContents);
        }

        protected async Task<HttpResponseMessage> PostAsync<T>(T content, string actionName = "")
        {
            string postBody = JsonConvert.SerializeObject(content);
            HttpResponseMessage response = await Client.PostAsync(actionName, new StringContent(postBody, Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            return response;
        }

        protected async Task<HttpResponseMessage> PutAsync<T>(T content, string actionName = "")
        {
            string putBody = JsonConvert.SerializeObject(content);
            HttpResponseMessage response = await Client.PutAsync(actionName, new StringContent(putBody, Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            return response;
        }


    }


}
