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
    public partial class FHocPhan : Form
    {
        #region khaibaobien
        ControlLopHoc ctrlLopHoc = new ControlLopHoc();
        ControlHocPhan ctrlHocPhan = new ControlHocPhan();
        HocPhan hocphan;
        List<LopHoc> listlophoc;
        List<HocPhan> listhocphan = new List<HocPhan>();

        #endregion

        public FHocPhan()
        {
            InitializeComponent();
            listhocphan = ctrlHocPhan.FindAll();
            loaddshocphan(listhocphan);
            loadcbblophoc();
            hocphan = listhocphan[0];
        }

        #region loadphuongthuc

        void loadcbblophoc()
        {
            listlophoc = ctrlLopHoc.FindLopDaiHan();
            foreach (LopHoc hocphan in listlophoc)
            {
                CBB_MaLopHoc.Items.Add(hocphan);
            }
        }
        private void FHocPhan_Load(object sender, EventArgs e)
        {

        }

        void loaddshocphan(List<HocPhan> lstKhoa)
        {
            var rs = from a in lstKhoa select new {a.MaLopHoc, a.MaHocPhan, a.TenHocPhan };
            DT_HocPhan.DataSource = rs.ToList();
        }

        private void DT_HocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRow = DT_HocPhan.CurrentCell.RowIndex;
            hocphan = listhocphan[idRow];
            loadhocphan(hocphan);
        }

        void loadhocphan(HocPhan hp)
        {
            CBB_MaLopHoc.Text = hp.MaLopHoc;
            TB_MaHocPhan.Text = hp.MaHocPhan;
            TB_TenHocPhan.Text = hp.TenHocPhan;

        }

        #endregion


        #region chucnang


        private void BTN_Them_Click(object sender, EventArgs e)
        {
            hocphan = new HocPhan
            {
                MaLopHoc = CBB_MaLopHoc.SelectedItem.ToString(),
                MaHocPhan = TB_MaHocPhan.Text,
                TenHocPhan = TB_TenHocPhan.Text
               
            };
            //them vao du lieu

            HocPhan result = listhocphan.Find(x => x.MaHocPhan == TB_MaHocPhan.Text);
            if (result != null)
            { MessageBox.Show("Mã này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {
                if (ctrlHocPhan.add(hocphan))
                {
                    listhocphan = ctrlHocPhan.FindAll();
                    loaddshocphan(listhocphan);
                }
                else
                    MessageBox.Show("Không thêm được hoc phan này!!!!");
            }
   
        }

        private void BTN_Xoa_Click(object sender, EventArgs e)
        {
            
            int index = DT_HocPhan.CurrentCell.RowIndex;
            hocphan = listhocphan[index];
            
            if (hocphan.MonHocs.Count == 0)
            {
                if (ctrlHocPhan.xoa(hocphan))
                {
                    listhocphan.Remove(hocphan);//hoac la dung lai pthuc findAll
                    loaddshocphan(listhocphan);
                }
            }
            else
                MessageBox.Show("Không thể xóa hoc phan này!");
        }

        private void BTN_Sua_Click(object sender, EventArgs e)
        {
            hocphan.MaLopHoc = CBB_MaLopHoc.Text;
            hocphan.MaHocPhan = TB_MaHocPhan.Text;
            hocphan.TenHocPhan = TB_TenHocPhan.Text;
            
            ctrlHocPhan.update(hocphan);
            loaddshocphan(listhocphan);
        }

        void TimKiemHocPhan()
        {
            listhocphan = ctrlHocPhan.findHocPhan(TB_FInd.Text);
            loaddshocphan(listhocphan);
        }

        private void TB_FInd_TextChanged(object sender, EventArgs e)
        {
            TimKiemHocPhan();
        }

        private void BTN_Tim_Click(object sender, EventArgs e)
        {
            TimKiemHocPhan();
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

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTaiKhoan f = new FTaiKhoan();
            f.Show();
            this.Hide();
        }

        private void hocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLopHoc f = new FLopHoc();
            f.Show();
            this.Hide();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            f.Show();
            this.Hide();
        }

        private void FHocPhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region ngoaile
        private void TB_TenHocPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        #endregion

      
    }
}
