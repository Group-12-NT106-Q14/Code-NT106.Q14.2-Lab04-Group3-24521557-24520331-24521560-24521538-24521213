using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private string GetHTML(string url, string filePath)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string html = reader.ReadToEnd();
            WebClient webClient = new WebClient();
            stream = webClient.OpenRead(url);
            webClient.DownloadFile(url, filePath);
            return html;
        }
        private void btnGET_Click(object sender, EventArgs e)
        {
            if (txtHTML.Text == "")
            {
                MessageBox.Show("Vui lòng nhập URL");
            }
            if (txtFILE.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đường dẫn file");
            }
            string url = txtHTML.Text;
            string filePath = txtFILE.Text;
            string response = GetHTML(url, filePath);
            rtxtHTML.Text = response;
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
