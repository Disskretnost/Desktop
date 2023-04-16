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
using System.IO;

namespace TESTControl
{
    public partial class ImgPnl : UserControl
    {
        //private Dictionary<string, Image> imageCache = new Dictionary<string, Image>();
        public string adress;
        public string text = "undefine";
        public string TextWithInfo;
        public FlowLayoutPanel flow;
        public string textWithInfo
        {
            get
            {
                return TextWithInfo;
            }
            set
            {
                TextWithInfo = value;
            }
        }
        public string numberFromServ;
        public string NumberFromServ
        {
            get
            {
                return numberFromServ;
            }
            set
            {
                numberFromServ = value;
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

        public object TexWithInfo { get; internal set; }

        public ImgPnl(FlowLayoutPanel flowL)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            flow = flowL;
        }
        public void CleanMG()
        {
            Visible = false;
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
            label1.Font = new Font("Microsoft Tai Le", 10, FontStyle.Regular);
            label1.ForeColor = System.Drawing.Color.White;
            label1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label1.Size = new System.Drawing.Size(Size.Width, Size.Height - 119);
            label1.Text = text;
            //pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            
        }
        protected async override void OnLoad(EventArgs e)
        {
            text = "undefined";
            await LoadPictureAsync("FileIcon.jpg");
        }

        protected override void OnTextChanged(EventArgs e)
        {
            label1.Text = Text;
        }
        public void ChangePict(string pathPict)
        {
            if (File.Exists(pathPict))
            {
                pathPict = $@"{pathPict}";
                try
                {
                    Task.Run(() => LoadPictureAsync(pathPict));
                }
                catch (OutOfMemoryException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Net");
            }
        }
        private async Task LoadPictureAsync(string filePath)
        {
            try
            {
                Image img = await Task.Run(() => Image.FromFile(filePath));
                //imageCache[filePath] = img;
                pictureBox1.Image = img;
            }
            catch (System.OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CrimeaCloud.OpenFile openfile = new CrimeaCloud.OpenFile(flow);
            //openfile.flow = flow;
            openfile.NumberFromServ = numberFromServ;
            //NumberFromServ = numberFromServ;
            openfile.nameFile = textWithInfo;
            openfile.ShowDialog();
            Console.WriteLine("dfdfdf");
        }
    }
}
