using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmMesaiEkle : Form
    {
        private Repository<mesailer> repo = new Repository<mesailer>();

        public FrmMesaiEkle()
        {
            InitializeComponent();
        }

        private void FrmMesaiEkle_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            var db = Baglanti.db;
            cmbPersonel.DataSource = db.personellers.Where(x => x.calisma_durumu == "aktif").Select(x => new { ID = x.personel_id, Ad = x.ad + " " + x.soyad }).ToList();
            cmbPersonel.DisplayMember = "Ad";
            cmbPersonel.ValueMember = "ID";
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_EK_MESAI");
            lblP.Text = DilYonetimi.Get("LBL_ZIMMETLI_PERSONEL");
            lblBas.Text = DilYonetimi.Get("LBL_MESAI_BASLANGIC");
            lblBit.Text = DilYonetimi.Get("LBL_MESAI_BITIS");
            lblUcret.Text = DilYonetimi.Get("LBL_SAAT_UCRETI");
            lblTutar.Text = DilYonetimi.Get("LBL_TOPLAM_TUTAR");
            btnKaydet.Text = "KAYDET";
        }

        private void Hesapla(object sender, EventArgs e)
        {
            TimeSpan fark = dtpBitis.Value - dtpBaslangic.Value;
            double saat = fark.TotalHours;

            if (saat < 0) saat += 24;

            decimal tutar = (decimal)saat * numSaatUcreti.Value;
            lblToplamTutar.Text = tutar.ToString("C2");
            lblToplamTutar.Tag = tutar;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedValue != null)
            {
                mesailer m = new mesailer();
                m.personel_id = (int)cmbPersonel.SelectedValue;
                m.baslangic_saati = dtpBaslangic.Value;
                m.bitis_saati = dtpBitis.Value;

                TimeSpan fark = dtpBitis.Value - dtpBaslangic.Value;
                double saat = fark.TotalHours;
                if (saat < 0) saat += 24;

                m.toplam_saat = (decimal)saat;
                m.saat_ucreti = numSaatUcreti.Value;
                m.toplam_tutar = (decimal)(lblToplamTutar.Tag ?? 0);
                m.tarih = DateTime.Now;
                m.onay_durumu = true;

                repo.Ekle(m);
                MessageBox.Show(DilYonetimi.Get("MSG_ISLEM_BASARILI"), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}