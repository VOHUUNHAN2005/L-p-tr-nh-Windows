using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlcuahangdochoi.DTO
{
    internal class CTHDNhapDTO
    {
        public int MaNhapHang { get; set; }
        public int MaSP { get; set; }
        public float DonGiaHang { get; set; }
        public int SLHang { get; set; }
        public float TongTienHang { get; set; }

        
        public CTHDNhapDTO() {
            MaNhapHang = 0;
            MaSP = 0;
            DonGiaHang = 0;
            SLHang = 0;
            TongTienHang = 0;
           
        
        }
    }
}
