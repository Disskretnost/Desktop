using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTControl;

namespace CrimeaCloud
{
    public partial class OpenFile : Form
    {
        public string numberFromServ;
        public string nameFile;
        public bool needDel;
        public FlowLayoutPanel flowL;
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
        public OpenFile(FlowLayoutPanel flow)
        {
            InitializeComponent();
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton3.TextAlign = ContentAlignment.MiddleCenter;
            StartPosition = FormStartPosition.CenterScreen;
            flowL = flow;
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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            DownloadThisFile();
            
        }
        public async void DownloadThisFile()
        {
            string token = UserData.ReadToken();
            var data = new
            {
                fileId = numberFromServ
            };
            var response = await ConnectHttp.PostDownloadFile(data, token, "http://176.99.11.107/api/file/", "getfile");
            SaveFile(nameFile, response.RawBytes);
            Console.WriteLine("гтова");
            
        }
        public void SaveFile(string fileName, byte[] fileData)
        {
            string appPath = Application.StartupPath;
            string filePathApp = Path.Combine(appPath, fileName);
            File.WriteAllBytes(filePathApp, fileData);
        }

        private void bunifuPanel1_Layout(object sender, LayoutEventArgs e)
        {
            label1.Text = nameFile;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DeleteThisFile();
            needDel = true;

            for (int i = 0; i < 30; i++)
            {
                flowL.Controls[$"imgPnl{i + 1}"].Visible = false;
            }
            InitFiles();


        }
        public static FilesInfo GetFilesFromServer()
        {
            string token = UserData.ReadToken();
            var response = ConnectHttp.PostDataHeader(token, "http://176.99.11.107/api/file/", "getfiles");

            if (!(response.Result.StatusCode == System.Net.HttpStatusCode.OK))
            {
                ErrorMessage error = new ErrorMessage();
                error.SetMessageText(response.Result.StatusCode.ToString());
                error.ShowDialog();
                return null;
            }
            Console.WriteLine(response.Result.Content);
            FilesInfo files = JsonSerializer.Deserialize<FilesInfo>(response.Result.Content);
            //filesCount = files.count;
            Console.WriteLine($"// {files.count} //");
            return files;
            //Console.WriteLine($"// {files.files[0].id} //");
        }
        public void InitFiles()
        {
            FilesInfo filesFromServ = GetFilesFromServer();
            flowL.Visible = true;
            //Console.WriteLine(filesCount);
            //Console.WriteLine(fileNames.Length);

            for (int i = 0; i < filesFromServ.count; i++)
            {
                string str = filesFromServ.files[i].extension.ToString();
                int index = str.IndexOf("/");
                string type = str.Substring(0, index); //извлекаем "расширения" для необходимых файлов
                //Console.WriteLine(type);
                ResetImg(type, i + 1, filesFromServ.files[i].id, filesFromServ.files[i].original_name);

            }
        }
        public void ResetImg(string type, int num, int numberFromServ, string text)
        {
            flowL.Controls[$"imgPnl{num}"].Visible = true;
            flowL.Controls[$"imgPnl{num}"].Text = text;
            //((TESTControl.ImgPnl)flowLayoutPanel1.Controls[$"imgPnl{num}"])
            ((TESTControl.ImgPnl)flowL.Controls[$"imgPnl{num}"]).textWithInfo = text;
            ((TESTControl.ImgPnl)flowL.Controls[$"imgPnl{num}"]).NumberFromServ = numberFromServ.ToString();
        }
        public void DisableAllControls(FlowLayoutPanel flowLayoutPanel)
        {
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    DisableAllControls((FlowLayoutPanel)control);
                }
            }
        }
        //удаление (номер файла, токен, ссылка)
        public async void DeleteThisFile()
        {
            string token = UserData.ReadToken();
            var data = new
            {
                fileId = numberFromServ
            };
            var response = await ConnectHttp.PostDeleteFile(data, token, "http://176.99.11.107/api/file/", "delete");
            //SaveFile(nameFile, response.RawBytes);
            Console.WriteLine(response.Content);

        }
    }
}
