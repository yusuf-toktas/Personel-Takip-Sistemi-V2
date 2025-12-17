using System;
using System.IO;
using System.Windows.Forms;

namespace Personel_Takip_Sistemi.Siniflar
{
    public static class AyarlarYonetimi
    {
        private static string dosyaYolu = Application.StartupPath + "\\config.dat";

        public static void AyarlariKaydet(string dilKodu)
        {
            try
            {
                string veri = "Dil:" + dilKodu;
                string sifreliVeri = Guvenlik.Sifrele(veri);
                File.WriteAllText(dosyaYolu, sifreliVeri);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayarlar kaydedilemedi: " + ex.Message);
            }
        }

        public static string AyarlariYukle()
        {
            try
            {
                if (File.Exists(dosyaYolu))
                {
                    string sifreliVeri = File.ReadAllText(dosyaYolu);
                    string cozulenVeri = Guvenlik.SifreCoz(sifreliVeri);

                    // Formatimiz "Dil:tr-TR" seklinde oldugu icin parcaliyoruz
                    if (cozulenVeri.StartsWith("Dil:"))
                    {
                        return cozulenVeri.Split(':')[1];
                    }
                }
            }
            catch
            {
                // Dosya bozuksa veya okunamadiysa varsayilan dondur
                return "tr-TR";
            }
            return "tr-TR";
        }
    }
}