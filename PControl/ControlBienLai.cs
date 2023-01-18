using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno.PControl
{
    internal class ControlBienLai
    {
        TrungTamDunnoEntities db = UtilDB.qltt;

        public List<BienLai> FindAll()
        {
            var dsBienLai = from s in db.BienLais select s;
            return dsBienLai.ToList();
        }

        public bool add(BienLai m)
        {
            try
            {
                db.BienLais.Add(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool xoa(BienLai m)
        {
            try
            {
                db.BienLais.Remove(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool update(BienLai s)
        {
            try
            {
                db.BienLais.AddOrUpdate(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<BienLai> findBienLai(string dieukien)
        {
            var rs = from s in db.BienLais
                     where s.MaBienLai.Contains(dieukien)
                     //|| s.TenBienLai.Contains(dieukien)

                     select s;
            return rs.ToList();
        }
    }
}
