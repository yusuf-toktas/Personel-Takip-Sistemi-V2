using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmPersonelEkle : Form
    {
        private int _personelId = 0;
        private bool surukleniyor = false;
        private Point baslangicNoktasi;
        private Repository<personeller> personelRepo = new Repository<personeller>();
        private string secilenResimYolu = "";

        // Constructor 1: Yeni Kayit
        public FrmPersonelEkle()
        {
            InitializeComponent();
            _personelId = 0;
        }

        // Constructor 2: Duzenleme
        public FrmPersonelEkle(int id)
        {
            InitializeComponent();
            _personelId = id;
        }

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            CombolariDoldur();

            if (_personelId > 0)
            {
                BilgileriGetir(_personelId);
            }
            else
            {
                cmbDurum.SelectedIndex = 0; // Default Aktif
            }
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_PERSONEL_ISLEM_BASLIK");
            tabGenel.Text = DilYonetimi.Get("TAB_GENEL");
            tabKurumsal.Text = DilYonetimi.Get("TAB_KURUMSAL");
            tabIletisim.Text = DilYonetimi.Get("TAB_ILETISIM");

            // Labels
            lblTC.Text = DilYonetimi.Get("COL_TC");
            lblAd.Text = DilYonetimi.Get("COL_AD");
            lblSoyad.Text = DilYonetimi.Get("COL_SOYAD");
            lblCinsiyet.Text = DilYonetimi.Get("LBL_CINSIYET");
            lblDogumTarihi.Text = DilYonetimi.Get("LBL_DOGUM_TARIHI");

            lblSube.Text = DilYonetimi.Get("LBL_SUBE");
            lblDepartman.Text = DilYonetimi.Get("COL_DEPARTMAN");
            lblPozisyon.Text = DilYonetimi.Get("COL_POZISYON");
            lblYonetici.Text = DilYonetimi.Get("LBL_YONETICI");
            lblIseGiris.Text = DilYonetimi.Get("COL_ISE_GIRIS");
            lblMaas.Text = DilYonetimi.Get("LBL_UCRET");
            lblDurum.Text = DilYonetimi.Get("COL_DURUM");

            lblCepTel.Text = DilYonetimi.Get("LBL_CEP_TEL");
            lblSirketMail.Text = DilYonetimi.Get("LBL_SIRKET_MAIL");
            lblAdres.Text = DilYonetimi.Get("LBL_ADRES");

            btnResimSec.Text = DilYonetimi.Get("BTN_RESIM_SEC");
            btnKaydet.Text = DilYonetimi.Get("BTN_KAYDET");
        }

        private void CombolariDoldur()
        {
            var db = Baglanti.db;

            // Subeler
            cmbSube.DataSource = db.subelers.ToList();
            cmbSube.DisplayMember = "sube_adi";
            cmbSube.ValueMember = "sube_id";

            // Departmanlar
            cmbDepartman.DataSource = db.departmanlars.ToList();
            cmbDepartman.DisplayMember = "departman_adi";
            cmbDepartman.ValueMember = "departman_id";

            // Yoneticiler (Sadece Yonetici pozisyonundakiler gelebilir mantigi kurabiliriz ama simdilik hepsi gelsin)
            var yoneticiler = db.personellers.Select(x => new {
                ID = x.personel_id,
                AdSoyad = x.ad + " " + x.soyad
            }).ToList();
            cmbYonetici.DataSource = yoneticiler;
            cmbYonetici.DisplayMember = "AdSoyad";
            cmbYonetici.ValueMember = "ID";
            cmbYonetici.SelectedIndex = -1;
        }

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Secilen departmana gore pozisyonlari getir (Cascading Dropdown)
            if (cmbDepartman.SelectedValue != null)
            {
                int depId;
                if (int.TryParse(cmbDepartman.SelectedValue.ToString(), out depId))
                {
                    var db = Baglanti.db;
                    var pozisyonlar = db.pozisyonlars.Where(x => x.departman_id == depId).ToList();
                    cmbPozisyon.DataSource = pozisyonlar;
                    cmbPozisyon.DisplayMember = "pozisyon_adi";
                    cmbPozisyon.ValueMember = "pozisyon_id";
                }
            }
        }

        private void BilgileriGetir(int id)
        {
            var p = personelRepo.Bul(x => x.personel_id == id);
            if (p != null)
            {
                txtTC.Text = p.tc_kimlik_no;
                txtAd.Text = p.ad;
                txtSoyad.Text = p.soyad;
                cmbCinsiyet.Text = p.cinsiyet;
                dtpDogumTarihi.Value = p.dogum_tarihi ?? DateTime.Now;

                cmbSube.SelectedValue = p.sube_id;
                cmbDepartman.SelectedValue = p.departman_id;
                // Pozisyonlar departman change eventi ile dolacak, sonra sececegiz
                cmbPozisyon.SelectedValue = p.pozisyon_id;

                if (p.yonetici_id != null)
                    cmbYonetici.SelectedValue = p.yonetici_id;

                dtpIseGiris.Value = p.ise_giris_tarihi;
                numMaas.Value = (decimal)(p.ucret ?? 0);
                cmbDurum.Text = p.calisma_durumu;

                txtCepTel.Text = p.cep_telefonu;
                txtSirketMail.Text = p.email_sirket;
                txtAdres.Text = p.ikametgah_adresi;

                if (!string.IsNullOrEmpty(p.resim_yolu) && File.Exists(p.resim_yolu))
                {
                    pbResim.ImageLocation = p.resim_yolu;
                    secilenResimYolu = p.resim_yolu;
                }
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbResim.ImageLocation = openFileDialog1.FileName;
                // Resmi gecici olarak degiskene aliyoruz, kaydet basinca kopyalayacagiz
                secilenResimYolu = openFileDialog1.FileName;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Basit Validasyon
            if (string.IsNullOrEmpty(txtTC.Text) || string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show(DilYonetimi.Get("MSG_BOS_ALAN"), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            personeller p;
            if (_personelId > 0)
                p = personelRepo.Bul(x => x.personel_id == _personelId);
            else
                p = new personeller();

            // Atamalar
            p.tc_kimlik_no = txtTC.Text;
            p.sicil_no = "SICIL-" + new Random().Next(1000, 9999); // Otomatik Sicil
            p.ad = txtAd.Text;
            p.soyad = txtSoyad.Text;
            p.cinsiyet = cmbCinsiyet.Text;
            p.dogum_tarihi = dtpDogumTarihi.Value;

            p.sube_id = (int)cmbSube.SelectedValue;
            p.departman_id = (int)cmbDepartman.SelectedValue;
            p.pozisyon_id = (int)cmbPozisyon.SelectedValue;

            if (cmbYonetici.SelectedValue != null)
                p.yonetici_id = (int)cmbYonetici.SelectedValue;

            p.ise_giris_tarihi = dtpIseGiris.Value;
            p.ucret = numMaas.Value;
            p.calisma_durumu = cmbDurum.Text;

            p.cep_telefonu = txtCepTel.Text;
            p.email_sirket = txtSirketMail.Text;
            p.ikametgah_adresi = txtAdres.Text;

            // Resim Kaydetme Islemi
            if (!string.IsNullOrEmpty(secilenResimYolu) && secilenResimYolu != p.resim_yolu)
            {
                string hedefKlasor = Application.StartupPath + "\\Resimler";
                if (!Directory.Exists(hedefKlasor)) Directory.CreateDirectory(hedefKlasor);

                string dosyaAdi = Guid.NewGuid() + Path.GetExtension(secilenResimYolu);
                string hedefYol = Path.Combine(hedefKlasor, dosyaAdi);

                File.Copy(secilenResimYolu, hedefYol);
                p.resim_yolu = hedefYol;
            }

            // DB Islemi
            if (_personelId > 0)
                personelRepo.Guncelle(p);
            else
                personelRepo.Ekle(p);

            MessageBox.Show(DilYonetimi.Get("MSG_KAYIT_BASARILI"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Pencere Surukleme
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