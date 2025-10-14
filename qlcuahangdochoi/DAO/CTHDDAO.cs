using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DTO;
using System.Windows.Forms;

namespace qlcuahangdochoi.DAO
{
    internal class CTHDDAO : DataProvider
    {
        public DataTable GetData_CTHD()
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT * FROM CTHD";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }

        public bool InsertChiTietHoaDon(CTHDDTO cthd)
        {
            string checkQuery = string.Format("SELECT COUNT(*) FROM CTHD WHERE MaHD = {0} AND MaSP = {1}", cthd.MaHD, cthd.MaSP);
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);

            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                // Dữ liệu đã tồn tại, không chèn nữa
                MessageBox.Show("Sản phẩm đã tồn tại trong chi tiết đơn hàng!");
                return false;
            }
            string query = string.Format("INSERT INTO CTHD (MaHD, MaSP, SL, DonGia, ThanhTien) VALUES ({0}, {1}, {2}, {3},{4})",
                cthd.MaHD, cthd.MaSP, cthd.SL, cthd.DonGia, cthd.ThanhTien
            );
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            return false;
        }

        // Xóa chi tiết hóa đơn
        public bool DeleteChiTietHoaDon(CTHDDTO cthd)
        {
            string strQuery = string.Format("DELETE from CTHD WHERE MaHD = {0} AND MaSP = {1}", cthd.MaHD, cthd.MaSP);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = strQuery;
            cm.Connection = conn;
            conn.Open();
            int n = cm.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteChiTietHoaDonALL(CTHDDTO cthd)
        {
            string strQuery = string.Format("DELETE from CTHD WHERE MaHD = {0}", cthd.MaHD);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = strQuery;
            cm.Connection = conn;
            conn.Open();
            int n = cm.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            return false;
        }

    }
}
