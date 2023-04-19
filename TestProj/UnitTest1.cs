using NUnit.Framework;
using CrimeaCloud;
using System.Net;

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
            var response = ConnectHttp.PostData(data, "http://176.99.11.107:3000/api/user/", "signin");
            Assert.AreEqual(response.Result.StatusCode, HttpStatusCode.OK);
        }
    }
}