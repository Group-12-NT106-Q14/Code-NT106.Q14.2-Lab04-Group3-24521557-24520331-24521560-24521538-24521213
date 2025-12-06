using System.Drawing;

namespace WinFormsApp1
{
    partial class RandomDish
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox = new System.Windows.Forms.PictureBox();
            lblName = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblUser = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new System.Drawing.Point(15, 15);
            pictureBox.Size = new System.Drawing.Size(120, 120);
            pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.Location = new System.Drawing.Point(150, 15);
            lblName.Size = new System.Drawing.Size(220, 30);
            lblName.Text = "Tên món";
            // 
            // lblPrice
            // 
            lblPrice.Location = new System.Drawing.Point(150, 50);
            lblPrice.Size = new System.Drawing.Size(220, 20);
            lblPrice.Text = "Giá:";
            // 
            // lblAddress
            // 
            lblAddress.Location = new System.Drawing.Point(150, 75);
            lblAddress.Size = new System.Drawing.Size(220, 20);
            lblAddress.Text = "Địa chỉ:";
            // 
            // lblUser
            // 
            lblUser.Location = new System.Drawing.Point(150, 100);
            lblUser.Size = new System.Drawing.Size(220, 20);
            lblUser.Text = "Đóng góp:";
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(150, 130);
            btnClose.Size = new System.Drawing.Size(100, 30);
            btnClose.Text = "OK";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // RandomDish
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(390, 180);
            Controls.Add(pictureBox);
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            Controls.Add(lblAddress);
            Controls.Add(lblUser);
            Controls.Add(btnClose);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Ăn món này đi!!!";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }
    }
}