using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmZimmetler : Form
    {
        private Repository<demirbaslar> repo = new Repository<demirbaslar>();

        public FrmZimmetler()
        {
            InitializeComponent();
        }

        private void FrmZimmetler_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            PersonelleriYukle();
            Listele();
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_ZIMMET_YONETIMI");
            btnZimmetle.Text = "ZİMMETLE";
            lblP.Text = DilYonetimi.Get("LBL_ZIMMETLI_PERSONEL");
            lblK.Text = DilYonetimi.Get("LBL_KATEGORI");
            lblM.Text = DilYonetimi.Get("LBL_URUN_ADI");
            lblS.Text = DilYonetimi.Get("LBL_SERI_NO");
        }

        private void PersonelleriYukle()
        {
            var db = Baglanti.db;
            var list = db.personellers.Where(x => x.calisma_durumu == "aktif").Select(x => new { ID = x.personel_id, Ad = x.ad + " " + x.soyad }).ToList();
            cmbPersonel.DataSource = list;
            cmbPersonel.DisplayMember = "Ad";
            cmbPersonel.ValueMember = "ID";
        }

        private void Listele()
        {
            var db = Baglanti.db;
            var liste = from d in db.demirbaslars
                        join p in db.personellers on d.personel_id equals p.personel_id
                        select new
                        {
                            Kategori = d.kategori,
                            Urun = d.marka_model,
                            SeriNo = d.seri_no,
                            ZimmetliKisi = p.ad + " " + p.soyad,
                            Tarih = d.alim_tarihi
                        };
            gridZimmet.DataSource = liste.ToList();
        }

        private void BtnZimmetle_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedValue != null)
            {
                demirbaslar d = new demirbaslar();
                d.personel_id = (int)cmbPersonel.SelectedValue;
                d.kategori = txtKategori.Text;
                d.marka_model = txtMarka.Text;
                d.seri_no = txtSeriNo.Text;
                d.alim_tarihi = DateTime.Now;

                repo.Ekle(d);
                Listele();
                MessageBox.Show(DilYonetimi.Get("MSG_ISLEM_BASARILI"), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}