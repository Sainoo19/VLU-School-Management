namespace Dunno.PView
{
    partial class FBienLai
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
            this.DT_LopHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_ThanhToan = new System.Windows.Forms.Button();
            this.DT_HocVien = new System.Windows.Forms.DataGridView();
            this.TB_MaLopHoc = new System.Windows.Forms.TextBox();
            this.TB_MaHocVien = new System.Windows.Forms.TextBox();
            this.TB_MaBienLai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_HuyThanhToan = new System.Windows.Forms.Button();
            this.DT_BienLai = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienLaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hocPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_HocPhi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DT_LopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_HocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BienLai)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DT_LopHoc
            // 
            this.DT_LopHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DT_LopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_LopHoc.Location = new System.Drawing.Point(0, 34);
            this.DT_LopHoc.Name = "DT_LopHoc";
            this.DT_LopHoc.Size = new System.Drawing.Size(443, 242);
            this.DT_LopHoc.TabIndex = 0;
            this.DT_LopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_LopHoc_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Biên Lai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Học Viên";
            // 
            // BTN_ThanhToan
            // 
            this.BTN_ThanhToan.Location = new System.Drawing.Point(541, 229);
            this.BTN_ThanhToan.Name = "BTN_ThanhToan";
            this.BTN_ThanhToan.Size = new System.Drawing.Size(98, 34);
            this.BTN_ThanhToan.TabIndex = 5;
            this.BTN_ThanhToan.Text = "Thanh Toán";
            this.BTN_ThanhToan.UseVisualStyleBackColor = true;
            this.BTN_ThanhToan.Click += new System.EventHandler(this.BTN_ThanhToan_Click);
            // 
            // DT_HocVien
            // 
            this.DT_HocVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DT_HocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_HocVien.Location = new System.Drawing.Point(0, 282);
            this.DT_HocVien.Name = "DT_HocVien";
            this.DT_HocVien.Size = new System.Drawing.Size(443, 279);
            this.DT_HocVien.TabIndex = 6;
            this.DT_HocVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_HocVien_CellClick);
            // 
            // TB_MaLopHoc
            // 
            this.TB_MaLopHoc.Location = new System.Drawing.Point(555, 136);
            this.TB_MaLopHoc.Name = "TB_MaLopHoc";
            this.TB_MaLopHoc.ReadOnly = true;
            this.TB_MaLopHoc.Size = new System.Drawing.Size(100, 20);
            this.TB_MaLopHoc.TabIndex = 9;
            // 
            // TB_MaHocVien
            // 
            this.TB_MaHocVien.Location = new System.Drawing.Point(735, 136);
            this.TB_MaHocVien.Name = "TB_MaHocVien";
            this.TB_MaHocVien.ReadOnly = true;
            this.TB_MaHocVien.Size = new System.Drawing.Size(100, 20);
            this.TB_MaHocVien.TabIndex = 10;
            // 
            // TB_MaBienLai
            // 
            this.TB_MaBienLai.Location = new System.Drawing.Point(555, 93);
            this.TB_MaBienLai.Name = "TB_MaBienLai";
            this.TB_MaBienLai.Size = new System.Drawing.Size(100, 20);
            this.TB_MaBienLai.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thanh Toán Học Phí";
            // 
            // BTN_HuyThanhToan
            // 
            this.BTN_HuyThanhToan.Location = new System.Drawing.Point(664, 229);
            this.BTN_HuyThanhToan.Name = "BTN_HuyThanhToan";
            this.BTN_HuyThanhToan.Size = new System.Drawing.Size(99, 34);
            this.BTN_HuyThanhToan.TabIndex = 13;
            this.BTN_HuyThanhToan.Text = "Huỷ";
            this.BTN_HuyThanhToan.UseVisualStyleBackColor = true;
            this.BTN_HuyThanhToan.Click += new System.EventHandler(this.BTN_HuyThanhToan_Click);
            // 
            // DT_BienLai
            // 
            this.DT_BienLai.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DT_BienLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_BienLai.Location = new System.Drawing.Point(449, 282);
            this.DT_BienLai.Name = "DT_BienLai";
            this.DT_BienLai.Size = new System.Drawing.Size(401, 279);
            this.DT_BienLai.TabIndex = 14;
            this.DT_BienLai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_BienLai_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.taiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienToolStripMenuItem,
            this.bienLaiToolStripMenuItem,
            this.hocPhanToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quanLyToolStripMenuItem.Text = "Quản Lý";
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sinhVienToolStripMenuItem.Text = "Học Viên";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // bienLaiToolStripMenuItem
            // 
            this.bienLaiToolStripMenuItem.Name = "bienLaiToolStripMenuItem";
            this.bienLaiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.bienLaiToolStripMenuItem.Text = "Lớp Học và Môn Học";
            this.bienLaiToolStripMenuItem.Click += new System.EventHandler(this.bienLaiToolStripMenuItem_Click);
            // 
            // hocPhanToolStripMenuItem
            // 
            this.hocPhanToolStripMenuItem.Name = "hocPhanToolStripMenuItem";
            this.hocPhanToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hocPhanToolStripMenuItem.Text = "Học Phần";
            this.hocPhanToolStripMenuItem.Click += new System.EventHandler(this.hocPhanToolStripMenuItem_Click);
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyTaiKhoanToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.taiKhoanToolStripMenuItem.Text = "Tài Khoản";
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.Name = "quanLyTaiKhoanToolStripMenuItem";
            this.quanLyTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quanLyTaiKhoanToolStripMenuItem.Text = "Quản Lý Tài Khoản";
            this.quanLyTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.quanLyTaiKhoanToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Image = global::Dunno.Properties.Resources.logout;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Học Phí";
            // 
            // TB_HocPhi
            // 
            this.TB_HocPhi.Location = new System.Drawing.Point(555, 180);
            this.TB_HocPhi.Name = "TB_HocPhi";
            this.TB_HocPhi.ReadOnly = true;
            this.TB_HocPhi.Size = new System.Drawing.Size(100, 20);
            this.TB_HocPhi.TabIndex = 23;
            // 
            // FBienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(849, 563);
            this.Controls.Add(this.TB_HocPhi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DT_BienLai);
            this.Controls.Add(this.BTN_HuyThanhToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_MaBienLai);
            this.Controls.Add(this.TB_MaHocVien);
            this.Controls.Add(this.TB_MaLopHoc);
            this.Controls.Add(this.DT_HocVien);
            this.Controls.Add(this.BTN_ThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DT_LopHoc);
            this.Name = "FBienLai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán Học Phí";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBienLai_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DT_LopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_HocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DT_BienLai)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DT_LopHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_ThanhToan;
        private System.Windows.Forms.DataGridView DT_HocVien;
        private System.Windows.Forms.TextBox TB_MaLopHoc;
        private System.Windows.Forms.TextBox TB_MaHocVien;
        private System.Windows.Forms.TextBox TB_MaBienLai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_HuyThanhToan;
        private System.Windows.Forms.DataGridView DT_BienLai;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bienLaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hocPhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_HocPhi;
    }
}