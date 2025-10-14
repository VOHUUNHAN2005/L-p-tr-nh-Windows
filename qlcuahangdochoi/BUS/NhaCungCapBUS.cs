using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DAO;
using qlcuahangdochoi.DTO;
namespace qlcuahangdochoi.BUS
{
    internal class NhaCungCapBUS
    {
        private NhaCungCapDAO nccDAO = new NhaCungCapDAO();

        public DataTable get_NCC() {
            return nccDAO.GetData_NhaCungCap();
        }
        public bool ThemNhaCungCap(NhaCungCapDTO nccDTO)
        {
            return nccDAO.themNhaCungCap(nccDTO);
        }
        public bool XoaNhaCungCap(NhaCungCapDTO nccDTO)
        {
            return nccDAO.xoaNhaCungCap(nccDTO);
        }
        public bool CapNhatNhaCungCap(NhaCungCapDTO nccDTO)
        {
            return nccDAO.editNhaCungCap(nccDTO);
        }
    }
}
