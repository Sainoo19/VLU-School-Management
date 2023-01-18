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
    public partial class FLopHoc : Form
    {
        //khai bao bien
        #region khaibaobien
        ControlLopHoc ctrlLopHoc = new ControlLopHoc();
        ControlMonHoc ctrlMonHoc = new ControlMonHoc();
        ControlHocPhan ctrlhocphan = new ControlHocPhan();
        ControlHocVien ctrlhocvien = new ControlHocVien();
        List<LopHoc> listlophoc = new List<LopHoc>();
        LopHoc lophoc;
        MonHoc monhoc;
        HocVien hocvien;
        List<HocPhan> listhocphan;
        List<HocVien> listhocvien;
        HocPhan hocphan;
        #endregion

        public FLopHoc()
        {
            InitializeComponent();
            loadcbblophoc();
            listlophoc = ctrlLopHoc.FindAll();
            loaddslophoc(listlophoc);
            lophoc = listlophoc[0];
            loadlophoc(lophoc);
            LoadDSMONHOC(lophoc.MonHocs.ToList());
           


            // LoadMonHoc(monhoc);
        }

        //region khai bao phuong thuc
        #region khaibaophuongthuc

        void loaddslophoc(List<LopHoc> lstlophoc)
        {
            var rs = from a in lstlophoc select new { a.MaLopHoc, a.TenLopHoc,a.LoaiLop,a.ThoiKhoaBieu,a.NgayKhaiGiang,a.HocPhi };
            DT_LopHoc.DataSource = rs.ToList();
        }
      
        void loadlophoc(LopHoc lh)
        {
            TB_MaLopHoc.Text = lh.MaLopHoc;
            TB_TenLopHOc.Text = lh.TenLopHoc;
            CBB_TKB.Text = lh.ThoiKhoaBieu;
            DTP_NgayKhaiGiang.Value = DateTime.Parse(lh.NgayKhaiGiang.ToString());
            TB_HocPhi.Text = lh.HocPhi.ToString();

            RDB_DaiHan.Checked = (lh.LoaiLop == "Dai Han" ? true : false);
            RDB_NganHan.Checked = (lh.LoaiLop == "Ngan Han" ? true : false);
        }
        void LoadDSMONHOC(List<MonHoc> lstmh)
        {
            var rst = from t in lstmh
                      select new { t.MaLopHoc,t.MaMonHoc, t.TenMonHoc,t.MaHocPhan, t.SoTietLyThuyet, t.SoTietThucHanh};
            DT_MonHoc.DataSource = rst.ToList();
        }

        private void dtLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        void loadcbbhocphan()
        {
            CBB_MaHocPhan.Items.Clear();
            listhocphan = ctrlhocphan.LoadHocPhan(TB_MaLopHoc.Text);
            if (listhocphan.Count > 0)
            {
                foreach (HocPhan hocphan in listhocphan)
                {
                    
                    CBB_MaHocPhan.Items.Add(hocphan);
                }
            }
            else
                CBB_MaHocPhan.Items.Add("(none)");
           // CBB_MaHocPhan.Items.Add(ctrlhocphan.LoadHocPhanNone());
            


        }
        void loadcbblophoc()
        {
            CBB_TKB.Items.Add("Thu 2-4-6");
            CBB_TKB.Items.Add("Thu 3-5-7");
        }

        void LoadMonHoc(MonHoc mh)
        {
            TB_MaMonHoc.Text = mh.MaMonHoc;
            TB_TenMonHoc.Text = mh.TenMonHoc;
            CBB_MaHocPhan.Text = mh.MaHocPhan;
            TB_SoTietLyThuyet.Text = mh.SoTietLyThuyet.ToString();
            TB_SoTietThucHanh.Text = mh.SoTietThucHanh.ToString();

        }

        /*private void CBB_MaHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocphan = (HocPhan)CBB_MaHocPhan.SelectedItem;
        }*/
        #endregion

        //region ho tro
        #region HoTro
        private void DT_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRowMH = DT_MonHoc.CurrentCell.RowIndex;
            monhoc = lophoc.MonHocs.ToList()[idRowMH];
            LoadMonHoc(monhoc);
        }
        private void DT_LopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRow = DT_LopHoc.CurrentCell.RowIndex;
            lophoc = listlophoc[idRow];
            loadlophoc(lophoc);
            LoadDSMONHOC(lophoc.MonHocs.ToList());
            SoLuongHocVien();
            loadcbbhocphan();

        }

        private void taiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
        #endregion

        //region chuc nang
        #region ChucNang(Button)

        //quan ly lop hoc
        #region quanlylophoc

        private void BTN_Them_Click(object sender, EventArgs e)
        {
            lophoc = new LopHoc
            {
                MaLopHoc = TB_MaLopHoc.Text,
                TenLopHoc = TB_TenLopHOc.Text,
                NgayKhaiGiang = DTP_NgayKhaiGiang.Value,
                HocPhi = int.Parse(TB_HocPhi.Text),
                LoaiLop = (RDB_DaiHan.Checked == true ? "Dai Han" : "Ngan Han"),
                ThoiKhoaBieu = CBB_TKB.SelectedItem.ToString()
            };


            //them vao du lieu

            LopHoc result = listlophoc.Find(x => x.MaLopHoc == TB_MaLopHoc.Text);
            if (result != null)
            { MessageBox.Show("Mã này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {
                if (ctrlLopHoc.add(lophoc))
                {
                    listlophoc = ctrlLopHoc.FindAll();
                    loaddslophoc(listlophoc);
                }
                else
                    MessageBox.Show("Không thêm được lop hoc này!!!!");
            }
         

           
        }

        private void BTN_Xoa_Click(object sender, EventArgs e)
        {
            //chon ra lop hoc can xoa
            int index = DT_LopHoc.CurrentCell.RowIndex;
            lophoc = listlophoc[index];
            //chi xoa cac sinh vien chua co diem thi
            if (lophoc.MonHocs.Count == 0)
            {
                if (ctrlLopHoc.xoa(lophoc))
                {
                    listlophoc.Remove(lophoc);//hoac la dung lai pthuc findAll
                    loaddslophoc(listlophoc);
                }
            }
            else
                MessageBox.Show("Không thể xóa lop hoc này!");
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {

                lophoc.MaLopHoc = TB_MaLopHoc.Text;
                lophoc.TenLopHoc = TB_TenLopHOc.Text;
                lophoc.LoaiLop = (RDB_DaiHan.Checked == true ? "Dai Han" : "Ngan Han");
                lophoc.ThoiKhoaBieu = CBB_TKB.SelectedItem.ToString();
                lophoc.NgayKhaiGiang = DTP_NgayKhaiGiang.Value;
                lophoc.HocPhi = int.Parse(TB_HocPhi.Text);
                ctrlLopHoc.update(lophoc);
                loaddslophoc(listlophoc);
            
        }

        void TimKiemLopHoc()
        {
            listlophoc = ctrlLopHoc.findlophoc(TB_TimKiem.Text);
            loaddslophoc(listlophoc);
        }

        private void BTN_Find_Click(object sender, EventArgs e)
        {
            TimKiemLopHoc();
        }

        private void TB_TimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemLopHoc();
        }
        #endregion


        //quan ly mon hoc
        #region quanlymonhoc
        private void BTN_Add_Click(object sender, EventArgs e)
        {
        

            monhoc = new MonHoc
            {
                LopHoc = lophoc,
                MaMonHoc = TB_MaMonHoc.Text,
                TenMonHoc = TB_TenMonHoc.Text,
                MaHocPhan = CBB_MaHocPhan.SelectedItem.ToString(),
                SoTietLyThuyet = int.Parse(TB_SoTietLyThuyet.Text),
                SoTietThucHanh = int.Parse(TB_SoTietThucHanh.Text)
                
                
            };
            //them mon hoc
            MonHoc result = lophoc.MonHocs.ToList().Find(x => x.MaMonHoc == TB_MaMonHoc.Text);
            if (result != null)
            { MessageBox.Show("Mã này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else 
            {
                if (ctrlMonHoc.add(monhoc))
                {
                    MessageBox.Show("Thêm môn học thành công!");
                    LoadDSMONHOC(lophoc.MonHocs.ToList());
                }
                else
                    MessageBox.Show("Thêm môn học thất bại!");
            }
           
        }


        

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            //xac dinh mon hoc can xoa
            int idrow = DT_MonHoc.CurrentCell.RowIndex;
            monhoc = lophoc.MonHocs.ToList()[idrow];//mon hoc dang chon
            //kiem tra xem mon hoc nay da co diem cua sv hay chua
            if (monhoc.DiemThis.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này!");
                return;
            }
            if (ctrlMonHoc.xoa(monhoc))
            {
                MessageBox.Show("Xóa môn học thành công!");
                LoadDSMONHOC(lophoc.MonHocs.ToList());
            }
            else
                MessageBox.Show("Xóa môn học chưa thành công!");
        }

        private void BTN_sua_Click(object sender, EventArgs e)
        {
            //cap nhat thong tin cho mon hoc
            monhoc.TenMonHoc = TB_TenMonHoc.Text;//can phai kiem tra tinh hop le
            monhoc.MaHocPhan = CBB_MaHocPhan.SelectedItem.ToString();
            monhoc.SoTietLyThuyet = int.Parse(TB_SoTietLyThuyet.Text);
            monhoc.SoTietThucHanh = int.Parse(TB_SoTietThucHanh.Text);
            //goi phuong thuc cap nhat
            if (ctrlMonHoc.update(monhoc))
            {
                MessageBox.Show("Cập nhật thành công!");
                //hien thi lai len dtgridview
                LoadDSMONHOC(lophoc.MonHocs.ToList());
            }
            else
                MessageBox.Show("Cập nhật chưa thành công");
        }

        void TimKiemMonHoc()
        {
            lophoc.MonHocs = ctrlMonHoc.findMonHoc(TB_TimMonHoc.Text);
            LoadDSMONHOC(lophoc.MonHocs.ToList());
        }
        

        private void TB_TimMonHoc_TextChanged(object sender, EventArgs e)
        {
            TimKiemMonHoc();
        }

        private void BTN_Tim_Click(object sender, EventArgs e)
        {
            TimKiemMonHoc();
        }
        #endregion

        #endregion

        #region loadForm
        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTaiKhoan f = new FTaiKhoan();
            f.Show();
            this.Hide();
        }

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

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            f.Show();
            this.Hide();
        }

        private void FLopHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion


        #region ngoaile
        private void TB_TenLopHOc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void TB_TenMonHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void TB_HocPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 44)
            {
                e.Handled = true;
            }
        }

        #endregion


        void SoLuongHocVien()
        {
            var list = ctrlLopHoc.findSLHocVien(TB_MaLopHoc.Text);
            int count =list.Count();
            TB_SLHocVien.Text = count.ToString();
        }
    }
}
