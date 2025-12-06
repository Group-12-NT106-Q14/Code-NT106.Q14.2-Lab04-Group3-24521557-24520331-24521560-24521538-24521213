// RandomDish.cs  (FORM)
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RandomDish : Form
    {
        private readonly Dish _dish;

        public RandomDish(Dish dish)
        {
            _dish = dish;
            InitializeComponent();
            Load += RandomDish_Load;
            btnClose.Click += (s, e) => Close();
        }

        private void RandomDish_Load(object sender, EventArgs e)
        {
            lblName.Text = _dish.TenMonAn;
            lblPrice.Text = "Giá: " + _dish.Gia.ToString("0");
            lblAddress.Text = "Địa chỉ: " + _dish.DiaChi;
            lblUser.Text = "Đóng góp: " + _dish.NguoiDongGop;
            UiHelpers.LoadImageAsync(pictureBox, _dish.HinhAnh);
        }
    }
}