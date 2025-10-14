using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DTO;
namespace qlcuahangdochoi.DAO
{
    internal class SanPhamDAO :DataProvider
    {
        public DataTable GetData_SanPham()
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT * FROM SANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }

        public bool themSanPham(SanPhamDTO spDTOThem)
        {
            String query = string.Format("Insert into SANPHAM (TenSP, LoaiSP, DonGia, SLTon, MoTa) VALUES (N'{0}',N'{1}','{2}','{3}',N'{4}')",
                spDTOThem.TenSP, spDTOThem.LoaiSP,spDTOThem.DonGia, spDTOThem.SLTon, spDTOThem.MoTa);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();

            int n = cmd.ExecuteNonQuery();
            conn.Close();

            if (n > 0)
            {
                return true;
            }
            return false;
        }
        public bool xoaSanPham(SanPhamDTO spDTOXoa)
        {
            string query = String.Format("DELETE FROM SANPHAM WHERE MaSP = {0}", spDTOXoa.MaSP);
            SqlCommand command = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();

            int n = command.ExecuteNonQuery();
            conn.Close();

            if (n > 0)
            {
                return true;
            }
            return false;
        }

        public bool editSanPham(SanPhamDTO spDTOEdit)
        {
            string query = string.Format("UPDATE SANPHAM SET TenSP = N'{0}', LoaiSP = '{1}', DonGia = '{2}', SLTon = N'{3}',  MoTa = N'{4}' WHERE MaSp = {5}",
                spDTOEdit.TenSP, spDTOEdit.LoaiSP, spDTOEdit.DonGia, spDTOEdit.SLTon, spDTOEdit.MoTa, spDTOEdit.MaSP);
            SqlCommand command1 = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();

            int n = command1.ExecuteNonQuery();
            conn.Close();

            if (n > 0)
            {
                return true;
            }
            return false;
        }

    }
}
