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
using Bunifu;
using System.Threading;
using System.Text.Json;
using System.Diagnostics;

namespace CrimeaCloud
{

    public partial class MainForm : Form
    {
        Point coordinate;
        public static int filesCount = 22;
        public FlowLayoutPanel flowL;
        const string url = "http://176.99.11.107/";

        public MainForm(string userName)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);
            bunifuVScrollBar1.Visible = false;
            bunifuVScrollBar1.Minimum = 0;
            bunifuVScrollBar1.Maximum = 400;
            bunifuVScrollBar1.SmallChange = 5;
            bunifuVScrollBar1.LargeChange = 15;
            label1.Text = userName;
            OpenFile.bunifuPanel = bunifuPanel6;
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
            InitFiles();
        }

        public void InitFiles()
        {
            FilesInfo filesFromServ =UpdateImage.GetFilesFromServer();
            if (filesFromServ == null)
            {
                return;
            }
            flowLayCust1.Visible = true;
            if (filesCount > 20)
            {
                bunifuVScrollBar1.Visible = true; //Вызываем метод для установки ползунка по нужным размерам
            }
            for (int i = 0; i < filesCount; i++)
            {
                string fullName = filesFromServ.files[i].original_name.ToString();
                int index = fullName.LastIndexOf(".");
                string extension = fullName.Substring(index); //извлекаем "расширения" для необходимых файлов
                flowLayCust1.RealizeImgPnls(extension, i + 1, filesFromServ.files[i].id, filesFromServ.files[i].original_name, bunifuPanel6);
            }
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            flowLayCust1.ScrollChanged(bunifuVScrollBar1.Value, bunifuVScrollBar1.Minimum, bunifuVScrollBar1.Maximum);
        }

        private void flowLayoutPanel1_EnabledChanged(object sender, EventArgs e)
        {
            this.Controls.Add(bunifuVScrollBar1);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog()) //файловый диалог
            {
                if (!flowLayCust1.Visible) //если не отображён flowLayCust1
                {
                    using (ErrorMessage err = new ErrorMessage())
                    {
                        err.SetMessageText("Please, open drive firstly");
                        err.ShowDialog();
                        return;
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK) //если файловый диалог открылся
                {
                    string pathNewFile = openFileDialog1.FileName; //полный пусть
                    string nameNewFile = openFileDialog1.SafeFileName; //только имя
                    var size = new FileInfo(pathNewFile).Length; //размер файла
                    if (size > 8589934592)
                    {
                        using (ErrorMessage err = new ErrorMessage())
                        {
                            err.SetMessageText("The file is too large. Size limit 1 Gb.");
                            err.ShowDialog();
                            return;
                        }
                    }
                    using (LoadfFileForm loadfFileForm = new LoadfFileForm())
                    {
                        bunifuPanel6.BringToFront();
                        bunifuPanel6.Visible = true;
                        await AddNewFileToServ(nameNewFile, pathNewFile);
                        bunifuPanel6.Visible = false;
                        InitFiles();
                    }
                }
            }
        }

        private async Task AddNewFileToServ(string fileName, string filePath)
        {
            string token = UserData.ReadToken();
            try
            {
                var respone = await ConnectHttp.PostFile(fileName, filePath, token, "http://176.99.11.107:3000/api/file/", "upload");
            }
            catch(Exception)
            {
                using (ErrorMessage err = new ErrorMessage())
                {
                    err.SetMessageText("failed to upload file to server");
                    err.ShowDialog();
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayCust1.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(1, 147, 147);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(40, 40, 40);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool availabile = IsAvailable();
            if (availabile== true)
            {
                Process.Start(url);
            }
            else
            {
                using (ErrorMessage err = new ErrorMessage())
                {
                    err.SetMessageText("The browser is not available");
                    return;
                }
            }
        }

        private static bool IsAvailable()
        {
            var psi = new ProcessStartInfo{FileName = url};
            try
            {
                using (var process = Process.Start(psi))
                {
                    return true; //если процесс запущен
                }
            }
            catch (Exception)
            {
                return false; //браузер не доступен
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(1, 147, 147);
        }
    }
}
