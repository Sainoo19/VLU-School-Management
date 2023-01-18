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
    public partial class FHocVien : Form
    {

        //Khai báo các control và các biến dùng trong chương trình
        string flag;
        #region khaibaobien
        ControlHocVien ctrHocVien = new ControlHocVien();
        ControlDiemThi ctrDiemThi = new ControlDiemThi();
        ControlLopHoc ctrlLopHoc = new ControlLopHoc();
        ControlMonHoc ctrlMonHoc = new ControlMonHoc();
        //
        List<HocVien> dsHocVien;
        //
        List<LopHoc> listlophoc;
        List<MonHoc> listmonhoc;
        MonHoc monhoc;
        LopHoc lophoc;
        HocVien hocvienObj;
        DiemThi diemthiObj;
        #endregion

        #region KhaiBaoCacPhuongThucBoTro
        //Hiển thị thông tin của học viên
        void loadDSHocVien(List<HocVien> lstHocVien)
        {
            var rs = from a in lstHocVien select new { a.MaHocVien, a.HoTen, a.MaLopHoc, a.GioiTinh, a.NgaySinh, a.NoiSinh, a.NgheNghiep };
            DGView_QLHocVien.DataSource = rs.ToList();
        }
        //Hiển thị danh sách học viên trong dataGridView
        void showHocVien(HocVien hv)
        {
            textBoxMaHocVien.Text = hv.MaHocVien;
            textBoxHoTen.Text = hv.HoTen;
            CBB_MaLopHoc.Text = hv.MaLopHoc;
            dateTimePickerNgaySinh.Text = hv.NgaySinh.ToString();
            comboBoxGioiTinh.Text = hv.GioiTinh;
            textBoxNoiSinh.Text = hv.NoiSinh;
            textBoxNgheNghiep.Text = hv.NgheNghiep;
        }
        void loadDSDiemThi(List<DiemThi> lstDiemThi)
        {
            var rst = from t in lstDiemThi
                      select new
                      {
                          t.MaMonHoc,
                          t.MaHocVien,
                          t.Diemthi1,
                      };
            DGView_QuanLiDiemThi.DataSource = rst.ToList();
        }
        void showDiemThi(DiemThi dt)
        {
            CBB_MaMonHoc.Text = dt.MaMonHoc;
            textBoxMaHocVienDiemThi.Text = dt.MaHocVien;
            numericUpDownDiemThi.Value = Int32.Parse(dt.Diemthi1 + "");
        }
        #endregion
        public FHocVien()
        {
            InitializeComponent();
            loadcbblophoc();
            
            
            dsHocVien = ctrHocVien.FindAll();
            loadDSHocVien(dsHocVien);
            
            hocvienObj = dsHocVien[0];
            showHocVien(hocvienObj);
            

        }
        #region chucnang
        public void LockControl()
        {
            buttonThem.Enabled = true;
            buttonSua.Enabled = true;
            buttonXoa.Enabled = true;
            buttonLuu.Enabled = false;
            buttonHuy.Enabled = false;

            textBoxMaHocVien.ReadOnly = true;
            textBoxHoTen.ReadOnly = true;
            //CBB_MaLopHoc.ReadOnly = true;
            textBoxNoiSinh.ReadOnly = true;
            textBoxNgheNghiep.ReadOnly = true;

            buttonThem.Focus();
        }
        public void LockControl2()
        {
            buttonThemDiemThi.Enabled = true;
            buttonSuaDiemThi.Enabled = true;
            buttonXoaDiemThi.Enabled = true;
            buttonLuuDiemThi.Enabled = false;
            buttonHuy2.Enabled = false;

            //CBB_MaMonHoc.ReadOnly = true;
            textBoxMaHocVienDiemThi.ReadOnly = true;
        }
        public void UnlockControl()
        {
            buttonThem.Enabled = false;
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            buttonLuu.Enabled = true;
            buttonHuy.Enabled = true;

            textBoxHoTen.ReadOnly = false;
            //textBoxMaLopHoc.ReadOnly = false;
            textBoxNoiSinh.ReadOnly = false;
            textBoxNgheNghiep.ReadOnly = false;

            textBoxMaHocVien.Focus();
        }
        public void UnlockControl2()
        {
            buttonThemDiemThi.Enabled = false;
            buttonSuaDiemThi.Enabled = false;
            buttonXoaDiemThi.Enabled = false;
            buttonLuuDiemThi.Enabled = true;
            buttonHuy2.Enabled = true;

            //textBoxMaMonHoc.ReadOnly = false;
            textBoxMaHocVienDiemThi.ReadOnly = true;

            CBB_MaLopHoc.Focus();
        }

        private void FHocVien_Load(object sender, EventArgs e)
        {
            LockControl();
            LockControl2();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            textBoxMaHocVien.ReadOnly = false;
            UnlockControl();
            flag = "addHocVien";

            textBoxMaHocVien.Text = "";
            textBoxHoTen.Text = "";
            CBB_MaLopHoc.Text = "";
            comboBoxGioiTinh.Text = "Nam";
            textBoxNoiSinh.Text = "";
            textBoxNgheNghiep.Text = "";
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            textBoxMaHocVien.ReadOnly = true;
            UnlockControl();
            flag = "editHocVien";
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            //Xác định học viên cần xóa
            int idrow = DGView_QLHocVien.CurrentCell.RowIndex;
            hocvienObj = dsHocVien[idrow]; //Học viên đang chọn
            if (MessageBox.Show("Bạn có muốn xóa học viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (hocvienObj.DiemThis.Count > 0)
                {
                    MessageBox.Show("Không thể xóa hoc vien này!");
                    return;
                }
                if (ctrHocVien.xoa(hocvienObj))
                {
                    MessageBox.Show("Xóa học viên thành công!");
                    dsHocVien = ctrHocVien.FindAll();
                    loadDSHocVien(dsHocVien);
                }
                else
                    MessageBox.Show("Xóa học viên chưa thành công!");
            }

            
        }

        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(textBoxMaHocVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMaHocVien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxHoTen.Focus();
                return false;
            }
            /*if (string.IsNullOrWhiteSpace(textBoxMaLopHoc.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMaLopHoc.Focus();
                return false;
            }*/
            if (string.IsNullOrWhiteSpace(textBoxNoiSinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập nơi sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNoiSinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxNgheNghiep.Text))
            {
                MessageBox.Show("Bạn chưa nhập nghề nghiệp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNgheNghiep.Focus();
                return false;
            }
            return true;
        }
        public bool checkData2()
        {
            if (string.IsNullOrWhiteSpace(CBB_MaMonHoc.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã môn học cần thêm điểm thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBB_MaMonHoc.Focus();
                return false;
            }
            return true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (flag == "addHocVien")
            {
                if (checkData())
                {
                    //Tạo thông tin học viên
                    hocvienObj = new HocVien
                    {
                        MaHocVien = textBoxMaHocVien.Text,
                        HoTen = textBoxHoTen.Text,
                        MaLopHoc = CBB_MaLopHoc.Text,
                        NgaySinh = DateTime.Parse(dateTimePickerNgaySinh.Text),
                        GioiTinh = comboBoxGioiTinh.Text,
                        NoiSinh = textBoxNoiSinh.Text,
                        NgheNghiep = textBoxNgheNghiep.Text,
                    };
                    //Thêm học viên
                    HocVien result = dsHocVien.Find(x => x.MaHocVien == textBoxMaHocVien.Text);
                    if (result != null)
                    { MessageBox.Show("Mã này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    else
                    {
                        if (ctrHocVien.add(hocvienObj))
                        {
                            MessageBox.Show("Thêm học viên thành công!");
                            dsHocVien = ctrHocVien.FindAll();
                            loadDSHocVien(dsHocVien);
                        }
                        else
                            MessageBox.Show("Thêm học viên thất bại!");
                    }
                            
                }
            }
            else if (flag == "editHocVien")
            {
                if (checkData())
                {
                    //Cập nhật thông tin cho học viên
                    hocvienObj.HoTen = textBoxHoTen.Text; //Cần phải kiểm tra tính hợp lệ
                    hocvienObj.MaLopHoc = CBB_MaLopHoc.Text;
                    hocvienObj.NgaySinh = DateTime.Parse(dateTimePickerNgaySinh.Text);
                    hocvienObj.GioiTinh = comboBoxGioiTinh.Text;
                    hocvienObj.NoiSinh = textBoxNoiSinh.Text;
                    hocvienObj.NgheNghiep = textBoxNgheNghiep.Text;
                    //Gọi phương thức cập nhật
                    if (ctrHocVien.update(hocvienObj))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        //Hiển thị lại lên dataGridView
                        loadDSHocVien(dsHocVien);
                    }
                    else
                        MessageBox.Show("Cập nhật chưa thành công");
                }
            }
            LockControl();
        }

        private void DGView_QLHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy ra chỉ số dòng đang chọn
            int idRow = DGView_QLHocVien.CurrentCell.RowIndex;
            hocvienObj = dsHocVien[idRow];
            showHocVien(hocvienObj);
            loadDSDiemThi(hocvienObj.DiemThis.ToList());
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            LockControl();

            textBoxMaHocVien.Text = "";
            textBoxHoTen.Text = "";
            CBB_MaLopHoc.Text = "";
            comboBoxGioiTinh.Text = "Nam";
            textBoxNoiSinh.Text = "";
            textBoxNgheNghiep.Text = "";
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTimMaHocVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học viên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTimMaHocVien.Focus();
            }
            else
            {
                dsHocVien = ctrHocVien.findHocVien(textBoxTimMaHocVien.Text);
                loadDSHocVien(dsHocVien);
            }
        }




        private void buttonThemDiemThi_Click(object sender, EventArgs e)
        {
            UnlockControl2();
            CBB_MaMonHoc.Text = "";
            textBoxMaHocVienDiemThi.Text = "";
            flag = "addDiemThi";
        }

        private void buttonSuaDiemThi_Click(object sender, EventArgs e)
        {
            UnlockControl2();
            flag = "editDiemThi";
        }

        private void buttonLuuDiemThi_Click(object sender, EventArgs e)
        {
            if (flag == "addDiemThi")
            {
                if (checkData2())
                {
                    //Tạo thông tin điểm thi
                    diemthiObj = new DiemThi
                    {
                        MaMonHoc = CBB_MaMonHoc.Text,
                        MaHocVien = textBoxMaHocVien.Text,
                        Diemthi1 = float.Parse(numericUpDownDiemThi.Value + ""),
                        HocVien = hocvienObj
                    };
                    //Thêm điểm thí
                    if(CBB_MaMonHoc.Text == "(none)")
                    {
                        MessageBox.Show("Lop Hoc Chua Dang Ky Mon Hoc Nao","Thong Bao");

                    }
                    else
                    {
                        if (ctrDiemThi.add(diemthiObj))
                        {
                            MessageBox.Show("Thêm điểm thi thành công!");
                            loadDSDiemThi(hocvienObj.DiemThis.ToList());
                        }
                        else
                            MessageBox.Show("Thêm điểm thi thất bại!");
                    }
                   
                }
            }
            else if (flag == "editDiemThi")
            {
                if (checkData2())
                {
                    //Cập nhật điểm thi
                    diemthiObj.Diemthi1 = Int32.Parse(numericUpDownDiemThi.Value + ""); //Cần phải kiểm tra tính hợp lệ
                    //Gọi phương thức cập nhật
                    if (ctrDiemThi.update(diemthiObj))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        //Hiển thị lại lên dataGridView
                        loadDSDiemThi(hocvienObj.DiemThis.ToList());
                    }
                    else
                        MessageBox.Show("Cập nhật chưa thành công");
                }
            }
            LockControl();
        }

        private void buttonXoaDiemThi_Click(object sender, EventArgs e)
        {
            //Xác định điểm thi cần xóa
            int idrow = DGView_QuanLiDiemThi.CurrentCell.RowIndex;
            diemthiObj = hocvienObj.DiemThis.ToList()[idrow]; //Điểm thi đang được chọn
            if (ctrDiemThi.xoa(diemthiObj))
            {
                MessageBox.Show("Xóa điểm thi thành công!");
                loadDSDiemThi(hocvienObj.DiemThis.ToList());
            }
            else
                MessageBox.Show("Xóa điểm thi chưa thành công!");
        }

        private void buttonHuy2_Click(object sender, EventArgs e)
        {

            LockControl2();
        }

        private void DGView_QuanLiDiemThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy ra chỉ số dòng đang chọn
            int idRow = DGView_QuanLiDiemThi.CurrentCell.RowIndex;
            diemthiObj = hocvienObj.DiemThis.ToList()[idRow];
            showDiemThi(diemthiObj);
        }

        #endregion

        #region loadphuongthuc
        void loadcbblophoc()
        {
            listlophoc = ctrlLopHoc.FindAll();
            foreach (LopHoc hocphan in listlophoc)
            {
                CBB_MaLopHoc.Items.Add(hocphan);
            }
        }

        void loadcbbmonhoc()
        {
            CBB_MaMonHoc.Items.Clear();
            listmonhoc = ctrlMonHoc.LoadMonHoc(CBB_MaLopHoc.SelectedItem.ToString());
            listmonhoc.Clear();
            listmonhoc = ctrlMonHoc.LoadMonHoc(CBB_MaLopHoc.SelectedItem.ToString());
            if (listmonhoc.Count > 0)
            {
                foreach (MonHoc hocphan in listmonhoc)
                {
                    CBB_MaMonHoc.Items.Add(hocphan);
                }
            }
            else
                CBB_MaMonHoc.Items.Add("(none)");

        }

        #endregion

        #region loadform
        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLopHoc f = new FLopHoc();
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

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTaiKhoan f = new FTaiKhoan();
            f.Show();
            this.Hide();
        }

        

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            f.Show();
            this.Hide();
        }

        private void FHocVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region ngoaile
        private void textBoxHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void textBoxNoiSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void textBoxNgheNghiep_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void numericUpDownDiemThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 44)
            {
                e.Handled = true;
            }
        }

        #endregion

        private void CBB_MaLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbbmonhoc();
        }
    }
}
