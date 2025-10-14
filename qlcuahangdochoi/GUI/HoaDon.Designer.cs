namespace qlcuahangdochoi.GUI
{
    partial class frm_HoaDon
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
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grb_HoaDon = new System.Windows.Forms.GroupBox();
            this.rbtn_ChuaTT = new System.Windows.Forms.RadioButton();
            this.rbtn_DaTT = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_NgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_ChiTietHoaDonBan = new System.Windows.Forms.GroupBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_MaSP = new System.Windows.Forms.ComboBox();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_MaDon = new System.Windows.Forms.Label();
            this.dgv_CTHD = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_XoaCT = new System.Windows.Forms.Button();
            this.btn_ThemCT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.grb_ChiTietHoaDonBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(161, 418);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(151, 24);
            this.txt_TimKiem.TabIndex = 11;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimKiem_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tìm kiếm hóa đơn:";
            // 
            // grb_HoaDon
            // 
            this.grb_HoaDon.Controls.Add(this.rbtn_ChuaTT);
            this.grb_HoaDon.Controls.Add(this.rbtn_DaTT);
            this.grb_HoaDon.Controls.Add(this.label2);
            this.grb_HoaDon.Controls.Add(this.txt_MaHD);
            this.grb_HoaDon.Controls.Add(this.label1);
            this.grb_HoaDon.Controls.Add(this.txt_MaNV);
            this.grb_HoaDon.Controls.Add(this.label10);
            this.grb_HoaDon.Controls.Add(this.dtp_NgayLapHD);
            this.grb_HoaDon.Controls.Add(this.label3);
            this.grb_HoaDon.Location = new System.Drawing.Point(9, 70);
            this.grb_HoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.grb_HoaDon.Name = "grb_HoaDon";
            this.grb_HoaDon.Padding = new System.Windows.Forms.Padding(2);
            this.grb_HoaDon.Size = new System.Drawing.Size(332, 152);
            this.grb_HoaDon.TabIndex = 13;
            this.grb_HoaDon.TabStop = false;
            this.grb_HoaDon.Text = "Hóa đơn:";
            // 
            // rbtn_ChuaTT
            // 
            this.rbtn_ChuaTT.AutoSize = true;
            this.rbtn_ChuaTT.Checked = true;
            this.rbtn_ChuaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_ChuaTT.Location = new System.Drawing.Point(135, 110);
            this.rbtn_ChuaTT.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_ChuaTT.Name = "rbtn_ChuaTT";
            this.rbtn_ChuaTT.Size = new System.Drawing.Size(83, 22);
            this.rbtn_ChuaTT.TabIndex = 16;
            this.rbtn_ChuaTT.TabStop = true;
            this.rbtn_ChuaTT.Text = "Chưa TT";
            this.rbtn_ChuaTT.UseVisualStyleBackColor = true;
            // 
            // rbtn_DaTT
            // 
            this.rbtn_DaTT.AutoSize = true;
            this.rbtn_DaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_DaTT.Location = new System.Drawing.Point(240, 110);
            this.rbtn_DaTT.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_DaTT.Name = "rbtn_DaTT";
            this.rbtn_DaTT.Size = new System.Drawing.Size(67, 22);
            this.rbtn_DaTT.TabIndex = 15;
            this.rbtn_DaTT.Text = "Đã TT";
            this.rbtn_DaTT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trạng thái:";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHD.Location = new System.Drawing.Point(152, 20);
            this.txt_MaHD.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.ReadOnly = true;
            this.txt_MaHD.Size = new System.Drawing.Size(155, 24);
            this.txt_MaHD.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(187, 50);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(120, 24);
            this.txt_MaNV.TabIndex = 7;
            this.txt_MaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaNV_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mã nhân viên phụ trách:";
            // 
            // dtp_NgayLapHD
            // 
            this.dtp_NgayLapHD.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLapHD.Location = new System.Drawing.Point(152, 80);
            this.dtp_NgayLapHD.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayLapHD.Name = "dtp_NgayLapHD";
            this.dtp_NgayLapHD.Size = new System.Drawing.Size(154, 24);
            this.dtp_NgayLapHD.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập hàng:";
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_HoaDon.Location = new System.Drawing.Point(452, 70);
            this.dgv_HoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 62;
            this.dgv_HoaDon.RowTemplate.Height = 28;
            this.dgv_HoaDon.Size = new System.Drawing.Size(702, 150);
            this.dgv_HoaDon.TabIndex = 14;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayLapHD";
            this.Column2.HeaderText = "Ngày lập HD";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNV";
            this.Column3.HeaderText = "Mã NV";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TrangThai";
            this.Column4.HeaderText = "Trạng thái";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // grb_ChiTietHoaDonBan
            // 
            this.grb_ChiTietHoaDonBan.Controls.Add(this.txt_ThanhTien);
            this.grb_ChiTietHoaDonBan.Controls.Add(this.label6);
            this.grb_ChiTietHoaDonBan.Controls.Add(this.cbb_MaSP);
            this.grb_ChiTietHoaDonBan.Controls.Add(this.txt_SL);
            this.grb_ChiTietHoaDonBan.Controls.Add(this.label9);
            this.grb_ChiTietHoaDonBan.Controls.Add(this.txt_DonGia);
            this.grb_ChiTietHoaDonBan.Controls.Add(this.label8);
            this.grb_ChiTietHoaDonBan.Controls.Add(this.label5);
            this.grb_ChiTietHoaDonBan.Controls.Add(this.lbl_MaDon);
            this.grb_ChiTietHoaDonBan.Location = new System.Drawing.Point(9, 250);
            this.grb_ChiTietHoaDonBan.Margin = new System.Windows.Forms.Padding(2);
            this.grb_ChiTietHoaDonBan.Name = "grb_ChiTietHoaDonBan";
            this.grb_ChiTietHoaDonBan.Padding = new System.Windows.Forms.Padding(2);
            this.grb_ChiTietHoaDonBan.Size = new System.Drawing.Size(332, 150);
            this.grb_ChiTietHoaDonBan.TabIndex = 15;
            this.grb_ChiTietHoaDonBan.TabStop = false;
            this.grb_ChiTietHoaDonBan.Text = "Chi tiết hoá đơn:";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(152, 110);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(151, 24);
            this.txt_ThanhTien.TabIndex = 13;
            this.txt_ThanhTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ThanhTien_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thành tiền:";
            // 
            // cbb_MaSP
            // 
            this.cbb_MaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MaSP.FormattingEnabled = true;
            this.cbb_MaSP.Location = new System.Drawing.Point(152, 20);
            this.cbb_MaSP.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_MaSP.Name = "cbb_MaSP";
            this.cbb_MaSP.Size = new System.Drawing.Size(151, 26);
            this.cbb_MaSP.TabIndex = 9;
            // 
            // txt_SL
            // 
            this.txt_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(152, 80);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(151, 24);
            this.txt_SL.TabIndex = 8;
            this.txt_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SL_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số lượng:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(152, 50);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(151, 24);
            this.txt_DonGia.TabIndex = 6;
            this.txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Đơn giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // lbl_MaDon
            // 
            this.lbl_MaDon.AutoSize = true;
            this.lbl_MaDon.Location = new System.Drawing.Point(87, -4);
            this.lbl_MaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaDon.Name = "lbl_MaDon";
            this.lbl_MaDon.Size = new System.Drawing.Size(0, 13);
            this.lbl_MaDon.TabIndex = 1;
            // 
            // dgv_CTHD
            // 
            this.dgv_CTHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTHD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_CTHD.Location = new System.Drawing.Point(452, 250);
            this.dgv_CTHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_CTHD.Name = "dgv_CTHD";
            this.dgv_CTHD.RowHeadersWidth = 62;
            this.dgv_CTHD.RowTemplate.Height = 28;
            this.dgv_CTHD.Size = new System.Drawing.Size(702, 150);
            this.dgv_CTHD.TabIndex = 16;
            this.dgv_CTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTHD_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaHD";
            this.Column5.HeaderText = "Mã hóa đơn";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaSP";
            this.Column6.HeaderText = "Mã sản phẩm";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SL";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DonGia";
            this.Column8.HeaderText = "Đơn giá";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ThanhTien";
            this.Column9.HeaderText = "Thành tiền";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.xoa;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Xoa.Location = new System.Drawing.Point(350, 160);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 45);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.them;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Them.Location = new System.Drawing.Point(350, 100);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 45);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_XoaCT
            // 
            this.btn_XoaCT.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.xoa1;
            this.btn_XoaCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XoaCT.Location = new System.Drawing.Point(350, 330);
            this.btn_XoaCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaCT.Name = "btn_XoaCT";
            this.btn_XoaCT.Size = new System.Drawing.Size(75, 45);
            this.btn_XoaCT.TabIndex = 18;
            this.btn_XoaCT.UseVisualStyleBackColor = true;
            this.btn_XoaCT.Click += new System.EventHandler(this.btn_XoaCT_Click);
            // 
            // btn_ThemCT
            // 
            this.btn_ThemCT.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.them1;
            this.btn_ThemCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThemCT.Location = new System.Drawing.Point(350, 270);
            this.btn_ThemCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemCT.Name = "btn_ThemCT";
            this.btn_ThemCT.Size = new System.Drawing.Size(75, 45);
            this.btn_ThemCT.TabIndex = 17;
            this.btn_ThemCT.UseVisualStyleBackColor = true;
            this.btn_ThemCT.Click += new System.EventHandler(this.btn_ThemCT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 58);
            this.panel1.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(408, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 42);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hoá đơn";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.home;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.Location = new System.Drawing.Point(1087, 404);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(67, 60);
            this.btn_Thoat.TabIndex = 34;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_XoaCT);
            this.Controls.Add(this.btn_ThemCT);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dgv_CTHD);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grb_ChiTietHoaDonBan);
            this.Controls.Add(this.dgv_HoaDon);
            this.Controls.Add(this.grb_HoaDon);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.grb_HoaDon.ResumeLayout(false);
            this.grb_HoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.grb_ChiTietHoaDonBan.ResumeLayout(false);
            this.grb_ChiTietHoaDonBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grb_HoaDon;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtn_ChuaTT;
        private System.Windows.Forms.RadioButton rbtn_DaTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.GroupBox grb_ChiTietHoaDonBan;
        private System.Windows.Forms.ComboBox cbb_MaSP;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_MaDon;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_CTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_XoaCT;
        private System.Windows.Forms.Button btn_ThemCT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Thoat;
    }
}