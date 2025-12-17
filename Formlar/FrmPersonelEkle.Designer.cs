namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmPersonelEkle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.tabKurumsal = new System.Windows.Forms.TabPage();
            this.numMaas = new System.Windows.Forms.NumericUpDown();
            this.dtpIseGiris = new System.Windows.Forms.DateTimePicker();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbYonetici = new System.Windows.Forms.ComboBox();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblIseGiris = new System.Windows.Forms.Label();
            this.lblYonetici = new System.Windows.Forms.Label();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblSube = new System.Windows.Forms.Label();
            this.tabIletisim = new System.Windows.Forms.TabPage();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSirketMail = new System.Windows.Forms.TextBox();
            this.txtCepTel = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSirketMail = new System.Windows.Forms.Label();
            this.lblCepTel = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlUst.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.tabKurumsal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).BeginInit();
            this.tabIletisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(600, 40);
            this.pnlUst.TabIndex = 0;
            this.pnlUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseDown);
            this.pnlUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseMove);
            this.pnlUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseUp);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(12, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(144, 21);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Personel İşlemleri";
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(560, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(40, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGenel);
            this.tabControl1.Controls.Add(this.tabKurumsal);
            this.tabControl1.Controls.Add(this.tabIletisim);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 420);
            this.tabControl1.TabIndex = 1;
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.btnResimSec);
            this.tabGenel.Controls.Add(this.pbResim);
            this.tabGenel.Controls.Add(this.dtpDogumTarihi);
            this.tabGenel.Controls.Add(this.cmbCinsiyet);
            this.tabGenel.Controls.Add(this.txtSoyad);
            this.tabGenel.Controls.Add(this.txtAd);
            this.tabGenel.Controls.Add(this.txtTC);
            this.tabGenel.Controls.Add(this.lblDogumTarihi);
            this.tabGenel.Controls.Add(this.lblCinsiyet);
            this.tabGenel.Controls.Add(this.lblSoyad);
            this.tabGenel.Controls.Add(this.lblAd);
            this.tabGenel.Controls.Add(this.lblTC);
            this.tabGenel.Location = new System.Drawing.Point(4, 26);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenel.Size = new System.Drawing.Size(568, 390);
            this.tabGenel.TabIndex = 0;
            this.tabGenel.Text = "Genel Bilgiler";
            this.tabGenel.UseVisualStyleBackColor = true;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(380, 180);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(150, 30);
            this.btnResimSec.TabIndex = 11;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(380, 20);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(150, 150);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 10;
            this.pbResim.TabStop = false;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(130, 180);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 25);
            this.dtpDogumTarihi.TabIndex = 9;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(130, 140);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(200, 25);
            this.cmbCinsiyet.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(130, 100);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 25);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(130, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 25);
            this.txtAd.TabIndex = 6;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(130, 20);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 25);
            this.txtTC.TabIndex = 5;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(20, 185);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(90, 19);
            this.lblDogumTarihi.TabIndex = 4;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(20, 145);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(57, 19);
            this.lblCinsiyet.TabIndex = 3;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(20, 105);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(45, 19);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(20, 65);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(26, 19);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(20, 25);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(84, 19);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC Kimlik No";
            // 
            // tabKurumsal
            // 
            this.tabKurumsal.Controls.Add(this.numMaas);
            this.tabKurumsal.Controls.Add(this.dtpIseGiris);
            this.tabKurumsal.Controls.Add(this.cmbDurum);
            this.tabKurumsal.Controls.Add(this.cmbYonetici);
            this.tabKurumsal.Controls.Add(this.cmbPozisyon);
            this.tabKurumsal.Controls.Add(this.cmbDepartman);
            this.tabKurumsal.Controls.Add(this.cmbSube);
            this.tabKurumsal.Controls.Add(this.lblDurum);
            this.tabKurumsal.Controls.Add(this.lblMaas);
            this.tabKurumsal.Controls.Add(this.lblIseGiris);
            this.tabKurumsal.Controls.Add(this.lblYonetici);
            this.tabKurumsal.Controls.Add(this.lblPozisyon);
            this.tabKurumsal.Controls.Add(this.lblDepartman);
            this.tabKurumsal.Controls.Add(this.lblSube);
            this.tabKurumsal.Location = new System.Drawing.Point(4, 26);
            this.tabKurumsal.Name = "tabKurumsal";
            this.tabKurumsal.Padding = new System.Windows.Forms.Padding(3);
            this.tabKurumsal.Size = new System.Drawing.Size(568, 390);
            this.tabKurumsal.TabIndex = 1;
            this.tabKurumsal.Text = "Kurumsal Bilgiler";
            this.tabKurumsal.UseVisualStyleBackColor = true;
            // 
            // numMaas
            // 
            this.numMaas.DecimalPlaces = 2;
            this.numMaas.Location = new System.Drawing.Point(130, 220);
            this.numMaas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMaas.Name = "numMaas";
            this.numMaas.Size = new System.Drawing.Size(200, 25);
            this.numMaas.TabIndex = 13;
            this.numMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpIseGiris
            // 
            this.dtpIseGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIseGiris.Location = new System.Drawing.Point(130, 180);
            this.dtpIseGiris.Name = "dtpIseGiris";
            this.dtpIseGiris.Size = new System.Drawing.Size(200, 25);
            this.dtpIseGiris.TabIndex = 12;
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "aktif",
            "pasif",
            "izinli",
            "askida"});
            this.cmbDurum.Location = new System.Drawing.Point(130, 260);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(200, 25);
            this.cmbDurum.TabIndex = 11;
            // 
            // cmbYonetici
            // 
            this.cmbYonetici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYonetici.FormattingEnabled = true;
            this.cmbYonetici.Location = new System.Drawing.Point(130, 140);
            this.cmbYonetici.Name = "cmbYonetici";
            this.cmbYonetici.Size = new System.Drawing.Size(200, 25);
            this.cmbYonetici.TabIndex = 10;
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozisyon.FormattingEnabled = true;
            this.cmbPozisyon.Location = new System.Drawing.Point(130, 100);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(200, 25);
            this.cmbPozisyon.TabIndex = 9;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(130, 60);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(200, 25);
            this.cmbDepartman.TabIndex = 8;
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.cmbDepartman_SelectedIndexChanged);
            // 
            // cmbSube
            // 
            this.cmbSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSube.FormattingEnabled = true;
            this.cmbSube.Location = new System.Drawing.Point(130, 20);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.Size = new System.Drawing.Size(200, 25);
            this.cmbSube.TabIndex = 7;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 265);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(50, 19);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Durum";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(20, 225);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(41, 19);
            this.lblMaas.TabIndex = 5;
            this.lblMaas.Text = "Maaş";
            // 
            // lblIseGiris
            // 
            this.lblIseGiris.AutoSize = true;
            this.lblIseGiris.Location = new System.Drawing.Point(20, 185);
            this.lblIseGiris.Name = "lblIseGiris";
            this.lblIseGiris.Size = new System.Drawing.Size(94, 19);
            this.lblIseGiris.TabIndex = 4;
            this.lblIseGiris.Text = "İşe Giriş Tarihi";
            // 
            // lblYonetici
            // 
            this.lblYonetici.AutoSize = true;
            this.lblYonetici.Location = new System.Drawing.Point(20, 145);
            this.lblYonetici.Name = "lblYonetici";
            this.lblYonetici.Size = new System.Drawing.Size(65, 19);
            this.lblYonetici.TabIndex = 3;
            this.lblYonetici.Text = "Yöneticisi";
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.Location = new System.Drawing.Point(20, 105);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(61, 19);
            this.lblPozisyon.TabIndex = 2;
            this.lblPozisyon.Text = "Pozisyon";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Location = new System.Drawing.Point(20, 65);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(76, 19);
            this.lblDepartman.TabIndex = 1;
            this.lblDepartman.Text = "Departman";
            // 
            // lblSube
            // 
            this.lblSube.AutoSize = true;
            this.lblSube.Location = new System.Drawing.Point(20, 25);
            this.lblSube.Name = "lblSube";
            this.lblSube.Size = new System.Drawing.Size(39, 19);
            this.lblSube.TabIndex = 0;
            this.lblSube.Text = "Şube";
            // 
            // tabIletisim
            // 
            this.tabIletisim.Controls.Add(this.txtAdres);
            this.tabIletisim.Controls.Add(this.txtSirketMail);
            this.tabIletisim.Controls.Add(this.txtCepTel);
            this.tabIletisim.Controls.Add(this.lblAdres);
            this.tabIletisim.Controls.Add(this.lblSirketMail);
            this.tabIletisim.Controls.Add(this.lblCepTel);
            this.tabIletisim.Location = new System.Drawing.Point(4, 26);
            this.tabIletisim.Name = "tabIletisim";
            this.tabIletisim.Padding = new System.Windows.Forms.Padding(3);
            this.tabIletisim.Size = new System.Drawing.Size(568, 390);
            this.tabIletisim.TabIndex = 2;
            this.tabIletisim.Text = "İletişim Bilgileri";
            this.tabIletisim.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(130, 100);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(400, 100);
            this.txtAdres.TabIndex = 5;
            // 
            // txtSirketMail
            // 
            this.txtSirketMail.Location = new System.Drawing.Point(130, 60);
            this.txtSirketMail.Name = "txtSirketMail";
            this.txtSirketMail.Size = new System.Drawing.Size(250, 25);
            this.txtSirketMail.TabIndex = 4;
            // 
            // txtCepTel
            // 
            this.txtCepTel.Location = new System.Drawing.Point(130, 20);
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.Size = new System.Drawing.Size(250, 25);
            this.txtCepTel.TabIndex = 3;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(20, 105);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(44, 19);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adres";
            // 
            // lblSirketMail
            // 
            this.lblSirketMail.AutoSize = true;
            this.lblSirketMail.Location = new System.Drawing.Point(20, 65);
            this.lblSirketMail.Name = "lblSirketMail";
            this.lblSirketMail.Size = new System.Drawing.Size(93, 19);
            this.lblSirketMail.TabIndex = 1;
            this.lblSirketMail.Text = "Şirket E-Posta";
            // 
            // lblCepTel
            // 
            this.lblCepTel.AutoSize = true;
            this.lblCepTel.Location = new System.Drawing.Point(20, 25);
            this.lblCepTel.Name = "lblCepTel";
            this.lblCepTel.Size = new System.Drawing.Size(89, 19);
            this.lblCepTel.TabIndex = 0;
            this.lblCepTel.Text = "Cep Telefonu";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(16, 480);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(568, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";
            // 
            // FrmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 540);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonelEkle";
            this.Load += new System.EventHandler(this.FrmPersonelEkle_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.tabKurumsal.ResumeLayout(false);
            this.tabKurumsal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).EndInit();
            this.tabIletisim.ResumeLayout(false);
            this.tabIletisim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.TabPage tabKurumsal;
        private System.Windows.Forms.TabPage tabIletisim;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.ComboBox cmbSube;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblIseGiris;
        private System.Windows.Forms.Label lblYonetici;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblSube;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbYonetici;
        private System.Windows.Forms.ComboBox cmbPozisyon;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.NumericUpDown numMaas;
        private System.Windows.Forms.DateTimePicker dtpIseGiris;
        private System.Windows.Forms.Label lblCepTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSirketMail;
        private System.Windows.Forms.TextBox txtCepTel;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSirketMail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}