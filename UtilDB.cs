using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunno
{
    internal class UtilDB
    {
        public static TrungTamDunnoEntities qltt = new TrungTamDunnoEntities();
        
        static UtilDB()
        {
            if (qltt == null)
                qltt = new TrungTamDunnoEntities();
        }
    }
}
