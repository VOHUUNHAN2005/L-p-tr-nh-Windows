    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DTO;
using qlcuahangdochoi.DAO;
using System.Data;
using System.Windows.Forms;


namespace qlcuahangdochoi.BUS
{
    internal class NhapHangBUS
    {
        NhapHangDAO nh = new NhapHangDAO();
        public DataTable LayDonHang()
        {
            return nh.GetData();
        }
        public bool ThemNhapHang(NhapHangDTO nhDTO)
        {
            return nh.InsertNhapHang(nhDTO);
        }
        public bool XoaNhapHang(NhapHangDTO nhDTO)
        {
            return nh.DeleteNhapHang(nhDTO);
        }
        //public bool CapNhatHang(NhapHangDTO nhDTO)
        //{
        //    return nh.UpdateNhapHang(nhDTO);
        //}
        public DataTable LayMaNhapHang(string MaNhapHang)
        {
            DataTable Lay = nh.GetData();
            DataRow[] rowp = Lay.Select(string.Format("MaNhapHang = {0}", MaNhapHang));
            if (rowp.Length == 0)
            {
                return Lay.Clone();
            }
            return rowp.CopyToDataTable();
        }
        public string LayMaTuTang()
        {
            return nh.GetMaTuTang();
        }
    }
}
