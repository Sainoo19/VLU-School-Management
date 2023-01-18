namespace Dunno.PView
{
    partial class FDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_TaiKhoan = new System.Windows.Forms.TextBox();
            this.TB_MatKhau = new System.Windows.Forms.TextBox();
            this.CB_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.BTN_DangNhap = new System.Windows.Forms.Button();
            this.BTN_Thoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu";
            // 
            // TB_TaiKhoan
            // 
            this.TB_TaiKhoan.Location = new System.Drawing.Point(412, 192);
            this.TB_TaiKhoan.Name = "TB_TaiKhoan";
            this.TB_TaiKhoan.Size = new System.Drawing.Size(167, 20);
            this.TB_TaiKhoan.TabIndex = 4;
            // 
            // TB_MatKhau
            // 
            this.TB_MatKhau.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MatKhau.Location = new System.Drawing.Point(412, 224);
            this.TB_MatKhau.Name = "TB_MatKhau";
            this.TB_MatKhau.PasswordChar = '*';
            this.TB_MatKhau.Size = new System.Drawing.Size(167, 20);
            this.TB_MatKhau.TabIndex = 5;
            // 
            // CB_HienMatKhau
            // 
            this.CB_HienMatKhau.AutoSize = true;
            this.CB_HienMatKhau.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_HienMatKhau.Location = new System.Drawing.Point(367, 269);
            this.CB_HienMatKhau.Name = "CB_HienMatKhau";
            this.CB_HienMatKhau.Size = new System.Drawing.Size(104, 19);
            this.CB_HienMatKhau.TabIndex = 6;
            this.CB_HienMatKhau.Text = "Hiện Mật Khẩu";
            this.CB_HienMatKhau.UseVisualStyleBackColor = true;
            this.CB_HienMatKhau.CheckedChanged += new System.EventHandler(this.CB_HienMatKhau_CheckedChanged);
            // 
            // BTN_DangNhap
            // 
            this.BTN_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DangNhap.Location = new System.Drawing.Point(349, 307);
            this.BTN_DangNhap.Name = "BTN_DangNhap";
            this.BTN_DangNhap.Size = new System.Drawing.Size(113, 34);
            this.BTN_DangNhap.TabIndex = 7;
            this.BTN_DangNhap.Text = "Đăng Nhập";
            this.BTN_DangNhap.UseVisualStyleBackColor = true;
            this.BTN_DangNhap.Click += new System.EventHandler(this.BTN_DangNhap_Click);
            // 
            // BTN_Thoat
            // 
            this.BTN_Thoat.Location = new System.Drawing.Point(470, 307);
            this.BTN_Thoat.Name = "BTN_Thoat";
            this.BTN_Thoat.Size = new System.Drawing.Size(109, 34);
            this.BTN_Thoat.TabIndex = 8;
            this.BTN_Thoat.Text = "Thoát";
            this.BTN_Thoat.UseVisualStyleBackColor = true;
            this.BTN_Thoat.Click += new System.EventHandler(this.BTN_Thoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(384, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(610, 454);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTN_Thoat);
            this.Controls.Add(this.BTN_DangNhap);
            this.Controls.Add(this.CB_HienMatKhau);
            this.Controls.Add(this.TB_MatKhau);
            this.Controls.Add(this.TB_TaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_TaiKhoan;
        private System.Windows.Forms.TextBox TB_MatKhau;
        private System.Windows.Forms.CheckBox CB_HienMatKhau;
        private System.Windows.Forms.Button BTN_DangNhap;
        private System.Windows.Forms.Button BTN_Thoat;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}