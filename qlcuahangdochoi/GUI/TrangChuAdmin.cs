using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlcuahangdochoi.DTO;
using qlcuahangdochoi.DAO;
using qlcuahangdochoi.BUS;
using System.Data.SqlClient;

namespace qlcuahangdochoi.GUI
{
    
    public partial class frm_TrangChuAdmin : Form
    {
        private static DangNhapBUS dnBUS = new DangNhapBUS();
        DataTable tk = dnBUS.thongTinDangNhap();
        public frm_TrangChuAdmin()
        {
            InitializeComponent();
        }

        private void frm_TrangChuAdmin_Load(object sender, EventArgs e)
        {
            grp_DanhMuc.Visible = true;
        }

        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            if (grp_DanhMuc.Visible == false)
                grp_DanhMuc.Visible = true;
            else grp_DanhMuc.Visible = false;
        }

        private void btn_SP_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_SanPham();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_NhanVien();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_dangnhap();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            //frm_NhaCungCap NCC_interface = new frm_NhaCungCap();
            //this.Hide();
            //NCC_interface.ShowDialog();
            //this.Show();
            this.Hide();
            var nhanvien = new frm_NhaCungCap();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_NhapHang();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            //frm_HoaDon hoadon_Interface = new frm_HoaDon();
            //this.Hide();
            //hoadon_Interface.ShowDialog();
            //this.Show();
            this.Hide();
            var nhanvien = new frm_HoaDon();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_TKHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_DoanhThu();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }
    }
    
}
