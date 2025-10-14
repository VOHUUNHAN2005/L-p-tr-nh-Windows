using qlcuahangdochoi.DAO;
using qlcuahangdochoi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DAO;
using qlcuahangdochoi.DTO;

namespace qlcuahangdochoi.BUS
{
    internal class DoanhThuBUS
    {
        private DoanhThuDAO dtDAO = new DoanhThuDAO();

        public DoanhThuDTO LayDoanhThu(int thang, int nam)
        {
            return dtDAO.LayDoanhThu(thang, nam);
        }

    }
}
