using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmMaasListesi : Form
    {
        public FrmMaasListesi()
        {
            InitializeComponent();
        }

        private void FrmMaasListesi_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            Listele();
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_MAAS_LISTESI_BASLIK");
            btnYeniOdeme.Text = DilYonetimi.Get("BTN_YENI_ODEME");
        }

        private void Listele()
        {
            var db = Baglanti.db;
            var liste = from m in db.maas_bordro
                        join p in db.personellers on m.personel_id equals p.personel_id
                        orderby m.yil descending, m.ay descending
                        select new
                        {
                            ID = m.bordro_id,
                            AdSoyad = p.ad + " " + p.soyad,
                            Yil = m.yil,
                            Ay = m.ay,
                            Brut = m.brut_maas,
                            Prim = m.primler,
                            Kesinti = m.kesintiler,
                            Net = m.net_odenen,
                            Tarih = m.odeme_tarihi
                        };

            gridMaaslar.DataSource = liste.ToList();

            gridMaaslar.Columns["ID"].Visible = false;
            gridMaaslar.Columns["AdSoyad"].HeaderText = DilYonetimi.Get("COL_AD") + " " + DilYonetimi.Get("COL_SOYAD");
            gridMaaslar.Columns["Yil"].HeaderText = DilYonetimi.Get("COL_YIL");
            gridMaaslar.Columns["Ay"].HeaderText = DilYonetimi.Get("COL_AY");
            gridMaaslar.Columns["Brut"].HeaderText = DilYonetimi.Get("COL_BRUT");
            gridMaaslar.Columns["Net"].HeaderText = DilYonetimi.Get("COL_NET");
        }

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            FrmMaasOdeme frm = new FrmMaasOdeme();
            frm.ShowDialog();
            Listele();
        }
    }
}