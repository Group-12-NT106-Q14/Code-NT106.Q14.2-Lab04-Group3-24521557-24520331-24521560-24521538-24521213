using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    #region Models

    public class LoginUser
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }
    }

    public class LoginResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("user")]
        public LoginUser User { get; set; }
    }

    public class SignupRequest
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("sex")]
        public int Sex { get; set; } // 0: male, 1: female

        [JsonPropertyName("birthday")]
        public DateTime Birthday { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }

    public class DishCreateRequest
    {
        [JsonPropertyName("ten_mon_an")]
        public string TenMonAn { get; set; }

        [JsonPropertyName("gia")]
        public decimal Gia { get; set; }

        [JsonPropertyName("mo_ta")]
        public string MoTa { get; set; }

        [JsonPropertyName("hinh_anh")]
        public string HinhAnh { get; set; }

        [JsonPropertyName("dia_chi")]
        public string DiaChi { get; set; }
    }

    public class Dish
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("ten_mon_an")]
        public string TenMonAn { get; set; }

        [JsonPropertyName("gia")]
        public decimal Gia { get; set; }

        [JsonPropertyName("mo_ta")]
        public string MoTa { get; set; }

        [JsonPropertyName("hinh_anh")]
        public string HinhAnh { get; set; }

        [JsonPropertyName("dia_chi")]
        public string DiaChi { get; set; }

        [JsonPropertyName("nguoi_dong_gop")]
        public string NguoiDongGop { get; set; }
    }

    public class Pagination
    {
        [JsonPropertyName("current")]
        public int Current { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

    public class DishListResponse
    {
        [JsonPropertyName("data")]
        public List<Dish> Data { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class PaginationRequest
    {
        [JsonPropertyName("current")]
        public int Current { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }
    }

    #endregion

    public static class ApiService
    {
        private static readonly HttpClient httpClient;
        private static readonly JsonSerializerOptions jsonOptions;

        public static string AccessToken { get; private set; }
        public static string TokenType { get; private set; } = "Bearer";
        public static string CurrentUsername { get; private set; }

        static ApiService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://nt106.uitiot.vn");
            jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        private static void EnsureAuthenticated()
        {
            if (string.IsNullOrWhiteSpace(AccessToken))
                throw new InvalidOperationException("Vui lòng đăng nhập trước khi gọi API.");
        }

        public static void Logout()
        {
            AccessToken = null;
            TokenType = "Bearer";
            CurrentUsername = null;
            httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public static async Task LoginAsync(string username, string password)
        {
            var formData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", ""),
                new KeyValuePair<string, string>("scope", "")
            };

            var content = new FormUrlEncodedContent(formData);
            var response = await httpClient.PostAsync("/auth/token", content);

            if (!response.IsSuccessStatusCode)
            {
                var err = await response.Content.ReadAsStringAsync();
                throw new Exception("Đăng nhập thất bại. Mã lỗi: " + (int)response.StatusCode + "\n" + err);
            }

            var json = await response.Content.ReadAsStringAsync();
            var token = JsonSerializer.Deserialize<LoginResponse>(json, jsonOptions);

            if (token == null || string.IsNullOrWhiteSpace(token.AccessToken))
                throw new Exception("Không nhận được token hợp lệ từ server.");

            AccessToken = token.AccessToken;
            TokenType = token.TokenType ?? "Bearer";
            CurrentUsername = token.User?.Username ?? username;

            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(TokenType, AccessToken);
        }

        public static async Task SignUpAsync(SignupRequest request)
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/api/v1/user/signup", content);

            if (!response.IsSuccessStatusCode)
            {
                var err = await response.Content.ReadAsStringAsync();
                throw new Exception("Đăng ký thất bại. Mã lỗi: " + (int)response.StatusCode + "\n" + err);
            }
        }

        public static async Task<DishListResponse> GetDishesAsync(int current, int pageSize, bool onlyMine)
        {
            EnsureAuthenticated();

            var req = new PaginationRequest { Current = current, PageSize = pageSize };
            var jsonBody = JsonSerializer.Serialize(req);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            string url = onlyMine ? "/api/v1/monan/my-dishes" : "/api/v1/monan/all";
            var response = await httpClient.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
            {
                var err = await response.Content.ReadAsStringAsync();
                throw new Exception("Lấy danh sách món ăn thất bại. Mã lỗi: " + (int)response.StatusCode + "\n" + err);
            }

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<DishListResponse>(json, jsonOptions);
        }

        public static async Task<List<Dish>> GetAllDishesForRandomAsync(bool onlyMine)
        {
            var res = await GetDishesAsync(1, 100, onlyMine);
            return res?.Data ?? new List<Dish>();
        }

        public static async Task AddDishAsync(DishCreateRequest request)
        {
            EnsureAuthenticated();

            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("/api/v1/monan/add", content);

            if (!response.IsSuccessStatusCode)
            {
                var err = await response.Content.ReadAsStringAsync();
                throw new Exception("Thêm món ăn thất bại. Mã lỗi: " + (int)response.StatusCode + "\n" + err);
            }
        }

        public static async Task DeleteDishAsync(int id)
        {
            EnsureAuthenticated();

            var response = await httpClient.DeleteAsync("/api/v1/monan/" + id);

            if (!response.IsSuccessStatusCode)
            {
                var err = await response.Content.ReadAsStringAsync();
                throw new Exception("Xóa món ăn thất bại. Mã lỗi: " + (int)response.StatusCode + "\n" + err);
            }
        }
    }

    public static class UiHelpers
    {
        public static void LoadImageAsync(PictureBox pictureBox, string urlOrPath)
        {
            pictureBox.Image = null;
            if (string.IsNullOrWhiteSpace(urlOrPath))
                return;

            Task.Run(() =>
            {
                try
                {
                    Image image = null;

                    if (urlOrPath.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                    {
                        using (var wc = new WebClient())
                        {
                            byte[] data = wc.DownloadData(urlOrPath);
                            using (var ms = new MemoryStream(data))
                                image = Image.FromStream(ms);
                        }
                    }
                    else if (File.Exists(urlOrPath))
                    {
                        image = Image.FromFile(urlOrPath);
                    }

                    if (image != null && !pictureBox.IsDisposed)
                    {
                        pictureBox.Invoke(new Action(() =>
                        {
                            pictureBox.Image = image;
                        }));
                    }
                }
                catch
                {
                    // ignore
                }
            });
        }
    }
}