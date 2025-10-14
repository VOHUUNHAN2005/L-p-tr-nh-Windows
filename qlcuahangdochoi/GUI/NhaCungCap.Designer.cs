namespace qlcuahangdochoi.GUI
{
    partial class frm_NhaCungCap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.grb_ThemSP = new System.Windows.Forms.GroupBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChinhSuaNCC = new System.Windows.Forms.Button();
            this.rtb_DiaChi = new System.Windows.Forms.RichTextBox();
            this.btn_XoaNCC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ThemNCC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.grb_NhaCungCap = new System.Windows.Forms.GroupBox();
            this.dgv_NhaCungCap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grb_ThemSP.SuspendLayout();
            this.grb_NhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 58);
            this.panel1.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(408, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 42);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nhà Cung Cấp";
            // 
            // grb_ThemSP
            // 
            this.grb_ThemSP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grb_ThemSP.Controls.Add(this.btn_Import);
            this.grb_ThemSP.Controls.Add(this.btn_export);
            this.grb_ThemSP.Controls.Add(this.btn_Reset);
            this.grb_ThemSP.Controls.Add(this.txt_MaNCC);
            this.grb_ThemSP.Controls.Add(this.label1);
            this.grb_ThemSP.Controls.Add(this.btn_ChinhSuaNCC);
            this.grb_ThemSP.Controls.Add(this.rtb_DiaChi);
            this.grb_ThemSP.Controls.Add(this.btn_XoaNCC);
            this.grb_ThemSP.Controls.Add(this.label2);
            this.grb_ThemSP.Controls.Add(this.btn_ThemNCC);
            this.grb_ThemSP.Controls.Add(this.label3);
            this.grb_ThemSP.Controls.Add(this.label5);
            this.grb_ThemSP.Controls.Add(this.txt_TenNCC);
            this.grb_ThemSP.Controls.Add(this.txt_SDT);
            this.grb_ThemSP.Location = new System.Drawing.Point(12, 64);
            this.grb_ThemSP.Name = "grb_ThemSP";
            this.grb_ThemSP.Size = new System.Drawing.Size(524, 385);
            this.grb_ThemSP.TabIndex = 33;
            this.grb_ThemSP.TabStop = false;
            this.grb_ThemSP.Text = "Sản phẩm";
            this.grb_ThemSP.Enter += new System.EventHandler(this.grb_ThemSP_Enter);
            // 
            // btn_Import
            // 
            this.btn_Import.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.import;
            this.btn_Import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Import.Location = new System.Drawing.Point(403, 143);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 45);
            this.btn_Import.TabIndex = 22;
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_export
            // 
            this.btn_export.BackgroundImage = global::qlcuahangdochoi.Properties.Resources._in;
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_export.Location = new System.Drawing.Point(403, 92);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 45);
            this.btn_export.TabIndex = 21;
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.reset;
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reset.Location = new System.Drawing.Point(300, 245);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 45);
            this.btn_Reset.TabIndex = 19;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_MaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNCC.Location = new System.Drawing.Point(93, 30);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.ReadOnly = true;
            this.txt_MaNCC.Size = new System.Drawing.Size(160, 24);
            this.txt_MaNCC.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NCC:";
            // 
            // btn_ChinhSuaNCC
            // 
            this.btn_ChinhSuaNCC.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.chinh_sua;
            this.btn_ChinhSuaNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChinhSuaNCC.Location = new System.Drawing.Point(300, 194);
            this.btn_ChinhSuaNCC.Name = "btn_ChinhSuaNCC";
            this.btn_ChinhSuaNCC.Size = new System.Drawing.Size(75, 45);
            this.btn_ChinhSuaNCC.TabIndex = 15;
            this.btn_ChinhSuaNCC.UseVisualStyleBackColor = true;
            this.btn_ChinhSuaNCC.Click += new System.EventHandler(this.btn_ChinhSuaNCC_Click);
            // 
            // rtb_DiaChi
            // 
            this.rtb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_DiaChi.Location = new System.Drawing.Point(93, 110);
            this.rtb_DiaChi.Name = "rtb_DiaChi";
            this.rtb_DiaChi.Size = new System.Drawing.Size(160, 62);
            this.rtb_DiaChi.TabIndex = 18;
            this.rtb_DiaChi.Text = "";
            // 
            // btn_XoaNCC
            // 
            this.btn_XoaNCC.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.xoa;
            this.btn_XoaNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XoaNCC.Location = new System.Drawing.Point(300, 143);
            this.btn_XoaNCC.Name = "btn_XoaNCC";
            this.btn_XoaNCC.Size = new System.Drawing.Size(75, 45);
            this.btn_XoaNCC.TabIndex = 14;
            this.btn_XoaNCC.UseVisualStyleBackColor = true;
            this.btn_XoaNCC.Click += new System.EventHandler(this.btn_XoaNCC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NCC:";
            // 
            // btn_ThemNCC
            // 
            this.btn_ThemNCC.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.them;
            this.btn_ThemNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThemNCC.Location = new System.Drawing.Point(300, 92);
            this.btn_ThemNCC.Name = "btn_ThemNCC";
            this.btn_ThemNCC.Size = new System.Drawing.Size(75, 45);
            this.btn_ThemNCC.TabIndex = 13;
            this.btn_ThemNCC.UseVisualStyleBackColor = true;
            this.btn_ThemNCC.Click += new System.EventHandler(this.btn_ThemNCC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số ĐT:";
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNCC.Location = new System.Drawing.Point(93, 70);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(160, 24);
            this.txt_TenNCC.TabIndex = 8;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(93, 190);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(160, 24);
            this.txt_SDT.TabIndex = 11;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
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
            // grb_NhaCungCap
            // 
            this.grb_NhaCungCap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.grb_NhaCungCap.Controls.Add(this.dgv_NhaCungCap);
            this.grb_NhaCungCap.Controls.Add(this.btn_TrangChu);
            this.grb_NhaCungCap.Location = new System.Drawing.Point(542, 64);
            this.grb_NhaCungCap.Name = "grb_NhaCungCap";
            this.grb_NhaCungCap.Size = new System.Drawing.Size(630, 385);
            this.grb_NhaCungCap.TabIndex = 34;
            this.grb_NhaCungCap.TabStop = false;
            this.grb_NhaCungCap.Text = "Danh sách nhà cung cấp";
            // 
            // dgv_NhaCungCap
            // 
            this.dgv_NhaCungCap.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhaCungCap.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_NhaCungCap.Location = new System.Drawing.Point(6, 19);
            this.dgv_NhaCungCap.MultiSelect = false;
            this.dgv_NhaCungCap.Name = "dgv_NhaCungCap";
            this.dgv_NhaCungCap.ReadOnly = true;
            this.dgv_NhaCungCap.Size = new System.Drawing.Size(618, 118);
            this.dgv_NhaCungCap.TabIndex = 0;
            this.dgv_NhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhaCungCap_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNCC";
            this.Column1.HeaderText = "Mã nhà cung cấp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên nhà cung cấp";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số ĐT";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // frm_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.grb_NhaCungCap);
            this.Controls.Add(this.grb_ThemSP);
            this.Controls.Add(this.panel1);
            this.Name = "frm_NhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_ThemSP.ResumeLayout(false);
            this.grb_ThemSP.PerformLayout();
            this.grb_NhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grb_ThemSP;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChinhSuaNCC;
        private System.Windows.Forms.RichTextBox rtb_DiaChi;
        private System.Windows.Forms.Button btn_XoaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ThemNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.GroupBox grb_NhaCungCap;
        private System.Windows.Forms.DataGridView dgv_NhaCungCap;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}