namespace WinFormsApp1
{
    partial class Bai6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTokenType = new TextBox();
            txtAccessToken = new TextBox();
            txtInfo = new TextBox();
            btnGetInfo = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtTokenType
            // 
            txtTokenType.Location = new Point(92, 40);
            txtTokenType.Multiline = true;
            txtTokenType.Name = "txtTokenType";
            txtTokenType.Size = new Size(137, 44);
            txtTokenType.TabIndex = 0;
            // 
            // txtAccessToken
            // 
            txtAccessToken.Location = new Point(105, 111);
            txtAccessToken.Multiline = true;
            txtAccessToken.Name = "txtAccessToken";
            txtAccessToken.Size = new Size(250, 70);
            txtAccessToken.TabIndex = 1;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(361, 40);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(338, 318);
            txtInfo.TabIndex = 2;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(12, 199);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(104, 50);
            btnGetInfo.TabIndex = 3;
            btnGetInfo.Text = "Lấy thông tin";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 53);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "Token type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 138);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Access token:";
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGetInfo);
            Controls.Add(txtInfo);
            Controls.Add(txtAccessToken);
            Controls.Add(txtTokenType);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTokenType;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnGetInfo;
        private Label label1;
        private Label label2;
    }
}