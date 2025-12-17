using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmPersonelListesi : Form
    {
        private Repository<personeller> personelRepo = new Repository<personeller>();

        public FrmPersonelListesi()
        {
            InitializeComponent();
        }

        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            Listele();
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_PERSONEL_LISTESI_BASLIK");
            lblAraAd.Text = DilYonetimi.Get("LBL_ARA_AD");
            btnAra.Text = DilYonetimi.Get("BTN_ARA");
            btnTemizle.Text = DilYonetimi.Get("BTN_TEMIZLE");
            btnYeniEkle.Text = DilYonetimi.Get("BTN_YENI_PERSONEL");
            btnDuzenle.Text = DilYonetimi.Get("BTN_DUZENLE");
            btnSil.Text = DilYonetimi.Get("BTN_SIL_PERSONEL");
        }

        private void Listele()
        {
            var db = Baglanti.db;

            var liste = (from p in db.personellers
                         join d in db.departmanlars on p.departman_id equals d.departman_id
                         join poz in db.pozisyonlars on p.pozisyon_id equals poz.pozisyon_id
                         where p.calisma_durumu == "aktif"
                         select new
                         {
                             ID = p.personel_id,
                             TC = p.tc_kimlik_no,
                             Ad = p.ad,
                             Soyad = p.soyad,
                             Departman = d.departman_adi,
                             Pozisyon = poz.pozisyon_adi,
                             IseGiris = p.ise_giris_tarihi,
                             Durum = p.calisma_durumu
                         }).ToList();

            if (!string.IsNullOrEmpty(txtAraAd.Text))
            {
                liste = liste.Where(x => x.Ad.ToLower().Contains(txtAraAd.Text.ToLower()) ||
                                         x.Soyad.ToLower().Contains(txtAraAd.Text.ToLower())).ToList();
            }

            gridPersonel.DataSource = liste;

            // Grid Kolon Basliklarini Dil Sistemine Gore Duzenle
            gridPersonel.Columns["ID"].Visible = false;
            gridPersonel.Columns["TC"].HeaderText = DilYonetimi.Get("COL_TC");
            gridPersonel.Columns["Ad"].HeaderText = DilYonetimi.Get("COL_AD");
            gridPersonel.Columns["Soyad"].HeaderText = DilYonetimi.Get("COL_SOYAD");
            gridPersonel.Columns["Departman"].HeaderText = DilYonetimi.Get("COL_DEPARTMAN");
            gridPersonel.Columns["Pozisyon"].HeaderText = DilYonetimi.Get("COL_POZISYON");
            gridPersonel.Columns["IseGiris"].HeaderText = DilYonetimi.Get("COL_ISE_GIRIS");
            gridPersonel.Columns["Durum"].HeaderText = DilYonetimi.Get("COL_DURUM");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAraAd.Text = "";
            Listele();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelEkle frm = new FrmPersonelEkle();
            frm.ShowDialog();
            Listele(); // Ekleme bitince listeyi yenile
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridPersonel.SelectedRows.Count > 0)
            {
                int id = int.Parse(gridPersonel.SelectedRows[0].Cells["ID"].Value.ToString());
                FrmPersonelEkle frm = new FrmPersonelEkle(id);
                frm.ShowDialog();
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridPersonel.SelectedRows.Count > 0)
            {
                DialogResult cvp = MessageBox.Show(DilYonetimi.Get("MSG_SILME_ONAY"), "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cvp == DialogResult.Yes)
                {
                    int id = int.Parse(gridPersonel.SelectedRows[0].Cells["ID"].Value.ToString());
                    var personel = personelRepo.Bul(x => x.personel_id == id);
                    if (personel != null)
                    {
                        // Enterprise sistemlerde veriyi fiziksel silmeyiz, durumunu degistiririz (Soft Delete)
                        personel.calisma_durumu = "silindi";
                        personelRepo.Guncelle(personel);
                        Listele();
                    }
                }
            }
        }
    }
}