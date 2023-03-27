using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CrimeaCloud
{
    class ConnectHttp
    {
        public static async Task<HttpResponseMessage> PostData(object data, string urlBase, string urlEnd)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlBase);
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync(urlEnd, content);
                return response;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
