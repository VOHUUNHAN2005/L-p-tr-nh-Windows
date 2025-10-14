    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DTO;
using qlcuahangdochoi.DAO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace qlcuahangdochoi.BUS
{
    internal class DangNhapBUS
    {

        private DangNhapDAO dn1 = new DangNhapDAO();

        // phuong thuc dang nhap
        public DataTable thongTinDangNhap()
        {
            return dn1.GetData_NhanVien();
        }

        public string check_DangNhap(DangNhapDTO DangNhap)
        {
            DataTable checkDangNhap = dn1.GetData_NhanVien();
            string dNNV = string.Format("TaiKhoan = '{0}' AND MatKhau = '{1}' ", DangNhap.TaiKhoan, DangNhap.MatKhau);
            DataRow[] dt = checkDangNhap.Select(dNNV);
            if (dt.Length > 0) {
                return dt[0]["Vaitro"].ToString();
            }
            return string.Empty;
        }
        public bool themNhanVien(DangNhapDTO nvDTO)
        {
            if (dn1.CheckTaiKhoanTrung(nvDTO.TaiKhoan))
            {
                MessageBox.Show("Tài khoản này đã tồn tại!","Cảnh cáo");
                return false;
            }
            return dn1.themNhanVien(nvDTO);
        }
        public bool xoaNhanVien(DangNhapDTO nvDTO)
        {
            return dn1.xoaNhanVien(nvDTO);
        }
        public bool editNhanVien(DangNhapDTO nvDTO)
        {
            return dn1.editNhanVien(nvDTO);
        }
        public DataTable laymaNV(string manv)
        {
            DataTable lay = dn1.GetData_NhanVien();
            DataRow[] row1 = lay.Select(string.Format("MaNV = {0}", manv));
            if (row1.Length == 0)
            {
                return null;
            }
            return row1.CopyToDataTable();
        }

    }
}
