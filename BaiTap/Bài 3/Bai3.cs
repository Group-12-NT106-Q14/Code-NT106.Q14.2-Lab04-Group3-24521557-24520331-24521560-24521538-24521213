using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Bai3 : Form
    {

        public Bai3()
        {
            InitializeComponent();

        }

        private void WbV_Click(object sender, EventArgs e)
        {

        }

        private void btnLOAD_Click(object sender, EventArgs e)
        {
            if (txtURL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập URL");
            }

            WbV.Source = new Uri(txtURL.Text);
        }

        private void btnRELOAD_Click(object sender, EventArgs e)
        {
            WbV.Reload();
        }
        private void GetHTML(string url, string filePath)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            WebClient webClient = new WebClient();
            stream = webClient.OpenRead(url);
            webClient.DownloadFile(url, filePath);
        }
        private void btnDOWN_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            string filePath = txtFILE.Text;
            GetHTML(url, filePath);
        }

        private async void btnDOWNR_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            string url = txtURL.Text.Trim();
            string html = await client.GetStringAsync(txtURL.Text);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var imageNodes = doc.DocumentNode.SelectNodes("//img[@src]");
            if (imageNodes == null)
            {
                MessageBox.Show("Không tìm thấy ảnh nào!");
                return;
            }
            //tao thu muc luu anh
            string folder = Path.Combine(Environment.CurrentDirectory, "download_images");
            Directory.CreateDirectory(folder);

            foreach (var img in imageNodes)
            {
                string src = img.GetAttributeValue("src", "");

                if (string.IsNullOrWhiteSpace(src))  continue;

                // Chuẩn hóa URL
                Uri baseUri = new Uri(url);
                Uri fullUri = new Uri(baseUri, src);

                try
                {
                    // Lấy tên file
                    string fileName = Path.GetFileName(fullUri.LocalPath);
                    if (string.IsNullOrEmpty(fileName))
                        fileName = Guid.NewGuid().ToString() + ".jpg";

                    string savePath = Path.Combine(folder, fileName);

                    // Download file
                    byte[] data = await client.GetByteArrayAsync(fullUri.ToString());
                    File.WriteAllBytes(savePath, data);

                    Console.WriteLine("Downloaded: " + fileName);
                }
                catch
                {
                    // Nếu file lỗi thì bỏ qua
                    continue;
                }

            }
            MessageBox.Show("Đã tải xong tất cả ảnh!");

        }
    }   
}
