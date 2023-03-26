using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CrimeaCloud
{
    class ConnectHttp
    {
        public static async Task<HttpResponseMessage> LoginUserAsync(object data)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://176.99.11.107/api/user/");
            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync("signin", content);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
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
        public static async Task<HttpResponseMessage> RegisterUserAsync(object data)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://176.99.11.107/api/user/");
            var json = JsonSerializer.Serialize(data);
            //Console.WriteLine(json);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = httpClient.PostAsync("signup", content).Result;
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
