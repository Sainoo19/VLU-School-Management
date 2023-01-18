using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno.PControl
{
    internal class ControlHocVien
    {
        TrungTamDunnoEntities db = UtilDB.qltt;

        public List<HocVien> FindAll()
        {
            var dsHocVien = from s in db.HocViens select s;
            return dsHocVien.ToList();
        }

        public bool add(HocVien s)
        {
            try
            {
                db.HocViens.Add(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }

        }

        public bool xoa(HocVien m)
        {
            try
            {
                db.HocViens.Remove(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool update(HocVien s)
        {
            try
            {
                db.HocViens.AddOrUpdate(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<HocVien> findHocVien(string dieukien)
        {
            var rs = from s in db.HocViens
                     where s.MaHocVien.Contains(dieukien)
                     || s.HoTen.Contains(dieukien)

                     select s;
            return rs.ToList();
        }
    }
}
