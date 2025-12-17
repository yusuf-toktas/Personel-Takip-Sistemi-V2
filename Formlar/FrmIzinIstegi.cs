using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmIzinIstegi : Form
    {
        private bool surukleniyor = false;
        private Point baslangicNoktasi;
        private Repository<izinler> izinRepo = new Repository<izinler>();
        private kullanicilar _aktifKullanici;

        // Formu acarken aktif kullaniciyi parametre olarak aliyoruz
        public FrmIzinIstegi(kullanicilar kullanici)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
        }

        private void FrmIzinIstegi_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            TurleriDoldur();
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_IZIN_ISTEGI_BASLIK");
            lblIzinTuru.Text = DilYonetimi.Get("COL_IZIN_TURU");
            lblBaslangic.Text = DilYonetimi.Get("COL_BASLANGIC");
            lblBitis.Text = DilYonetimi.Get("COL_BITIS");
            lblGunSayisi.Text = DilYonetimi.Get("COL_GUN");
            lblAciklama.Text = DilYonetimi.Get("LBL_ACIKLAMA");
            btnKaydet.Text = DilYonetimi.Get("BTN_KAYDET");
        }

        private void TurleriDoldur()
        {
            var db = Baglanti.db;
            cmbIzinTuru.DataSource = db.izin_turleri.ToList();
            cmbIzinTuru.DisplayMember = "tur_adi";
            cmbIzinTuru.ValueMember = "tur_id";
        }

        private void GunHesapla()
        {
            TimeSpan fark = dtpBitis.Value.Date - dtpBaslangic.Value.Date;
            // Eger ayni gunse 1 gun sayilir
            double gun = fark.TotalDays + 1;

            if (gun < 0)
            {
                lblHesaplananGun.Text = "Hata";
                lblHesaplananGun.ForeColor = Color.Red;
            }
            else
            {
                lblHesaplananGun.Text = gun.ToString();
                lblHesaplananGun.ForeColor = Color.Black;
            }
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            GunHesapla();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            GunHesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dtpBitis.Value.Date < dtpBaslangic.Value.Date)
            {
                MessageBox.Show(DilYonetimi.Get("MSG_TARIH_HATA"), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            izinler yeniIzin = new izinler();
            yeniIzin.personel_id = _aktifKullanici.personel_id; // Giris yapan personel
            yeniIzin.tur_id = (int)cmbIzinTuru.SelectedValue;
            yeniIzin.baslangic = dtpBaslangic.Value;
            yeniIzin.bitis = dtpBitis.Value;
            yeniIzin.gun_sayisi = decimal.Parse(lblHesaplananGun.Text);
            yeniIzin.adres_telefon = txtAciklama.Text; // Aciklama alani
            yeniIzin.onay_durumu = 0; // 0: Bekliyor

            izinRepo.Ekle(yeniIzin);
            MessageBox.Show(DilYonetimi.Get("MSG_ISLEM_BASARILI"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlUst_MouseDown(object sender, MouseEventArgs e)
        {
            surukleniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void pnlUst_MouseUp(object sender, MouseEventArgs e)
        {
            surukleniyor = false;
        }

        private void pnlUst_MouseMove(object sender, MouseEventArgs e)
        {
            if (surukleniyor)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - baslangicNoktasi.X, p.Y - baslangicNoktasi.Y);
            }
        }
    }
}