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
    internal class NhaCungCapDAO : DataProvider
    {
        public DataTable GetData_NhaCungCap()
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT * FROM NHACUNGCAP";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }
        public bool themNhaCungCap(NhaCungCapDTO nccDTOThem)
        {
            string query = string.Format(
                "INSERT INTO NHACUNGCAP (TenNCC, DiaChi, SDT) VALUES (N'{0}', N'{1}', '{2}')",
                nccDTOThem.TenNCC, nccDTOThem.DiaChi, nccDTOThem.SDT
            );

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            conn.Close();

            return n > 0;
        }
        public bool xoaNhaCungCap(NhaCungCapDTO nccDTOXoa)
        {
            string query = string.Format("DELETE FROM NHACUNGCAP WHERE MaNCC = {0}", nccDTOXoa.MaNCC);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            conn.Close();

            return n > 0;
        }
        public bool editNhaCungCap(NhaCungCapDTO nccDTOEdit)
        {
            string query = string.Format(
                "UPDATE NHACUNGCAP SET TenNCC = N'{0}', DiaChi = N'{1}', SDT = '{2}' WHERE MaNCC = {3}",
                nccDTOEdit.TenNCC, nccDTOEdit.DiaChi, nccDTOEdit.SDT, nccDTOEdit.MaNCC
            );

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            conn.Close();

            return n > 0;
        }
    }
}
