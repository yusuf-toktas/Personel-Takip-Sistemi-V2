namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmMaasOdeme
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
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.lblDonem = new System.Windows.Forms.Label();
            this.numYil = new System.Windows.Forms.NumericUpDown();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.lblAnaMaas = new System.Windows.Forms.Label();
            this.numAnaMaas = new System.Windows.Forms.NumericUpDown();
            this.lblEkOdeme = new System.Windows.Forms.Label();
            this.numEkOdeme = new System.Windows.Forms.NumericUpDown();
            this.lblKesinti = new System.Windows.Forms.Label();
            this.numKesinti = new System.Windows.Forms.NumericUpDown();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblHesaplananNet = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnaMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEkOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKesinti)).BeginInit();
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
            this.pnlUst.Size = new System.Drawing.Size(450, 40);
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
            this.lblBaslik.Size = new System.Drawing.Size(161, 21);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Maaş Ödeme Ekranı";
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(410, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(40, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(150, 70);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(250, 25);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPersonel.Location = new System.Drawing.Point(30, 73);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(86, 19);
            this.lblPersonel.TabIndex = 2;
            this.lblPersonel.Text = "Personel Seç";
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDonem.Location = new System.Drawing.Point(30, 115);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(53, 19);
            this.lblDonem.TabIndex = 3;
            this.lblDonem.Text = "Dönem";
            // 
            // numYil
            // 
            this.numYil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numYil.Location = new System.Drawing.Point(280, 113);
            this.numYil.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numYil.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numYil.Name = "numYil";
            this.numYil.Size = new System.Drawing.Size(120, 25);
            this.numYil.TabIndex = 4;
            this.numYil.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // cmbAy
            // 
            this.cmbAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAy.Location = new System.Drawing.Point(150, 112);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(120, 25);
            this.cmbAy.TabIndex = 5;
            // 
            // lblAnaMaas
            // 
            this.lblAnaMaas.AutoSize = true;
            this.lblAnaMaas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAnaMaas.Location = new System.Drawing.Point(30, 155);
            this.lblAnaMaas.Name = "lblAnaMaas";
            this.lblAnaMaas.Size = new System.Drawing.Size(70, 19);
            this.lblAnaMaas.TabIndex = 6;
            this.lblAnaMaas.Text = "Ana Maaş";
            // 
            // numAnaMaas
            // 
            this.numAnaMaas.DecimalPlaces = 2;
            this.numAnaMaas.Enabled = false;
            this.numAnaMaas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numAnaMaas.Location = new System.Drawing.Point(150, 153);
            this.numAnaMaas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAnaMaas.Name = "numAnaMaas";
            this.numAnaMaas.Size = new System.Drawing.Size(250, 25);
            this.numAnaMaas.TabIndex = 7;
            this.numAnaMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEkOdeme
            // 
            this.lblEkOdeme.AutoSize = true;
            this.lblEkOdeme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEkOdeme.Location = new System.Drawing.Point(30, 195);
            this.lblEkOdeme.Name = "lblEkOdeme";
            this.lblEkOdeme.Size = new System.Drawing.Size(70, 19);
            this.lblEkOdeme.TabIndex = 8;
            this.lblEkOdeme.Text = "Ek Ödeme";
            // 
            // numEkOdeme
            // 
            this.numEkOdeme.DecimalPlaces = 2;
            this.numEkOdeme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numEkOdeme.Location = new System.Drawing.Point(150, 193);
            this.numEkOdeme.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numEkOdeme.Name = "numEkOdeme";
            this.numEkOdeme.Size = new System.Drawing.Size(250, 25);
            this.numEkOdeme.TabIndex = 9;
            this.numEkOdeme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEkOdeme.ValueChanged += new System.EventHandler(this.numEkOdeme_ValueChanged);
            // 
            // lblKesinti
            // 
            this.lblKesinti.AutoSize = true;
            this.lblKesinti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKesinti.Location = new System.Drawing.Point(30, 235);
            this.lblKesinti.Name = "lblKesinti";
            this.lblKesinti.Size = new System.Drawing.Size(49, 19);
            this.lblKesinti.TabIndex = 10;
            this.lblKesinti.Text = "Kesinti";
            // 
            // numKesinti
            // 
            this.numKesinti.DecimalPlaces = 2;
            this.numKesinti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numKesinti.Location = new System.Drawing.Point(150, 233);
            this.numKesinti.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numKesinti.Name = "numKesinti";
            this.numKesinti.Size = new System.Drawing.Size(250, 25);
            this.numKesinti.TabIndex = 11;
            this.numKesinti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKesinti.ValueChanged += new System.EventHandler(this.numKesinti_ValueChanged);
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNet.Location = new System.Drawing.Point(30, 290);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(127, 21);
            this.lblNet.TabIndex = 12;
            this.lblNet.Text = "NET ÖDENECEK";
            // 
            // lblHesaplananNet
            // 
            this.lblHesaplananNet.AutoSize = true;
            this.lblHesaplananNet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHesaplananNet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblHesaplananNet.Location = new System.Drawing.Point(145, 280);
            this.lblHesaplananNet.Name = "lblHesaplananNet";
            this.lblHesaplananNet.Size = new System.Drawing.Size(91, 37);
            this.lblHesaplananNet.TabIndex = 13;
            this.lblHesaplananNet.Text = "0,00 ₺";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(34, 350);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(366, 50);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "ÖDEMEYİ KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Gray;
            this.btnHesapla.FlatAppearance.BorderSize = 0;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(340, 285);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(60, 30);
            this.btnHesapla.TabIndex = 15;
            this.btnHesapla.Text = "Yenile";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // FrmMaasOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 430);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblHesaplananNet);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.numKesinti);
            this.Controls.Add(this.lblKesinti);
            this.Controls.Add(this.numEkOdeme);
            this.Controls.Add(this.lblEkOdeme);
            this.Controls.Add(this.numAnaMaas);
            this.Controls.Add(this.lblAnaMaas);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.numYil);
            this.Controls.Add(this.lblDonem);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaasOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMaasOdeme";
            this.Load += new System.EventHandler(this.FrmMaasOdeme_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnaMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEkOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKesinti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Label lblDonem;
        private System.Windows.Forms.NumericUpDown numYil;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.Label lblAnaMaas;
        private System.Windows.Forms.NumericUpDown numAnaMaas;
        private System.Windows.Forms.Label lblEkOdeme;
        private System.Windows.Forms.NumericUpDown numEkOdeme;
        private System.Windows.Forms.Label lblKesinti;
        private System.Windows.Forms.NumericUpDown numKesinti;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblHesaplananNet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnHesapla;
    }
}