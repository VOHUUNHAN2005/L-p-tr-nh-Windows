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
using static qlcuahangdochoi.BUS.DangNhapBUS;
namespace qlcuahangdochoi.GUI
{
    public partial class frm_dangnhap : Form
    {
        private static  DangNhapBUS dnBUS = new DangNhapBUS();
        DataTable tk = dnBUS.thongTinDangNhap();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TaiKhoan.Text) || string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng không để trống tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TaiKhoan.Focus();
                txt_MatKhau.Focus();
                return;
            }
            else
            {
                DangNhapDTO _dn = new DangNhapDTO();
                _dn.TaiKhoan=txt_TaiKhoan.Text;
                _dn.MatKhau=txt_MatKhau.Text;

                string check = dnBUS.check_DangNhap(_dn);
                if (!string.IsNullOrEmpty(check))
                {
                    if(check == "nv01")
                    {
                        this.Hide();
                        var nhanvien = new frm_TrangChuAdmin();
                        nhanvien.Closed += (s, args) => this.Close();
                        nhanvien.Show();
                    }
                    else if (check == "staff")
                    {
                        //frm_TrangChuAdmin admin_Interface = new frm_TrangChuAdmin();
                        //this.Hide();
                        //admin_Interface.ShowDialog();
                        //this.Show();
                        this.Hide();
                        var nhanvien = new frm_TrangChuAdmin();
                        nhanvien.Closed += (s, args) => this.Close();
                        nhanvien.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat chuong trinh khong", "Thong Bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
                return;
            }
        }



        private void grb_DangNhap_Enter(object sender, EventArgs e)
        {

        }

    }
}
