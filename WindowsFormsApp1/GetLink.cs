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
    public partial class GetLink : Form
    {
        protected string link;
        Point coordinate;
        public GetLink(string link)
        {
            this.link = link;
            InitializeComponent();
            bunifuTextBox1.Text =link;
            //bunifuTextBox1.Too
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(link);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - coordinate.X; // передвижение по осям
                this.Top += e.Y - coordinate.Y;
            }
        }

        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            coordinate = new Point(e.X, e.Y);
        }
    }
}
