namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmZimmetler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlIslem = new System.Windows.Forms.Panel();
            this.btnZimmetle = new System.Windows.Forms.Button();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.lblS = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblM = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblP = new System.Windows.Forms.Label();
            this.gridZimmet = new System.Windows.Forms.DataGridView();
            this.pnlUst.SuspendLayout();
            this.pnlIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZimmet)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(166, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Zimmet Yönetimi";
            // 
            // pnlIslem
            // 
            this.pnlIslem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlIslem.Controls.Add(this.btnZimmetle);
            this.pnlIslem.Controls.Add(this.txtSeriNo);
            this.pnlIslem.Controls.Add(this.lblS);
            this.pnlIslem.Controls.Add(this.txtMarka);
            this.pnlIslem.Controls.Add(this.lblM);
            this.pnlIslem.Controls.Add(this.txtKategori);
            this.pnlIslem.Controls.Add(this.lblK);
            this.pnlIslem.Controls.Add(this.cmbPersonel);
            this.pnlIslem.Controls.Add(this.lblP);
            this.pnlIslem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIslem.Location = new System.Drawing.Point(0, 60);
            this.pnlIslem.Name = "pnlIslem";
            this.pnlIslem.Size = new System.Drawing.Size(1000, 150);
            this.pnlIslem.TabIndex = 1;
            // 
            // btnZimmetle
            // 
            this.btnZimmetle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnZimmetle.FlatAppearance.BorderSize = 0;
            this.btnZimmetle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmetle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnZimmetle.ForeColor = System.Drawing.Color.White;
            this.btnZimmetle.Location = new System.Drawing.Point(100, 90);
            this.btnZimmetle.Name = "btnZimmetle";
            this.btnZimmetle.Size = new System.Drawing.Size(510, 40);
            this.btnZimmetle.TabIndex = 8;
            this.btnZimmetle.Text = "ZİMMETLE";
            this.btnZimmetle.UseVisualStyleBackColor = false;
            this.btnZimmetle.Click += new System.EventHandler(this.BtnZimmetle_Click);
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSeriNo.Location = new System.Drawing.Point(410, 47);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(200, 25);
            this.txtSeriNo.TabIndex = 7;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblS.Location = new System.Drawing.Point(320, 50);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(55, 19);
            this.lblS.TabIndex = 6;
            this.lblS.Text = "Seri No";
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMarka.Location = new System.Drawing.Point(410, 17);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(200, 25);
            this.txtMarka.TabIndex = 5;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblM.Location = new System.Drawing.Point(320, 20);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(90, 19);
            this.lblM.TabIndex = 4;
            this.lblM.Text = "Marka/Model";
            // 
            // txtKategori
            // 
            this.txtKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKategori.Location = new System.Drawing.Point(100, 47);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(200, 25);
            this.txtKategori.TabIndex = 3;
            this.txtKategori.Text = "Laptop";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblK.Location = new System.Drawing.Point(20, 50);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(60, 19);
            this.lblK.TabIndex = 2;
            this.lblK.Text = "Kategori";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(100, 17);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(200, 25);
            this.cmbPersonel.TabIndex = 1;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblP.Location = new System.Drawing.Point(20, 20);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(61, 19);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "Personel";
            // 
            // gridZimmet
            // 
            this.gridZimmet.AllowUserToAddRows = false;
            this.gridZimmet.AllowUserToDeleteRows = false;
            this.gridZimmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridZimmet.BackgroundColor = System.Drawing.Color.White;
            this.gridZimmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridZimmet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridZimmet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridZimmet.ColumnHeadersHeight = 40;
            this.gridZimmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridZimmet.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridZimmet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridZimmet.EnableHeadersVisualStyles = false;
            this.gridZimmet.Location = new System.Drawing.Point(0, 210);
            this.gridZimmet.MultiSelect = false;
            this.gridZimmet.Name = "gridZimmet";
            this.gridZimmet.ReadOnly = true;
            this.gridZimmet.RowHeadersVisible = false;
            this.gridZimmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridZimmet.Size = new System.Drawing.Size(1000, 390);
            this.gridZimmet.TabIndex = 2;
            // 
            // FrmZimmetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridZimmet);
            this.Controls.Add(this.pnlIslem);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmZimmetler";
            this.Text = "Zimmet ve Demirbaş Yönetimi";
            this.Load += new System.EventHandler(this.FrmZimmetler_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlIslem.ResumeLayout(false);
            this.pnlIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZimmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel pnlIslem;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Button btnZimmetle;
        private System.Windows.Forms.DataGridView gridZimmet;
    }
}