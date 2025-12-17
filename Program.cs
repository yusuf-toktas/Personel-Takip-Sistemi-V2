using System;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string kayitliDil = AyarlarYonetimi.AyarlariYukle();
            DilYonetimi.DiliYukle(kayitliDil);

            Application.Run(new Formlar.FrmLogin());
        }
    }
}