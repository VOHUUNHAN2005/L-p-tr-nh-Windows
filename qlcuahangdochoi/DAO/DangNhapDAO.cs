using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using qlcuahangdochoi.DTO;
using qlcuahangdochoi.BUS;
using System.Windows.Forms;

namespace qlcuahangdochoi.DAO
{

    internal class DangNhapDAO : DataProvider
    {

        public DataTable GetData_NhanVien()
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT * FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);    
            return dt;
        }
        public bool themNhanVien(DangNhapDTO nvDTOThem)
        {
            String query = string.Format("Insert into NHANVIEN VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', N'{6}', '{7}', '{8}')",
                 nvDTOThem.TaiKhoan,nvDTOThem.MatKhau,nvDTOThem.HoNV,nvDTOThem.TenNV,nvDTOThem.Vaitro,nvDTOThem.NgaySinh.ToString("yyyy-MM-dd"), nvDTOThem.DiaChi,nvDTOThem.GioiTinh,nvDTOThem.SDT);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();

            int n = cmd.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        public bool xoaNhanVien(DangNhapDTO nvDTOXoa)
        {
            string query = String.Format("DELETE FROM NHANVIEN WHERE MaNV = {0}", nvDTOXoa.MaNV);
            SqlCommand command = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();

            int n = command.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }

        public bool editNhanVien(DangNhapDTO nvDTOEdit)
        {
            string query = string.Format("UPDATE NHANVIEN SET TaiKhoan = N'{0}', MatKhau = N'{1}', HoNV = N'{2}', TenNV = N'{3}',  VaiTro = N'{4}', NgaySinh='{5}', DiaChi=N'{6}', GioiTinh='{7}', SDT='{8}' WHERE MaNV = {9 }",
                nvDTOEdit.TaiKhoan, nvDTOEdit.MatKhau, nvDTOEdit.HoNV, nvDTOEdit.TenNV, nvDTOEdit.Vaitro, nvDTOEdit.NgaySinh.ToString("yyyy-MM-dd"), nvDTOEdit.DiaChi, nvDTOEdit.GioiTinh, nvDTOEdit.SDT, nvDTOEdit.MaNV);
            SqlCommand command1 = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();

            int n = command1.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        public bool CheckTaiKhoanTrung(string taiKhoan)
        {
            string query = string.Format("SELECT COUNT(*) FROM NHANVIEN WHERE TaiKhoan = N'{0}'", taiKhoan);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();
            int count = (int)cmd.ExecuteScalar(); 
            conn.Close();

            return count > 0; 
        }


    }

}
