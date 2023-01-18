using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dunno.PControl; 

namespace Dunno.PView
{
    public partial class FDangNhap : Form
    {
        ControlDangNhap ctrldangnhap = new ControlDangNhap();
        TaiKhoan taikhoan;
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void BTN_DangNhap_Click(object sender, EventArgs e)
        {
            if (TB_TaiKhoan.Text == "" || TB_MatKhau.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ vào tài khoản và mật khẩu!", "Thông báo");
            else
            {
                
                if (ctrldangnhap.check(TB_TaiKhoan.Text, TB_MatKhau.Text) == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    FLopHoc form1 = new FLopHoc();
                    form1.Show();
                    this.Hide();
                   
                    TB_TaiKhoan.Text = "";
                    TB_MatKhau.Text = "";
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng vui lòng thử lại!", "Thông báo");
            }
        }

        private void CB_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_HienMatKhau.Checked == true)
                TB_MatKhau.PasswordChar = '\0';
            else
                TB_MatKhau.PasswordChar = '*';
        }

        private void BTN_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
