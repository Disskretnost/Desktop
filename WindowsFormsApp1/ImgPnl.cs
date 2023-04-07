using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TESTControl
{
    public partial class ImgPnl : UserControl
    {
        public string adress;
        public string text = "test.file";
        public string textWithInfo;
        public string TexWithInfo
        {
            get
            {
                return textWithInfo;
            }
            set
            {
                textWithInfo = value;
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }
        public string TextL
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        public ImgPnl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            label1.BackColor = BackColor;
        }
        protected async override void OnSizeChanged(EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = Size;
            label1.Font = new Font("Microsoft Tai Le", 11, FontStyle.Regular);
            label1.ForeColor = System.Drawing.Color.White;
            label1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label1.Size = new System.Drawing.Size(Size.Width, Size.Height - 119);
            label1.Text = text;
            //pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            
        }
        protected async override void OnLoad(EventArgs e)
        {
            label1.Text = "OnLoad";
            Console.WriteLine("лоад");
            if (adress == null)
            {
                await LoadPictureAsync("xdd_cut-photo.ru.jpg");
            }
            else
            {
                pictureBox1.ImageLocation = adress;
                pictureBox1.LoadAsync();
            }
        }

        //Image img = Image.FromFile("anime.png");//if file exist;
        //pictureBox1.Image = img;
        //pictureBox1.LoadAsync();

        protected override void OnTextChanged(EventArgs e)
        {

            label1.Text = Text;
        }
        private async Task LoadPictureAsync(string filePath)
        {
            Console.WriteLine("size");
            try
            {
                Image img = await Task.Run(() => Image.FromFile(filePath));
                pictureBox1.Image = img;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
        
    }
}
