namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmMesaiEkle
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
            this.pnlIcerik = new System.Windows.Forms.Panel();
            this.lblP = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblBas = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBit = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblUcret = new System.Windows.Forms.Label();
            this.numSaatUcreti = new System.Windows.Forms.NumericUpDown();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            this.pnlIcerik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaatUcreti)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1000, 60);
            this.pnlUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaslik.Location = new System.Drawing.Point(20, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(139, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ek Mesai Girişi";
            // 
            // pnlIcerik
            // 
            this.pnlIcerik.BackColor = System.Drawing.Color.White;
            this.pnlIcerik.Controls.Add(this.btnKaydet);
            this.pnlIcerik.Controls.Add(this.lblToplamTutar);
            this.pnlIcerik.Controls.Add(this.lblTutar);
            this.pnlIcerik.Controls.Add(this.numSaatUcreti);
            this.pnlIcerik.Controls.Add(this.lblUcret);
            this.pnlIcerik.Controls.Add(this.dtpBitis);
            this.pnlIcerik.Controls.Add(this.lblBit);
            this.pnlIcerik.Controls.Add(this.dtpBaslangic);
            this.pnlIcerik.Controls.Add(this.lblBas);
            this.pnlIcerik.Controls.Add(this.cmbPersonel);
            this.pnlIcerik.Controls.Add(this.lblP);
            this.pnlIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIcerik.Location = new System.Drawing.Point(0, 60);
            this.pnlIcerik.Name = "pnlIcerik";
            this.pnlIcerik.Size = new System.Drawing.Size(1000, 540);
            this.pnlIcerik.TabIndex = 1;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblP.Location = new System.Drawing.Point(50, 40);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(61, 19);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "Personel";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(150, 37);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(250, 25);
            this.cmbPersonel.TabIndex = 1;
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBas.Location = new System.Drawing.Point(50, 90);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(66, 19);
            this.lblBas.TabIndex = 2;
            this.lblBas.Text = "Başlangıç";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBaslangic.Location = new System.Drawing.Point(150, 87);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.ShowUpDown = true;
            this.dtpBaslangic.Size = new System.Drawing.Size(120, 25);
            this.dtpBaslangic.TabIndex = 3;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.Hesapla);
            // 
            // lblBit
            // 
            this.lblBit.AutoSize = true;
            this.lblBit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBit.Location = new System.Drawing.Point(50, 140);
            this.lblBit.Name = "lblBit";
            this.lblBit.Size = new System.Drawing.Size(34, 19);
            this.lblBit.TabIndex = 4;
            this.lblBit.Text = "Bitiş";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBitis.Location = new System.Drawing.Point(150, 137);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.ShowUpDown = true;
            this.dtpBitis.Size = new System.Drawing.Size(120, 25);
            this.dtpBitis.TabIndex = 5;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.Hesapla);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUcret.Location = new System.Drawing.Point(50, 190);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(76, 19);
            this.lblUcret.TabIndex = 6;
            this.lblUcret.Text = "Saat Ücreti";
            // 
            // numSaatUcreti
            // 
            this.numSaatUcreti.DecimalPlaces = 2;
            this.numSaatUcreti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSaatUcreti.Location = new System.Drawing.Point(150, 187);
            this.numSaatUcreti.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSaatUcreti.Name = "numSaatUcreti";
            this.numSaatUcreti.Size = new System.Drawing.Size(120, 25);
            this.numSaatUcreti.TabIndex = 7;
            this.numSaatUcreti.ValueChanged += new System.EventHandler(this.Hesapla);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTutar.Location = new System.Drawing.Point(50, 250);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(83, 19);
            this.lblTutar.TabIndex = 8;
            this.lblTutar.Text = "TOPLAM:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblToplamTutar.Location = new System.Drawing.Point(145, 245);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(87, 26);
            this.lblToplamTutar.TabIndex = 9;
            this.lblToplamTutar.Text = "0.00 TL";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Crimson;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(54, 300);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(346, 50);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "MESAİ KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmMesaiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlIcerik);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMesaiEkle";
            this.Text = "Ek Mesai Girişi";
            this.Load += new System.EventHandler(this.FrmMesaiEkle_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlIcerik.ResumeLayout(false);
            this.pnlIcerik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaatUcreti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel pnlIcerik;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblBit;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.NumericUpDown numSaatUcreti;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnKaydet;
    }
}