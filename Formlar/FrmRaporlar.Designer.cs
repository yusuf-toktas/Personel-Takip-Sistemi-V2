namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmRaporlar
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
            this.btnRaporla = new System.Windows.Forms.Button();
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.lblRaporTuru = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUst.Controls.Add(this.btnRaporla);
            this.pnlUst.Controls.Add(this.cmbRaporTuru);
            this.pnlUst.Controls.Add(this.lblRaporTuru);
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1000, 80);
            this.pnlUst.TabIndex = 0;
            // 
            // btnRaporla
            // 
            this.btnRaporla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRaporla.FlatAppearance.BorderSize = 0;
            this.btnRaporla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRaporla.ForeColor = System.Drawing.Color.White;
            this.btnRaporla.Location = new System.Drawing.Point(550, 40);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(150, 30);
            this.btnRaporla.TabIndex = 3;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = false;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaporTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRaporTuru.FormattingEnabled = true;
            this.cmbRaporTuru.Items.AddRange(new object[] {
            "Personel Listesi (Tüm Detaylar)",
            "Departman Bazlı Maaş Raporu",
            "İzin Durum Raporu"});
            this.cmbRaporTuru.Location = new System.Drawing.Point(200, 43);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(300, 25);
            this.cmbRaporTuru.TabIndex = 2;
            // 
            // lblRaporTuru
            // 
            this.lblRaporTuru.AutoSize = true;
            this.lblRaporTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRaporTuru.Location = new System.Drawing.Point(25, 46);
            this.lblRaporTuru.Name = "lblRaporTuru";
            this.lblRaporTuru.Size = new System.Drawing.Size(76, 19);
            this.lblRaporTuru.TabIndex = 1;
            this.lblRaporTuru.Text = "Rapor Türü";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaslik.Location = new System.Drawing.Point(20, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(256, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Raporlar ve Analiz Merkezi";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Personel_Takip_Sistemi.Raporlar.RptPersonelListesi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 520);
            this.reportViewer1.TabIndex = 1;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblRaporTuru;
        private System.Windows.Forms.ComboBox cmbRaporTuru;
        private System.Windows.Forms.Button btnRaporla;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}