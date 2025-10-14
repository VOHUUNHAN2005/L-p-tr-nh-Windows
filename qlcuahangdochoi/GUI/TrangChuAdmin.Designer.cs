namespace qlcuahangdochoi.GUI
{
    partial class frm_TrangChuAdmin
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
            this.btn_NhaCungCap = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_DanhMuc = new System.Windows.Forms.Button();
            this.grp_DanhMuc = new System.Windows.Forms.GroupBox();
            this.btn_TKHoaDon = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_SP = new System.Windows.Forms.Button();
            this.btn_Kho = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grp_DanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.Location = new System.Drawing.Point(0, 175);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.Size = new System.Drawing.Size(232, 33);
            this.btn_NhaCungCap.TabIndex = 4;
            this.btn_NhaCungCap.Text = "Nhà cung cấp";
            this.btn_NhaCungCap.UseVisualStyleBackColor = true;
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_NhaCungCap_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 136);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(232, 33);
            this.btn_NhanVien.TabIndex = 3;
            this.btn_NhanVien.Text = "Nhân viên";
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.Location = new System.Drawing.Point(85, 12);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Size = new System.Drawing.Size(76, 23);
            this.btn_DanhMuc.TabIndex = 2;
            this.btn_DanhMuc.Text = "Danh mục";
            this.btn_DanhMuc.UseVisualStyleBackColor = true;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click);
            // 
            // grp_DanhMuc
            // 
            this.grp_DanhMuc.BackColor = System.Drawing.Color.RosyBrown;
            this.grp_DanhMuc.Controls.Add(this.btn_TKHoaDon);
            this.grp_DanhMuc.Controls.Add(this.btn_NhaCungCap);
            this.grp_DanhMuc.Controls.Add(this.btn_HoaDon);
            this.grp_DanhMuc.Controls.Add(this.btn_NhanVien);
            this.grp_DanhMuc.Controls.Add(this.btn_SP);
            this.grp_DanhMuc.Controls.Add(this.btn_Kho);
            this.grp_DanhMuc.Location = new System.Drawing.Point(12, 41);
            this.grp_DanhMuc.Name = "grp_DanhMuc";
            this.grp_DanhMuc.Size = new System.Drawing.Size(232, 265);
            this.grp_DanhMuc.TabIndex = 5;
            this.grp_DanhMuc.TabStop = false;
            this.grp_DanhMuc.Text = "Danh mục Admin";
            // 
            // btn_TKHoaDon
            // 
            this.btn_TKHoaDon.Location = new System.Drawing.Point(0, 214);
            this.btn_TKHoaDon.Name = "btn_TKHoaDon";
            this.btn_TKHoaDon.Size = new System.Drawing.Size(232, 33);
            this.btn_TKHoaDon.TabIndex = 5;
            this.btn_TKHoaDon.Text = "Thống kê hóa đơn";
            this.btn_TKHoaDon.UseVisualStyleBackColor = true;
            this.btn_TKHoaDon.Click += new System.EventHandler(this.btn_TKHoaDon_Click);
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
            // btn_SP
            // 
            this.btn_SP.Location = new System.Drawing.Point(0, 19);
            this.btn_SP.Name = "btn_SP";
            this.btn_SP.Size = new System.Drawing.Size(232, 33);
            this.btn_SP.TabIndex = 0;
            this.btn_SP.Text = "Sản phẩm";
            this.btn_SP.UseVisualStyleBackColor = true;
            this.btn_SP.Click += new System.EventHandler(this.btn_SP_Click);
            // 
            // btn_Kho
            // 
            this.btn_Kho.Location = new System.Drawing.Point(0, 58);
            this.btn_Kho.Name = "btn_Kho";
            this.btn_Kho.Size = new System.Drawing.Size(232, 33);
            this.btn_Kho.TabIndex = 1;
            this.btn_Kho.Text = "Kho-Nhập hàng";
            this.btn_Kho.UseVisualStyleBackColor = true;
            this.btn_Kho.Click += new System.EventHandler(this.btn_Kho_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.dang_xuat;
            this.btn_DangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DangXuat.Location = new System.Drawing.Point(85, 312);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(76, 54);
            this.btn_DangXuat.TabIndex = 6;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::qlcuahangdochoi.Properties.Resources.maybam;
            this.pictureBox1.Location = new System.Drawing.Point(250, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_TrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(613, 378);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.grp_DanhMuc);
            this.Controls.Add(this.btn_DanhMuc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_TrangChuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ Admin";
            this.Load += new System.EventHandler(this.frm_TrangChuAdmin_Load);
            this.grp_DanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_NhaCungCap;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_DanhMuc;
        private System.Windows.Forms.GroupBox grp_DanhMuc;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_SP;
        private System.Windows.Forms.Button btn_Kho;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_TKHoaDon;
    }
}