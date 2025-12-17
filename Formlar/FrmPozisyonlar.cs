using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmPozisyonlar : Form
    {
        private Repository<pozisyonlar> repo = new Repository<pozisyonlar>();
        private bool surukleniyor = false;
        private Point baslangicNoktasi;

        public FrmPozisyonlar()
        {
            InitializeComponent();
        }

        private void FrmPozisyonlar_Load(object sender, EventArgs e)
        {
            DepartmanlariDoldur();
            Listele();
        }

        private void DepartmanlariDoldur()
        {
            var db = Baglanti.db;
            cmbDepartman.DataSource = db.departmanlars.ToList();
            cmbDepartman.DisplayMember = "departman_adi";
            cmbDepartman.ValueMember = "departman_id";
        }

        private void Listele()
        {
            var db = Baglanti.db;
            var liste = from p in db.pozisyonlars
                        join d in db.departmanlars on p.departman_id equals d.departman_id
                        select new { ID = p.pozisyon_id, Departman = d.departman_adi, Pozisyon = p.pozisyon_adi };
            gridPozisyon.DataSource = liste.ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (cmbDepartman.SelectedValue != null && !string.IsNullOrEmpty(txtAd.Text))
            {
                pozisyonlar p = new pozisyonlar();
                p.departman_id = (int)cmbDepartman.SelectedValue;
                p.pozisyon_adi = txtAd.Text;
                p.aktif_mi = true;
                repo.Ekle(p);
                Listele();
            }
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