using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlcuahangdochoi.DTO;
using qlcuahangdochoi.DAO;
using qlcuahangdochoi.BUS;
using System.Data.SqlClient;

namespace qlcuahangdochoi.GUI
{
    public partial class frm_TrangChuStaff : Form
    {
        public frm_TrangChuStaff()
        {
            InitializeComponent();
        }

        private void frm_TrangChuStaff_Load(object sender, EventArgs e)
        {
            grp_DanhMuc.Visible = false;
        }

        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            if (grp_DanhMuc.Visible == false)
                grp_DanhMuc.Visible = true;
            else grp_DanhMuc.Visible = false; 
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_dangnhap();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_SanPham();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_HoaDon();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_NhapHang();
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
