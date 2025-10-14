using qlcuahangdochoi.BUS;
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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace qlcuahangdochoi.GUI
{
    public partial class frm_SanPham : Form
    {
        private static SanPhamBUS spBUS1 = new SanPhamBUS();

        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            dgv_SanPham.DataSource = spBUS1.laySP();
            txt_TenSP.Focus();
            rdb_MaSP.Checked = true;
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            SanPhamDTO themSP = new SanPhamDTO();
            if (string.IsNullOrEmpty(txt_TenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_TenSP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_LoaiSP.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_LoaiSP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Gia.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_Gia.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SL.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_SL.Focus();
                return;
            }
            themSP.TenSP= txt_TenSP.Text;
            themSP.LoaiSP= txt_LoaiSP.Text;
            themSP.DonGia = float.Parse(txt_Gia.Text);
            themSP.SLTon=int.Parse(txt_SL.Text);
            themSP.MoTa = rtb_MoTa.Text;

            if(spBUS1.themSanPham(themSP))
            {
                dgv_SanPham.DataSource = spBUS1.laySP();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            txt_LoaiSP.Clear();
            txt_Gia.Clear();
            txt_SL.Clear();
            rtb_MoTa.Clear();
            txt_MaSP.Focus();
        }

        private void btn_ChinhSuaSP_Click(object sender, EventArgs e)
        {
            SanPhamDTO suaSP = new SanPhamDTO();
            if (string.IsNullOrEmpty(txt_MaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
                return;
            }
            if (string.IsNullOrEmpty(txt_TenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_TenSP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_LoaiSP.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_LoaiSP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Gia.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_Gia.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SL.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_SL.Focus();
                return;
            }
            suaSP.MaSP = int.Parse(txt_MaSP.Text);
            suaSP.TenSP = txt_TenSP.Text;
            suaSP.LoaiSP = txt_LoaiSP.Text;
            suaSP.DonGia = float.Parse(txt_Gia.Text);
            suaSP.SLTon = int.Parse(txt_SL.Text);
            suaSP.MoTa = rtb_MoTa.Text;
            if (spBUS1.suaSanPham(suaSP))
            {
                dgv_SanPham.DataSource = spBUS1.laySP();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            txt_LoaiSP.Clear();
            txt_Gia.Clear();
            txt_SL.Clear();
            rtb_MoTa.Clear();
            txt_MaSP.Focus();
        }
        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            SanPhamDTO xoaSP = new SanPhamDTO();
            if (string.IsNullOrEmpty(txt_MaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
                return;
            }
            xoaSP.MaSP=int.Parse(txt_MaSP.Text);
            if (spBUS1.xoasanpham(xoaSP))
            {
                
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            txt_LoaiSP.Clear();
            txt_Gia.Clear();
            txt_SL.Clear();
            rtb_MoTa.Clear();
            txt_MaSP.Focus();
            dgv_SanPham.DataSource = spBUS1.laySP();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
                txt_MaSP.Clear();
                txt_TenSP.Clear();
                txt_LoaiSP.Clear();
                txt_Gia.Clear();
                txt_SL.Clear();
                rtb_MoTa.Clear();
                txt_MaSP.Focus();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string searchValue = txt_Tim.Text;
            DangNhapDTO maSP1 = new DangNhapDTO();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm đúng để tìm kiếm");
                txt_Tim.Focus();
            }
            else
            {
                dgv_SanPham.DataSource = spBUS1.layMaSP(searchValue);
            }

        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_TrangChuAdmin();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void btn_XoaTimKiem_Click(object sender, EventArgs e)
        {
            dgv_SanPham.DataSource = spBUS1.laySP();
            txt_Tim.Clear();
        }

        private void grb_ThemSP_Enter(object sender, EventArgs e)
        {
            txt_TenSP.Focus();
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_SanPham.Rows.Count)
            {
                DataGridViewRow Rows = dgv_SanPham.Rows[e.RowIndex];
                txt_MaSP.Text = Rows.Cells[0].Value.ToString();
                txt_TenSP.Text = Rows.Cells[1].Value.ToString();
                txt_LoaiSP.Text = Rows.Cells[2].Value.ToString();
                txt_Gia.Text = Rows.Cells[3].Value.ToString();
                txt_SL.Text = Rows.Cells[4].Value.ToString();
                rtb_MoTa.Text = Rows.Cells[5].Value.ToString();
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgv_SanPham.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgv_SanPham.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgv_SanPham.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_SanPham.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgv_SanPham.Rows[i].Cells[j].Value;
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

        private void txt_Gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
