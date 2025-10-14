using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlcuahangdochoi.DTO
{
    internal class NhaCungCapDTO
    {
        public int MaNCC {  get; set; }
        public string TenNCC {  get; set; }
        public string DiaChi {  get; set; }
        public string SDT {  get; set; }
        public NhaCungCapDTO() {
            MaNCC = 0;
            TenNCC = string.Empty;
            DiaChi = string.Empty;
            SDT = string.Empty;

        }
    }
}
