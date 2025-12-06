using System.Drawing;

namespace WinFormsApp1
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.TabPage tabMine;
        private System.Windows.Forms.FlowLayoutPanel flowAll;
        private System.Windows.Forms.FlowLayoutPanel flowMine;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.NumericUpDown numPage;
        private System.Windows.Forms.Label lblTotalPages;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.ComboBox cmbPageSize;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnRandom = new Button();
            btnAddDish = new Button();
            tabControl = new TabControl();
            tabAll = new TabPage();
            flowAll = new FlowLayoutPanel();
            tabMine = new TabPage();
            flowMine = new FlowLayoutPanel();
            bottomPanel = new Panel();
            lblWelcome = new Label();
            linkLogout = new LinkLabel();
            progressBar = new ProgressBar();
            lblPage = new Label();
            numPage = new NumericUpDown();
            lblTotalPages = new Label();
            lblPageSize = new Label();
            cmbPageSize = new ComboBox();
            tabControl.SuspendLayout();
            tabAll.SuspendLayout();
            tabMine.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.IndianRed;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(267, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÔM NAY ĂN GÌ?";
            // 
            // btnRandom
            // 
            btnRandom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRandom.BackColor = Color.FromArgb(255, 227, 201);
            btnRandom.FlatAppearance.BorderSize = 0;
            btnRandom.FlatStyle = FlatStyle.Flat;
            btnRandom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRandom.ForeColor = Color.SaddleBrown;
            btnRandom.Location = new Point(470, 12);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(150, 40);
            btnRandom.TabIndex = 1;
            btnRandom.Text = "Ăn gì giờ?";
            btnRandom.UseVisualStyleBackColor = false;
            // 
            // btnAddDish
            // 
            btnAddDish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddDish.BackColor = Color.FromArgb(255, 243, 220);
            btnAddDish.FlatAppearance.BorderSize = 0;
            btnAddDish.FlatStyle = FlatStyle.Flat;
            btnAddDish.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddDish.ForeColor = Color.SaddleBrown;
            btnAddDish.Location = new Point(630, 12);
            btnAddDish.Name = "btnAddDish";
            btnAddDish.Size = new Size(150, 40);
            btnAddDish.TabIndex = 2;
            btnAddDish.Text = "Thêm món ăn";
            btnAddDish.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabAll);
            tabControl.Controls.Add(tabMine);
            tabControl.Location = new Point(12, 60);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 420);
            tabControl.TabIndex = 3;
            // 
            // tabAll
            // 
            tabAll.Controls.Add(flowAll);
            tabAll.Location = new Point(4, 29);
            tabAll.Name = "tabAll";
            tabAll.Padding = new Padding(3);
            tabAll.Size = new Size(768, 387);
            tabAll.TabIndex = 0;
            tabAll.Text = "All";
            tabAll.UseVisualStyleBackColor = true;
            // 
            // flowAll
            // 
            flowAll.AutoScroll = true;
            flowAll.Dock = DockStyle.Fill;
            flowAll.FlowDirection = FlowDirection.TopDown;
            flowAll.Location = new Point(3, 3);
            flowAll.Name = "flowAll";
            flowAll.Size = new Size(762, 381);
            flowAll.TabIndex = 0;
            flowAll.WrapContents = false;
            // 
            // tabMine
            // 
            tabMine.Controls.Add(flowMine);
            tabMine.Location = new Point(4, 29);
            tabMine.Name = "tabMine";
            tabMine.Padding = new Padding(3);
            tabMine.Size = new Size(768, 387);
            tabMine.TabIndex = 1;
            tabMine.Text = "Tôi đóng góp";
            tabMine.UseVisualStyleBackColor = true;
            // 
            // flowMine
            // 
            flowMine.AutoScroll = true;
            flowMine.Dock = DockStyle.Fill;
            flowMine.FlowDirection = FlowDirection.TopDown;
            flowMine.Location = new Point(3, 3);
            flowMine.Name = "flowMine";
            flowMine.Size = new Size(762, 381);
            flowMine.TabIndex = 0;
            flowMine.WrapContents = false;
            // 
            // bottomPanel
            // 
            bottomPanel.BorderStyle = BorderStyle.FixedSingle;
            bottomPanel.Controls.Add(lblWelcome);
            bottomPanel.Controls.Add(linkLogout);
            bottomPanel.Controls.Add(progressBar);
            bottomPanel.Controls.Add(lblPage);
            bottomPanel.Controls.Add(numPage);
            bottomPanel.Controls.Add(lblTotalPages);
            bottomPanel.Controls.Add(lblPageSize);
            bottomPanel.Controls.Add(cmbPageSize);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 488);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(800, 60);
            bottomPanel.TabIndex = 4;
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(10, 8);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(184, 22);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, user";
            // 
            // linkLogout
            // 
            linkLogout.Location = new Point(10, 30);
            linkLogout.Name = "linkLogout";
            linkLogout.Size = new Size(60, 20);
            linkLogout.TabIndex = 1;
            linkLogout.TabStop = true;
            linkLogout.Text = "Logout";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(200, 20);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(250, 15);
            progressBar.TabIndex = 2;
            progressBar.Visible = false;
            // 
            // lblPage
            // 
            lblPage.Location = new Point(456, 10);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(48, 22);
            lblPage.TabIndex = 3;
            lblPage.Text = "Page:";
            // 
            // numPage
            // 
            numPage.Location = new Point(510, 8);
            numPage.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPage.Name = "numPage";
            numPage.Size = new Size(60, 27);
            numPage.TabIndex = 4;
            numPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTotalPages
            // 
            lblTotalPages.Location = new Point(575, 10);
            lblTotalPages.Name = "lblTotalPages";
            lblTotalPages.Size = new Size(50, 20);
            lblTotalPages.TabIndex = 5;
            lblTotalPages.Text = "/ 1";
            // 
            // lblPageSize
            // 
            lblPageSize.Location = new Point(612, 12);
            lblPageSize.Name = "lblPageSize";
            lblPageSize.Size = new Size(80, 20);
            lblPageSize.TabIndex = 6;
            lblPageSize.Text = "Page size:";
            // 
            // cmbPageSize
            // 
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Location = new Point(692, 9);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(60, 28);
            cmbPageSize.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(bottomPanel);
            Controls.Add(tabControl);
            Controls.Add(btnAddDish);
            Controls.Add(btnRandom);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hôm nay ăn gì?";
            tabControl.ResumeLayout(false);
            tabAll.ResumeLayout(false);
            tabMine.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}