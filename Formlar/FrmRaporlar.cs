using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            cmbRaporTuru.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_RAPORLAR_BASLIK");
            lblRaporTuru.Text = DilYonetimi.Get("LBL_RAPOR_TURU");
            btnRaporla.Text = DilYonetimi.Get("BTN_RAPOR_GORUNTULE");
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            if (cmbRaporTuru.SelectedIndex == 0)
            {
                PersonelListesiRaporu();
            }
            else if (cmbRaporTuru.SelectedIndex == 1)
            {
                MaasAnalizRaporu();
            }
            else if (cmbRaporTuru.SelectedIndex == 2)
            {
                IzinDurumRaporu();
            }
        }

        // 1. RAPOR: Personel Listesi
        private void PersonelListesiRaporu()
        {
            var db = Baglanti.db;
            var liste = (from p in db.personellers
                         join d in db.departmanlars on p.departman_id equals d.departman_id
                         join poz in db.pozisyonlars on p.pozisyon_id equals poz.pozisyon_id
                         where p.calisma_durumu == "aktif"
                         select new
                         {
                             AdSoyad = p.ad + " " + p.soyad,
                             TC = p.tc_kimlik_no,
                             Departman = d.departman_adi,
                             Pozisyon = poz.pozisyon_adi,
                             IseGiris = p.ise_giris_tarihi,
                             Maas = p.ucret
                         }).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("AdSoyad");
            dt.Columns.Add("TC");
            dt.Columns.Add("Departman");
            dt.Columns.Add("Pozisyon");
            dt.Columns.Add("IseGiris");
            dt.Columns.Add("Maas");

            foreach (var item in liste)
            {
                DataRow dr = dt.NewRow();
                dr["AdSoyad"] = item.AdSoyad;
                dr["TC"] = item.TC;
                dr["Departman"] = item.Departman;
                dr["Pozisyon"] = item.Pozisyon;
                dr["IseGiris"] = item.IseGiris.ToString("dd.MM.yyyy");
                dr["Maas"] = string.Format("{0:C2}", item.Maas);
                dt.Rows.Add(dr);
            }

            RaporuGoster("dsPersonel", dt, "Personel_Takip_Sistemi.Raporlar.RptPersonelListesi.rdlc");
        }

        private void MaasAnalizRaporu()
        {
            var db = Baglanti.db;

            var analiz = db.personellers
                .Where(x => x.calisma_durumu == "aktif")
                .GroupBy(p => p.departmanlar.departman_adi)
                .Select(g => new
                {
                    Departman = g.Key,
                    KisiSayisi = g.Count(),
                    TopMaas = g.Sum(x => x.ucret),
                    OrtMaas = g.Average(x => x.ucret)
                }).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Departman");
            dt.Columns.Add("PersonelSayisi");
            dt.Columns.Add("ToplamMaas");
            dt.Columns.Add("OrtalamaMaas");

            foreach (var item in analiz)
            {
                DataRow dr = dt.NewRow();
                dr["Departman"] = item.Departman;
                dr["PersonelSayisi"] = item.KisiSayisi.ToString();
                dr["ToplamMaas"] = string.Format("{0:C2}", item.TopMaas);
                dr["OrtalamaMaas"] = string.Format("{0:C2}", item.OrtMaas);
                dt.Rows.Add(dr);
            }

            RaporuGoster("dsMaas", dt, "Personel_Takip_Sistemi.Raporlar.RptMaasAnaliz.rdlc");
        }

        private void IzinDurumRaporu()
        {
            var db = Baglanti.db;
            var liste = (from i in db.izinlers
                         join p in db.personellers on i.personel_id equals p.personel_id
                         join d in db.departmanlars on p.departman_id equals d.departman_id
                         join t in db.izin_turleri on i.tur_id equals t.tur_id
                         orderby i.baslangic descending
                         select new
                         {
                             AdSoyad = p.ad + " " + p.soyad,
                             TC = p.tc_kimlik_no,
                             Departman = d.departman_adi,
                             Tur = t.tur_adi,
                             Baslangic = i.baslangic,
                             Bitis = i.bitis,
                             Gun = i.gun_sayisi,
                             DurumKodu = i.onay_durumu
                         }).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("AdSoyad");
            dt.Columns.Add("TC");
            dt.Columns.Add("Departman");
            dt.Columns.Add("IzinTuru");
            dt.Columns.Add("Baslangic");
            dt.Columns.Add("Bitis");
            dt.Columns.Add("Gun");
            dt.Columns.Add("Durum");

            foreach (var item in liste)
            {
                DataRow dr = dt.NewRow();
                dr["AdSoyad"] = item.AdSoyad;
                dr["TC"] = item.TC;
                dr["Departman"] = item.Departman;
                dr["IzinTuru"] = item.Tur;
                dr["Baslangic"] = item.Baslangic.ToString("dd.MM.yyyy");
                dr["Bitis"] = item.Bitis.ToString("dd.MM.yyyy");
                dr["Gun"] = item.Gun.ToString("0.0");

                // Durum Kodunu Yaziya Cevir
                string durumYazi = "Bekliyor";
                if (item.DurumKodu == 1) durumYazi = "Onaylandı";
                else if (item.DurumKodu == 2) durumYazi = "Reddedildi";

                dr["Durum"] = durumYazi;
                dt.Rows.Add(dr);
            }

            RaporuGoster("dsIzin", dt, "Personel_Takip_Sistemi.Raporlar.RptIzinDurum.rdlc");
        }

        private void RaporuGoster(string datasetIsmi, DataTable dt, string raporYolu)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource(datasetIsmi, dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportEmbeddedResource = raporYolu;
            reportViewer1.RefreshReport();
        }
    }
}