namespace WinFormsApp1
{
    partial class Bai2
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
            txtHTML = new TextBox();
            txtFILE = new TextBox();
            rtxtHTML = new RichTextBox();
            btnGET = new Button();
            SuspendLayout();
            // 
            // txtHTML
            // 
            txtHTML.Location = new Point(26, 20);
            txtHTML.Name = "txtHTML";
            txtHTML.Size = new Size(583, 23);
            txtHTML.TabIndex = 0;
            // 
            // txtFILE
            // 
            txtFILE.Location = new Point(26, 62);
            txtFILE.Name = "txtFILE";
            txtFILE.Size = new Size(583, 23);
            txtFILE.TabIndex = 1;
            // 
            // rtxtHTML
            // 
            rtxtHTML.Location = new Point(30, 102);
            rtxtHTML.Name = "rtxtHTML";
            rtxtHTML.Size = new Size(757, 334);
            rtxtHTML.TabIndex = 2;
            rtxtHTML.Text = "";
            // 
            // btnGET
            // 
            btnGET.Location = new Point(657, 20);
            btnGET.Name = "btnGET";
            btnGET.Size = new Size(130, 65);
            btnGET.TabIndex = 3;
            btnGET.Text = "GET";
            btnGET.UseVisualStyleBackColor = true;
            btnGET.Click += btnGET_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGET);
            Controls.Add(rtxtHTML);
            Controls.Add(txtFILE);
            Controls.Add(txtHTML);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHTML;
        private TextBox txtFILE;
        private RichTextBox rtxtHTML;
        private Button btnGET;
    }
}