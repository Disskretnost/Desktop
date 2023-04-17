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
using System.Threading;

namespace CrimeaCloud
{
    class ConnectHttp
    {
        //Логин, пароль
        public static async Task<HttpResponseMessage> PostData(object data, string urlBase, string urlEnd)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(urlBase);
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(urlEnd, content);
                return response;
            }
        }
        //добавление файлов на сервер
        public static async Task<HttpResponseMessage> PostFile(string fileName, string filePath, string token, string urlBase, string urlEnd)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(urlBase);
                httpClient.Timeout = TimeSpan.FromSeconds(200);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); // Добавляем заголовок с токеном

                using (var form = new MultipartFormDataContent())
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var streamContent = new StreamContent(fileStream))
                        {
                            using (var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync()))
                            {
                                form.Add(fileContent, "file", Path.GetFileName(filePath));
                                try
                                {
                                    var response = await httpClient.PostAsync(urlEnd, form); //ИСКЛЮЧЕНИЕ..........НУЖНЕН TRY/CATCH

                                    return response;
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine("Ошибка при отправке файла");
                                }
                                return null;
                            }
                        }
                    }
                }
            }
        }
        //update
        public static async Task<RestResponse> PostDataHeader(string token, string urlBase, string urlEnd)
        {
            using (var clientRest = new RestClient(urlBase))
            {
                var requestRest = new RestRequest(urlEnd, Method.Post);
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
            }
            return null;
        }
        public static async Task<HttpResponseMessage> PostDownloadFile(object number, string token, string urlBase, string urlEnd, string nameFile)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlBase);

                var json = JsonSerializer.Serialize(number);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                client.Timeout = TimeSpan.FromMilliseconds(600000);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                try
                {
                    var response = await client.PostAsync(urlEnd, content);
                    Console.WriteLine(response.StatusCode);
                    return response;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка HttpClient: " + ex.Message);
                }
            }

            return null;
        }

        public static async Task<RestResponse> PostDeleteFile(object number, string token, string urlBase, string urlEnd)
        {
            using (var clientRest = new RestClient(urlBase))
            {
                var requestRest = new RestRequest(urlEnd, Method.Post);
                var json = JsonSerializer.Serialize(number); //номер файла
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
            }
            return null;
        }


        public async static void CheckTokenStartApp()
        {
            string oldToken = UserData.ReadToken();
            //Console.WriteLine("Старый токен: " + oldToken);
            try
            {
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
                    Application.Run(new MainForm(userData.user.name));
                }
                else
                {
                    Application.Run(new LoginForm());
                }
            
            }
            catch (Exception) { }
        }
    }
}
