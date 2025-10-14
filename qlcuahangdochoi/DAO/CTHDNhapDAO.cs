using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using qlcuahangdochoi.DTO;
using System.Data;
using System.Windows.Forms;

namespace qlcuahangdochoi.DAO
{
    internal class CTHDNhapDAO : DataProvider
    {
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            string strQuey = "select * from CTHDNHAP";
            SqlDataAdapter da = new SqlDataAdapter(strQuey, conn);
            da.Fill(dt);
            return dt;
        }
        public bool InsertChiTietNhapHang(CTHDNhapDTO cthdn)
        {
            //string checkQuery = string.Format("SELECT COUNT(*) FROM CTHDNHAP WHERE MaNhapHang = ?",cthdn.MaNhapHang);
            string strQuery = string.Format("INSERT INTO CTHDNHAP ( MaNhapHang, MaSP, DonGiaHang, SLHang, TongTienHang ) VALUES ({0},{1},{2},{3},{4})",cthdn.MaNhapHang, cthdn.MaSP, cthdn.DonGiaHang, cthdn.SLHang, cthdn.TongTienHang);
            SqlCommand cm = new SqlCommand();
            //SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            cm.CommandText = strQuery;
            cm.Connection = conn;
            conn.Open();
            //object i = cm.ExecuteScalar();
            int n = cm.ExecuteNonQuery();
            
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteChiTietNhapHang(CTHDNhapDTO cthdn)
        {
            string strQuery = string.Format("DELETE from CTHDNHAP WHERE MaNhapHang = '{0}'", cthdn.MaNhapHang);
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
        public bool DeleteChiTietNhapHangALL(CTHDNhapDTO cthdn)
        {
            string strQuery = string.Format("DELETE from CTHDNHAP WHERE MaNhapHang = {0}", cthdn.MaNhapHang);
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
        //public bool UpdateChiTietNhapHang(CTHDNhapDTO cthdn)
        //{
        //    string strQuery = string.Format("UPDATE CTHDNHAP SET MaNhapHang = {0}, MaSP = {1}, DonGiaHang = {2}, SLHang = {3}, TongTienHang = {4} WHERE MaNhapHang = {5}", cthdn.MaNhapHang, cthdn.MaSP, cthdn.DonGiaHang, cthdn.SLHang, cthdn.TongTienHang, cthdn.MaNhapHang);
        //    SqlCommand cm = new SqlCommand();
        //    cm.CommandText = strQuery;
        //    cm.Connection = conn;
        //    conn.Open();
        //    int n = cm.ExecuteNonQuery();
        //    conn.Close();
        //    if (n > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
