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
    public partial class FTaiKhoan : Form
    {
        #region
        ControlTaiKhoan ctrlTaiKhoan = new ControlTaiKhoan();
        List<TaiKhoan> listtaikhoan = new List<TaiKhoan>();
        TaiKhoan taikhoan;
        #endregion
        public FTaiKhoan()
        {
            InitializeComponent();
            listtaikhoan = ctrlTaiKhoan.FindAll();
            loaddstaikhoan(listtaikhoan);
        }
        #region Khaibaophuongthuc

        void loaddstaikhoan(List<TaiKhoan> lstKhoa)
        {
            var rs = from a in lstKhoa select new { a.TaiKhoan1, a.TenHienThi ,a.MatKhau};
            DT_TaiKhoan.DataSource = rs.ToList();
        }

        private void DT_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRow = DT_TaiKhoan.CurrentCell.RowIndex;
            taikhoan = listtaikhoan[idRow];
            loadtaikhoan(taikhoan);
        }

        void loadtaikhoan(TaiKhoan hp)
        {
            TB_TenTaiKhoan.Text = hp.TaiKhoan1;
            TB_TenHienThi.Text = hp.TenHienThi;
            TB_MatKhau.Text = hp.MatKhau;

        }
        #endregion

        #region chucnang
        private void BTN_Them_Click(object sender, EventArgs e)
        {
            taikhoan = new TaiKhoan
            {
                TaiKhoan1 = TB_TenTaiKhoan.Text,
                TenHienThi = TB_TenHienThi.Text,
                MatKhau = TB_MatKhau.Text,
            };
            //them vao du lieu

            TaiKhoan result = listtaikhoan.Find(x => x.TaiKhoan1 == TB_TenTaiKhoan.Text);
            if (result != null)
            { MessageBox.Show("Tên tài khoản này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {
                if (ctrlTaiKhoan.add(taikhoan))
                {
                    listtaikhoan = ctrlTaiKhoan.FindAll();
                    loaddstaikhoan(listtaikhoan);
                }
                else
                    MessageBox.Show("Không thêm được tai khoan này!!!!");
            }
           
        }

        private void BTN_Xoa_Click(object sender, EventArgs e)
        {
            int index = DT_TaiKhoan.CurrentCell.RowIndex;
            taikhoan = listtaikhoan[index];

           
                if (ctrlTaiKhoan.xoa(taikhoan))
                {
                    listtaikhoan.Remove(taikhoan);//hoac la dung lai pthuc findAll
                    loaddstaikhoan(listtaikhoan);
                }
                else
                MessageBox.Show("Không thể xóa tai khoan này!");
        }

        private void BTN_Sua_Click(object sender, EventArgs e)
        {

                taikhoan.TaiKhoan1 = TB_TenTaiKhoan.Text;
                taikhoan.TenHienThi = TB_TenHienThi.Text;
                taikhoan.MatKhau = TB_MatKhau.Text;



                ctrlTaiKhoan.update(taikhoan);
                loaddstaikhoan(listtaikhoan);
            
        }

        void TimKiemTaiKhoan()
        {
            listtaikhoan = ctrlTaiKhoan.findTaiKhoan(TB_Tim.Text);
            loaddstaikhoan(listtaikhoan);
        }

        private void TB_Tim_TextChanged(object sender, EventArgs e)
        {
            TimKiemTaiKhoan();
        }

        private void BTN_Tim_Click(object sender, EventArgs e)
        {
            TimKiemTaiKhoan();
        }
        #endregion

        #region chuyenform

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHocVien f = new FHocVien();
            f.Show();
            this.Hide();
        }

        private void bienLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBienLai f = new FBienLai();
            f.Show();
            this.Hide();
        }

        private void hocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHocPhan f = new FHocPhan();
            f.Show();
            this.Hide();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            f.Show();
            this.Hide();
        }

        private void FTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
