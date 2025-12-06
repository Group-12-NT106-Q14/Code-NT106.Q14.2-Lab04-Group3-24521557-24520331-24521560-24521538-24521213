using System.Drawing;

namespace WinFormsApp1
{
    partial class AddDish
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox picPreview;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblImage = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();

            txtName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtImage = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();

            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            btnBrowseImage = new System.Windows.Forms.Button();
            picPreview = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(150, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(153, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm món ăn";
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Tên món:";
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 27);
            txtName.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(20, 90);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(80, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Giá:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(105, 87);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(120, 27);
            txtPrice.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(20, 125);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(80, 20);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(105, 122);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 27);
            txtAddress.TabIndex = 6;
            // 
            // lblImage
            // 
            lblImage.Location = new Point(20, 160);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(80, 20);
            lblImage.TabIndex = 7;
            lblImage.Text = "Ảnh (URL):";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(105, 157);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(240, 27);
            txtImage.TabIndex = 8;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(105, 190);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(140, 30);
            btnBrowseImage.TabIndex = 9;
            btnBrowseImage.Text = "Chọn ảnh từ máy";
            btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(20, 230);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(80, 20);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Mô tả:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(105, 227);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(240, 80);
            txtDescription.Multiline = true;
            txtDescription.TabIndex = 11;
            // 
            // picPreview
            // 
            picPreview.Location = new Point(360, 52);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(120, 120);
            picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 12;
            picPreview.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(105, 325);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 32);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 325);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddDish
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(500, 380);
            Controls.Add(lblTitle);

            Controls.Add(lblName);
            Controls.Add(txtName);

            Controls.Add(lblPrice);
            Controls.Add(txtPrice);

            Controls.Add(lblAddress);
            Controls.Add(txtAddress);

            Controls.Add(lblImage);
            Controls.Add(txtImage);

            Controls.Add(btnBrowseImage);

            Controls.Add(lblDescription);
            Controls.Add(txtDescription);

            Controls.Add(picPreview);

            Controls.Add(btnAdd);
            Controls.Add(btnCancel);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Thêm món ăn";
            Name = "AddDish";

            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}