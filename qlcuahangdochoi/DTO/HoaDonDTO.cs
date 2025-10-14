using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlcuahangdochoi.DTO
{
    internal class HoaDonDTO
    {
        public int MaHD { get; set; }

        public DateTime NgayLapHD { get; set; }
        public string TrangThai { get; set; }
        public int MaNV { get; set; }
        public HoaDonDTO()
        {
            MaHD = 0;
            NgayLapHD = DateTime.Now;
            TrangThai = string.Empty;
            MaNV = 0;
        }
    }
}
