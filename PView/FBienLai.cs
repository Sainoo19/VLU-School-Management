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
    public partial class FBienLai : Form
    {
        #region
        ControlLopHoc ctrlLopHoc = new ControlLopHoc();
        ControlMonHoc  ctrlMonHoc = new ControlMonHoc();
        ControlBienLai ctrlBienLai = new ControlBienLai();
        LopHoc lophoc;
        HocVien hocvien;
        BienLai bienLai;
        List<BienLai> listbienlai = new List<BienLai>();
        List<LopHoc> listlophoc = new List<LopHoc>();
        List<HocVien> listhocvien = new List<HocVien>();

        #endregion

        public FBienLai()
        {
            InitializeComponent();
            listlophoc = ctrlLopHoc.FindAll();
            listbienlai = ctrlBienLai.FindAll();
            loaddsbienlai(listbienlai);
            loaddslophoc(listlophoc);
            lophoc = listlophoc[0];
            loadlophoc(lophoc);
        }
        #region loadphuongthuc
        void loaddslophoc(List<LopHoc> lstlophoc)
        {
            var rs = from a in lstlophoc select new { a.MaLopHoc, a.TenLopHoc, a.LoaiLop, a.ThoiKhoaBieu, a.NgayKhaiGiang, a.HocPhi };
            DT_LopHoc.DataSource = rs.ToList();
        }

        void loadlophoc(LopHoc lh)
        {
            TB_MaLopHoc.Text = lh.MaLopHoc;
            TB_HocPhi.Text = lh.HocPhi.ToString();
        }

        void loadDSHocVien(List<HocVien> lstHocVien)
        {
            var rs = from a in lstHocVien select new { a.MaHocVien, a.HoTen, a.MaLopHoc, a.GioiTinh, a.NgaySinh, a.NoiSinh, a.NgheNghiep };
            DT_HocVien.DataSource = rs.ToList();
        }

        void loadhocvien(HocVien hv)
        {
            TB_MaHocVien.Text = hv.MaHocVien;
          
        }

        void loaddsbienlai(List<BienLai> lstbienlai)
        {
            var rs = from a in lstbienlai select new { a.MaBienLai,a.MaLopHoc,a.MaHocVien,a.TinhTrang};
            DT_BienLai.DataSource = rs.ToList();
        }

        void loadbienlai(BienLai bl)
        {
            TB_MaBienLai.Text = bl.MaBienLai;
            TB_MaHocVien.Text = bl.MaHocVien;
            TB_MaLopHoc.Text = bl.MaLopHoc;
            TB_HocPhi.Text = bl.LopHoc.HocPhi.ToString();

        }

        private void DT_BienLai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRow = DT_BienLai.CurrentCell.RowIndex;
            bienLai = listbienlai[idRow];
            loadbienlai(bienLai);

        }

        private void DT_LopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRow = DT_LopHoc.CurrentCell.RowIndex;
            lophoc = listlophoc[idRow];
            loadlophoc(lophoc);
            loadDSHocVien(lophoc.HocViens.ToList());
        }

        private void DT_HocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRowMH = DT_HocVien.CurrentCell.RowIndex;
            hocvien = lophoc.HocViens.ToList()[idRowMH];
            loadhocvien(hocvien);
        }
        #endregion



        #region ChuyenForm
        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHocVien f = new FHocVien();
            f.Show();
            this.Hide();
        }

        private void hocPhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHocPhan f = new FHocPhan();
            f.Show();
            this.Hide();
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTaiKhoan f = new FTaiKhoan();
            f.Show();
            this.Hide();
        }

        private void bienLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLopHoc f = new FLopHoc();
            f.Show();
            this.Hide();
        }
        #endregion


        #region chucnang
        private void BTN_ThanhToan_Click(object sender, EventArgs e)
        {
            bienLai = new BienLai
            {
                MaBienLai = TB_MaBienLai.Text,
                MaHocVien = TB_MaHocVien.Text,
                MaLopHoc = TB_MaLopHoc.Text,
                TinhTrang = "Đã thanh toán"

            };
            //them vao du lieu
            BienLai result = listbienlai.Find(x => x.MaBienLai == TB_MaBienLai.Text);
            if (result != null)
            { MessageBox.Show("Mã này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {
                if (ctrlBienLai.add(bienLai))
                {
                    listbienlai = ctrlBienLai.FindAll();
                    loaddsbienlai(listbienlai);
                }
                else
                    MessageBox.Show("Không thêm được tai khoan này!!!!");
            }
           
        }

        private void BTN_HuyThanhToan_Click(object sender, EventArgs e)
        {
            int index = DT_BienLai.CurrentCell.RowIndex;
            bienLai = listbienlai[index];


            if (ctrlBienLai.xoa(bienLai))
            {
                listbienlai.Remove(bienLai);//hoac la dung lai pthuc findAll
                loaddsbienlai(listbienlai);
            }
            else
                MessageBox.Show("Không thể xóa bien lai nay này!");
        }
        #endregion


        private void FBienLai_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
