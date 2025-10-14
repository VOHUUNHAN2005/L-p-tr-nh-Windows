    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlcuahangdochoi.DTO
{
    internal class SanPhamDTO
    {
        public int MaSP {  get; set; }
        public string TenSP { get; set; }
        public int SLTon { get; set; }
        public float DonGia { get; set; }
        public string MoTa { get; set; }
        public string LoaiSP {  get; set; }

        public SanPhamDTO() {
            MaSP = 0;
            TenSP = string.Empty;
            SLTon = 0;
            DonGia = 0;
            MoTa = string.Empty;
            LoaiSP = string.Empty;
        }
    }
}
