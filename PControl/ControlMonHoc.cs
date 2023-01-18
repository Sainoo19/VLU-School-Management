using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno.PControl
{
    internal class ControlMonHoc
    {
        TrungTamDunnoEntities db = UtilDB.qltt;

        

        public List<MonHoc> FindAll()
        {
            var dsMonHoc = from s in db.MonHocs select s;
            return dsMonHoc.ToList();
        }

        public bool add(MonHoc m)
        {
            try
            {
                db.MonHocs.Add(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool xoa(MonHoc m)
        {
            try
            {
                db.MonHocs.Remove(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool update(MonHoc s)
        {
            try
            {
                db.MonHocs.AddOrUpdate(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<MonHoc> findMonHoc(string dieukien)
        {
            var rs = from s in db.MonHocs
                     where s.MaMonHoc.Contains(dieukien)
                     || s.TenMonHoc.Contains(dieukien)

                     select s;
            return rs.ToList();
        }

        public List<MonHoc> LoadMonHoc(string dieukien)
        {
            var rs = from s in db.MonHocs
                     where s.MaLopHoc.Contains(dieukien)
                     select s;
            return rs.ToList();
        }
    }
}
