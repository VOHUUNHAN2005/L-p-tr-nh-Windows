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
    internal class HoaDonDAO : DataProvider
    {
        public DataTable GetData_HoaDon()
        {
            DataTable dt = new DataTable();
            string strQuery = "SELECT * FROM HOADON";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }

        public bool InsertHoaDon(HoaDonDTO hdDTO)
        {
            string query = string.Format(
                "INSERT INTO HOADON (NgayLapHD, TrangThai, MaNV) VALUES ('{0}', N'{1}', {2})",
                hdDTO.NgayLapHD.ToString("yyyy-MM-dd"), hdDTO.TrangThai, hdDTO.MaNV
            );
            conn.Close();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int n = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteHoaDon(HoaDonDTO hdDTO, CTHDDTO cthdDTO)
        {
            string strQueryDeleteCTHD = string.Format("DELETE FROM CTHD WHERE MAHD = '{0}'", hdDTO.MaHD);
            SqlCommand cmDeleteCTHD = new SqlCommand(strQueryDeleteCTHD, conn);
            conn.Open();
            cmDeleteCTHD.ExecuteNonQuery();
            conn.Close();

            // Sau đó mới xóa hóa đơn
            string strQueryDeleteHD = string.Format("DELETE FROM HOADON WHERE MAHD = '{0}'", cthdDTO.MaHD);
            SqlCommand cmDeleteHD = new SqlCommand(strQueryDeleteHD, conn);
            conn.Open();
            int n = cmDeleteHD.ExecuteNonQuery();
            conn.Close();

            if (n > 0)
            {
                return true;
            }
            return false;
        }

        public string GetMaTuTang()
        {
            string strIC = string.Format("select IDENT_CURRENT('HOADON')");
            SqlCommand layID = new SqlCommand(strIC, conn);
            conn.Open();
            object i = layID.ExecuteScalar();
            conn.Close();
            return i.ToString();

        }
    }
}
