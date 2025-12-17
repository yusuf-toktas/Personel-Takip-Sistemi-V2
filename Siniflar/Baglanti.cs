using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personel_Takip_Sistemi.Database;

namespace Personel_Takip_Sistemi.Siniflar
{
    // Singleton Design Pattern: Uygulama boyunca tek bir veritabani nesnesi (Context) uretir.
    public static class Baglanti
    {
        private static PersonelTakipSistemiDBEntities _db;

        public static PersonelTakipSistemiDBEntities db
        {
            get
            {
                if (_db == null)
                {
                    _db = new PersonelTakipSistemiDBEntities();
                }
                return _db;
            }
        }
    }
}