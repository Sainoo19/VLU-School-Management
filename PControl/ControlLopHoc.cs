using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dunno.PView;

namespace Dunno.PControl
{
    internal class ControlLopHoc
    {
        TrungTamDunnoEntities db = UtilDB.qltt;

        public List<LopHoc> FindAll()
        {
            var dslophoc = from s in db.LopHocs select s;
            return dslophoc.ToList();
        }

        public bool add(LopHoc s)
        {
            try
            {
                db.LopHocs.Add(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }

        }

        public bool xoa(LopHoc m)
        {
            try
            {
                db.LopHocs.Remove(m);
                db.SaveChanges();
                return true;
            }
            catch
            {
                db.Dispose();
                return false;
            }
        }

        public bool update(LopHoc s)
        {
            try
            {
                db.LopHocs.AddOrUpdate(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LopHoc> findlophoc(string dieukien)
        {
            var rs = from s in db.LopHocs
                     where s.MaLopHoc.Contains(dieukien)
                     || s.TenLopHoc.Contains(dieukien)
                     
                    
                     select s;
            return rs.ToList();
        }





        public List<HocVien> findSLHocVien(string dieukien)
        {
            var rs = from s in db.HocViens
                     where s.MaLopHoc.Contains(dieukien)
                    


                     select s;
            return rs.ToList();
        }

        public List<LopHoc> FindLopDaiHan()
        {
            var rs = from s in db.LopHocs
                     where s.LoaiLop == "Dai Han"



                     select s;
            return rs.ToList();
        }

    }
}
