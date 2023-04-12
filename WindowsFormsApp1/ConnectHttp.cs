using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using System.Windows.Forms;

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
        public static async Task<IRestResponse> PostDataHeader(string token, string urlBase, string urlEnd)
        {
            var clientRest = new RestClient(urlBase);
            var requestRest = new RestRequest(urlEnd, Method.POST);
            try
            {
                requestRest.AddHeader("Authorization", "Bearer " + token);
                var response = clientRest.Execute(requestRest);
                return response;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка RestSharp:" + ex);
            }
            return null;
        }
        public async static void CheckTokenStartApp()
        {
            string oldToken = UserData.ReadToken();
            var response = await PostDataHeader(oldToken, "http://176.99.11.107/api/user/", "update");
            if (response == null)
            {
                Application.Run(new LoginForm());
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content); // поймать токен и перезаписать
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new LoginForm());
            }
        }
    }
}
