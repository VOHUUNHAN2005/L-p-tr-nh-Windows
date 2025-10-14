namespace qlcuahangdochoi.GUI
{
    partial class frm_SanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_ThemSP = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChinhSuaSP = new System.Windows.Forms.Button();
            this.rtb_MoTa = new System.Windows.Forms.RichTextBox();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ThemSP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.txt_LoaiSP = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.grb_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_XoaTimKiem = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.rdb_MaSP = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_ThemSP.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.grb_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ThemSP
            // 
            this.grb_ThemSP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grb_ThemSP.Controls.Add(this.btn_export);
            this.grb_ThemSP.Controls.Add(this.btn_Reset);
            this.grb_ThemSP.Controls.Add(this.txt_MaSP);
            this.grb_ThemSP.Controls.Add(this.label1);
            this.grb_ThemSP.Controls.Add(this.btn_ChinhSuaSP);
            this.grb_ThemSP.Controls.Add(this.rtb_MoTa);
            this.grb_ThemSP.Controls.Add(this.btn_XoaSP);
            this.grb_ThemSP.Controls.Add(this.label2);
            this.grb_ThemSP.Controls.Add(this.btn_ThemSP);
            this.grb_ThemSP.Controls.Add(this.label3);
            this.grb_ThemSP.Controls.Add(this.label4);
            this.grb_ThemSP.Controls.Add(this.label5);
            this.grb_ThemSP.Controls.Add(this.label6);
            this.grb_ThemSP.Controls.Add(this.txt_TenSP);
            this.grb_ThemSP.Controls.Add(this.txt_SL);
            this.grb_ThemSP.Controls.Add(this.txt_LoaiSP);
            this.grb_ThemSP.Controls.Add(this.txt_Gia);
            this.grb_ThemSP.Location = new System.Drawing.Point(12, 62);
            this.grb_ThemSP.Name = "grb_ThemSP";
            this.grb_ThemSP.Size = new System.Drawing.Size(524, 385);
            this.grb_ThemSP.TabIndex = 31;
            this.grb_ThemSP.TabStop = false;
            this.grb_ThemSP.Text = "Sản phẩm";
            this.grb_ThemSP.Enter += new System.EventHandler(this.grb_ThemSP_Enter);
            // 
            // btn_export
            // 
            this.btn_export.BackgroundImage = global::qlcuahangdochoi.Properties.Resources._in;
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_export.Location = new System.Drawing.Point(400, 180);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 45);
            this.btn_export.TabIndex = 34;
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.reset;
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reset.Location = new System.Drawing.Point(300, 330);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 45);
            this.btn_Reset.TabIndex = 19;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_MaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSP.Location = new System.Drawing.Point(88, 32);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.ReadOnly = true;
            this.txt_MaSP.Size = new System.Drawing.Size(160, 24);
            this.txt_MaSP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SP:";
            // 
            // btn_ChinhSuaSP
            // 
            this.btn_ChinhSuaSP.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.chinh_sua;
            this.btn_ChinhSuaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChinhSuaSP.Location = new System.Drawing.Point(300, 282);
            this.btn_ChinhSuaSP.Name = "btn_ChinhSuaSP";
            this.btn_ChinhSuaSP.Size = new System.Drawing.Size(75, 45);
            this.btn_ChinhSuaSP.TabIndex = 15;
            this.btn_ChinhSuaSP.UseVisualStyleBackColor = true;
            this.btn_ChinhSuaSP.Click += new System.EventHandler(this.btn_ChinhSuaSP_Click);
            // 
            // rtb_MoTa
            // 
            this.rtb_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_MoTa.Location = new System.Drawing.Point(327, 26);
            this.rtb_MoTa.Name = "rtb_MoTa";
            this.rtb_MoTa.Size = new System.Drawing.Size(160, 62);
            this.rtb_MoTa.TabIndex = 18;
            this.rtb_MoTa.Text = "";
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.xoa;
            this.btn_XoaSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XoaSP.Location = new System.Drawing.Point(300, 231);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(75, 45);
            this.btn_XoaSP.TabIndex = 14;
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP:";
            // 
            // btn_ThemSP
            // 
            this.btn_ThemSP.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.them;
            this.btn_ThemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThemSP.Location = new System.Drawing.Point(300, 180);
            this.btn_ThemSP.Name = "btn_ThemSP";
            this.btn_ThemSP.Size = new System.Drawing.Size(75, 45);
            this.btn_ThemSP.TabIndex = 13;
            this.btn_ThemSP.UseVisualStyleBackColor = true;
            this.btn_ThemSP.Click += new System.EventHandler(this.btn_ThemSP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "SL tồn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mô tả:";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSP.Location = new System.Drawing.Point(88, 72);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(160, 24);
            this.txt_TenSP.TabIndex = 8;
            // 
            // txt_SL
            // 
            this.txt_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(88, 196);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(160, 24);
            this.txt_SL.TabIndex = 11;
            this.txt_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SL_KeyPress);
            // 
            // txt_LoaiSP
            // 
            this.txt_LoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiSP.Location = new System.Drawing.Point(88, 112);
            this.txt_LoaiSP.Name = "txt_LoaiSP";
            this.txt_LoaiSP.Size = new System.Drawing.Size(160, 24);
            this.txt_LoaiSP.TabIndex = 9;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gia.Location = new System.Drawing.Point(88, 154);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(160, 24);
            this.txt_Gia.TabIndex = 10;
            this.txt_Gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gia_KeyPress);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.home;
            this.btn_TrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu.Location = new System.Drawing.Point(544, 319);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(80, 60);
            this.btn_TrangChu.TabIndex = 20;
            this.btn_TrangChu.UseVisualStyleBackColor = true;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 56);
            this.panel1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(384, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sản Phẩm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SanPham.Location = new System.Drawing.Point(6, 19);
            this.dgv_SanPham.MultiSelect = false;
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.ReadOnly = true;
            this.dgv_SanPham.Size = new System.Drawing.Size(618, 118);
            this.dgv_SanPham.TabIndex = 0;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            // 
            // grb_TimKiem
            // 
            this.grb_TimKiem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grb_TimKiem.Controls.Add(this.btn_XoaTimKiem);
            this.grb_TimKiem.Controls.Add(this.btn_TrangChu);
            this.grb_TimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TimKiem.Controls.Add(this.txt_Tim);
            this.grb_TimKiem.Controls.Add(this.rdb_MaSP);
            this.grb_TimKiem.Controls.Add(this.dgv_SanPham);
            this.grb_TimKiem.Location = new System.Drawing.Point(546, 62);
            this.grb_TimKiem.Name = "grb_TimKiem";
            this.grb_TimKiem.Size = new System.Drawing.Size(630, 385);
            this.grb_TimKiem.TabIndex = 33;
            this.grb_TimKiem.TabStop = false;
            this.grb_TimKiem.Text = "Tìm kiếm";
            // 
            // btn_XoaTimKiem
            // 
            this.btn_XoaTimKiem.Location = new System.Drawing.Point(436, 267);
            this.btn_XoaTimKiem.Name = "btn_XoaTimKiem";
            this.btn_XoaTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaTimKiem.TabIndex = 21;
            this.btn_XoaTimKiem.Text = "Xóa";
            this.btn_XoaTimKiem.UseVisualStyleBackColor = true;
            this.btn_XoaTimKiem.Click += new System.EventHandler(this.btn_XoaTimKiem_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(355, 267);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 20;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tim.Location = new System.Drawing.Point(160, 267);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(173, 24);
            this.txt_Tim.TabIndex = 4;
            // 
            // rdb_MaSP
            // 
            this.rdb_MaSP.AutoSize = true;
            this.rdb_MaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_MaSP.Location = new System.Drawing.Point(11, 267);
            this.rdb_MaSP.Name = "rdb_MaSP";
            this.rdb_MaSP.Size = new System.Drawing.Size(143, 24);
            this.rdb_MaSP.TabIndex = 1;
            this.rdb_MaSP.TabStop = true;
            this.rdb_MaSP.Text = "Tìm theo mã SP:";
            this.rdb_MaSP.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSP";
            this.Column2.HeaderText = "Tên SP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LoaiSP";
            this.Column3.HeaderText = "Loại SP";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGia";
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SLTon";
            this.Column5.HeaderText = "SL tồn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MoTa";
            this.Column6.HeaderText = "Mô tả";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.grb_TimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grb_ThemSP);
            this.Name = "frm_SanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            this.grb_ThemSP.ResumeLayout(false);
            this.grb_ThemSP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.grb_TimKiem.ResumeLayout(false);
            this.grb_TimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ThemSP;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChinhSuaSP;
        private System.Windows.Forms.RichTextBox rtb_MoTa;
        private System.Windows.Forms.Button btn_XoaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ThemSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.TextBox txt_LoaiSP;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.GroupBox grb_TimKiem;
        private System.Windows.Forms.RadioButton rdb_MaSP;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Button btn_XoaTimKiem;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}