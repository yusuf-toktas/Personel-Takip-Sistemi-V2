namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmIzinIstegi
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
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.lblIzinTuru = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblGunSayisi = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblHesaplananGun = new System.Windows.Forms.Label();
            this.pnlUst.SuspendLayout();
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
            this.pnlUst.Size = new System.Drawing.Size(400, 40);
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
            this.lblBaslik.Size = new System.Drawing.Size(127, 21);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Yeni İzin Talebi";
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(360, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(40, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzinTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Location = new System.Drawing.Point(130, 70);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(240, 25);
            this.cmbIzinTuru.TabIndex = 1;
            // 
            // lblIzinTuru
            // 
            this.lblIzinTuru.AutoSize = true;
            this.lblIzinTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIzinTuru.Location = new System.Drawing.Point(25, 73);
            this.lblIzinTuru.Name = "lblIzinTuru";
            this.lblIzinTuru.Size = new System.Drawing.Size(62, 19);
            this.lblIzinTuru.TabIndex = 2;
            this.lblIzinTuru.Text = "İzin Türü";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(130, 110);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(240, 25);
            this.dtpBaslangic.TabIndex = 3;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBaslangic.Location = new System.Drawing.Point(25, 115);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(66, 19);
            this.lblBaslangic.TabIndex = 4;
            this.lblBaslangic.Text = "Başlangıç";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(130, 150);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(240, 25);
            this.dtpBitis.TabIndex = 5;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBitis.Location = new System.Drawing.Point(25, 155);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(34, 19);
            this.lblBitis.TabIndex = 6;
            this.lblBitis.Text = "Bitiş";
            // 
            // lblGunSayisi
            // 
            this.lblGunSayisi.AutoSize = true;
            this.lblGunSayisi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGunSayisi.Location = new System.Drawing.Point(25, 195);
            this.lblGunSayisi.Name = "lblGunSayisi";
            this.lblGunSayisi.Size = new System.Drawing.Size(73, 19);
            this.lblGunSayisi.TabIndex = 7;
            this.lblGunSayisi.Text = "Gün Sayısı";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAciklama.Location = new System.Drawing.Point(130, 230);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(240, 100);
            this.txtAciklama.TabIndex = 8;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAciklama.Location = new System.Drawing.Point(25, 230);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 19);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "Açıklama";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(29, 350);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(341, 40);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "GÖNDER";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblHesaplananGun
            // 
            this.lblHesaplananGun.AutoSize = true;
            this.lblHesaplananGun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesaplananGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblHesaplananGun.Location = new System.Drawing.Point(126, 193);
            this.lblHesaplananGun.Name = "lblHesaplananGun";
            this.lblHesaplananGun.Size = new System.Drawing.Size(19, 21);
            this.lblHesaplananGun.TabIndex = 11;
            this.lblHesaplananGun.Text = "0";
            // 
            // FrmIzinIstegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.lblHesaplananGun);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblGunSayisi);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblIzinTuru);
            this.Controls.Add(this.cmbIzinTuru);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzinIstegi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmIzinIstegi";
            this.Load += new System.EventHandler(this.FrmIzinIstegi_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Label lblIzinTuru;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblGunSayisi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblHesaplananGun;
    }
}