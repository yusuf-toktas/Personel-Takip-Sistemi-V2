namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmPozisyonlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlIslem = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.gridPozisyon = new System.Windows.Forms.DataGridView();
            this.pnlUst.SuspendLayout();
            this.pnlIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPozisyon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(650, 40);
            this.pnlUst.TabIndex = 0;
            this.pnlUst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseDown);
            this.pnlUst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseMove);
            this.pnlUst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlUst_MouseUp);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(610, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(40, 40);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(12, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(150, 21);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Pozisyon Yönetimi";
            // 
            // pnlIslem
            // 
            this.pnlIslem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlIslem.Controls.Add(this.btnEkle);
            this.pnlIslem.Controls.Add(this.txtAd);
            this.pnlIslem.Controls.Add(this.lblAd);
            this.pnlIslem.Controls.Add(this.cmbDepartman);
            this.pnlIslem.Controls.Add(this.lblDep);
            this.pnlIslem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIslem.Location = new System.Drawing.Point(0, 40);
            this.pnlIslem.Name = "pnlIslem";
            this.pnlIslem.Size = new System.Drawing.Size(650, 100);
            this.pnlIslem.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(320, 17);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 60);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "KAYDET";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAd.Location = new System.Drawing.Point(100, 52);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 25);
            this.txtAd.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAd.Location = new System.Drawing.Point(20, 55);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(61, 19);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Pozisyon";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(100, 17);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(200, 25);
            this.cmbDepartman.TabIndex = 1;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDep.Location = new System.Drawing.Point(20, 20);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(76, 19);
            this.lblDep.TabIndex = 0;
            this.lblDep.Text = "Departman";
            // 
            // gridPozisyon
            // 
            this.gridPozisyon.AllowUserToAddRows = false;
            this.gridPozisyon.AllowUserToDeleteRows = false;
            this.gridPozisyon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPozisyon.BackgroundColor = System.Drawing.Color.White;
            this.gridPozisyon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPozisyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPozisyon.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridPozisyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPozisyon.Location = new System.Drawing.Point(0, 140);
            this.gridPozisyon.MultiSelect = false;
            this.gridPozisyon.Name = "gridPozisyon";
            this.gridPozisyon.ReadOnly = true;
            this.gridPozisyon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPozisyon.Size = new System.Drawing.Size(650, 360);
            this.gridPozisyon.TabIndex = 2;
            // 
            // FrmPozisyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.gridPozisyon);
            this.Controls.Add(this.pnlIslem);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPozisyonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ünvan ve Pozisyon Yönetimi";
            this.Load += new System.EventHandler(this.FrmPozisyonlar_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlIslem.ResumeLayout(false);
            this.pnlIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPozisyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel pnlIslem;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.DataGridView gridPozisyon;
    }
}