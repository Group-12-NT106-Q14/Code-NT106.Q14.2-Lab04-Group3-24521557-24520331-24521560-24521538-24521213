using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            string url = txtUrl.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ URL, Username và Password!");
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    // Dùng MultipartFormDataContent giống mẫu giáo viên
                    var content = new MultipartFormDataContent
                    {
                        { new StringContent(username), "username" },
                        { new StringContent(password), "password" }
                    };

                    // POST dữ liệu
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    var responseObject = JObject.Parse(responseString);

                    if (!response.IsSuccessStatusCode)
                    {
                        string detail = responseObject["detail"]?.ToString() ?? "Unknown error";
                        txtResult.Text = $"Đăng nhập thất bại: {detail}";
                        return;
                    }

                    // Nếu thành công
                    string tokenType = responseObject["token_type"]?.ToString();
                    string accessToken = responseObject["access_token"]?.ToString();

                    txtResult.Text = $"{tokenType} {accessToken}\r\nĐăng nhập thành công";

                    // Ví dụ: sử dụng token để GET thông tin người dùng
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                    string getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                    var getUserResponse = await client.GetAsync(getUserUrl);
                   // string getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();

                   // txtResult.AppendText($"\r\nThông tin user:\r\n{getUserResponseString}");
                }
            }
            catch (Exception ex)
            {
                txtResult.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}
