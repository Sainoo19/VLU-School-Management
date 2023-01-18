using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno.PControl
{
    internal class ControlHocPhan
    {
        TrungTamDunnoEntities db = UtilDB.qltt;

        public List<HocPhan> FindAll()
        {
            var dsHocPhan = from s in db.HocPhans select s;
            return dsHocPhan.ToList();
        }

        public bool add(HocPhan s)
        {
            try
            {
                db.HocPhans.Add(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

            public bool xoa(HocPhan m)
        {
            try
            {
                db.HocPhans.Remove(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool update(HocPhan s)
        {
            try
            {
                db.HocPhans.AddOrUpdate(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<HocPhan> findHocPhan(string dieukien)
        {
            var rs = from s in db.HocPhans
                     where s.MaHocPhan.Contains(dieukien)
                     || s.TenHocPhan.Contains(dieukien)

                     select s;
            return rs.ToList();
        }

        public List<HocPhan> LoadHocPhan(string dieukien)
        {
            var rs = from s in db.HocPhans
                     where s.MaLopHoc.Contains(dieukien)
                     select s;
            return rs.ToList();
        }


    }
}
