namespace qlcuahangdochoi.GUI
{
    partial class frm_TrangChuStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_DanhMuc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_DanhMuc = new System.Windows.Forms.GroupBox();
            this.btn_TKHoaDon = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_DanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 97);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(232, 33);
            this.btn_HoaDon.TabIndex = 2;
            this.btn_HoaDon.Text = "Hóa đơn";
            this.btn_HoaDon.UseVisualStyleBackColor = true;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.Location = new System.Drawing.Point(0, 58);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(232, 33);
            this.btn_NhapHang.TabIndex = 1;
            this.btn_NhapHang.Text = "Kho-Nhập hàng";
            this.btn_NhapHang.UseVisualStyleBackColor = true;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.Location = new System.Drawing.Point(0, 19);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(232, 33);
            this.btn_SanPham.TabIndex = 0;
            this.btn_SanPham.Text = "Sản phẩm";
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.Location = new System.Drawing.Point(85, 43);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Size = new System.Drawing.Size(76, 23);
            this.btn_DanhMuc.TabIndex = 3;
            this.btn_DanhMuc.Text = "Danh mục";
            this.btn_DanhMuc.UseVisualStyleBackColor = true;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::qlcuahangdochoi.Properties.Resources.spa;
            this.pictureBox1.Location = new System.Drawing.Point(250, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grp_DanhMuc
            // 
            this.grp_DanhMuc.Controls.Add(this.btn_TKHoaDon);
            this.grp_DanhMuc.Controls.Add(this.btn_HoaDon);
            this.grp_DanhMuc.Controls.Add(this.btn_SanPham);
            this.grp_DanhMuc.Controls.Add(this.btn_NhapHang);
            this.grp_DanhMuc.Location = new System.Drawing.Point(12, 72);
            this.grp_DanhMuc.Name = "grp_DanhMuc";
            this.grp_DanhMuc.Size = new System.Drawing.Size(232, 265);
            this.grp_DanhMuc.TabIndex = 4;
            this.grp_DanhMuc.TabStop = false;
            this.grp_DanhMuc.Text = "Danh mục nhân viên";
            // 
            // btn_TKHoaDon
            // 
            this.btn_TKHoaDon.Location = new System.Drawing.Point(0, 136);
            this.btn_TKHoaDon.Name = "btn_TKHoaDon";
            this.btn_TKHoaDon.Size = new System.Drawing.Size(232, 33);
            this.btn_TKHoaDon.TabIndex = 6;
            this.btn_TKHoaDon.Text = "Thống kê hóa đơn";
            this.btn_TKHoaDon.UseVisualStyleBackColor = true;
            this.btn_TKHoaDon.Click += new System.EventHandler(this.btn_TKHoaDon_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Location = new System.Drawing.Point(85, 343);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(76, 23);
            this.btn_DangXuat.TabIndex = 5;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // frm_TrangChuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 378);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.grp_DanhMuc);
            this.Controls.Add(this.btn_DanhMuc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_TrangChuStaff";
            this.Text = "TrangChuStaff";
            this.Load += new System.EventHandler(this.frm_TrangChuStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_DanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_DanhMuc;
        private System.Windows.Forms.GroupBox grp_DanhMuc;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_TKHoaDon;
    }
}