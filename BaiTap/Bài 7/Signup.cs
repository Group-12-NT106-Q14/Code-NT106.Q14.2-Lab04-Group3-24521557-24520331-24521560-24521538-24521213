using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            btnSubmit.Click += btnSubmit_Click;
            btnCancel.Click += (s, e) => Close();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập tối thiểu Username, Password và Email.");
                return;
            }

            try
            {
                var req = new SignupRequest
                {
                    Username = txtUsername.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Language = cmbLanguage.Text.Trim(),
                    Sex = radMale.Checked ? 0 : 1,
                    Birthday = dtpBirthday.Value.Date
                };

                btnSubmit.Enabled = false;
                await ApiService.SignUpAsync(req);
                MessageBox.Show("Đăng ký thành công! Hãy quay lại màn hình đăng nhập.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSubmit.Enabled = true;
            }
        }
    }
}