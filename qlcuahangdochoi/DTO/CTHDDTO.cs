using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlcuahangdochoi.DTO
{
    internal class CTHDDTO
    {
        public int MaHD { get; set; }
        public int MaSP { get; set; }
        public int SL { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }

        public CTHDDTO()
        {
            MaHD = 0;
            MaSP = 0;
            SL = 0;
            DonGia = 0;
            ThanhTien = 0;
        }
    }
}
