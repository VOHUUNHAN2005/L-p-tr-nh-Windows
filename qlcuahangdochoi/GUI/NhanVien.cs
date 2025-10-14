using qlcuahangdochoi.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlcuahangdochoi.DTO;
using qlcuahangdochoi.DAO;
using qlcuahangdochoi.BUS;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace qlcuahangdochoi.GUI
{
    public partial class frm_NhanVien : Form
    {
        private static DangNhapBUS dnBUS = new DangNhapBUS();
        DataTable tk = dnBUS.thongTinDangNhap();

        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            txt_MaNV.Focus();
            rdb_Nam.Checked = true;
            cmb_Vaitro.TabIndex= 1;
            dgv_NhanVien.DataSource = dnBUS.thongTinDangNhap();
            rdb_MaNV.Checked = true;
            dtp_NgaySinh.MaxDate = DateTime.Today;
        }

        
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            DangNhapDTO nvDTOThem = new DangNhapDTO();
            if (string.IsNullOrEmpty(txt_TaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng không để trống tài khoản.", "Thông báo");
                txt_TaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng không để trống mật khẩu.", "Thông báo");
                txt_MatKhau.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_HoNV.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_HoNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_TenNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmb_Vaitro.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                cmb_Vaitro.Focus();
                return;
            }
            nvDTOThem.TaiKhoan = txt_TaiKhoan.Text;
            nvDTOThem.MatKhau = txt_MatKhau.Text;
            nvDTOThem.HoNV = txt_HoNV.Text;
            nvDTOThem.TenNV = txt_TenNV.Text;
            nvDTOThem.Vaitro = cmb_Vaitro.Text;
            nvDTOThem.NgaySinh = dtp_NgaySinh.Value;
            nvDTOThem.DiaChi = rtb_DiaChi.Text;
            if (rdb_Nam.Checked == true)
                nvDTOThem.GioiTinh = rdb_Nam.Text;
            else nvDTOThem.GioiTinh = rdb_Nu.Text;
            nvDTOThem.SDT = txt_SDT.Text;
            if (dnBUS.themNhanVien(nvDTOThem))
            {
                dgv_NhanVien.DataSource = dnBUS.thongTinDangNhap();
                MessageBox.Show("Thêm NV thành công");
            }
            else MessageBox.Show("Thêm NV thất bại");
            txt_MaNV.Clear();
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
            txt_HoNV.Clear();
            txt_TenNV.Clear();
            cmb_Vaitro.SelectedIndex = 0;
            dtp_NgaySinh.Value = DateTime.Today;
            rtb_DiaChi.Clear();
            rdb_Nam.Checked = true;
            txt_SDT.Clear();
            txt_TaiKhoan.Focus();

        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            DangNhapDTO xoaNV = new DangNhapDTO();
            if (string.IsNullOrEmpty(txt_MaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
                return;
            }
            xoaNV.MaNV = int.Parse(txt_MaNV.Text);
            if (dnBUS.xoaNhanVien(xoaNV))
            {
                dgv_NhanVien.DataSource = dnBUS.thongTinDangNhap();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            txt_MaNV.Clear();
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
            txt_HoNV.Clear();
            txt_TenNV.Clear();
            cmb_Vaitro.SelectedIndex = 0;
            dtp_NgaySinh.Value = DateTime.Today;
            rtb_DiaChi.Clear();
            rdb_Nam.Checked = true;
            txt_SDT.Clear();
            txt_TaiKhoan.Focus();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
                txt_MaNV.Clear();
                txt_TaiKhoan.Clear();
                txt_MatKhau.Clear();
                txt_HoNV.Clear();
                txt_TenNV.Clear();
                cmb_Vaitro.SelectedIndex = 0;
                dtp_NgaySinh.Value = DateTime.Today;
                rtb_DiaChi.Clear();
                rdb_Nam.Checked = true;
                txt_SDT.Clear();
                txt_MaNV.Focus();
        }

        private void btn_ChinhSuaNV_Click(object sender, EventArgs e)
        {

            DangNhapDTO suaNV = new DangNhapDTO();
            if (string.IsNullOrEmpty(txt_TaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng không để trống tài khoản.", "Thông báo");
                txt_TaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng không để trống mật khẩu.", "Thông báo");
                txt_MatKhau.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_HoNV.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_HoNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_TenNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmb_Vaitro.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                cmb_Vaitro.Focus();
                return;
            }
            suaNV.MaNV = int.Parse(txt_MaNV.Text);
            suaNV.TaiKhoan = txt_TaiKhoan.Text;
            suaNV.MatKhau = txt_MatKhau.Text;
            suaNV.HoNV = txt_HoNV.Text;
            suaNV.TenNV = txt_TenNV.Text;
            suaNV.Vaitro = cmb_Vaitro.Text;
            suaNV.NgaySinh = dtp_NgaySinh.Value;
            suaNV.DiaChi = rtb_DiaChi.Text;
            if (rdb_Nam.Checked == true)
                suaNV.GioiTinh = rdb_Nam.Text;
            else suaNV.GioiTinh = rdb_Nu.Text;
            suaNV.SDT = txt_SDT.Text;
            if (dnBUS.editNhanVien(suaNV))
            {
                dgv_NhanVien.DataSource = dnBUS.thongTinDangNhap();
                MessageBox.Show("Chỉnh sửa NV thành công");
            }
            else MessageBox.Show("Chỉnh sửa NV thất bại");
            txt_MaNV.Clear();
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
            txt_HoNV.Clear();
            txt_TenNV.Clear();
            cmb_Vaitro.SelectedIndex = 0;
            dtp_NgaySinh.Value = DateTime.Today;
            rtb_DiaChi.Clear();
            rdb_Nam.Checked = true;
            txt_SDT.Clear();
            txt_TaiKhoan.Focus();
        }



        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string searchValue = txt_TimNV.Text;
            DangNhapDTO maSP1= new DangNhapDTO();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm đúng để tìm kiếm");
                txt_TimNV.Focus();
            }
            else
            {
                dgv_NhanVien.DataSource = dnBUS.laymaNV(searchValue);
            }
        }

        private void btn_XoaTimKiem_Click(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = dnBUS.thongTinDangNhap();
            txt_TimNV.Clear();
        }

        private void grb_NhanVien_Enter(object sender, EventArgs e)
        {
            txt_TaiKhoan.Focus();
            cmb_Vaitro.SelectedIndex = 0;
        }

        private void btn_TrangChu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_TrangChuAdmin();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_NhanVien.Rows.Count)
            {
                DataGridViewRow rows = dgv_NhanVien.Rows[e.RowIndex];
                txt_MaNV.Text = rows.Cells[0].Value.ToString();
                txt_TaiKhoan.Text = rows.Cells[1].Value.ToString();
                txt_MatKhau.Text = rows.Cells[2].Value.ToString();
                txt_HoNV.Text = rows.Cells[3].Value.ToString();
                txt_TenNV.Text = rows.Cells[4].Value.ToString();
                cmb_Vaitro.Text = rows.Cells[5].Value.ToString();
                dtp_NgaySinh.Text = rows.Cells[6].Value.ToString();
                rtb_DiaChi.Text = rows.Cells[7].Value.ToString();
                if (rows.Cells[8].Value.ToString() == "Nam")
                {
                    rdb_Nam.Checked = true;
                }
                else
                {
                    rdb_Nu.Checked = true;
                }
                txt_SDT.Text = rows.Cells[9].Value.ToString();
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgv_NhanVien.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgv_NhanVien.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgv_NhanVien.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_NhanVien.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgv_NhanVien.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx) |*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công" + ex.Message);
                }
            }
        }
        private void txt_SDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
