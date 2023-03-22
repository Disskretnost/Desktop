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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point coordinate;
        string url = "176.99.11.107:1000";
        private readonly HttpClient _httpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void registerlabel_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show();
            Hide();
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.White;
        }

        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            Close.ForeColor = Color.FromArgb(1,147,147);
        }
        
        //Передвижение первой формы//
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - coordinate.X; // передвижение по осям
                this.Top += e.Y - coordinate.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            coordinate = new Point(e.X, e. Y); // устанавливаем изначальное место
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            LogIn.AllowAnimations = false;
            //bunifuButton1.BackColor = Color.FromArgb(1, 147, 147);

         
        }
        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordAuto_TextChanged(object sender, EventArgs e)
        {

            //Console.WriteLine($"{LoginAuto.Text}");

        }

        private void LoginAuto_TextChanged(object sender, EventArgs e)
        {
           
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

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("fdfd");
        }

        private async void LogIn_Click(object sender, EventArgs e)
        {
            
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("email", LoginAuto.Text),
                new KeyValuePair<string, string>("password", PasswordAuto.Text),
            });
            var responce = await _httpClient.PostAsync(url, content);//передаём контент
                                                                        
            if (responce.IsSuccessStatusCode)
            {
                var responceContent = await responce.Content.ReadAsStringAsync();
                Console.WriteLine($"{responce}");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }


    }
}
