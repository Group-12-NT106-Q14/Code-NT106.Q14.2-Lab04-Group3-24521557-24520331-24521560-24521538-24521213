using System;

namespace WinFormsApp1
{
    public class MovieSummary
    {
        public string Id { get; set; }          // gf=... nếu cần
        public string Name { get; set; }
        public string DetailUrl { get; set; }
        public string PosterUrl { get; set; }
        public string Genre { get; set; }       // Thể loại
        public string Duration { get; set; }    // Thời lượng (chuỗi)
    }
}
