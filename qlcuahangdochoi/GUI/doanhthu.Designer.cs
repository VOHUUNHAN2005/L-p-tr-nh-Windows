namespace qlcuahangdochoi.GUI
{
    partial class frm_DoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_DoanhThu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.cmb_thang = new System.Windows.Forms.ComboBox();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 58);
            this.panel1.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(276, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 42);
            this.label11.TabIndex = 0;
            this.label11.Text = "Doanh thu";
            // 
            // dgv_DoanhThu
            // 
            this.dgv_DoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_DoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoanhThu.Location = new System.Drawing.Point(12, 88);
            this.dgv_DoanhThu.Name = "dgv_DoanhThu";
            this.dgv_DoanhThu.Size = new System.Drawing.Size(517, 300);
            this.dgv_DoanhThu.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Năm:";
            // 
            // txt_Nam
            // 
            this.txt_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nam.Location = new System.Drawing.Point(599, 178);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(160, 24);
            this.txt_Nam.TabIndex = 38;
            this.txt_Nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nam_KeyPress);
            // 
            // cmb_thang
            // 
            this.cmb_thang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_thang.FormattingEnabled = true;
            this.cmb_thang.Location = new System.Drawing.Point(599, 144);
            this.cmb_thang.Name = "cmb_thang";
            this.cmb_thang.Size = new System.Drawing.Size(160, 26);
            this.cmb_thang.TabIndex = 41;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.home;
            this.btn_TrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu.Location = new System.Drawing.Point(704, 403);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(80, 60);
            this.btn_TrangChu.TabIndex = 40;
            this.btn_TrangChu.UseVisualStyleBackColor = true;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackgroundImage = global::qlcuahangdochoi.Properties.Resources.kinhlupden;
            this.btn_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_check.Location = new System.Drawing.Point(599, 208);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 45);
            this.btn_check.TabIndex = 39;
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cmb_thang);
            this.Controls.Add(this.btn_TrangChu);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nam);
            this.Controls.Add(this.dgv_DoanhThu);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.frm_DoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_DoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.ComboBox cmb_thang;
    }
}