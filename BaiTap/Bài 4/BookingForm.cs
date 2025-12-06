using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class BookingForm : Form
    {
        private class MovieInfo
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public List<int> Rooms { get; set; }
            public int TotalSeats { get; set; }
            public int SoldSeats { get; set; }

            public int RemainingSeats => TotalSeats - SoldSeats;
            public decimal SalesPercentage => TotalSeats > 0 ? (decimal)SoldSeats / TotalSeats * 100 : 0;
            public decimal Revenue { get; set; }
        }

        private Dictionary<string, MovieInfo> movies = new Dictionary<string, MovieInfo>();
        private Dictionary<string, decimal> seatPriceMultipliers = new Dictionary<string, decimal>();
        private Dictionary<string, bool> bookedSeats = new Dictionary<string, bool>();
        private Dictionary<string, Button> seatButtons = new Dictionary<string, Button>();
        private List<string> selectedSeats = new List<string>();
        private int currentRoom = 0;
        private const int TOTAL_SEATS_PER_ROOM = 188;

        public BookingForm(List<MovieSummary> movieSummaries, string initMovieName = null)
        {
            InitializeComponent();
            InitializeSeatMultipliers();
            InitializeMoviesFromSummaries(movieSummaries);
            UpdateMovieComboBox();

            if (!string.IsNullOrEmpty(initMovieName))
            {
                int index = cmbMovie.Items.IndexOf(initMovieName);
                if (index >= 0)
                    cmbMovie.SelectedIndex = index;
            }
        }

        private void InitializeSeatMultipliers()
        {
            string[] discountSeats = { "A1", "A5", "C1", "C5" };
            foreach (var seat in discountSeats)
                seatPriceMultipliers[seat] = 0.25m;

            string[] normalSeats = { "A2", "A3", "A4", "C2", "C3", "C4" };
            foreach (var seat in normalSeats)
                seatPriceMultipliers[seat] = 1m;

            string[] vipSeats = { "B2", "B3", "B4" };
            foreach (var seat in vipSeats)
                seatPriceMultipliers[seat] = 2m;

            string[] coupleSeats = { "M1+2", "M3+4", "M5+6", "M7+8", "M9+10", "M11+12" };
            foreach (var seat in coupleSeats)
                seatPriceMultipliers[seat] = 2m;
        }

        // KHÁC VỚI BÀI 5: không đọc file, tự tạo MovieInfo từ danh sách phim
        private void InitializeMoviesFromSummaries(List<MovieSummary> summaries)
        {
            movies.Clear();
            bookedSeats.Clear();

            Random rnd = new Random();

            foreach (var s in summaries)
            {
                // Random 1-3 phòng trong khoảng 1-8
                int roomCount = rnd.Next(1, 4);
                List<int> rooms = new List<int>();

                while (rooms.Count < roomCount)
                {
                    int r = rnd.Next(1, 9); // phòng 1..8
                    if (!rooms.Contains(r))
                    {
                        rooms.Add(r);
                        InitializeSeatsForRoom(r);
                    }
                }

                movies[s.Name] = new MovieInfo
                {
                    Name = s.Name,
                    Price = 80000m, 
                    Rooms = rooms,
                    TotalSeats = rooms.Count * TOTAL_SEATS_PER_ROOM,
                    SoldSeats = 0,
                    Revenue = 0
                };
            }
        }

        private void InitializeSeatsForRoom(int room)
        {
            char[] rows = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
            foreach (char row in rows)
            {
                if (row == 'M')
                {
                    string[] coupleSeats = { "M1+2", "M3+4", "M5+6", "M7+8", "M9+10", "M11+12" };
                    foreach (var seat in coupleSeats)
                    {
                        string seatKey = $"{room}_{seat}";
                        if (!bookedSeats.ContainsKey(seatKey))
                            bookedSeats[seatKey] = false;
                    }
                }
                else
                {
                    for (int col = 1; col <= 14; ++col)
                    {
                        string seatKey = $"{room}_{row}{col}";
                        if (!bookedSeats.ContainsKey(seatKey))
                            bookedSeats[seatKey] = false;
                    }
                }
            }
        }

        private void UpdateMovieComboBox()
        {
            cmbMovie.Items.Clear();
            foreach (var movie in movies.Keys)
            {
                cmbMovie.Items.Add(movie);
            }
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovie.SelectedItem == null) return;

            string selectedMovie = cmbMovie.SelectedItem.ToString();
            cmbRoom.Items.Clear();

            if (movies.ContainsKey(selectedMovie))
            {
                foreach (var room in movies[selectedMovie].Rooms)
                {
                    cmbRoom.Items.Add($"Phòng {room}");
                }
            }

            cmbRoom.Enabled = true;
            panelSeats.Visible = false;
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedItem == null) return;

            currentRoom = int.Parse(cmbRoom.SelectedItem.ToString().Split(' ')[1]);
            selectedSeats.Clear();
            CreateSeatLayout();
            panelSeats.Visible = true;
        }

        // Phần CreateSeatLayout, SetSeatButtonColor, SeatButton_Click, UpdateSelectedSeatsDisplay,
        // btnCalculate_Click, btnReset_Click, btnExit_Click
        // GIỮ NGUYÊN từ code Bai05 của bạn (chỉ đổi tên class).
        // Mình dán lại đầy đủ cho bạn dùng luôn:

        private void CreateSeatLayout()
        {
            panelSeats.Controls.Clear();
            seatButtons.Clear();

            int startX = 50, startY = 80, buttonWidth = 35, buttonHeight = 30, spacingX = 40, spacingY = 35;
            char[] rows = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };

            Label screenLabel = new Label
            {
                Text = "Screen",
                Location = new Point(startX + 200, 10),
                Size = new Size(200, 30),
                Font = new Font("Arial", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.LightGray
            };
            panelSeats.Controls.Add(screenLabel);

            Panel screenPanel = new Panel
            {
                Location = new Point(startX + 50, 45),
                Size = new Size(500, 20),
                BackColor = Color.Transparent,
            };
            screenPanel.Paint += (s, e) =>
            {
                Point[] points = {
                    new Point(50,0), new Point(450,0), new Point(500,20), new Point(0,20)
                };
                e.Graphics.DrawPolygon(Pens.Black, points);
            };
            panelSeats.Controls.Add(screenPanel);

            for (int i = 0; i < rows.Length; i++)
            {
                Label rowLabel = new Label
                {
                    Text = rows[i].ToString(),
                    Location = new Point(20, startY + i * spacingY + 5),
                    Size = new Size(20, 20),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panelSeats.Controls.Add(rowLabel);

                if (rows[i] == 'M')
                {
                    string[] coupleSeats = { "1+2", "3+4", "5+6", "7+8", "9+10", "11+12" };
                    for (int j = 0; j < coupleSeats.Length; j++)
                    {
                        string seatName = $"M{coupleSeats[j]}";
                        string seatKey = $"{currentRoom}_{seatName}";

                        Button btn = new Button
                        {
                            Text = coupleSeats[j],
                            Location = new Point(startX + j * spacingX * 2 + (j * 10), startY + i * spacingY),
                            Size = new Size(buttonWidth * 2 + 10, buttonHeight),
                            Font = new Font("Arial", 8, FontStyle.Bold),
                            Tag = seatName,
                            FlatStyle = FlatStyle.Flat
                        };

                        SetSeatButtonColor(btn, seatName, seatKey);
                        btn.Click += SeatButton_Click;
                        seatButtons[seatKey] = btn;
                        panelSeats.Controls.Add(btn);
                    }
                }
                else
                {
                    for (int j = 1; j <= 14; ++j)
                    {
                        string seatName = $"{rows[i]}{j}";
                        string seatKey = $"{currentRoom}_{seatName}";

                        Button btn = new Button
                        {
                            Text = j.ToString(),
                            Location = new Point(startX + (j - 1) * spacingX, startY + i * spacingY),
                            Size = new Size(buttonWidth, buttonHeight),
                            Font = new Font("Arial", 8),
                            Tag = seatName,
                            FlatStyle = FlatStyle.Flat
                        };

                        SetSeatButtonColor(btn, seatName, seatKey);
                        btn.Click += SeatButton_Click;
                        seatButtons[seatKey] = btn;
                        panelSeats.Controls.Add(btn);
                    }
                }
            }
        }

        private void SetSeatButtonColor(Button btn, string seatName, string seatKey)
        {
            if (bookedSeats.ContainsKey(seatKey) && bookedSeats[seatKey])
            {
                btn.BackColor = Color.DarkGray;
                btn.ForeColor = Color.White;
                btn.Enabled = false;
                return;
            }

            if (selectedSeats.Contains(seatName))
            {
                btn.BackColor = Color.Yellow;
                btn.ForeColor = Color.Black;
                return;
            }

            char row = seatName[0];
            if ((row == 'A' || row == 'B' || row == 'C'))
            {
                btn.BackColor = Color.Gray;
                btn.ForeColor = Color.White;
                btn.Enabled = false;
            }
            else if (row == 'M')
            {
                btn.BackColor = Color.DodgerBlue;
                btn.ForeColor = Color.White;
                btn.Enabled = true;
            }
            else if ((row == 'F' || row == 'G' || row == 'I'))
            {
                int col = int.Parse(seatName.Substring(1));
                if ((row == 'F' && (col == 7 || col == 8)) ||
                    (row == 'G' && (col == 7 || col == 8)) ||
                    (row == 'I' && (col >= 5 && col <= 10)))
                {
                    btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }
            else
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string seatName = btn.Tag.ToString();
            string seatKey = $"{currentRoom}_{seatName}";

            if (bookedSeats.ContainsKey(seatKey) && bookedSeats[seatKey])
            {
                MessageBox.Show("Ghế này đã được đặt!");
                return;
            }

            if (selectedSeats.Contains(seatName))
                selectedSeats.Remove(seatName);
            else
                selectedSeats.Add(seatName);

            SetSeatButtonColor(btn, seatName, seatKey);
            UpdateSelectedSeatsDisplay();
        }

        private void UpdateSelectedSeatsDisplay()
        {
            txtSelectedSeats.Text = string.Join(", ", selectedSeats);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!");
                return;
            }

            if (cmbMovie.SelectedItem == null || cmbRoom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!");
                return;
            }

            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!");
                return;
            }

            string customerName = txtCustomerName.Text;
            string movieName = cmbMovie.SelectedItem.ToString();
            decimal basePrice = movies[movieName].Price; // 80
            decimal totalAmount = 0;

            foreach (var seatName in selectedSeats)
            {
                decimal multiplier = seatPriceMultipliers.ContainsKey(seatName) ? seatPriceMultipliers[seatName] : 1m;
                totalAmount += basePrice * multiplier;

                string seatKey = $"{currentRoom}_{seatName}";
                bookedSeats[seatKey] = true;
            }

            string result = "";
            result += $"Họ và tên: {customerName}\r\n";
            result += $"Tên phim: {movieName}\r\n";
            result += $"Phòng chiếu: {currentRoom}\r\n";
            result += $"Vé đã chọn: {string.Join(", ", selectedSeats)}\r\n";
            result += $"Tổng tiền: {totalAmount:N0}đ\r\n";

            txtResult.Text = result;
            MessageBox.Show("Đặt vé thành công!");

            selectedSeats.Clear();
            CreateSeatLayout();
            UpdateSelectedSeatsDisplay();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            cmbMovie.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            cmbRoom.Items.Clear();
            cmbRoom.Enabled = false;
            txtResult.Clear();
            txtSelectedSeats.Clear();
            selectedSeats.Clear();
            panelSeats.Visible = false;
            panelSeats.Controls.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
