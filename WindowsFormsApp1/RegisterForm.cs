using System;
using System.Drawing;
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
            loginform.Show();
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
            var response = await ConnectHttp.RegisterUserAsync(data);
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
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
