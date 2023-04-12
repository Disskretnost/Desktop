using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace CrimeaCloud
{
    public partial class LoginForm : Form
    {
        Point coordinate;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerlabel_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = Location;
            registerForm.ShowDialog();
            Close();
           
        }


        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            Close.ForeColor = Color.FromArgb(1,147,147);
        }
        
        // Передвижение первой формы
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - coordinate.X; // передвижение по осям
                this.Top += e.Y - coordinate.Y;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogIn.AllowAnimations = false;
            //bunifuButton1.BackColor = Color.FromArgb(1, 147, 147);
        }

        private void registerlabel_MouseMove(object sender, MouseEventArgs e)
        {
            registerlabel.ForeColor = Color.FromArgb(1,147,147);
        }

        private void registerlabel_MouseLeave(object sender, EventArgs e)
        {
            registerlabel.ForeColor = Color.White;
        }

        private void resetLabel_Click(object sender, EventArgs e)
        {
            // Восстановление пароля
        }

        private async void LogIn_Click(object sender, EventArgs e)
        {
            var data = new
            {
                email = LoginAuto.Text,
                password = PasswordAuto.Text
            };
            var response = await ConnectHttp.PostData(data, "http://176.99.11.107/api/user/", "signin");
            ErrorMessage errorMessage = new ErrorMessage();
            if (response == null)
            {
                errorMessage.SetMessageText("No netconnection"); //без ToString тоже ошибка с кодировкой 
                errorMessage.Show();
                return;
            }
            if (!(response.StatusCode == System.Net.HttpStatusCode.OK)) // если статус не 200
            {
                ErrorData errorInfo = JsonSerializer.Deserialize<ErrorData>(response.Content.ReadAsStringAsync().Result);
                errorMessage.SetMessageText(errorInfo.message.ToString()); //без ToString тоже ошибка с кодировкой 
                errorMessage.Show();
                //Console.WriteLine($"Ошибка: {errorInfo.message}: {errorInfo.status}");
                return;
            }
            UserData dataFromServ = JsonSerializer.Deserialize<UserData>(response.Content.ReadAsStringAsync().Result); //в экземпляр класса передаем информация с сервера
            //распаковали данные 
            Console.WriteLine($"{dataFromServ.user.id} Token ({dataFromServ.user.name}){dataFromServ.token}");
            Console.WriteLine($"Email: {dataFromServ.user.email}"); 
            UserData.SaveToken(dataFromServ.token); //записали токен в файл
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }


        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            coordinate = new Point(e.X, e.Y);
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void PasswordAuto_TextChange(object sender, EventArgs e)
        {
            if (PasswordAuto.Text.Length == 0)
                this.PasswordAuto.PasswordChar = '\0';
            else
                this.PasswordAuto.PasswordChar = '*';
        }

    }
}
