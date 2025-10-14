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
using qlcuahangdochoi.DTO;

namespace qlcuahangdochoi.GUI
{
    public partial class frm_NhapHang : Form
    {
        NhapHangBUS nh = new NhapHangBUS();
        SanPhamBUS sp = new SanPhamBUS();
        CTHDNhapBUS ctdhn = new CTHDNhapBUS();
        public frm_NhapHang()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhapHangDTO nhThem = new NhapHangDTO();
            if (string.IsNullOrEmpty(txt_MaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_MaNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_MaNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_MaNCC.Focus();
                return;
            }
            nhThem.NgayNhapHang = dtp_NgayNhapHang.Value;
            nhThem.MaNV = int.Parse(txt_MaNV.Text);
            nhThem.MaNCC = int.Parse(txt_MaNCC.Text);
            
            if (nh.ThemNhapHang(nhThem))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");

            txt_MaNhapHang.Clear();
            txt_MaNV.Clear();
            txt_MaNCC.Clear();
            dtp_NgayNhapHang.Value = DateTime.Now;
            dgv_NhapHang.DataSource = nh.LayDonHang();
            dgv_ChiTietDonHang.DataSource = ctdhn.LayChiTietDonNhap();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            dgv_NhapHang.DataSource = nh.LayDonHang();
            dgv_ChiTietDonHang.DataSource = ctdhn.LayChiTietDonNhap();
            cbb_MaSP.DataSource = sp.laySP();
            cbb_MaSP.DisplayMember = "TenSP";
            cbb_MaSP.ValueMember = "MaSP";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            NhapHangDTO nhXoa = new NhapHangDTO();
            CTHDNhapDTO cTHDNhapXOA = new CTHDNhapDTO();

            nhXoa.MaNhapHang = int.Parse(txt_MaNhapHang.Text);
            cTHDNhapXOA.MaNhapHang = int.Parse(txt_MaNhapHang.Text);

            if (nh.XoaNhapHang(nhXoa) && ctdhn.XoaChiTietNhapHangALL(cTHDNhapXOA))
            {
                    MessageBox.Show("Xóa thành công");
            }
            else
            {
                    MessageBox.Show("Xóa thất bại");
            }
            txt_MaNhapHang.Clear();
            txt_MaNV.Clear();
            txt_MaNCC.Clear();
            dtp_NgayNhapHang.Value = DateTime.Now;
            dgv_NhapHang.DataSource = nh.LayDonHang();
            dgv_ChiTietDonHang.DataSource = ctdhn.LayChiTietDonNhap();
        }

        private void dgv_NhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dgv_NhapHang.Rows[e.RowIndex];
            txt_MaNhapHang.Text = rows.Cells[0].Value.ToString();
            //txt_MaNhapHang.Text = (nh.LayMaTuTang());
            dtp_NgayNhapHang.Text = rows.Cells[1].Value.ToString();
            txt_MaNV.Text = rows.Cells[2].Value.ToString();
            txt_MaNCC.Text = rows.Cells[3].Value.ToString();
            //DataGridViewRow rowss = dgv_ChiTietDonHang.Rows[e.RowIndex];
            //txt_MaNhapHang.Text = rowss.Cells[0].Value.ToString();
            //cbb_MaSP.Text = rowss.Cells[1].Value.ToString();
        }

