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
    public partial class testform : Form
    {
        private Dictionary<string, Image> imageCache = new Dictionary<string, Image>();
        public testform()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
         ControlStyles.UserPaint |
         ControlStyles.AllPaintingInWmPaint, true);
            //imgPnl1.
            this.DoubleBuffered = true;
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);

            //tableLayoutPanel1.WrapContents = true;
            //tableLayoutPanel1.DoubleBuffered = true;
            //Controls["imgPnl1"].Text = "It's working.txt";
            //flowLayoutPanel1.Controls["imgPnl2"].Text = "It's working.txt";
            //flowLayoutPanel1.Controls["imgPnl20"].Text = "It's workingx.txt";
            
            foreach (Control control in flowLayCust1.Controls)
            {
                if (control is PictureBox)
                {
                    LoadPictureAsync("blue.png", (PictureBox)control);
                }
            } 
        }
        public async Task LoadPictureAsync(string filePath, PictureBox pictureBoxtop)
        {
            if (imageCache.ContainsKey(filePath))
            {
                pictureBoxtop.Image = imageCache[filePath];
                return;
            }
            try
            {
                Image img = await Task.Run(() => Image.FromFile(filePath));
                imageCache[filePath] = img;
                pictureBoxtop.Image = img;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void flowLayoutCustomPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            //this.Invalidate();
            Console.WriteLine("xad");
            MessageBox.Show("F");
        }

        private void imgPnl80_Load(object sender, EventArgs e)
        {

        }
    }
}
