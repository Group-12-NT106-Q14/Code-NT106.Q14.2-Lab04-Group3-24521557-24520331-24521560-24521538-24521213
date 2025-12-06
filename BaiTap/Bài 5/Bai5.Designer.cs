using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Bai5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUrl = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtResult = new TextBox();
            lblUrl = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(100, 12);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(350, 27);
            txtUrl.TabIndex = 3;
            txtUrl.Text = "https://nt106.uitiot.vn/auth/token";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(100, 42);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(370, 100);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(80, 33);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log In";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 130);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(438, 250);
            txtResult.TabIndex = 7;
            // 
            // lblUrl
            // 
            lblUrl.Location = new Point(12, 15);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(80, 20);
            lblUrl.TabIndex = 0;
            lblUrl.Text = "API URL:";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(12, 45);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(12, 75);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // Bai5
            // 
            ClientSize = new Size(462, 400);
            Controls.Add(lblUrl);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtUrl);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtResult);
            Name = "Bai5";
            Text = "Bai5 - HTTP POST Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
