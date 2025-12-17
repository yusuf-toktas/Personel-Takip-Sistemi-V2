using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmIzinListesi : Form
    {
        private kullanicilar _aktifKullanici;
        private Repository<izinler> izinRepo = new Repository<izinler>();

        public FrmIzinListesi(kullanicilar kullanici)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
        }

        private void FrmIzinListesi_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            YetkiKontrolu();
            Listele();
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_IZIN_LISTESI_BASLIK");
            btnYeniIzin.Text = DilYonetimi.Get("BTN_YENI_IZIN");
            btnOnayla.Text = DilYonetimi.Get("BTN_ONAYLA");
            btnReddet.Text = DilYonetimi.Get("BTN_REDDET");
        }

        private void YetkiKontrolu()
        {
            // Admin degilse onay butonlarini gizle
            if (_aktifKullanici.rol_yetkisi != "admin" && _aktifKullanici.rol_yetkisi != "ik_admin")
            {
                btnOnayla.Visible = false;
                btnReddet.Visible = false;
            }
        }

        private void Listele()
        {
            var db = Baglanti.db;

            // LINQ ile izinleri cekiyoruz
            var sorgu = from i in db.izinlers
                        join p in db.personellers on i.personel_id equals p.personel_id
                        join t in db.izin_turleri on i.tur_id equals t.tur_id
                        select new
                        {
                            ID = i.izin_id,
                            PersonelID = p.personel_id, // Filtreleme icin lazim
                            AdSoyad = p.ad + " " + p.soyad,
                            Tur = t.tur_adi,
                            Baslangic = i.baslangic,
                            Bitis = i.bitis,
                            Gun = i.gun_sayisi,
                            DurumKodu = i.onay_durumu,
                            Durum = i.onay_durumu == 0 ? "Bekliyor" : (i.onay_durumu == 1 ? "Onaylandı" : "Reddedildi")
                        };

            // Standart kullanici sadece kendi izinlerini gorur
            if (_aktifKullanici.rol_yetkisi != "admin" && _aktifKullanici.rol_yetkisi != "ik_admin")
            {
                sorgu = sorgu.Where(x => x.PersonelID == _aktifKullanici.personel_id);
            }

            // Listeye cevir ve gride bas (Ters siralama ile en yeni en ustte)
            var liste = sorgu.OrderByDescending(x => x.Baslangic).ToList();
            gridIzinler.DataSource = liste;

            // Grid Ayarlari
            gridIzinler.Columns["ID"].Visible = false;
            gridIzinler.Columns["PersonelID"].Visible = false;
            gridIzinler.Columns["DurumKodu"].Visible = false;

            gridIzinler.Columns["AdSoyad"].HeaderText = DilYonetimi.Get("COL_AD") + " " + DilYonetimi.Get("COL_SOYAD");
            gridIzinler.Columns["Tur"].HeaderText = DilYonetimi.Get("COL_IZIN_TURU");
            gridIzinler.Columns["Baslangic"].HeaderText = DilYonetimi.Get("COL_BASLANGIC");
            gridIzinler.Columns["Bitis"].HeaderText = DilYonetimi.Get("COL_BITIS");
            gridIzinler.Columns["Gun"].HeaderText = DilYonetimi.Get("COL_GUN");
            gridIzinler.Columns["Durum"].HeaderText = DilYonetimi.Get("COL_ONAY_DURUMU");
        }

        private void btnYeniIzin_Click(object sender, EventArgs e)
        {
            FrmIzinIstegi frm = new FrmIzinIstegi(_aktifKullanici);
            frm.ShowDialog();
            Listele(); // Ekleme bitince yenile
        }

        private void DurumGuncelle(int durum) // 1: Onay, 2: Red
        {
            if (gridIzinler.SelectedRows.Count > 0)
            {
                int id = int.Parse(gridIzinler.SelectedRows[0].Cells["ID"].Value.ToString());
                var izin = izinRepo.Bul(x => x.izin_id == id);

                if (izin != null)
                {
                    izin.onay_durumu = durum;
                    izinRepo.Guncelle(izin);
                    Listele();
                }
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            DurumGuncelle(1);
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            DurumGuncelle(2);
        }
    }
}