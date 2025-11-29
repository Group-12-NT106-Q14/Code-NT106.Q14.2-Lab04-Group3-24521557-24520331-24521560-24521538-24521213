namespace WinFormsApp1
{
    partial class Bai1
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
            txtURL = new TextBox();
            rtxtHTML = new RichTextBox();
            btnGET = new Button();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(37, 26);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(550, 23);
            txtURL.TabIndex = 0;
            txtURL.TextChanged += txtURL_TextChanged;
            // 
            // rtxtHTML
            // 
            rtxtHTML.Location = new Point(37, 55);
            rtxtHTML.Name = "rtxtHTML";
            rtxtHTML.Size = new Size(722, 368);
            rtxtHTML.TabIndex = 1;
            rtxtHTML.Text = "";
            // 
            // btnGET
            // 
            btnGET.Location = new Point(607, 26);
            btnGET.Name = "btnGET";
            btnGET.Size = new Size(138, 23);
            btnGET.TabIndex = 2;
            btnGET.Text = "GET";
            btnGET.UseVisualStyleBackColor = true;
            btnGET.Click += btnGET_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGET);
            Controls.Add(rtxtHTML);
            Controls.Add(txtURL);
            Name = "Bai1";
            Text = "Bai1";
            Load += Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private RichTextBox rtxtHTML;
        private Button btnGET;
    }
}