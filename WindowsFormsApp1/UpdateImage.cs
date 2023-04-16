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
    class UpdateImage
    {
        //public FlowLayoutPanel flowL;
        public static void ResetImg(string type, int num, int numberFromServ, string text, FlowLayoutPanel flowL)
        {
            flowL.Controls[$"imgPnl{num}"].Visible = true;
            flowL.Controls[$"imgPnl{num}"].Text = text;
            //((TESTControl.ImgPnl)flowLayoutPanel1.Controls[$"imgPnl{num}"])
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
        public static void InitFiles(FlowLayoutPanel flowL)
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
                //ResetImg(type, i + 1, filesFromServ.files[i].id, filesFromServ.files[i].original_name);
                UpdateImage.ResetImg(type, i + 1, filesFromServ.files[i].id, filesFromServ.files[i].original_name, flowL);

            }
        }
    }
}
