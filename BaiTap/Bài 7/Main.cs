using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        private bool _suppressPageEvents = false;
        private readonly Random _random = new Random();

        public Main()
        {
            InitializeComponent();
            Load += Main_Load;
            tabControl.SelectedIndexChanged += async (s, e) => await ReloadCurrentTabAsync();
            cmbPageSize.SelectedIndexChanged += async (s, e) =>
            {
                if (_suppressPageEvents) return;
                numPage.Value = 1;
                await ReloadCurrentTabAsync();
            };
            numPage.ValueChanged += async (s, e) =>
            {
                if (_suppressPageEvents) return;
                await ReloadCurrentTabAsync();
            };
            btnAddDish.Click += btnAddDish_Click;
            btnRandom.Click += btnRandom_Click;
            linkLogout.LinkClicked += linkLogout_LinkClicked;
        }

        private void SetLoading(bool loading)
        {
            progressBar.Style = loading ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            progressBar.Visible = loading;
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + ApiService.CurrentUsername;
            if (cmbPageSize.Items.Count == 0)
            {
                cmbPageSize.Items.AddRange(new object[] { "3", "5", "10" });
            }
            cmbPageSize.SelectedIndex = 1; // 5
            numPage.Value = 1;
            await ReloadCurrentTabAsync();
        }

        private async System.Threading.Tasks.Task ReloadCurrentTabAsync()
        {
            try
            {
                if (cmbPageSize.SelectedItem == null)
                    cmbPageSize.SelectedIndex = 1;

                int pageSize = int.Parse(cmbPageSize.SelectedItem.ToString());
                int current = (int)numPage.Value;
                bool onlyMine = tabControl.SelectedTab == tabMine;

                SetLoading(true);
                var res = await ApiService.GetDishesAsync(current, pageSize, onlyMine);

                var panel = onlyMine ? flowMine : flowAll;
                panel.Controls.Clear();

                if (res?.Data != null)
                {
                    foreach (var dish in res.Data)
                        AddDishCard(panel, dish, onlyMine);
                }

                int total = res?.Pagination?.Total ?? (res?.Data?.Count ?? 0);
                int totalPages = Math.Max(1, (int)Math.Ceiling(total / (double)pageSize));

                _suppressPageEvents = true;
                numPage.Maximum = totalPages;
                if (numPage.Value > numPage.Maximum)
                    numPage.Value = numPage.Maximum;
                lblTotalPages.Text = "/ " + totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _suppressPageEvents = false;
                SetLoading(false);
            }
        }

        private void AddDishCard(FlowLayoutPanel container, Dish dish, bool showDeleteButton)
        {
            var card = new Panel();
            card.Width = container.ClientSize.Width - 30;
            card.Height = 110;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(5);

            var pic = new PictureBox();
            pic.Location = new Point(8, 8);
            pic.Size = new Size(90, 90);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            card.Controls.Add(pic);
            UiHelpers.LoadImageAsync(pic, dish.HinhAnh);

            var lblName = new Label();
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.Location = new Point(110, 8);
            lblName.Text = dish.TenMonAn;
            card.Controls.Add(lblName);

            var lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(110, 35);
            lblPrice.Text = "Giá: " + dish.Gia.ToString("0");
            card.Controls.Add(lblPrice);

            var lblAddress = new Label();
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(110, 55);
            lblAddress.Text = "Địa chỉ: " + dish.DiaChi;
            card.Controls.Add(lblAddress);

            var lblUser = new Label();
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.DarkGreen;
            lblUser.Location = new Point(110, 75);
            lblUser.Text = "Đóng góp: " + dish.NguoiDongGop;
            card.Controls.Add(lblUser);

            if (showDeleteButton)
            {
                var btnDelete = new System.Windows.Forms.Button();
                btnDelete.Text = "Xóa";
                btnDelete.Size = new Size(60, 28);
                btnDelete.Location = new Point(card.Width - 70, 8);
                btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btnDelete.Tag = dish;
                btnDelete.Click += async (s, e) => await DeleteDishAsync(dish);
                card.Controls.Add(btnDelete);
            }

            container.Controls.Add(card);
        }

        private async System.Threading.Tasks.Task DeleteDishAsync(Dish dish)
        {
            if (MessageBox.Show("Xóa món \"" + dish.TenMonAn + "\" ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SetLoading(true);
                    await ApiService.DeleteDishAsync(dish.Id);
                    await ReloadCurrentTabAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    SetLoading(false);
                }
            }
        }

        private async void btnAddDish_Click(object sender, EventArgs e)
        {
            using (var f = new AddDish())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    numPage.Value = 1;
                    await ReloadCurrentTabAsync();
                }
            }
        }

        private async void btnRandom_Click(object sender, EventArgs e)
        {
            bool onlyMine = tabControl.SelectedTab == tabMine;

            try
            {
                SetLoading(true);
                List<Dish> dishes = await ApiService.GetAllDishesForRandomAsync(onlyMine);
                if (dishes == null || dishes.Count == 0)
                {
                    MessageBox.Show("Không có món ăn nào để random.");
                    return;
                }

                var dish = dishes[_random.Next(dishes.Count)];
                using (var f = new RandomDish(dish))
                {
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi random", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetLoading(false);
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close(); // quay lại Dashboard/Program hiện tại
        }
    }
}