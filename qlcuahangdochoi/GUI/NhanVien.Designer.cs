namespace qlcuahangdochoi.GUI
{
    partial class frm_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_HoNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.rtb_DiaChi = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.cmb_Vaitro = new System.Windows.Forms.ComboBox();
            this.grb_NhanVien = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_ChinhSuaNV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.grb_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_XoaTimKiem = new System.Windows.Forms.Button();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimNV = new System.Windows.Forms.TextBox();
            this.rdb_MaNV = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.grb_NhanVien.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grb_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_NhanVien.Location = new System.Drawing.Point(6, 20);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.ReadOnly = true;
            this.dgv_NhanVien.Size = new System.Drawing.Size(618, 118);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mật khẩu:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(87, 14);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(145, 24);
            this.txt_MaNV.TabIndex = 10;
            // 
            // txt_HoNV
            // 
            this.txt_HoNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoNV.Location = new System.Drawing.Point(87, 134);
            this.txt_HoNV.Name = "txt_HoNV";
            this.txt_HoNV.Size = new System.Drawing.Size(145, 24);
            this.txt_HoNV.TabIndex = 11;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.Location = new System.Drawing.Point(87, 174);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(145, 24);
            this.txt_TenNV.TabIndex = 12;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(87, 54);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(145, 24);
            this.txt_TaiKhoan.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số ĐT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giới tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Địa chỉ:";
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nam.Location = new System.Drawing.Point(360, 94);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(60, 24);
            this.rdb_Nam.TabIndex = 20;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nu.Location = new System.Drawing.Point(450, 94);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(47, 24);
            this.rdb_Nu.TabIndex = 21;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // rtb_DiaChi
            // 
            this.rtb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_DiaChi.Location = new System.Drawing.Point(358, 13);
            this.rtb_DiaChi.Name = "rtb_DiaChi";
            this.rtb_DiaChi.Size = new System.Drawing.Size(145, 56);
            this.rtb_DiaChi.TabIndex = 22;
            this.rtb_DiaChi.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Vai trò:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ngày sinh:";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(86, 254);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(145, 24);
            this.dtp_NgaySinh.TabIndex = 26;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(87, 94);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(145, 24);
            this.txt_MatKhau.TabIndex = 27;
            // 
            // cmb_Vaitro
            // 
            this.cmb_Vaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vaitro.FormattingEnabled = true;
            this.cmb_Vaitro.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.cmb_Vaitro.Location = new System.Drawing.Point(86, 214);
            this.cmb_Vaitro.Name = "cmb_Vaitro";
            this.cmb_Vaitro.Size = new System.Drawing.Size(145, 26);
            this.cmb_Vaitro.TabIndex = 28;
            // 
            // grb_NhanVien
            // 
            this.grb_NhanVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grb_NhanVien.Controls.Add(this.btn_export);
            this.grb_NhanVien.Controls.Add(this.txt_SDT);
            this.grb_NhanVien.Controls.Add(this.btn_Reset);
            this.grb_NhanVien.Controls.Add(this.label1);
            this.grb_NhanVien.Controls.Add(this.btn_XoaNV);
            this.grb_NhanVien.Controls.Add(this.cmb_Vaitro);
            this.grb_NhanVien.Controls.Add(this.btn_ThemNV);
            this.grb_NhanVien.Controls.Add(this.txt_MatKhau);
            this.grb_NhanVien.Controls.Add(this.btn_ChinhSuaNV);
            this.grb_NhanVien.Controls.Add(this.dtp_NgaySinh);
            this.grb_NhanVien.Controls.Add(this.label2);
            this.grb_NhanVien.Controls.Add(this.label10);
            this.grb_NhanVien.Controls.Add(this.label3);
            this.grb_NhanVien.Controls.Add(this.label9);
            this.grb_NhanVien.Controls.Add(this.label4);
            this.grb_NhanVien.Controls.Add(this.rtb_DiaChi);
            this.grb_NhanVien.Controls.Add(this.label5);
            this.grb_NhanVien.Controls.Add(this.rdb_Nu);
            this.grb_NhanVien.Controls.Add(this.txt_MaNV);
            this.grb_NhanVien.Controls.Add(this.rdb_Nam);
            this.grb_NhanVien.Controls.Add(this.txt_HoNV);
            this.grb_NhanVien.Controls.Add(this.txt_TenNV);
            this.grb_NhanVien.Controls.Add(this.label8);
            this.grb_NhanVien.Controls.Add(this.txt_TaiKhoan);
            this.grb_NhanVien.Controls.Add(this.label7);
            this.grb_NhanVien.Controls.Add(this.label6);
            this.grb_NhanVien.Location = new System.Drawing.Point(12, 64);
            this.grb_NhanVien.Name = "grb_NhanVien";
            this.grb_NhanVien.Size = new System.Drawing.Size(524, 385);
            this.grb_NhanVien.TabIndex = 30;
            this.grb_NhanVien.TabStop = false;
            this.grb_NhanVien.Text = "Nhân viên";
            this.grb_NhanVien.Enter += new System.EventHandler(this.grb_NhanVien_Enter);
            // 
            // btn_export
            // 
            this.btn_export.BackgroundImage = global::qlcuahangdochoi.Properties.Resources._in;
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_export.Location = new System.Drawing.Point(400, 180);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 45);
            this.btn_export.TabIndex = 33;
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(360, 134);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(145, 24);
            this.txt_SDT.TabIndex = 30;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress_1);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.reset;
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reset.Location = new System.Drawing.Point(300, 327);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 45);
            this.btn_Reset.TabIndex = 29;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.xoa;
            this.btn_XoaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XoaNV.Location = new System.Drawing.Point(300, 229);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(75, 45);
            this.btn_XoaNV.TabIndex = 3;
            this.btn_XoaNV.UseVisualStyleBackColor = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.them;
            this.btn_ThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThemNV.Location = new System.Drawing.Point(300, 180);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(75, 45);
            this.btn_ThemNV.TabIndex = 4;
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_ChinhSuaNV
            // 
            this.btn_ChinhSuaNV.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.chinh_sua;
            this.btn_ChinhSuaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChinhSuaNV.Location = new System.Drawing.Point(300, 280);
            this.btn_ChinhSuaNV.Name = "btn_ChinhSuaNV";
            this.btn_ChinhSuaNV.Size = new System.Drawing.Size(75, 45);
            this.btn_ChinhSuaNV.TabIndex = 5;
            this.btn_ChinhSuaNV.UseVisualStyleBackColor = true;
            this.btn_ChinhSuaNV.Click += new System.EventHandler(this.btn_ChinhSuaNV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 58);
            this.panel1.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(408, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 42);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nhân Viên";
            // 
            // grb_TimKiem
            // 
            this.grb_TimKiem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grb_TimKiem.Controls.Add(this.btn_XoaTimKiem);
            this.grb_TimKiem.Controls.Add(this.btn_TrangChu);
            this.grb_TimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TimKiem.Controls.Add(this.txt_TimNV);
            this.grb_TimKiem.Controls.Add(this.rdb_MaNV);
            this.grb_TimKiem.Controls.Add(this.dgv_NhanVien);
            this.grb_TimKiem.Location = new System.Drawing.Point(542, 64);
            this.grb_TimKiem.Name = "grb_TimKiem";
            this.grb_TimKiem.Size = new System.Drawing.Size(630, 385);
            this.grb_TimKiem.TabIndex = 32;
            this.grb_TimKiem.TabStop = false;
            this.grb_TimKiem.Text = "Tìm kiếm";
            // 
            // btn_XoaTimKiem
            // 
            this.btn_XoaTimKiem.Location = new System.Drawing.Point(430, 255);
            this.btn_XoaTimKiem.Name = "btn_XoaTimKiem";
            this.btn_XoaTimKiem.Size = new System.Drawing.Size(75, 25);
            this.btn_XoaTimKiem.TabIndex = 26;
            this.btn_XoaTimKiem.Text = "Xóa";
            this.btn_XoaTimKiem.UseVisualStyleBackColor = true;
            this.btn_XoaTimKiem.Click += new System.EventHandler(this.btn_XoaTimKiem_Click);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.home;
            this.btn_TrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu.Location = new System.Drawing.Point(544, 319);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(80, 60);
            this.btn_TrangChu.TabIndex = 32;
            this.btn_TrangChu.UseVisualStyleBackColor = true;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click_1);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(349, 255);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 25);
            this.btn_TimKiem.TabIndex = 25;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimNV
            // 
            this.txt_TimNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimNV.Location = new System.Drawing.Point(160, 256);
            this.txt_TimNV.Name = "txt_TimNV";
            this.txt_TimNV.Size = new System.Drawing.Size(173, 24);
            this.txt_TimNV.TabIndex = 24;
            // 
            // rdb_MaNV
            // 
            this.rdb_MaNV.AutoSize = true;
            this.rdb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_MaNV.Location = new System.Drawing.Point(6, 254);
            this.rdb_MaNV.Name = "rdb_MaNV";
            this.rdb_MaNV.Size = new System.Drawing.Size(144, 24);
            this.rdb_MaNV.TabIndex = 21;
            this.rdb_MaNV.TabStop = true;
            this.rdb_MaNV.Text = "Tìm theo mã NV:";
            this.rdb_MaNV.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TaiKhoan";
            this.Column2.HeaderText = "Tài khoản";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatKhau";
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HoNV";
            this.Column4.HeaderText = "Họ NV";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenNV";
            this.Column5.HeaderText = "Tên NV";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Vaitro";
            this.Column6.HeaderText = "Vai trò";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgaySinh";
            this.Column7.HeaderText = "Ngày sinh";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DiaChi";
            this.Column8.HeaderText = "Địa chỉ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "GioiTinh";
            this.Column9.HeaderText = "Giới tính";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SDT";
            this.Column10.HeaderText = "Số ĐT";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.grb_TimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grb_NhanVien);
            this.Name = "frm_NhanVien";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.grb_NhanVien.ResumeLayout(false);
            this.grb_NhanVien.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_TimKiem.ResumeLayout(false);
            this.grb_TimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_ChinhSuaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_HoNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.RichTextBox rtb_DiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.ComboBox cmb_Vaitro;
        private System.Windows.Forms.GroupBox grb_NhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grb_TimKiem;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimNV;
        private System.Windows.Forms.RadioButton rdb_MaNV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Button btn_XoaTimKiem;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}