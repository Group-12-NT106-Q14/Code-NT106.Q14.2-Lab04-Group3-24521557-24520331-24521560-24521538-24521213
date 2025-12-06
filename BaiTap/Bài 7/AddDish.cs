using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddDish : Form
    {
        public AddDish()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;

            // TextChanged để preview khi nhập URL
            txtImage.TextChanged += txtImage_TextChanged;

            // Chọn file từ máy
            btnBrowseImage.Click += btnBrowseImage_Click;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn hình món ăn";
                ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Lưu đường dẫn file vào textbox
                    txtImage.Text = ofd.FileName;

                    // Disable ô URL như bạn yêu cầu
                    txtImage.Enabled = false;

                    // Preview ảnh
                    UiHelpers.LoadImageAsync(picPreview, ofd.FileName);
                }
            }
        }

        private void txtImage_TextChanged(object sender, EventArgs e)
        {
            // Nếu đã chọn file từ máy (ô URL disable) thì thôi,
            // không cần xử lý thêm
            if (!txtImage.Enabled)
                return;

            string pathOrUrl = txtImage.Text.Trim();
            if (string.IsNullOrWhiteSpace(pathOrUrl))
            {
                picPreview.Image = null;
                return;
            }

            // Preview cho cả URL lẫn file local
            UiHelpers.LoadImageAsync(picPreview, pathOrUrl);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Number,
                    CultureInfo.InvariantCulture, out decimal price))
            {
                MessageBox.Show("Giá không hợp lệ.");
                return;
            }

            var imgText = txtImage.Text.Trim();

            // Nếu đang disable (tức đã chọn file từ máy): imgText là path local
            // Nếu còn enable: imgText có thể là URL người dùng nhập

            var req = new DishCreateRequest
            {
                TenMonAn = txtName.Text.Trim(),
                Gia = price,
                DiaChi = txtAddress.Text.Trim(),
                HinhAnh = imgText, // gửi đúng string này lên API
                MoTa = txtDescription.Text.Trim()
            };

            try
            {
                btnAdd.Enabled = false;
                await ApiService.AddDishAsync(req);
                MessageBox.Show("Đã thêm món ăn thành công!");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAdd.Enabled = true;
            }
        }
    }
}