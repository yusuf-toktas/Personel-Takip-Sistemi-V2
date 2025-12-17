using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmMaasOdeme : Form
    {
        private bool surukleniyor = false;
        private Point baslangicNoktasi;
        private Repository<maas_bordro> maasRepo = new Repository<maas_bordro>();

        public FrmMaasOdeme()
        {
            InitializeComponent();
        }

        private void FrmMaasOdeme_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            PersonelleriDoldur();

            // Varsayilan olarak bu ay ve yil
            numYil.Value = DateTime.Now.Year;
            cmbAy.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_MAAS_ODEME_BASLIK");
            lblPersonel.Text = DilYonetimi.Get("LBL_PERSONEL_SEC");
            lblDonem.Text = DilYonetimi.Get("LBL_DONEM");
            lblAnaMaas.Text = DilYonetimi.Get("LBL_ANA_MAAS");
            lblEkOdeme.Text = DilYonetimi.Get("LBL_EK_ODEME");
            lblKesinti.Text = DilYonetimi.Get("LBL_KESINTI");
            lblNet.Text = DilYonetimi.Get("LBL_NET_ODENECEK");
            btnKaydet.Text = DilYonetimi.Get("BTN_KAYDET");
        }

        private void PersonelleriDoldur()
        {
            var db = Baglanti.db;
            var liste = db.personellers.Where(x => x.calisma_durumu == "aktif")
                .Select(x => new
                {
                    ID = x.personel_id,
                    AdSoyad = x.ad + " " + x.soyad
                }).ToList();

            cmbPersonel.DataSource = liste;
            cmbPersonel.DisplayMember = "AdSoyad";
            cmbPersonel.ValueMember = "ID";
            cmbPersonel.SelectedIndex = -1;
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedValue != null)
            {
                int id;
                if (int.TryParse(cmbPersonel.SelectedValue.ToString(), out id))
                {
                    var db = Baglanti.db;
                    var p = db.personellers.Find(id);
                    if (p != null)
                    {
                        numAnaMaas.Value = (decimal)(p.ucret ?? 0);
                        Hesapla();
                    }
                }
            }
        }

        private void Hesapla()
        {
            decimal anaMaas = numAnaMaas.Value;
            decimal ek = numEkOdeme.Value;
            decimal kesinti = numKesinti.Value;

            decimal net = (anaMaas + ek) - kesinti;
            lblHesaplananNet.Text = net.ToString("C2");
        }

        private void numEkOdeme_ValueChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void numKesinti_ValueChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedValue == null)
            {
                MessageBox.Show(DilYonetimi.Get("MSG_BOS_ALAN"), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int personelId = (int)cmbPersonel.SelectedValue;
            int yil = (int)numYil.Value;
            int ay = cmbAy.SelectedIndex + 1;

            // Mukerrer kayit kontrolu
            var db = Baglanti.db;
            var kontrol = db.maas_bordro.FirstOrDefault(x => x.personel_id == personelId && x.yil == yil && x.ay == ay);

            if (kontrol != null)
            {
                MessageBox.Show(DilYonetimi.Get("MSG_ODEME_VAR"), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            maas_bordro bordro = new maas_bordro();
            bordro.personel_id = personelId;
            bordro.yil = yil;
            bordro.ay = ay;
            bordro.brut_maas = numAnaMaas.Value;
            bordro.primler = numEkOdeme.Value;
            bordro.kesintiler = numKesinti.Value;

            // Net maasi tekrar hesapla garanti olsun
            bordro.net_odenen = (bordro.brut_maas + bordro.primler) - bordro.kesintiler;
            bordro.odeme_tarihi = DateTime.Now;
            bordro.durum = true; // Odendi

            maasRepo.Ekle(bordro);

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