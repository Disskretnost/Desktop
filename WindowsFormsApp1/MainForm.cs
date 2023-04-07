using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CrimeaCloud
{

    public partial class MainForm : Form
    {
        Point coordinate;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
           
        }

        private void MyDrive_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            coordinate = new Point(e.X, e.Y);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - coordinate.X; // передвижение по осям
                this.Top += e.Y - coordinate.Y;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(40,40,40) ;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 147, 147);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(1, 147, 147);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(1, 147, 147);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(1, 147, 147);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserData.ClearToken();
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = new Point(Location.X + 400, Location.Y + 165);
            loginForm.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            //Controls["imgPnl1"].Text = "It's working.txt";
            //flowLayoutPanel1.Controls["imgPnl2"].Text = "It's working.txt";
            flowLayoutPanel1.Controls["imgPnl20"].Text = "It's workingx.txt";
            for(int i = 1; i < 21; i++)
            {
                flowLayoutPanel1.Controls[$"imgPnl{i}"].Visible = true;
            }
            //Controls["imgPnl1"].Text
            //TESTControl.ImgPnl img = new TESTControl.ImgPnl() { Size = new Size(100, 100), Location = new Point(200, 200), Text = "New" };
            //Controls.Add(img);

        }
    }
}
