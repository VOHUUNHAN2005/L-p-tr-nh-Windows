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

namespace qlcuahangdochoi.GUI
{
    public partial class frm_DoanhThu : Form
    {
        public frm_DoanhThu()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_thang.Text) || string.IsNullOrEmpty(txt_Nam.Text))
            {
                MessageBox.Show("Vui lòng nhập tháng và năm!");
                return;
            }

            int thang = int.Parse(cmb_thang.Text);
            int nam = int.Parse(txt_Nam.Text);

            DoanhThuBUS dtBus = new DoanhThuBUS();
            DoanhThuDTO dtDTO = dtBus.LayDoanhThu(thang, nam);

            DataTable dt = new DataTable();
            dt.Columns.Add("Tháng", typeof(int));
            dt.Columns.Add("Năm", typeof(int));
            dt.Columns.Add("Tiền nhập hàng", typeof(float));
            dt.Columns.Add("Tiền hóa đơn", typeof(float));
            dt.Columns.Add("Tổng tiền nhập lẫn hoá đơn", typeof(float));

            dt.Rows.Add(dtDTO.Thang, dtDTO.Nam, dtDTO.TienNhapHang, dtDTO.TienHoaDon, dtDTO.TongTien);
            dgv_DoanhThu.DataSource = dt;

        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nhanvien = new frm_TrangChuAdmin();
            nhanvien.Closed += (s, args) => this.Close();
            nhanvien.Show();
        }

        private void txt_Thang_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_DoanhThu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmb_thang.Items.Add(i);
            }
        }

        private void txt_Nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Nhập năm bằng số.","Thông báo");
                e.Handled = true;
            }
        }
    }
}
