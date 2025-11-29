using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace WinFormsApp1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
        public string getHTML(string URL)
        {
            WebRequest request = WebRequest.Create(URL);
            WebResponse responses = request.GetResponse();
            Stream stream = responses.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string html = reader.ReadToEnd();
            return html;

        }
        private void btnGET_Click(object sender, EventArgs e)
        {
            if(txtURL.Text=="")
            {
                MessageBox.Show("Vui lòng nhập URL");
                return;
            }
            string URL = txtURL.Text;
            string response = getHTML(URL);
            rtxtHTML.Text = response;

        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
