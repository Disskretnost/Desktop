using System;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;


namespace CrimeaCloud
{
    public partial class RegisterForm : Form
    {
        Point coordinate;
        public RegisterForm()
        {
            InitializeComponent();

        }
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - coordinate.X; // передвижение по осям
                this.Top += e.Y - coordinate.Y;
            }
        }

        private void RegisterForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            coordinate = new Point(e.X, e.Y); // устанавливаем изначальное место
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

            RegReg.AllowAnimations = false;
            AutorReg.AllowAnimations = false;

        }

        private void AutorReg_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginform = new LoginForm();
            loginform.StartPosition = FormStartPosition.Manual;
            loginform.Location = Location;
            loginform.ShowDialog();
            Close();
        }

        private async void RegReg_Click(object sender, EventArgs e)
        {
            var data = new
            {
                name = LoginRegist.Text,
                email = bunifuTextBox1.Text,
                password = bunifuTextBox2.Text,
                confirmPassword = bunifuTextBox3.Text
            };
            try
            {
                var response = await ConnectHttp.PostData(data, "http://176.99.11.107:3000/api/user/", "signup");
                if (!(response.StatusCode == System.Net.HttpStatusCode.OK))
                {
                    using (ErrorMessage errorMessage = new ErrorMessage())
                    {
                        ErrorData errorInfo = JsonSerializer.Deserialize<ErrorData>(response.Content.ReadAsStringAsync().Result);
                        errorMessage.SetMessageText(errorInfo.message.ToString()); //без ToString тоже ошибка с кодировкой 
                        errorMessage.ShowDialog();
                        //Console.WriteLine($"Ошибка: {errorInfo.message}: {errorInfo.status}");
                        return;
                    }
                }
            
                UserData dataFromServ = JsonSerializer.Deserialize<UserData>(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine($"{dataFromServ.token}");
                //Console.WriteLine($"Email: {dataFromServ.user.email}");
                UserData.SaveToken(dataFromServ.token);
            }
            catch (Exception)
            {
                using (ErrorMessage errorMessage = new ErrorMessage())
                {
                    errorMessage.SetMessageText("Check your internet connection."); //без ToString тоже ошибка с кодировкой 
                    errorMessage.ShowDialog();
                    return;
                }
            }

                
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {
            if (bunifuTextBox2.Text.Length == 0)
                this.bunifuTextBox2.PasswordChar = '\0';
            else
                this.bunifuTextBox2.PasswordChar = '*';
        }

        private void bunifuTextBox3_TextChange(object sender, EventArgs e)
        {
            if (bunifuTextBox3.Text.Length == 0)
                this.bunifuTextBox3.PasswordChar = '\0';
            else
                this.bunifuTextBox3.PasswordChar = '*';
        }
    }

}
