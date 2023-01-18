namespace Dunno.PView
{
    partial class FHocPhan
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienLaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hocPhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_FInd = new System.Windows.Forms.TextBox();
            this.BTN_Tim = new System.Windows.Forms.Button();
            this.BTN_Sua = new System.Windows.Forms.Button();
            this.BTN_Xoa = new System.Windows.Forms.Button();
            this.BTN_Them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBB_MaLopHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_TenHocPhan = new System.Windows.Forms.TextBox();
            this.TB_MaHocPhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DT_HocPhan = new System.Windows.Forms.DataGridView();
            this.trungTamDunnoDataSet = new Dunno.TrungTamDunnoDataSet();
            this.trungTamDunnoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DT_HocPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamDunnoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamDunnoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.taiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
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
            this.bienLaiToolStripMenuItem.Text = "Biên Lai";
            this.bienLaiToolStripMenuItem.Click += new System.EventHandler(this.bienLaiToolStripMenuItem_Click);
            // 
            // hocPhanToolStripMenuItem
            // 
            this.hocPhanToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hocPhanToolStripMenuItem.Name = "hocPhanToolStripMenuItem";
            this.hocPhanToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hocPhanToolStripMenuItem.Text = "Lớp Học và Môn Học";
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
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quản Lý Học Phần";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_FInd);
            this.panel1.Controls.Add(this.BTN_Tim);
            this.panel1.Controls.Add(this.BTN_Sua);
            this.panel1.Controls.Add(this.BTN_Xoa);
            this.panel1.Controls.Add(this.BTN_Them);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 79);
            this.panel1.TabIndex = 23;
            // 
            // TB_FInd
            // 
            this.TB_FInd.Location = new System.Drawing.Point(388, 31);
            this.TB_FInd.Name = "TB_FInd";
            this.TB_FInd.Size = new System.Drawing.Size(117, 20);
            this.TB_FInd.TabIndex = 4;
            this.TB_FInd.TextChanged += new System.EventHandler(this.TB_FInd_TextChanged);
            // 
            // BTN_Tim
            // 
            this.BTN_Tim.Location = new System.Drawing.Point(498, 29);
            this.BTN_Tim.Name = "BTN_Tim";
            this.BTN_Tim.Size = new System.Drawing.Size(75, 23);
            this.BTN_Tim.TabIndex = 3;
            this.BTN_Tim.Text = "Tìm";
            this.BTN_Tim.UseVisualStyleBackColor = true;
            this.BTN_Tim.Click += new System.EventHandler(this.BTN_Tim_Click);
            // 
            // BTN_Sua
            // 
            this.BTN_Sua.Location = new System.Drawing.Point(209, 28);
            this.BTN_Sua.Name = "BTN_Sua";
            this.BTN_Sua.Size = new System.Drawing.Size(75, 23);
            this.BTN_Sua.TabIndex = 2;
            this.BTN_Sua.Text = "Sửa";
            this.BTN_Sua.UseVisualStyleBackColor = true;
            this.BTN_Sua.Click += new System.EventHandler(this.BTN_Sua_Click);
            // 
            // BTN_Xoa
            // 
            this.BTN_Xoa.Location = new System.Drawing.Point(119, 28);
            this.BTN_Xoa.Name = "BTN_Xoa";
            this.BTN_Xoa.Size = new System.Drawing.Size(75, 23);
            this.BTN_Xoa.TabIndex = 1;
            this.BTN_Xoa.Text = "Xoá";
            this.BTN_Xoa.UseVisualStyleBackColor = true;
            this.BTN_Xoa.Click += new System.EventHandler(this.BTN_Xoa_Click);
            // 
            // BTN_Them
            // 
            this.BTN_Them.Location = new System.Drawing.Point(27, 29);
            this.BTN_Them.Name = "BTN_Them";
            this.BTN_Them.Size = new System.Drawing.Size(75, 23);
            this.BTN_Them.TabIndex = 0;
            this.BTN_Them.Text = "Thêm";
            this.BTN_Them.UseVisualStyleBackColor = true;
            this.BTN_Them.Click += new System.EventHandler(this.BTN_Them_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CBB_MaLopHoc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TB_TenHocPhan);
            this.panel2.Controls.Add(this.TB_MaHocPhan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 311);
            this.panel2.TabIndex = 24;
            // 
            // CBB_MaLopHoc
            // 
            this.CBB_MaLopHoc.FormattingEnabled = true;
            this.CBB_MaLopHoc.Location = new System.Drawing.Point(106, 60);
            this.CBB_MaLopHoc.Name = "CBB_MaLopHoc";
            this.CBB_MaLopHoc.Size = new System.Drawing.Size(175, 22);
            this.CBB_MaLopHoc.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã Lớp Học";
            // 
            // TB_TenHocPhan
            // 
            this.TB_TenHocPhan.Location = new System.Drawing.Point(106, 151);
            this.TB_TenHocPhan.Name = "TB_TenHocPhan";
            this.TB_TenHocPhan.Size = new System.Drawing.Size(175, 20);
            this.TB_TenHocPhan.TabIndex = 2;
            this.TB_TenHocPhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TenHocPhan_KeyPress);
            // 
            // TB_MaHocPhan
            // 
            this.TB_MaHocPhan.Location = new System.Drawing.Point(106, 106);
            this.TB_MaHocPhan.Name = "TB_MaHocPhan";
            this.TB_MaHocPhan.Size = new System.Drawing.Size(175, 20);
            this.TB_MaHocPhan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Học Phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Học Phần";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DT_HocPhan);
            this.panel3.Location = new System.Drawing.Point(301, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 311);
            this.panel3.TabIndex = 25;
            // 
            // DT_HocPhan
            // 
            this.DT_HocPhan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DT_HocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_HocPhan.Location = new System.Drawing.Point(3, 3);
            this.DT_HocPhan.Name = "DT_HocPhan";
            this.DT_HocPhan.Size = new System.Drawing.Size(281, 308);
            this.DT_HocPhan.TabIndex = 0;
            this.DT_HocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DT_HocPhan_CellClick);
            // 
            // trungTamDunnoDataSet
            // 
            this.trungTamDunnoDataSet.DataSetName = "TrungTamDunnoDataSet";
            this.trungTamDunnoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trungTamDunnoDataSetBindingSource
            // 
            this.trungTamDunnoDataSetBindingSource.DataSource = this.trungTamDunnoDataSet;
            this.trungTamDunnoDataSetBindingSource.Position = 0;
            // 
            // FHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(585, 425);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học Phần";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FHocPhan_FormClosed);
            this.Load += new System.EventHandler(this.FHocPhan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DT_HocPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamDunnoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trungTamDunnoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bienLaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hocPhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_FInd;
        private System.Windows.Forms.Button BTN_Tim;
        private System.Windows.Forms.Button BTN_Sua;
        private System.Windows.Forms.Button BTN_Xoa;
        private System.Windows.Forms.Button BTN_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DT_HocPhan;
        private System.Windows.Forms.BindingSource trungTamDunnoDataSetBindingSource;
        private TrungTamDunnoDataSet trungTamDunnoDataSet;
        private System.Windows.Forms.TextBox TB_TenHocPhan;
        private System.Windows.Forms.TextBox TB_MaHocPhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBB_MaLopHoc;
        private System.Windows.Forms.Label label4;
    }
}