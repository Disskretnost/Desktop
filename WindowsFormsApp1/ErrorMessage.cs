using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrimeaCloud
{
    public partial class ErrorMessage : Form
    {
        Point coordinate;
        public ErrorMessage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void SetMessageText(string message)
        {
            bunifuLabel1.Text = message;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - coordinate.X; // передвижение по осям
                this.Top += e.Y - coordinate.Y;
            }
        }

        private void bunifuLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            coordinate = new Point(e.X, e.Y);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
