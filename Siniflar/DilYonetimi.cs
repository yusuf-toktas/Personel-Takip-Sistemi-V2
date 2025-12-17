using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;

namespace Personel_Takip_Sistemi.Siniflar
{
    public static class DilYonetimi
    {
        private static Dictionary<string, string> _sozluk = new Dictionary<string, string>();
        public static string MevcutDil = "tr-TR";

        public static void DiliYukle(string dilKodu)
        {
            try
            {
                MevcutDil = dilKodu;
                _sozluk.Clear();

                using (var db = new PersonelTakipSistemiDBEntities())
                {
                    var kelimeler = db.dil_cevirileri.Where(x => x.dil_kodu == dilKodu).ToList();

                    foreach (var item in kelimeler)
                    {
                        if (!_sozluk.ContainsKey(item.anahtar))
                        {
                            _sozluk.Add(item.anahtar, item.deger);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dil yüklenirken hata oluştu: " + ex.Message);
            }
        }

        public static string Get(string anahtar)
        {
            if (_sozluk.ContainsKey(anahtar))
            {
                return _sozluk[anahtar];
            }
            return "{" + anahtar + "}";
        }
    }
}