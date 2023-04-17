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



namespace CrimeaCloud
{

    public partial class MainForm : Form
    {
        Point coordinate;
        public static int filesCount = 22;
        string[] fileNames = new string[filesCount];
        public FlowLayoutPanel flowL;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);
            //bunifuVScrollBar1.Value = flowLayCust1.VerticalScroll.Value;
            bunifuVScrollBar1.Visible = false;
            bunifuVScrollBar1.Minimum = 0;
            bunifuVScrollBar1.Maximum = 400;
            bunifuVScrollBar1.SmallChange = 5;
            bunifuVScrollBar1.LargeChange = 15;
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
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("сАНЯ ЧЁ ЭТО ЗА ХУЙНЯ" + ex.Message);
            }
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
            
            InitFiles();
            //UpdateImage.InitFiles(flowL);

        }
        public void InitFiles()
        {
            FilesInfo filesFromServ = GetFilesFromServer();
            flowLayCust1.Visible = true;
            Console.WriteLine("Количество файлов на диске:" + filesCount);
            if (filesCount > 20)
            {
                //Вызываем метод для установки ползунка по нужным размерам
                bunifuVScrollBar1.Visible = true;
            }
            for (int i = 0; i < filesCount; i++)
            {
                string str = filesFromServ.files[i].extension.ToString();
                int index = str.IndexOf("/");
                string type = str.Substring(0, index); //извлекаем "расширения" для необходимых файлов
                //Console.WriteLine(type);
                flowLayCust1.RealizeImgPnls(type, i + 1, filesFromServ.files[i].id, filesFromServ.files[i].original_name);
            }
            //filesFromServ.files.Clear(); // очистка списка files
        }

        public static FilesInfo GetFilesFromServer()
        {
            string token = UserData.ReadToken();
            var response = ConnectHttp.PostDataHeader(token, "http://176.99.11.107:3000/api/file/", "getfiles");

            if(!(response.Result.StatusCode == System.Net.HttpStatusCode.OK))
            {
                ErrorMessage error = new ErrorMessage();
                error.SetMessageText(response.Result.StatusCode.ToString());
                error.ShowDialog();
                return null;
            }
            Console.WriteLine(response.Result.Content);
            FilesInfo files = JsonSerializer.Deserialize<FilesInfo>(response.Result.Content);
            filesCount = files.count;
            Console.WriteLine($"// {files.count} //");
            return files;
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            flowLayCust1.ScrollChanged(bunifuVScrollBar1.Value, bunifuVScrollBar1.Minimum, bunifuVScrollBar1.Maximum);
        }

        private void flowLayoutPanel1_EnabledChanged(object sender, EventArgs e)
        {
            this.Controls.Add(bunifuVScrollBar1);
            // Добавляем обработчик события прокрутки
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //файловый диалог
            ErrorMessage err = new ErrorMessage(); //для ошибок
            if (!flowLayCust1.Visible) //если не отображён flowLayCust1
            {
                err.SetMessageText("Please, open drive firstly");
                err.ShowDialog();
                return;
            }
            if(openFileDialog1.ShowDialog() == DialogResult.OK) //если файловый диалог открылся
            {
                string pathNewFile = openFileDialog1.FileName; //полный пусть
                string nameNewFile = openFileDialog1.SafeFileName; //только имя
                string fileExtension = Path.GetExtension(pathNewFile); //расширение
                var size = new FileInfo(pathNewFile).Length; //размер файла

                if (size > 524288000) // 
                {
                    err.SetMessageText("The file is too large. Size limit 500 MB.");
                    err.ShowDialog();
                    //вызов метода
                    return;
                }
                await AddNewFileToServ(nameNewFile, pathNewFile);
                Console.Write("//////////////////////////////");
                //AddNewFileToForm(pathNewFile, nameNewFile, fileExtension); //добавление файла на форму
                InitFiles(); //МЕГАКОСТЫЛЬ.................................................................................................................................

            }
        }

        private async Task AddNewFileToServ(string fileName, string filePath)
        {
            string token = UserData.ReadToken();
            try
            {
                var respone = await ConnectHttp.PostFile(fileName, filePath, token, "http://176.99.11.107:3000/api/file/", "upload");
                Console.WriteLine(respone.StatusCode);
                Console.WriteLine(respone.Content.ReadAsStringAsync().Result);
                Console.WriteLine("Файл добавлен на сервер");
                if (!respone.IsSuccessStatusCode)
                {
                    ErrorMessage error = new ErrorMessage();
                    error.SetMessageText("Failed to send file");
                    error.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void AddNewFileToForm(string pathFile, string nameFile, string extensionFile)
        {
            filesCount++;
            fileNames[filesCount-1] = nameFile;
            flowLayCust1.RealizeImgPnls(filesCount, 0, nameFile);
            Console.WriteLine(nameFile);
            Console.WriteLine(pathFile);
        }
        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
