using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    partial class Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.flpMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.webViewDetail = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnLoadFromJson = new System.Windows.Forms.Button();
            this.btnCrawl = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDetail)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMovies
            // 
            this.flpMovies.AutoScroll = true;
            this.flpMovies.BackColor = System.Drawing.Color.White;
            this.flpMovies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMovies.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMovies.Location = new System.Drawing.Point(0, 60);
            this.flpMovies.Name = "flpMovies";
            this.flpMovies.Padding = new System.Windows.Forms.Padding(5);
            this.flpMovies.Size = new System.Drawing.Size(350, 640);
            this.flpMovies.TabIndex = 0;
            // 
            // webViewDetail
            // 
            this.webViewDetail.AllowExternalDrop = true;
            this.webViewDetail.CreationProperties = null;
            this.webViewDetail.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewDetail.Location = new System.Drawing.Point(350, 60);
            this.webViewDetail.Name = "webViewDetail";
            this.webViewDetail.Size = new System.Drawing.Size(830, 640);
            this.webViewDetail.TabIndex = 1;
            this.webViewDetail.ZoomFactor = 1D;
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.btnBook);
            this.panelTop.Controls.Add(this.btnLoadFromJson);
            this.panelTop.Controls.Add(this.btnCrawl);
            this.panelTop.Controls.Add(this.progressBar);
            this.panelTop.Controls.Add(this.lblStatus);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1180, 60);
            this.panelTop.TabIndex = 2;
            // 
            // btnCrawl
            // 
            this.btnCrawl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCrawl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrawl.Location = new System.Drawing.Point(10, 10);
            this.btnCrawl.Name = "btnCrawl";
            this.btnCrawl.Size = new System.Drawing.Size(160, 35);
            this.btnCrawl.TabIndex = 0;
            this.btnCrawl.Text = "Crawl phim từ web";
            this.btnCrawl.UseVisualStyleBackColor = false;
            this.btnCrawl.Click += new System.EventHandler(this.btnCrawl_Click);
            // 
            // btnLoadFromJson
            // 
            this.btnLoadFromJson.BackColor = System.Drawing.Color.LightYellow;
            this.btnLoadFromJson.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadFromJson.Location = new System.Drawing.Point(180, 10);
            this.btnLoadFromJson.Name = "btnLoadFromJson";
            this.btnLoadFromJson.Size = new System.Drawing.Size(170, 35);
            this.btnLoadFromJson.TabIndex = 1;
            this.btnLoadFromJson.Text = "Đọc phim từ JSON";
            this.btnLoadFromJson.UseVisualStyleBackColor = false;
            this.btnLoadFromJson.Click += new System.EventHandler(this.btnLoadFromJson_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.LightGreen;
            this.btnBook.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBook.Location = new System.Drawing.Point(360, 10);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(140, 35);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Đặt vé";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(520, 10);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(280, 15);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(520, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(640, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "...";
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 700);
            this.Controls.Add(this.webViewDetail);
            this.Controls.Add(this.flpMovies);
            this.Controls.Add(this.panelTop);
            this.Name = "Bai04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 04 – Quản lý phòng vé (phiên bản 4)";
            ((System.ComponentModel.ISupportInitialize)(this.webViewDetail)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMovies;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDetail;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnLoadFromJson;
        private System.Windows.Forms.Button btnCrawl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
    }
}
