namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmAyarlar
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblDil = new System.Windows.Forms.Label();
            this.cmbDil = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpYonetim = new System.Windows.Forms.GroupBox();
            this.btnPozisyon = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.grpYonetim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(145, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Sistem Ayarları";
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDil.Location = new System.Drawing.Point(25, 80);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(69, 19);
            this.lblDil.TabIndex = 1;
            this.lblDil.Text = "Dil Seçimi";
            // 
            // cmbDil
            // 
            this.cmbDil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDil.FormattingEnabled = true;
            this.cmbDil.Location = new System.Drawing.Point(29, 102);
            this.cmbDil.Name = "cmbDil";
            this.cmbDil.Size = new System.Drawing.Size(200, 25);
            this.cmbDil.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(29, 150);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 40);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grpYonetim
            // 
            this.grpYonetim.Controls.Add(this.btnPozisyon);
            this.grpYonetim.Controls.Add(this.btnDepartman);
            this.grpYonetim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpYonetim.Location = new System.Drawing.Point(300, 80);
            this.grpYonetim.Name = "grpYonetim";
            this.grpYonetim.Size = new System.Drawing.Size(400, 150);
            this.grpYonetim.TabIndex = 4;
            this.grpYonetim.TabStop = false;
            this.grpYonetim.Text = "Tanımlamalar";
            // 
            // btnPozisyon
            // 
            this.btnPozisyon.BackColor = System.Drawing.Color.DimGray;
            this.btnPozisyon.FlatAppearance.BorderSize = 0;
            this.btnPozisyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPozisyon.ForeColor = System.Drawing.Color.White;
            this.btnPozisyon.Location = new System.Drawing.Point(20, 80);
            this.btnPozisyon.Name = "btnPozisyon";
            this.btnPozisyon.Size = new System.Drawing.Size(360, 40);
            this.btnPozisyon.TabIndex = 1;
            this.btnPozisyon.Text = "POZİSYON / ÜNVAN YÖNETİMİ";
            this.btnPozisyon.UseVisualStyleBackColor = false;
            this.btnPozisyon.Click += new System.EventHandler(this.btnPozisyon_Click);
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.DimGray;
            this.btnDepartman.FlatAppearance.BorderSize = 0;
            this.btnDepartman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartman.ForeColor = System.Drawing.Color.White;
            this.btnDepartman.Location = new System.Drawing.Point(20, 30);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(360, 40);
            this.btnDepartman.TabIndex = 0;
            this.btnDepartman.Text = "DEPARTMAN YÖNETİMİ";
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpYonetim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbDil);
            this.Controls.Add(this.lblDil);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAyarlar";
            this.Text = "FrmAyarlar";
            this.Load += new System.EventHandler(this.FrmAyarlar_Load);
            this.grpYonetim.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.ComboBox cmbDil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox grpYonetim;
        private System.Windows.Forms.Button btnPozisyon;
        private System.Windows.Forms.Button btnDepartman;
    }
}