using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;




namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        Point coordinate;
        public RegisterForm()
        {
            InitializeComponent();

        }
        private void LoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void PssswordCon_TextChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

            RegReg.AllowAnimations = false;
            AutorReg.AllowAnimations = false;

        }

        private void AutorReg_Click(object sender, EventArgs e)
        {

        }

        private async void RegReg_Click(object sender, EventArgs e)
        {
            
            var data = new
            {
                name = LoginRegist.Text,
                email = bunifuTextBox2.Text,
                password = bunifuTextBox1.Text,
                confirmPassword = bunifuTextBox3.Text
            };
            var response = await RegisterUserAsync(data);
            MessageBox.Show(response);
        }

        public static async Task<string> RegisterUserAsync(object data)
        {
            var httpClient = new HttpClient();
            var url = "http://176.99.11.107/api/user/signup";
            var content = JsonContent.Create(data);
            Console.WriteLine(content.Value);
            try
            {
                var response = await httpClient.PostAsync(url, content);
                Console.WriteLine(response);
                //response.EnsureSuccessStatusCode();
                //return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LoginRegist_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
