using qlcuahangdochoi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DTO;

namespace qlcuahangdochoi.DAO
{
    internal class DoanhThuDAO : DataProvider
    {
        public DoanhThuDTO LayDoanhThu(int thang, int nam)
        {
            DoanhThuDTO doanhThu = new DoanhThuDTO();
            doanhThu.Thang = thang;
            doanhThu.Nam = nam;

            
            string queryNhapHang = string.Format("SELECT COALESCE(SUM(TongTienHang), 0) FROM CTHDNHAP WHERE MaNhapHang IN (SELECT MaNhapHang FROM NHAPHANG WHERE MONTH(NgayNhapHang) = {0} AND YEAR(NgayNhapHang) = {1})",
                thang, nam);

            SqlCommand cmdNH = new SqlCommand(queryNhapHang, conn);
            conn.Close();
            conn.Open();
            object resultNH = cmdNH.ExecuteScalar();
            doanhThu.TienNhapHang = resultNH != null ? Convert.ToSingle(resultNH) : 0;
            conn.Close();

           
            string queryHoaDon = string.Format("SELECT COALESCE(SUM(ThanhTien), 0) FROM CTHD WHERE MaHD IN (SELECT MaHD FROM HOADON WHERE MONTH(NgayLapHD) = {0} AND YEAR(NgayLapHD) = {1})",
                thang, nam);

            SqlCommand cmdHD = new SqlCommand(queryHoaDon, conn);
            conn.Close();
            conn.Open();
            object resultHD = cmdHD.ExecuteScalar();
            doanhThu.TienHoaDon = resultHD != null ? Convert.ToSingle(resultHD) : 0;
            conn.Close();

            // Tính tổng doanh thu
            doanhThu.TongTien = doanhThu.TienNhapHang + doanhThu.TienHoaDon;

            return doanhThu;
        }


    }
}
