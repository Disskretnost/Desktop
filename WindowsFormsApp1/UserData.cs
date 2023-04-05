using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CrimeaCloud
{
    /// <summary>
    /// Класс для десериализации ответа.
    /// </summary>
    class UserData
    {
        private static readonly byte[] entropy = { 0x15, 0x30, 0x23, 0x14, 0x4, 0xAB, 0xCD, 0xEF };
        public string token { get; set; }
        public User user { get; set; }
        public async static void SaveToken(string token)
        {
            byte[] data = Encoding.Unicode.GetBytes(token);
            byte[] encryptedData = ProtectedData.Protect(data, entropy, DataProtectionScope.CurrentUser);
            File.WriteAllBytes("secrets.bin", encryptedData);
        }
        public static string ReadToken()
        {
            if (File.Exists("secrets.bin"))
            {
                byte[] encryptedData = File.ReadAllBytes("secrets.bin");
                byte[] data = ProtectedData.Unprotect(encryptedData, entropy, DataProtectionScope.CurrentUser);
                return Encoding.Unicode.GetString(data);
            }
            return null;
        }
        public async static void ClearToken()
        {
            byte[] data = Encoding.Unicode.GetBytes("");
            byte[] encryptedData = ProtectedData.Protect(data, entropy, DataProtectionScope.CurrentUser);
            File.WriteAllBytes("secrets.bin", encryptedData);
        }
        
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
