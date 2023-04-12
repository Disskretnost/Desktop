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
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private Point _mouseDownLocation;

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownLocation = e.Location;
        }

        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - _mouseDownLocation.X;
                this.Top += e.Y - _mouseDownLocation.Y;
            }
        }
    }
}
