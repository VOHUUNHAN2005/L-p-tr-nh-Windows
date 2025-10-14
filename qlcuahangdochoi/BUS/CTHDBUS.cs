using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DAO;
using qlcuahangdochoi.DTO;
namespace qlcuahangdochoi.BUS
{
    internal class CTHDBUS
    {
        private CTHDDAO cthd = new CTHDDAO();

        public DataTable LayCTHD()
        {
            return cthd.GetData_CTHD();
        }

        public bool ThemChiTietHoaDon(CTHDDTO cthdDTO)
        {
            return cthd.InsertChiTietHoaDon(cthdDTO);
        }

        public bool XoaChiTietHoaDon(CTHDDTO cthdDTO)
        {
            return cthd.DeleteChiTietHoaDon(cthdDTO);
        }
        public bool XoaChiTietHoaDonALL(CTHDDTO ctdhDTO)
        {
            return cthd.DeleteChiTietHoaDonALL(ctdhDTO);
        }
        public float tinhThanhTien(CTHDDTO ctdhDTO)
        {
            return ctdhDTO.DonGia * ctdhDTO.SL;
        }
        public DataTable LayMaHDCT(string MaHD)
        {
            DataTable Lay = cthd.GetData_CTHD();
            DataRow[] rowp = Lay.Select(string.Format("MaHD = {0}", MaHD));
            if (rowp.Length == 0)
            {
                return Lay.Clone();
            }
            return rowp.CopyToDataTable();
        }

    }
}
