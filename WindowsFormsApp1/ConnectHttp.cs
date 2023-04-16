using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using System.Windows.Forms;
using System.IO;

namespace CrimeaCloud
{
    class ConnectHttp
    {
        //Логин, пароль
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
        //добавление файлов на сервер
        public static async Task<HttpResponseMessage> PostFile(string fileName, string filePath, string token, string urlBase, string urlEnd)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlBase);
            httpClient.Timeout = TimeSpan.FromSeconds(200);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); // Добавляем заголовок с токеном

            var form = new MultipartFormDataContent();
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var streamContent = new StreamContent(fileStream);
            var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync());

            //fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

            form.Add(fileContent, "file", Path.GetFileName(filePath));
            var response = await httpClient.PostAsync(urlEnd, form); //ИСКЛЮЧЕНИЕ..........НУЖНЕН TRY/CATCH

            return response;
        }
        //update
        public static async Task<IRestResponse> PostDataHeader(string token, string urlBase, string urlEnd)
        {
            var clientRest = new RestClient(urlBase);
            var requestRest = new RestRequest(urlEnd, Method.POST);
            requestRest.AddHeader("Authorization", "Bearer " + token);
            try
            {
                var response = clientRest.Execute(requestRest);
                return response;
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка RestSharp: " + ex.Message);
            }
            return null;
        }
        public static async Task<IRestResponse> PostDownloadFile(object number, string token, string urlBase, string urlEnd)
        {
            var clientRest = new RestClient(urlBase);
            var requestRest = new RestRequest(urlEnd, Method.POST);
            var json = JsonSerializer.Serialize(number);
            try
            {
                requestRest.AddHeader("Authorization", "Bearer " + token);
                requestRest.AddHeader("Content-Type", "application/json");
                requestRest.AddParameter("application/json", json, ParameterType.RequestBody);
                var response = clientRest.Execute(requestRest);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка RestSharp2: " + ex.Message);
            }
            return null;
        }
        public static async Task<IRestResponse> PostDeleteFile(object number, string token, string urlBase, string urlEnd)
        {
            var clientRest = new RestClient(urlBase);
            var requestRest = new RestRequest(urlEnd, Method.POST); 
            var json = JsonSerializer.Serialize(number); //номер файла
            MessageBox.Show(json);
            try
            {
                requestRest.AddHeader("Authorization", "Bearer " + token); //добавил токен в заголовок 
                requestRest.AddParameter("application/json", json, ParameterType.RequestBody);
                var response = clientRest.Execute(requestRest);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка RestSharp2: " + ex.Message);
            }
            return null;
        }


        public async static void CheckTokenStartApp()
        {
            string oldToken = UserData.ReadToken();
            //Console.WriteLine("Старый токен: " + oldToken);
            var response = await PostDataHeader(oldToken, "http://176.99.11.107:3000/api/user/", "update");
            if (response == null)
            {
                Application.Run(new LoginForm());
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
                UserData userData = JsonSerializer.Deserialize<UserData>(response.Content);
                Console.WriteLine("Полученный Токен: {0}", userData.token); //(успешно Deserialize
                if (userData != null && !string.IsNullOrEmpty(userData.token)) //проверка на пустоту
                {
                    UserData.SaveToken(userData.token); //сохраняем
                }
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new LoginForm());
            }
        }
    }
}
