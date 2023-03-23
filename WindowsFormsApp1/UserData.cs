using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeaCloud
{
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
}
