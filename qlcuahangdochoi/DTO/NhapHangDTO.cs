using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace qlcuahangdochoi.DTO
{
    internal class NhapHangDTO
    {
        public int MaNhapHang {  get; set; }
        public DateTime NgayNhapHang { get; set; }
        public int MaNV {  get; set; }
        public int MaNCC { get; set; }

        public NhapHangDTO() {
            MaNhapHang = 0;
            NgayNhapHang = DateTime.Now;
            MaNV = 0;
            MaNCC = 0;
        }
    }
}
