namespace Dunno.PView
{
    partial class FTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.TB_TenHienThi = new System.Windows.Forms.TextBox();
            this.TB_MatKhau = new System.Windows.Forms.TextBox();
            this.DT_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.BTN_Them = new System.Windows.Forms.Button();
            this.BTN_Xoa = new System.Windows.Forms.Button();
            this.BTN_Sua = new System.Windows.Forms.Button();
            this.BTN_Tim = new System.Windows.Forms.Button();
            this.TB_Tim = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienLaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hocPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DT_TaiKhoan)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hiển Thị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật Khẩu";
            // 
            // TB_TenTaiKhoan
            // 
            this.TB_TenTaiKhoan.Location = new System.Drawing.Point(169, 87);
            this.TB_TenTaiKhoan.Name = "TB_TenTaiKhoan";
            this.TB_TenTaiKhoan.Size = new System.Drawing.Size(100, 20);
            this.TB_TenTaiKhoan.TabIndex = 4;
            // 
            // TB_TenHienThi
            // 
            this.TB_TenHienThi.Location = new System.Drawing.Point(169, 122);
            this.TB_TenHienThi.Name = "TB_TenHienThi";
            this.TB_TenHienThi.Size = new System.Drawing.Size(100, 20);
            this.TB_TenHienThi.TabIndex = 5;
            // 
            // TB_MatKhau
            // 
            this.TB_MatKhau.Location = new System.Drawing.Point(169, 160);
            this.TB_MatKhau.Name = "TB_MatKhau";
            this.TB_MatKhau.Size = new System.Drawing.Size(100, 20);
            this.TB_MatKhau.TabIndex = 6;
            // 
            // DT_TaiKhoan
            // 
            this.DT_TaiKhoan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DT_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_TaiKhoan.Location = new System.Drawing.Point(2, 225);
            this.DT_TaiKhoan.Name = "DT_TaiKhoan";
            this.DT_TaiKhoan.Size = new System.Drawing.Size(604, 226);
            this.DT_TaiKhoan.TabIndex = 7;
            this.DT_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_TaiKhoan_CellClick);
            // 
            // BTN_Them
            // 
            this.BTN_Them.Location = new System.Drawing.Point(396, 78);
            this.BTN_Them.Name = "BTN_Them";
            this.BTN_Them.Size = new System.Drawing.Size(87, 23);
            this.BTN_Them.TabIndex = 8;
            this.BTN_Them.Text = "Thêm";
            this.BTN_Them.UseVisualStyleBackColor = true;
            this.BTN_Them.Click += new System.EventHandler(this.BTN_Them_Click);
            // 
            // BTN_Xoa
            // 
            this.BTN_Xoa.Location = new System.Drawing.Point(489, 78);
            this.BTN_Xoa.Name = "BTN_Xoa";
            this.BTN_Xoa.Size = new System.Drawing.Size(88, 23);
            this.BTN_Xoa.TabIndex = 9;
            this.BTN_Xoa.Text = "Xoá";
            this.BTN_Xoa.UseVisualStyleBackColor = true;
            this.BTN_Xoa.Click += new System.EventHandler(this.BTN_Xoa_Click);
            // 
            // BTN_Sua
            // 
            this.BTN_Sua.Location = new System.Drawing.Point(396, 118);
            this.BTN_Sua.Name = "BTN_Sua";
            this.BTN_Sua.Size = new System.Drawing.Size(181, 23);
            this.BTN_Sua.TabIndex = 10;
            this.BTN_Sua.Text = "Sửa";
            this.BTN_Sua.UseVisualStyleBackColor = true;
            this.BTN_Sua.Click += new System.EventHandler(this.BTN_Sua_Click);
            // 
            // BTN_Tim
            // 
            this.BTN_Tim.Location = new System.Drawing.Point(396, 156);
            this.BTN_Tim.Name = "BTN_Tim";
            this.BTN_Tim.Size = new System.Drawing.Size(75, 23);
            this.BTN_Tim.TabIndex = 11;
            this.BTN_Tim.Text = "Tìm";
            this.BTN_Tim.UseVisualStyleBackColor = true;
            this.BTN_Tim.Click += new System.EventHandler(this.BTN_Tim_Click);
            // 
            // TB_Tim
            // 
            this.TB_Tim.Location = new System.Drawing.Point(477, 157);
            this.TB_Tim.Name = "TB_Tim";
            this.TB_Tim.Size = new System.Drawing.Size(100, 20);
            this.TB_Tim.TabIndex = 12;
            this.TB_Tim.TextChanged += new System.EventHandler(this.TB_Tim_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.taiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
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
            this.sinhVienToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sinhVienToolStripMenuItem.Text = "Học Viên";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // bienLaiToolStripMenuItem
            // 
            this.bienLaiToolStripMenuItem.Name = "bienLaiToolStripMenuItem";
            this.bienLaiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bienLaiToolStripMenuItem.Text = "Biên Lai";
            this.bienLaiToolStripMenuItem.Click += new System.EventHandler(this.bienLaiToolStripMenuItem_Click);
            // 
            // hocPhanToolStripMenuItem
            // 
            this.hocPhanToolStripMenuItem.Name = "hocPhanToolStripMenuItem";
            this.hocPhanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hocPhanToolStripMenuItem.Text = "Học Phần";
            this.hocPhanToolStripMenuItem.Click += new System.EventHandler(this.hocPhanToolStripMenuItem_Click);
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem});
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.taiKhoanToolStripMenuItem.Text = "Tài Khoản";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Image = global::Dunno.Properties.Resources.logout;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // FTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TB_Tim);
            this.Controls.Add(this.BTN_Tim);
            this.Controls.Add(this.BTN_Sua);
            this.Controls.Add(this.BTN_Xoa);
            this.Controls.Add(this.BTN_Them);
            this.Controls.Add(this.DT_TaiKhoan);
            this.Controls.Add(this.TB_MatKhau);
            this.Controls.Add(this.TB_TenHienThi);
            this.Controls.Add(this.TB_TenTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FTaiKhoan_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DT_TaiKhoan)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_TenTaiKhoan;
        private System.Windows.Forms.TextBox TB_TenHienThi;
        private System.Windows.Forms.TextBox TB_MatKhau;
        private System.Windows.Forms.DataGridView DT_TaiKhoan;
        private System.Windows.Forms.Button BTN_Them;
        private System.Windows.Forms.Button BTN_Xoa;
        private System.Windows.Forms.Button BTN_Sua;
        private System.Windows.Forms.Button BTN_Tim;
        private System.Windows.Forms.TextBox TB_Tim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bienLaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hocPhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
    }
}