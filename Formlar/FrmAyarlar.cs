using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            DilCevirileriniYukle();
            DilleriComboboxaDoldur();
        }

        private void DilCevirileriniYukle()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_AYARLAR_BASLIK");
            lblDil.Text = DilYonetimi.Get("LBL_DIL_SECIMI");
            btnKaydet.Text = DilYonetimi.Get("BTN_KAYDET");

            btnDepartman.Text = DilYonetimi.Get("BTN_DEPARTMAN_YONETIMI");
            btnPozisyon.Text = DilYonetimi.Get("BTN_UNVAN_YONETIMI");
        }

        private void DilleriComboboxaDoldur()
        {
            var db = Baglanti.db;
            var diller = db.dil_tanimlari.Where(x => x.aktif_mi == true).ToList();

            cmbDil.DataSource = diller;
            cmbDil.DisplayMember = "dil_adi";
            cmbDil.ValueMember = "dil_kodu";

            cmbDil.SelectedValue = DilYonetimi.MevcutDil;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string secilenDil = cmbDil.SelectedValue.ToString();
            AyarlarYonetimi.AyarlariKaydet(secilenDil);
            MessageBox.Show(DilYonetimi.Get("MSG_AYAR_KAYDEDILDI"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            FrmDepartmanlar frm = new FrmDepartmanlar();
            frm.ShowDialog();
        }

        private void btnPozisyon_Click(object sender, EventArgs e)
        {
            FrmPozisyonlar frm = new FrmPozisyonlar();
            frm.ShowDialog();
        }
    }
}