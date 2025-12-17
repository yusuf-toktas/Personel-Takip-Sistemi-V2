using System;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            VerileriGetir();
        }

        private void DilCevirileriniUygula()
        {
            // Veritabanindan gelen metinleri UI'a basiyoruz
            lblDashBaslik.Text = DilYonetimi.Get("LBL_DASHBOARD_BASLIK");
            lblToplamPersonel.Text = DilYonetimi.Get("LBL_TOPLAM_PERSONEL");
            lblIzindekiler.Text = DilYonetimi.Get("LBL_IZINDEKI_PERSONEL");
            lblOrtMaas.Text = DilYonetimi.Get("LBL_ORTALAMA_MAAS");

            // Grafik basliklari
            chartDepartman.Titles.Clear();
            chartDepartman.Titles.Add(DilYonetimi.Get("LBL_DEPARTMAN_DAGILIMI"));

            chartMaas.Titles.Clear();
            chartMaas.Titles.Add(DilYonetimi.Get("LBL_ORTALAMA_MAAS"));
        }

        private void VerileriGetir()
        {
            var db = Baglanti.db;

            // DUZELTME 1: aktif_mi yerine calisma_durumu kullanildi
            // 1. KART: Toplam Personel (Sadece 'aktif' olanlar)
            int personelSayisi = db.personellers.Count(x => x.calisma_durumu == "aktif");
            lblToplamPersonelSayi.Text = personelSayisi.ToString();

            // 2. KART: Şu an İzinde Olanlar
            DateTime bugun = DateTime.Today;
            int izindekiler = db.izinlers.Count(x => x.bitis >= bugun && x.baslangic <= bugun && x.onay_durumu == 2); // 2:Onayli
            lblIzindekilerSayi.Text = izindekiler.ToString();

            // DUZELTME 2: aktif_mi yerine calisma_durumu kullanildi
            // 3. KART: Ortalama Maas
            decimal ortMaas = 0;
            // Eger hic personel yoksa hata vermemesi icin kontrol
            if (personelSayisi > 0)
            {
                ortMaas = db.personellers
                            .Where(x => x.calisma_durumu == "aktif")
                            .Average(x => (decimal?)x.ucret) ?? 0;
            }
            lblOrtMaasSayi.Text = ortMaas.ToString("C0"); // Para birimi formatinda

            // CHART 1: Departman Dagilimi (Pie)
            var departmanVerisi = db.personellers
                .Where(x => x.calisma_durumu == "aktif") // Sadece aktifleri grafige dök
                .GroupBy(p => p.departmanlar.departman_adi)
                .Select(g => new { Departman = g.Key, Sayi = g.Count() })
                .ToList();

            chartDepartman.Series[0].Points.Clear();
            foreach (var item in departmanVerisi)
            {
                chartDepartman.Series[0].Points.AddXY(item.Departman, item.Sayi);
            }

            // CHART 2: Pozisyonlara Göre Ortalama Maaş (Bar)
            var maasVerisi = db.personellers
                .Where(x => x.calisma_durumu == "aktif")
                .GroupBy(p => p.pozisyonlar.pozisyon_adi)
                .Select(g => new { Pozisyon = g.Key, OrtMaas = g.Average(x => x.ucret) })
                .OrderByDescending(x => x.OrtMaas)
                .Take(5) // En yuksek 5 pozisyon
                .ToList();

            chartMaas.Series[0].Points.Clear();
            foreach (var item in maasVerisi)
            {
                chartMaas.Series[0].Points.AddXY(item.Pozisyon, item.OrtMaas);
            }
        }
    }
}