
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace qlcuahangdochoi.DTO
{
    internal class DangNhapDTO
    {
        public int MaNV { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public string Vaitro { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }


        public DangNhapDTO() {
            MaNV = 0;

            TaiKhoan = string.Empty;

            MatKhau = string.Empty;

            HoNV = string.Empty;

            TenNV = string.Empty;

            Vaitro = string.Empty;

            NgaySinh = DateTime.Today;

            DiaChi = string.Empty;

            GioiTinh = string.Empty;

            SDT = string.Empty;

        }
    }
}
