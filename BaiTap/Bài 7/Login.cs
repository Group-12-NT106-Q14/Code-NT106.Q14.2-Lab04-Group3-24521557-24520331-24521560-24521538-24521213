using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập username và password.");
                return;
            }

            btnLogin.Enabled = false;
            try
            {
                await ApiService.LoginAsync(username, password);
                using (var main = new Main())
                {
                    Hide();
                    main.ShowDialog();
                }
                ApiService.Logout();
                Show();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var f = new Signup())
            {
                f.ShowDialog();
            }
        }
    }
}