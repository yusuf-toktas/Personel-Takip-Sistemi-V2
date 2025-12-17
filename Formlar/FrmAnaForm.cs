using System;
using System.Drawing;
using System.Windows.Forms;
using Personel_Takip_Sistemi.Database;
using Personel_Takip_Sistemi.Siniflar;

namespace Personel_Takip_Sistemi.Formlar
{
    public partial class FrmAnaForm : Form
    {
        private kullanicilar _aktifKullanici;
        private bool surukleniyor = false;
        private Point baslangicNoktasi;

        public FrmAnaForm(kullanicilar kullanici)
        {
            InitializeComponent();
            _aktifKullanici = kullanici;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            DilCevirileriniUygula();
            RolveYetkiYonetimi();
            KullaniciBilgileriniGetir();
            DashboardAc();
        }

        private void DilCevirileriniUygula()
        {
            btnPersonel.Text = DilYonetimi.Get("BTN_PERSONEL_YONETIMI");
            btnIzin.Text = DilYonetimi.Get("BTN_IZIN_HAREKETLERI");
            btnMaas.Text = DilYonetimi.Get("BTN_MAAS_ODEMELER");
            btnZimmet.Text = DilYonetimi.Get("BTN_ZIMMET_YONETIMI");
            btnMesai.Text = DilYonetimi.Get("BTN_EK_MESAI");
            btnRaporlar.Text = DilYonetimi.Get("BTN_RAPORLAR");
            btnAyarlar.Text = DilYonetimi.Get("BTN_SISTEM_AYARLARI");
            btnCikis.Text = DilYonetimi.Get("BTN_CIKIS_YAP");

            lblBaslik.Text = DilYonetimi.Get("LBL_ANASAYFA_BASLIK");
        }

        private void DashboardAc()
        {
            lblBaslik.Text = DilYonetimi.Get("LBL_ANASAYFA_BASLIK");
            FrmDashboard frm = new FrmDashboard();
            ChildFormAc(frm);
        }

        private void KullaniciBilgileriniGetir()
        {
            if (_aktifKullanici != null)
            {
                string aktifKullaniciLbl = DilYonetimi.Get("LBL_AKTIF_KULLANICI");
                lblAktifKullanici.Text = $"{aktifKullaniciLbl}: {_aktifKullanici.kullanici_adi} ({_aktifKullanici.rol_yetkisi.ToUpper()})";
            }
        }

        private void RolveYetkiYonetimi()
        {
            if (_aktifKullanici.rol_yetkisi == "user" || _aktifKullanici.rol_yetkisi == "ik_user")
            {
                btnAyarlar.Visible = false;
                btnMaas.Visible = false;
            }
        }

        private void ChildFormAc(Form childForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        // --- BUTON OLAYLARI ---

        private void pnlLogo_Click(object sender, EventArgs e)
        {
            DashboardAc();
        }

        private void lblProjeAdi_Click(object sender, EventArgs e)
        {
            DashboardAc();
        }

        private void lblVersiyon_Click(object sender, EventArgs e)
        {
            DashboardAc();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_PERSONEL_YONETIMI");
            FrmPersonelListesi frm = new FrmPersonelListesi();
            ChildFormAc(frm);
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_IZIN_HAREKETLERI");
            FrmIzinListesi frm = new FrmIzinListesi(_aktifKullanici);
            ChildFormAc(frm);
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_MAAS_ODEMELER");
            FrmMaasListesi frm = new FrmMaasListesi();
            ChildFormAc(frm);
        }

        private void btnZimmet_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_ZIMMET_YONETIMI");
            FrmZimmetler frm = new FrmZimmetler();
            ChildFormAc(frm);
        }

        private void btnMesai_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_EK_MESAI");
            FrmMesaiEkle frm = new FrmMesaiEkle();
            ChildFormAc(frm);
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_RAPORLAR");
            FrmRaporlar frm = new FrmRaporlar();
            ChildFormAc(frm);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = DilYonetimi.Get("BTN_SISTEM_AYARLARI");
            FrmAyarlar frm = new FrmAyarlar();
            ChildFormAc(frm);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnSimge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlUst_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                surukleniyor = true;
                baslangicNoktasi = new Point(e.X, e.Y);
            }
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