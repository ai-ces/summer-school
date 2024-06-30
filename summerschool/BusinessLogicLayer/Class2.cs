using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    internal class Class2
    {
        public static int OgrenciEkle(EntityOgrenci p)
        {
            if (p.AD!=null && p.SOYAD !=null && p.NUMARA !=null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
    }
}
