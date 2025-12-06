// Signup.Designer.cs  (FORM)
using System.Drawing;

namespace WinFormsApp1
{
    partial class Signup
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblSex;

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblBirthday = new Label();
            lblPhone = new Label();
            lblLanguage = new Label();
            lblSex = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            cmbLanguage = new ComboBox();
            dtpBirthday = new DateTimePicker();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(110, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÔM NAY ĂN GÌ?";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(25, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(25, 95);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(25, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(25, 165);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "Firstname:";
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(25, 200);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(80, 20);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Lastname:";
            // 
            // lblBirthday
            // 
            lblBirthday.Location = new Point(25, 235);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(80, 20);
            lblBirthday.TabIndex = 11;
            lblBirthday.Text = "Birthday:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(25, 270);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 20);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Phone:";
            // 
            // lblLanguage
            // 
            lblLanguage.Location = new Point(25, 305);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(80, 20);
            lblLanguage.TabIndex = 15;
            lblLanguage.Text = "Language:";
            // 
            // lblSex
            // 
            lblSex.Location = new Point(25, 340);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(80, 20);
            lblSex.TabIndex = 17;
            lblSex.Text = "Sex:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(230, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(120, 162);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(140, 27);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 197);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(140, 27);
            txtLastName.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 267);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 27);
            txtPhone.TabIndex = 14;
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.Items.AddRange(new object[] { "vi", "en" });
            cmbLanguage.Location = new Point(120, 302);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(150, 28);
            cmbLanguage.TabIndex = 16;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(120, 232);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(268, 27);
            dtpBirthday.TabIndex = 12;
            // 
            // radMale
            // 
            radMale.Location = new Point(120, 338);
            radMale.Name = "radMale";
            radMale.Size = new Size(69, 24);
            radMale.TabIndex = 18;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.Location = new Point(190, 338);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(80, 24);
            radFemale.TabIndex = 19;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(120, 380);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 32);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 430);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblBirthday);
            Controls.Add(dtpBirthday);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblLanguage);
            Controls.Add(cmbLanguage);
            Controls.Add(lblSex);
            Controls.Add(radMale);
            Controls.Add(radFemale);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sign up";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
