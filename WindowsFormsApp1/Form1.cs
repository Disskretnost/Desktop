using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point coordinate;
        public Form1()
        {
            InitializeComponent();
            this.PasswordField.AutoSize = false;
            this.LoginField.AutoSize = false;    
            LoginField.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void registerlabel_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show();
            Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit(); // закрываем приложение
            Close.ForeColor = Color.Green;
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        


        ///////////////////////////////////////////////////////
    }
}
