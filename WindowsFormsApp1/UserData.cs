using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CrimeaCloud
{
    /// <summary>
    /// Класс для десериализации ответа.
    /// </summary>
    class UserData
    {
        public string token { get; set; }
        public User user { get; set; }
        public async static void SaveToken(string token)
        {
            using (FileStream fstream = new FileStream("secrets.txt", FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(token);
                await fstream.WriteAsync(buffer, 0, buffer.Length);
            }
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
        public void PrintError(string message)
        {
            switch (message) //В кейсы поместить месседж боксы, чтоб пользователь знал что не так.
            {
                case "Неверный пароль!":
                    //MessageBox.Show("Неверный пароль!");
                    break;
                case "Пользователь с такой почтой не найден.":
                    //MessageBox.Show("Пользователь с такой почтой не найден.");
                    break;
                case "Пароли не совпадают":
                    //MessageBox.Show("Пароли не совпадают");
                    break;
                case "Пользователь с такой электронной почтой уже существует":
                    //MessageBox.Show("Пользователь с такой электронной почтой уже существует");
                    break;
                default:
                    MessageBox.Show($"Не знаю что это: {message}");
                    break;
            }
        }
    }
}
