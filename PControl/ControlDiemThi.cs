using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno.PControl
{
    internal class ControlDiemThi
    {
        TrungTamDunnoEntities db = UtilDB.qltt;

        public List<DiemThi> FindAll()
        {
            var dsDiemThi = from s in db.DiemThis select s;
            return dsDiemThi.ToList();
        }

        public bool add(DiemThi s)
        {
            try
            {
                db.DiemThis.Add(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }

        }

        public bool xoa(DiemThi m)
        {
            try
            {
                db.DiemThis.Remove(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool update(DiemThi s)
        {
            try
            {
                db.DiemThis.AddOrUpdate(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<HocVien> findDiemThi(string dieukien)
        {
            var rs = from s in db.HocViens
                     where s.MaHocVien.Contains(dieukien)
                     || s.HoTen.Contains(dieukien)

                     select s;
            return rs.ToList();
        }
    }
}
