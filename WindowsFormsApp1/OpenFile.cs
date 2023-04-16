using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeaCloud
{
    public partial class OpenFile : Form
    {
        public string numberFromServ;
        public string nameFile;
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
        public OpenFile()
        {
            InitializeComponent();
            bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton2.TextAlign = ContentAlignment.MiddleCenter;
            bunifuButton3.TextAlign = ContentAlignment.MiddleCenter;
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
            //GetFilesFromServer();

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
