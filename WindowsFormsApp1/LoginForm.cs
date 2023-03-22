﻿using System;
using System.Drawing;
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
            registerForm.Show();
            //Close();
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
            var response = await ConnectHttp.LoginUserAsync(data);
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        }


        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            coordinate = new Point(e.X, e.Y);
        }
    }
}