        private void dgv_ChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dgv_ChiTietDonHang.Rows[e.RowIndex];
            cbb_MaSP.Text = rows.Cells[1].Value.ToString();
            txt_DonGiaHang.Text = rows.Cells[2].Value.ToString();
            txt_SLHang.Text = rows.Cells[3].Value.ToString();
            txt_TongTienHang.Text =rows.Cells[4].Value.ToString();
            dgv_NhapHang_CellClick(sender, e);
        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {
            CTHDNhapDTO cTHDNhapThem = new CTHDNhapDTO();
            if (string.IsNullOrEmpty(txt_MaNhapHang.Text))
            {
                MessageBox.Show("Yêu cầu chọn 1 đơn mã");
                return;
            }
            //string maMoi = txt_MaNhapHang.Text.Trim();
            //bool trungLap = false;
            //foreach (DataGridViewRow row in dgv_ChiTietDonHang.Rows)
            //{
            //    if (row.Cells["Column9"].Value != null && row.Cells["Column9"].Value.ToString().Trim() == maMoi)
            //    {
            //        trungLap = true;
            //        break;
            //    }
                
            //}

            //if (trungLap)
            //{
            //    MessageBox.Show("Mã nhập hàng này đã tồn tại. Vui lòng thêm mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    // Xóa nội dung TextBox hoặc thực hiện hành động phù hợp khác
            //    txt_MaNhapHang.Clear();
            //    return;
            //}

            if (string.IsNullOrEmpty(txt_DonGiaHang.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_DonGiaHang.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SLHang.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu vào!");
                txt_SLHang.Focus();
                return;
            }
            cTHDNhapThem.MaNhapHang = int.Parse(txt_MaNhapHang.Text);//nh.LayMaTuTang());
            cTHDNhapThem.MaSP = int.Parse(cbb_MaSP.SelectedValue.ToString());
            cTHDNhapThem.DonGiaHang = float.Parse(txt_DonGiaHang.Text);
            cTHDNhapThem.SLHang = int.Parse(txt_SLHang.Text);
            cTHDNhapThem.TongTienHang = ctdhn.tinhTongTienHang(cTHDNhapThem);
            if (ctdhn.ThemChiTietNhapHang(cTHDNhapThem))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            txt_MaNhapHang.Clear();
            txt_TongTienHang.Clear();
            txt_DonGiaHang.Clear();
            txt_SLHang.Clear();
            txt_TongTienHang.Clear();
            dgv_NhapHang.DataSource = nh.LayDonHang();
            dgv_ChiTietDonHang.DataSource = ctdhn.LayChiTietDonNhap();
        }

        //private void btn_TimKiem_Click(object sender, EventArgs e)
        //{
        //    string MaNhapHang = txt_TimKiem.Text;
        //    NhapHangDTO MaNhapHangDTO = new NhapHangDTO();
        //    CTHDNhapDTO MaCTHDNhapDTO = new CTHDNhapDTO();
        //    if (string.IsNullOrEmpty(MaNhapHang))
        //    {
        //        MessageBox.Show("Vui lòng nhập mã nhập hàng");
        //        txt_TimKiem.Focus();
        //        dgv_NhapHang.DataSource = nh.LayDonHang();
        //        dgv_ChiTietDonHang.DataSource = ctdhn.LayChiTietDonNhap();
        //    }
        //    else
        //    {
        //        dgv_ChiTietDonHang.DataSource = ctdhn.LayMaNhapHangCT(MaNhapHang);
        //        dgv_NhapHang.DataSource = nh.LayMaNhapHang(MaNhapHang);
        //    }
        //}

        private void txt_MaNV_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_MaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là ký tự điều khiển (ví dụ: Backspace)
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }
        }

        private void txt_DonGiaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là ký tự điều khiển (ví dụ: Backspace)
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }
        }

        private void txt_SLHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải là số và không phải là ký tự điều khiển (ví dụ: Backspace)
                e.Handled = true; // Ngăn ký tự được nhập vào TextBox
            }
        }

        private void btn_XoaCT_Click(object sender, EventArgs e)
        {
            CTHDNhapDTO cTHDNhapXOA = new CTHDNhapDTO();
            if (string.IsNullOrWhiteSpace(txt_MaNhapHang.Text) || string.IsNullOrWhiteSpace(cbb_MaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Nhập Hàng và Mã Sản Phẩm!");
                return;
            }
            cTHDNhapXOA.MaNhapHang = int.Parse(txt_MaNhapHang.Text);
            cTHDNhapXOA.MaSP = int.Parse(cbb_MaSP.Text);

            if (ctdhn.XoaChiTietNhapHang(cTHDNhapXOA))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            txt_MaNhapHang.Clear();
            txt_TongTienHang.Clear();
            txt_DonGiaHang.Clear();
            txt_SLHang.Clear();
            txt_TongTienHang.Clear();
            dgv_NhapHang.DataSource = nh.LayDonHang();
            dgv_ChiTietDonHang.DataSource = ctdhn.LayChiTietDonNhap();
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
            string MaNhapHang = txt_TimKiem.Text;
            NhapHangDTO MaNhapHangDTO = new NhapHangDTO();
            CTHDNhapDTO MaCTHDNhapDTO = new CTHDNhapDTO();
            if (string.IsNullOrEmpty(MaNhapHang))
            {
                txt_TimKiem.Focus();
                dgv_NhapHang.DataSource = nh.LayDonHang();
                dgv_ChiTietDonHang.DataSource = ctdhn.LayChiTietDonNhap();
            }
            else
            {
                dgv_ChiTietDonHang.DataSource = ctdhn.LayMaNhapHangCT(MaNhapHang);
                dgv_NhapHang.DataSource = nh.LayMaNhapHang(MaNhapHang);
            }
        }
    }
}
