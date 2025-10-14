using qlcuahangdochoi.BUS;
using qlcuahangdochoi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;
//using DataTable = System.Data.DataTable;

//using DataTable = Microsoft.Office.Interop.Excel.DataTable;
namespace qlcuahangdochoi.GUI
{
    public partial class frm_NhaCungCap : Form
    {
        NhaCungCapBUS bus = new NhaCungCapBUS();

        public frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            txt_TenNCC.Focus();
            dgv_NhaCungCap.DataSource = bus.get_NCC();
        }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_TenNCC.Focus();
                return;
            }
            if (string.IsNullOrEmpty(rtb_DiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                rtb_DiaChi.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_SDT.Focus();
                return;
            }
            NhaCungCapDTO nccDTO= new NhaCungCapDTO();
            nccDTO.TenNCC=txt_TenNCC.Text;
            nccDTO.DiaChi = rtb_DiaChi.Text;
            nccDTO.SDT = txt_SDT.Text;
            if (bus.ThemNhaCungCap(nccDTO)){
                MessageBox.Show("Thêm thành công");
                dgv_NhaCungCap.DataSource = bus.get_NCC();
            }
            else MessageBox.Show("Thêm thất bại");
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_SDT.Clear();
            rtb_DiaChi.Clear();
            txt_TenNCC.Focus();
        }

        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nccDTO = new NhaCungCapDTO();
            if (string.IsNullOrEmpty(txt_MaNCC.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng!");
                return;
            }
            nccDTO.MaNCC = int.Parse(txt_MaNCC.Text);

            if (bus.XoaNhaCungCap(nccDTO))
            {
                MessageBox.Show("Xóa nhà cung cấp thành công");
                dgv_NhaCungCap.DataSource = bus.get_NCC();
            }
            else
            {
                MessageBox.Show("Xóa nhà cung cấp thất bại");
            }


        }

        private void btn_ChinhSuaNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_TenNCC.Focus();
                return;
            }
            if (string.IsNullOrEmpty(rtb_DiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                rtb_DiaChi.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_SDT.Focus();
                return;
            }
            NhaCungCapDTO nccDTO = new NhaCungCapDTO();
            nccDTO.MaNCC = int.Parse(txt_MaNCC.Text);
            nccDTO.TenNCC = txt_TenNCC.Text;
            nccDTO.DiaChi = rtb_DiaChi.Text;
            nccDTO.SDT = txt_SDT.Text;
            if (bus.CapNhatNhaCungCap(nccDTO)){
                MessageBox.Show("Cập nhật thành công");
                dgv_NhaCungCap.DataSource = bus.get_NCC();
            }
            else MessageBox.Show("Cập nhật thất bại");
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_SDT.Clear();
            rtb_DiaChi.Clear();
            txt_TenNCC.Focus();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_SDT.Clear();
            rtb_DiaChi.Clear();
            txt_TenNCC.Focus();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_TrangChuAdmin();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void grb_ThemSP_Enter(object sender, EventArgs e)
        {
            txt_TenNCC.Focus();
        }

        private void dgv_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_NhaCungCap.Rows.Count)
            {
                DataGridViewRow rows = dgv_NhaCungCap.Rows[e.RowIndex];
                txt_MaNCC.Text = rows.Cells[0].Value.ToString();
                txt_TenNCC.Text = rows.Cells[1].Value.ToString();
                rtb_DiaChi.Text = rows.Cells[2].Value.ToString();
                txt_SDT.Text = rows.Cells[3].Value.ToString();
            }
        }

        private void ExportExcel (string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgv_NhaCungCap.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgv_NhaCungCap.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgv_NhaCungCap.Rows.Count; i++) {
                for (int j = 0; j < dgv_NhaCungCap.Columns.Count; j++) {
                    application.Cells[i + 2, j +1] = dgv_NhaCungCap.Rows[i].Cells[j].Value;
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
                    MessageBox.Show("Xuất file không thành công"+ex.Message);
                }
            }
        }
        private void ImportExcel(string path)
        {
            
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                DataTable dt = new DataTable();
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dt.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for(int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for(int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dt.Rows.Add(listRows.ToArray());
                }
                dgv_NhaCungCap.DataSource = dt;

            }
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công" + ex.Message);
                }
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
