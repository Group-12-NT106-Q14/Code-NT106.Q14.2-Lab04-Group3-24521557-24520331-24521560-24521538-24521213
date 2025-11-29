namespace WinFormsApp1
{
    partial class Bai3
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
            btnLOAD = new Button();
            btnRELOAD = new Button();
            btnDOWN = new Button();
            btnDOWNR = new Button();
            WbV = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtFILE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)WbV).BeginInit();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(115, 25);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(543, 23);
            txtURL.TabIndex = 0;
            // 
            // btnLOAD
            // 
            btnLOAD.Location = new Point(21, 25);
            btnLOAD.Name = "btnLOAD";
            btnLOAD.Size = new Size(75, 23);
            btnLOAD.TabIndex = 1;
            btnLOAD.Text = "Load";
            btnLOAD.UseVisualStyleBackColor = true;
            btnLOAD.Click += btnLOAD_Click;
            // 
            // btnRELOAD
            // 
            btnRELOAD.Location = new Point(691, 25);
            btnRELOAD.Name = "btnRELOAD";
            btnRELOAD.Size = new Size(75, 23);
            btnRELOAD.TabIndex = 2;
            btnRELOAD.Text = "reload";
            btnRELOAD.UseVisualStyleBackColor = true;
            btnRELOAD.Click += btnRELOAD_Click;
            // 
            // btnDOWN
            // 
            btnDOWN.Location = new Point(573, 54);
            btnDOWN.Name = "btnDOWN";
            btnDOWN.Size = new Size(75, 23);
            btnDOWN.TabIndex = 3;
            btnDOWN.Text = "Down File";
            btnDOWN.UseVisualStyleBackColor = true;
            btnDOWN.Click += btnDOWN_Click;
            // 
            // btnDOWNR
            // 
            btnDOWNR.Location = new Point(654, 54);
            btnDOWNR.Name = "btnDOWNR";
            btnDOWNR.Size = new Size(112, 23);
            btnDOWNR.TabIndex = 4;
            btnDOWNR.Text = "Down Resources";
            btnDOWNR.UseVisualStyleBackColor = true;
            btnDOWNR.Click += btnDOWNR_Click;
            // 
            // WbV
            // 
            WbV.AllowExternalDrop = true;
            WbV.CreationProperties = null;
            WbV.DefaultBackgroundColor = Color.White;
            WbV.Location = new Point(19, 85);
            WbV.Name = "WbV";
            WbV.Size = new Size(747, 353);
            WbV.TabIndex = 5;
            WbV.ZoomFactor = 1D;
            WbV.Click += WbV_Click;
            // 
            // txtFILE
            // 
            txtFILE.Location = new Point(115, 55);
            txtFILE.Name = "txtFILE";
            txtFILE.Size = new Size(452, 23);
            txtFILE.TabIndex = 6;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFILE);
            Controls.Add(WbV);
            Controls.Add(btnDOWNR);
            Controls.Add(btnDOWN);
            Controls.Add(btnRELOAD);
            Controls.Add(btnLOAD);
            Controls.Add(txtURL);
            Name = "Bai3";
            Text = "Bai3";
            ((System.ComponentModel.ISupportInitialize)WbV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private Button btnLOAD;
        private Button btnRELOAD;
        private Button btnDOWN;
        private Button btnDOWNR;
        private Microsoft.Web.WebView2.WinForms.WebView2 WbV;
        private TextBox txtFILE;
    }
}