using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CrimeaCloud
{
    // ПОМЕНЯТЬ ДЛЯ УСТАНОВЩИКА
    class UserData
    {
        private static readonly byte[] entropy = { 0x15, 0x30, 0x23, 0x14, 0x4, 0xAB, 0xCD, 0xEF };
        public string token { get; set; }
        public User user { get; set; }

        public async static void SaveToken(string token)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string resourcesDirectory = Path.Combine(projectDirectory, @"Resources");
            byte[] data = Encoding.Unicode.GetBytes(token);
            byte[] encryptedData = ProtectedData.Protect(data, entropy, DataProtectionScope.CurrentUser);
            //File.WriteAllBytes($@"{ Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\CrimeaCloud\secrets.bin", encryptedData); 
            File.WriteAllBytes($@"{resourcesDirectory}\secrets.bin", encryptedData);
        }

        public static string ReadToken()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string resourcesDirectory = Path.Combine(projectDirectory, @"Resources");
            //if (File.Exists($@"{ Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\CrimeaCloud\secrets.bin"))
            if (File.Exists($@"{resourcesDirectory}\secrets.bin"))
            {
                //byte[] encryptedData = File.ReadAllBytes($@"{ Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\CrimeaCloud\secrets.bin");
                byte[] encryptedData = File.ReadAllBytes($@"{resourcesDirectory}\secrets.bin");
                byte[] data = ProtectedData.Unprotect(encryptedData, entropy, DataProtectionScope.CurrentUser);
                return Encoding.Unicode.GetString(data);
            }
            return null;
        }

        public async static void ClearToken()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string resourcesDirectory = Path.Combine(projectDirectory, @"Resources");
            byte[] data = Encoding.Unicode.GetBytes("");
            byte[] encryptedData = ProtectedData.Protect(data, entropy, DataProtectionScope.CurrentUser);
            //File.WriteAllBytes($@"{ Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\CrimeaCloud\secrets.bin", encryptedData);
            File.WriteAllBytes($@"{resourcesDirectory}\secrets.bin", encryptedData);
        }
        
    }

    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }

    public class FilesInfo
    {
        public int status { get; set; }
        public int count { get; set; }
        public List<Files> files {get;set;}

    }

    public class Files
    {
        public int id { get; set; }
        public int owner_id { get; set; }
        public string original_name { get; set; }
        public string code_name { get; set; }
        public string extension { get; set; }
    }

    class ErrorData
    {
        public int status { get; set; }
        public string message { get; set; }
       
    }
}
