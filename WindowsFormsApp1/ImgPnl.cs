using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using CrimeaCloud;

namespace TESTControl
{
    public partial class ImgPnl : UserControl
    {
        public string adress;
        public string text = "undefine";
        public string TextWithInfo;
        public string fileType;
        public static List<string> imgTypes = new List<string> { ".jpg", ".png", ".jpeg", ".gif", ".bmp", ".tiff", ".tif", ".svg", ".webp", ".ico", ".psd" };
        public static List<string> textTypes = new List<string> { ".txt", ".csv", ".html", ".xml", ".json", ".docx", ".md", ".log", ".pdf" };
        public FlowLayoutPanel flow;
        public Bunifu.UI.WinForms.BunifuPanel bunifuPanel;
        public string numberFromServ;
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
            label1.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Size = new Size(Size.Width, Size.Height - 119);
            label1.Text = text;
        }
        protected async override void OnLoad(EventArgs e)
        {
            text = "undefined";
            switch (fileType)
            {
                case var type when imgTypes.Contains(type):
                    await LoadPictureAsync($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\CrimeaCloud\SecondPhoto.jpg");
                    break;
                case var type when textTypes.Contains(type):
                    await LoadPictureAsync($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\CrimeaCloud\FileIcon.jpg");
                    break;
                default:
                    await LoadPictureAsync($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\CrimeaCloud\PhotoQuestion.jpg");
                    break;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            label1.Text = Text;
        }

        private async Task LoadPictureAsync(string filePath)
        {
            try
            {
                Image img = await Task.Run(() => Image.FromFile(filePath));
                pictureBox1.Image = img;
            }
            catch (Exception)
            {
                using (ErrorMessage errorMessage = new ErrorMessage())
                {
                    errorMessage.SetMessageText("failed to update image");
                    errorMessage.ShowDialog();
                    return;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CrimeaCloud.OpenFile openfile = new CrimeaCloud.OpenFile(flow, fileType, bunifuPanel);
            openfile.NumberFromServ = numberFromServ;
            openfile.nameFile = textWithInfo;
            openfile.ShowDialog();
        }
    }
}
