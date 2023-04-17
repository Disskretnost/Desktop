using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TESTControl;

namespace CrimeaCloud
{
    public partial class OpenFile : Form
    {
        public string numberFromServ;
        public string nameFile;
        public bool needDel;
        public bool deletedFile = true;
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

        private async void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            LoadfFileForm loadfFileForm = new LoadfFileForm();
            loadfFileForm.SetMessageText("Uploading files");///////
            //loadfFileForm.Topmost = true;
            loadfFileForm.Show();
            Close();
            await DownloadThisFile();
            loadfFileForm.Close();
        }

        public async Task DownloadThisFile()
        {
            string token = UserData.ReadToken();
            var data = new
            {
                fileId = numberFromServ
            };
            var response =  await ConnectHttp.PostDownloadFile(data, token, "http://176.99.11.107:3000/api/file/", "getfile", nameFile);
            if (response != null && response.IsSuccessStatusCode)
            {
                var contentBytes = await response.Content.ReadAsByteArrayAsync();
                SaveFile(nameFile, contentBytes);
                Console.WriteLine("Файл сохранен.");
            }
            else
            {
                using (ErrorMessage errorMessage = new ErrorMessage())
                {
                    errorMessage.SetMessageText("Failed to download");
                    errorMessage.ShowDialog();
                }
            }
            System.Runtime.GCSettings.LargeObjectHeapCompactionMode = System.Runtime.GCLargeObjectHeapCompactionMode.CompactOnce;
            System.GC.Collect();
        }
        public void SaveFile(string fileName, byte[] fileData)
        {
            string appPath = Application.StartupPath;
            string filePathApp = Path.Combine(appPath, fileName);
            if (fileData != null)
            {
                File.WriteAllBytes(filePathApp, fileData);
            }
            else
            {
                Console.WriteLine("Не удалось скачать");
            }
        }

        private void bunifuPanel1_Layout(object sender, LayoutEventArgs e)
        {
            label1.Text = nameFile;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DeleteThisFile();
            Close();
            if (!deletedFile)
            {
                using (ErrorMessage errorMessage = new ErrorMessage())
                {
                    errorMessage.SetMessageText("Check your internet connection");
                    errorMessage.ShowDialog();
                    return;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                flowL.Controls[$"imgPnl{i + 1}"].Visible = false;
            }
            UpdateImage.InitFiles(flowL);
        }

        //удаление (номер файла, токен, ссылка)
        public async void DeleteThisFile()
        {
            string token = UserData.ReadToken();
            var data = new
            {
                fileId = numberFromServ
            };
            try
            {
                var response = await ConnectHttp.PostDeleteFile(data, token, "http://176.99.11.107:3000/api/file/", "delete");
                if (response == null || response.StatusCode != HttpStatusCode.OK)
                {
                    deletedFile = false;
                }
            }
            catch(Exception ex)
            {
                deletedFile = false;
                Console.WriteLine("fafa" + ex.Message);
            }
        }
    }
}
