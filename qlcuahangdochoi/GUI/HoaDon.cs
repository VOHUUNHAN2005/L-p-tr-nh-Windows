using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlcuahangdochoi.BUS;
using qlcuahangdochoi.DAO;
using qlcuahangdochoi.DTO;

namespace qlcuahangdochoi.GUI
{
    public partial class frm_HoaDon : Form
    {
        CTHDBUS cthd = new CTHDBUS();
        HoaDonBUS hd = new HoaDonBUS();
        SanPhamBUS sp = new SanPhamBUS();
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dgv_CTHD.DataSource = cthd.LayCTHD();
            dgv_HoaDon.DataSource = hd.LayHoaDon();
            cbb_MaSP.DataSource = sp.laySP();
            cbb_MaSP.DisplayMember = "TenSP";
            cbb_MaSP.ValueMember = "MaSP";
            dgv_HoaDon.CellClick += dgv_HoaDon_CellClick;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            HoaDonDTO hdThem = new HoaDonDTO();
            if (string.IsNullOrEmpty(txt_MaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_MaNV.Focus();
                return;
            }
            hdThem.MaNV = int.Parse(txt_MaNV.Text);
            hdThem.NgayLapHD = dtp_NgayLapHD.Value;
            if (rbtn_ChuaTT.Checked == true)
            {
                hdThem.TrangThai = rbtn_ChuaTT.Text;
            }
            else if(rbtn_DaTT.Checked==true){
                hdThem.TrangThai= rbtn_DaTT.Text;
            }
            else
            {
                MessageBox.Show("Yêu cầu chọn 1 trạng thái!");
                return;
            }

            if (hd.ThemHoaDon(hdThem))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            rbtn_ChuaTT.Checked = false; 
            rbtn_DaTT.Checked = false;
            txt_MaNV.Clear();
            dtp_NgayLapHD.Value = DateTime.Now;
            dgv_CTHD.DataSource = cthd.LayCTHD();
            dgv_HoaDon.DataSource = hd.LayHoaDon();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            HoaDonDTO hdXoa = new HoaDonDTO();
            CTHDDTO cTHDXOA = new CTHDDTO();
            if (string.IsNullOrEmpty(txt_MaHD.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!");
                txt_MaHD.Focus();
                return;
            }
            hdXoa.MaHD = int.Parse(txt_MaHD.Text);
            cTHDXOA.MaHD = int.Parse(txt_MaHD.Text);
            if (hd.XoaHoaDon(hdXoa,cTHDXOA) && cthd.XoaChiTietHoaDonALL(cTHDXOA)) 
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                MessageBox.Show("Xóa thành công");
            }
            rbtn_ChuaTT.Checked = false;
            rbtn_DaTT.Checked = false;
            txt_MaNV.Clear();
            dtp_NgayLapHD.Value = DateTime.Now;
            dgv_CTHD.DataSource = cthd.LayCTHD();
            dgv_HoaDon.DataSource = hd.LayHoaDon();
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dgv_HoaDon.Rows[e.RowIndex];
            txt_MaHD.Text = rows.Cells[0].Value.ToString();
            dtp_NgayLapHD.Text = rows.Cells[1].Value.ToString();
            txt_MaNV.Text = rows.Cells[3].Value.ToString();

            string trangThai = rows.Cells[2].Value.ToString();

            
            if  (trangThai == rbtn_DaTT.Text)
            {

                rbtn_DaTT.Checked = true;

            }
            else
            {
                rbtn_ChuaTT.Checked = true;

            }
        }

        private void dgv_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dgv_CTHD.Rows[e.RowIndex];
            txt_MaHD.Text = rows.Cells[0].Value.ToString();
            cbb_MaSP.Text = rows.Cells[1].Value.ToString();
            txt_DonGia.Text = rows.Cells[3].Value.ToString();
            txt_SL.Text = rows.Cells[2].Value.ToString();
            txt_ThanhTien.Text = rows.Cells[4].Value.ToString();
        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {
            CTHDDTO cTHDThem = new CTHDDTO();
            if (string.IsNullOrEmpty(txt_MaHD.Text))
            {
                MessageBox.Show("Yêu cầu chọn 1 đơn mã");
                return;
            }
            if (string.IsNullOrEmpty(txt_DonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_DonGia.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SL.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_SL.Focus();
                return;
            }
            cTHDThem.MaHD = int.Parse(txt_MaHD.Text);//hd.LayMaTuTang());
            cTHDThem.MaSP = int.Parse(cbb_MaSP.SelectedValue.ToString());
            cTHDThem.DonGia = float.Parse(txt_DonGia.Text);
            cTHDThem.SL = int.Parse(txt_SL.Text);
            cTHDThem.ThanhTien= cthd.tinhThanhTien(cTHDThem);
            if (cthd.ThemChiTietHoaDon(cTHDThem))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            txt_MaHD.Clear();
            txt_DonGia.Clear();
            txt_SL.Clear();
            txt_ThanhTien.Clear();
            dgv_CTHD.DataSource = cthd.LayCTHD();
            dgv_HoaDon.DataSource = hd.LayHoaDon();
        }

        private void btn_XoaCT_Click(object sender, EventArgs e)
        {
            CTHDDTO cTHDXOA = new CTHDDTO();
            if (string.IsNullOrWhiteSpace(txt_MaHD.Text) || string.IsNullOrWhiteSpace(cbb_MaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Hóa Đơn và Mã Sản Phẩm!");
                return;
            }
            cTHDXOA.MaHD = int.Parse(txt_MaHD.Text);
            cTHDXOA.MaSP = int.Parse(cbb_MaSP.Text);

            if (cthd.XoaChiTietHoaDon(cTHDXOA))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            txt_MaHD.Clear();
            txt_DonGia.Clear();
            txt_SL.Clear();
            txt_ThanhTien.Clear();
            dgv_CTHD.DataSource = cthd.LayCTHD();
            dgv_HoaDon.DataSource = hd.LayHoaDon();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_TrangChuAdmin();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string MaHoaDon = txt_TimKiem.Text;
            HoaDonDTO MaHoaDonDTO = new HoaDonDTO();
            CTHDDTO MaCTHDDTO = new CTHDDTO();
            if (string.IsNullOrEmpty(MaHoaDon))
            {
                txt_TimKiem.Focus();
                dgv_HoaDon.DataSource = hd.LayHoaDon();
                dgv_CTHD.DataSource = cthd.LayCTHD();
            }
            else
            {
                dgv_HoaDon.DataSource = hd.LayMaNhapHang(MaHoaDon);
                dgv_CTHD.DataSource = cthd.LayMaHDCT(MaHoaDon);
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là ký tự điều khiển (ví dụ: Backspace)
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là ký tự điều khiển (ví dụ: Backspace)
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }
        }

        private void txt_ThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là ký tự điều khiển (ví dụ: Backspace)
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }
        }

        private void txt_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là ký tự điều khiển (ví dụ: Backspace)
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }
        }

        private void txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là ký tự điều khiển (ví dụ: Backspace)
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }
        }
    }
    
}
