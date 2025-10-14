using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DTO;
using qlcuahangdochoi.DAO;
using System.Data;

namespace qlcuahangdochoi.BUS
{
    internal class CTHDNhapBUS
    {
        CTHDNhapDAO cthdn = new CTHDNhapDAO();
        public DataTable LayChiTietDonNhap()
        {
            return cthdn.GetData();
        }
        public bool ThemChiTietNhapHang(CTHDNhapDTO ctdhnDTO)
        {
            return cthdn.InsertChiTietNhapHang(ctdhnDTO);
        }
        public bool XoaChiTietNhapHang(CTHDNhapDTO ctdhnDTO)
        {
            return cthdn.DeleteChiTietNhapHang(ctdhnDTO);
        }
        public bool XoaChiTietNhapHangALL(CTHDNhapDTO ctdhnDTO)
        {
            return cthdn.DeleteChiTietNhapHangALL(ctdhnDTO);
        }
        public float tinhTongTienHang(CTHDNhapDTO ctdhnDTO)
        {
            return ctdhnDTO.DonGiaHang * ctdhnDTO.SLHang;
        }
        public DataTable LayMaNhapHangCT(string MaNhapHang)
        {
            DataTable Lay = cthdn.GetData();
            DataRow[] rowp = Lay.Select(string.Format("MaNhapHang = {0}", MaNhapHang));
            if (rowp.Length == 0)
            {
                return Lay.Clone();
            }
            return rowp.CopyToDataTable();
        }
    }
}
