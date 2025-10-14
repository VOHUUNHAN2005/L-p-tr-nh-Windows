using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using qlcuahangdochoi.DTO;
using System.Windows.Forms;

namespace qlcuahangdochoi.DAO
{
    internal class NhapHangDAO : DataProvider
    {
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            string strQuey = "select * from NHAPHANG";
            SqlDataAdapter da = new SqlDataAdapter(strQuey, conn);
            da.Fill(dt);
            return dt;
        }
        public bool InsertNhapHang(NhapHangDTO nh)
        {
            string strQuery = string.Format("INSERT INTO NHAPHANG ( NgayNhapHang, MaNV, MaNCC ) VALUES ('{0}',{1},{2})",nh.NgayNhapHang,nh.MaNV,nh.MaNCC);
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
        public bool DeleteNhapHang(NhapHangDTO nh)
        {
            string strQuery = string.Format("DELETE from NHAPHANG WHERE MaNhapHang = {0}", nh.MaNhapHang);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = strQuery;
            cm.Connection = conn;
            conn.Open();
            int n = cm.ExecuteNonQuery();
            conn.Close();
            if (n > 0) {
                return true;
            }
            return false ;
        }

        public string GetMaTuTang()
        {
            string strIC = string.Format("select IDENT_CURRENT('NHAPHANG')");
            SqlCommand layID = new SqlCommand(strIC, conn);
            conn.Open();
            object i = layID.ExecuteScalar();
            conn.Close();
            return i.ToString();

        }
        //public bool UpdateNhapHang(NhapHangDTO nh)
        //{
        //    string strQuery = string.Format("UPDATE NHAPHANG SET NgayNhapHang = '{0}', MaNV = {1}, MaNCC = {2} WHERE MaNhapHang = {3}", nh.NgayNhapHang, nh.MaNV, nh.MaNCC,nh.MaNhapHang);
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
        //public int InsertNhapHangAndGetID(NhapHangDTO nh)
        //{
        //    int newID = -1;
        //    string query = string.Format("INSERT INTO NHAPHANG ( NgayNhapHang, MaNV, MaNCC ) VALUES ({0},{1},{2} SELECT SCOPE_IDENTITY();)", nh.NgayNhapHang,nh.MaNV,nh.MaNCC);

        //    SqlCommand cmd = new SqlCommand(query, conn);

        //    try
        //    {
        //        conn.Open();
        //        object result = cmd.ExecuteScalar();
        //        if (result != null)
        //        {
        //            newID = Convert.ToInt32(result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi thêm NHAPHANG: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return newID;
        //}

    }
}
