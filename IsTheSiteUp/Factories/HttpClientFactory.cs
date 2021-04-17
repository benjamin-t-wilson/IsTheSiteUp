using System.Net.Http;
using System.Threading.Tasks;

namespace IsTheSiteUp.Factories
{
    public class HttpClientFactory : Interfaces.IHttpClientFactory
    {
        public async Task<bool> IsGetRequestSuccessful(string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            return response.IsSuccessStatusCode;
        }
    }
}