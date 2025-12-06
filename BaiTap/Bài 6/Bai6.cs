using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private async void btnGetInfo_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();

            string tokenType = txtTokenType.Text.Trim();     // Bearer
            string accessToken = txtAccessToken.Text.Trim(); // token lấy từ bài 5

            if (string.IsNullOrEmpty(tokenType) || string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("Vui lòng nhập Token Type và Access Token!");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Thêm header Authorization
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                    string url = "https://nt106.uitiot.vn/api/v1/user/me";
                    var response = await client.GetAsync(url);
                    string body = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        txtInfo.Text = "Lỗi: " + body;
                        return;
                    }

                    // Parse JSON
                    using (JsonDocument doc = JsonDocument.Parse(body))
                    {
                        var root = doc.RootElement;

                        string username = root.GetProperty("username").GetString();
                        string email = root.GetProperty("email").GetString();
                        string firstName = root.GetProperty("first_name").GetString();
                        string lastName = root.GetProperty("last_name").GetString();
                        string phone = root.GetProperty("phone").GetString();

                        txtInfo.Text =
                            $"Username: {username}\r\n" +
                            $"Email: {email}\r\n" +
                            $"First Name: {firstName}\r\n" +
                            $"Last Name: {lastName}\r\n" +
                            $"Phone: {phone}\r\n\r\n" +
                            $"Lấy thông tin thành công!";
                    }
                }
            }
            catch (Exception ex)
            {
                txtInfo.Text = "Lỗi: " + ex.Message;
            }
        }

       
    }
}
