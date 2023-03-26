using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeaCloud
{
    /// <summary>
    /// Класс для десериализации ответа.
    /// </summary>
    class UserData
    {
        public string token { get; set; }
        public User user { get; set; }
    }
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
    /// <summary>
    /// Класс для десериализации ошибки.
    /// </summary>
    class ErrorData
    {
        public int status { get; set; }
        public string message { get; set; }
    }
}
