using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DAO;
using qlcuahangdochoi.DTO;

namespace qlcuahangdochoi.BUS
{
    internal class SanPhamBUS
    {
        private SanPhamDAO spDAO1 = new SanPhamDAO();

        public DataTable laySP()
        {
            return spDAO1.GetData_SanPham();
        }
        public bool themSanPham(SanPhamDTO spDAO)
        {
            return spDAO1.themSanPham(spDAO);
        }

        public bool xoasanpham(SanPhamDTO spDAO)
        {
            return spDAO1.xoaSanPham(spDAO);
        }

        public bool suaSanPham(SanPhamDTO spDAO)
        {
            return spDAO1.editSanPham(spDAO);
        }
        public DataTable layMaSP(string maSP)
        {
            DataTable lay = spDAO1.GetData_SanPham();
            DataRow[] row1 = lay.Select(string.Format("MaSP = {0}", maSP));
            if (row1.Length == 0)
            {
                return null;
            }
            return row1.CopyToDataTable();
        }
    }
}
