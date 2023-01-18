using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno.PControl
{
    internal class ControlDangNhap
    {
        TrungTamDunnoEntities db = UtilDB.qltt;
        public bool check(string taikhoan, string matkhau)
        {
            var rst = from k in db.TaiKhoans where (k.TaiKhoan1 == taikhoan) && (k.MatKhau == matkhau) select k;
            if (rst.SingleOrDefault() != null)
                return true;
            else
                return false;
        }

       
    }
}
