using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmDepartmanlar : Form
    {
        private Repository<departmanlar> repo = new Repository<departmanlar>();
        private bool surukleniyor = false;
        private Point baslangicNoktasi;

        public FrmDepartmanlar()
        {
            InitializeComponent();
        }

        private void FrmDepartmanlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            gridDepartman.DataSource = repo.Listele().Select(x => new { ID = x.departman_id, Ad = x.departman_adi, Durum = x.aktif_mi }).ToList();
        }

        private void GridDepartman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDepartman.CurrentRow != null)
            {
                txtAd.Text = gridDepartman.CurrentRow.Cells["Ad"].Value.ToString();
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAd.Text))
            {
                departmanlar d = new departmanlar { departman_adi = txtAd.Text, aktif_mi = true };
                repo.Ekle(d);
                Listele();
                txtAd.Text = "";
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (gridDepartman.CurrentRow != null)
            {
                int id = (int)gridDepartman.CurrentRow.Cells["ID"].Value;
                var d = repo.Bul(x => x.departman_id == id);
                d.departman_adi = txtAd.Text;
                repo.Guncelle(d);
                Listele();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (gridDepartman.CurrentRow != null)
            {
                int id = (int)gridDepartman.CurrentRow.Cells["ID"].Value;
                repo.Sil(id); // Veya aktif_mi = false yapilabilir
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