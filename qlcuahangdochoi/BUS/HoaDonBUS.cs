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
    internal class HoaDonBUS
    {
        private HoaDonDAO hd = new HoaDonDAO();

        public DataTable LayHoaDon()
        {
            return hd.GetData_HoaDon();
        }
        public bool ThemHoaDon(HoaDonDTO hdDTO)
        {
            return hd.InsertHoaDon(hdDTO);
        }

        public bool XoaHoaDon(HoaDonDTO hdDTO, CTHDDTO cthdDTO)
        {
            return hd.DeleteHoaDon(hdDTO, cthdDTO);
        }
        public DataTable LayMaNhapHang(string MaHD)
        {
            DataTable Lay = hd.GetData_HoaDon();
            DataRow[] rowp = Lay.Select(string.Format("MaHD = {0}", MaHD));
            if (rowp.Length == 0)
            {
                return Lay.Clone();
            }
            return rowp.CopyToDataTable();
        }
        public string LayMaTuTang()
        {
            return hd.GetMaTuTang();
        }


    }
}
