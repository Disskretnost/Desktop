using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using System.Windows.Forms;
using System.IO;

namespace CrimeaCloud
{
    public class UpdateImage
    {
        public static void ResetImg(string type, int num, int numberFromServ, string text, FlowLayoutPanel flowL)
        {
            flowL.Controls[$"imgPnl{num}"].Visible = true;
            flowL.Controls[$"imgPnl{num}"].Text = text;
            ((TESTControl.ImgPnl)flowL.Controls[$"imgPnl{num}"]).textWithInfo = text;
            ((TESTControl.ImgPnl)flowL.Controls[$"imgPnl{num}"]).NumberFromServ = numberFromServ.ToString();
        }

        public static FilesInfo GetFilesFromServer()
        {
            string token = UserData.ReadToken();
            var response = ConnectHttp.PostDataHeader(token, "http://176.99.11.107:3000/api/file/", "getfiles");
            if (!(response.Result.StatusCode == System.Net.HttpStatusCode.OK))
            {
                ErrorMessage error = new ErrorMessage();
                error.SetMessageText("Check your internet connection");
                error.ShowDialog();
                return null;
            }
            Console.WriteLine(response.Result.Content);
            FilesInfo files = JsonSerializer.Deserialize<FilesInfo>(response.Result.Content);
            MainForm.filesCount = files.count;
            return files;
        }

        public static void InitFiles(FlowLayoutPanel flowL)
        {
            FilesInfo filesFromServ = GetFilesFromServer();
            if (filesFromServ == null)
            {
                return;
            }
            flowL.Visible = true;
            for (int i = 0; i < filesFromServ.count; i++)
            {
                string str = filesFromServ.files[i].extension.ToString();
                int index = str.IndexOf("/");
                string type = str.Substring(0, index); //извлекаем "расширения" для необходимых файлов
                ResetImg(type, i + 1, filesFromServ.files[i].id, filesFromServ.files[i].original_name, flowL);
            }
        }

    }
}
