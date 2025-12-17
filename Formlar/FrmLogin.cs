using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmLogin : Form
    {
        private bool surukleniyor = false;
        private Point baslangicNoktasi;
        private Repository<kullanicilar> kullaniciRepo = new Repository<kullanicilar>();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
        }

        private void DilCevirileriniUygula()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_GIRIS_BASLIK");
            lblKullaniciAdi.Text = DilYonetimi.Get("LBL_KULLANICI_ADI");
            lblSifre.Text = DilYonetimi.Get("LBL_SIFRE");
            btnGiris.Text = DilYonetimi.Get("BTN_GIRIS_YAP");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                Location = new Point(p.X - baslangicNoktasi.X, p.Y - baslangicNoktasi.Y);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show(DilYonetimi.Get("MSG_BOS_ALAN"), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string girilenSifreHash = Sha256Hash(txtSifre.Text);
            var kullanici = kullaniciRepo.Bul(k => k.kullanici_adi == txtKullaniciAdi.Text && k.sifre_hash == girilenSifreHash);

            if (kullanici != null)
            {
                MessageBox.Show($"{DilYonetimi.Get("MSG_GIRIS_BASARILI")} {kullanici.kullanici_adi}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kullanici.son_giris = DateTime.Now;
                kullaniciRepo.Guncelle(kullanici);

                FrmAnaForm frm = new FrmAnaForm(kullanici);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(DilYonetimi.Get("MSG_HATALI_GIRIS"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }

        private string Sha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}