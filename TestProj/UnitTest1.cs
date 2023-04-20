using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Text.Json;
using System.Text;

namespace TestProj
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAuth()
        {
            var data = new
            {
                email = "yraaaa",
                password = "12345"
            };
            var response = PostData(data, "http://176.99.11.107:3000/api/user/", "signin");
            Assert.AreEqual(response.Result.StatusCode, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> PostData(object data, string urlBase, string urlEnd)//Логин, пароль
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
    }
}