using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno.PControl
{
    internal class ControlTaiKhoan
    {
        TrungTamDunnoEntities db = UtilDB.qltt;

        public List<TaiKhoan> FindAll()
        {
            var dsTaiKhoan = from s in db.TaiKhoans select s;
            return dsTaiKhoan.ToList();
        }

        public bool add(TaiKhoan s)
        {
            try
            {
                db.TaiKhoans.Add(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool xoa(TaiKhoan m)
        {
            try
            {
                db.TaiKhoans.Remove(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool update(TaiKhoan s)
        {
            try
            {
                db.TaiKhoans.AddOrUpdate(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TaiKhoan> findTaiKhoan(string dieukien)
        {
            var rs = from s in db.TaiKhoans
                     where s.TaiKhoan1.Contains(dieukien)
                     || s.TenHienThi.Contains(dieukien)

                     select s;
            return rs.ToList();
        }
    }
}
