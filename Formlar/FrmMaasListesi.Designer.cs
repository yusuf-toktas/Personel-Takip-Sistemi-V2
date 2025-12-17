namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmMaasListesi
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
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.btnYeniOdeme = new System.Windows.Forms.Button();
            this.gridMaaslar = new System.Windows.Forms.DataGridView();
            this.pnlUst.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaaslar)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(220, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Maaş ve Ödeme Geçmişi";
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAlt.Controls.Add(this.btnYeniOdeme);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 520);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1000, 80);
            this.pnlAlt.TabIndex = 1;
            // 
            // btnYeniOdeme
            // 
            this.btnYeniOdeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnYeniOdeme.FlatAppearance.BorderSize = 0;
            this.btnYeniOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniOdeme.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYeniOdeme.ForeColor = System.Drawing.Color.White;
            this.btnYeniOdeme.Location = new System.Drawing.Point(20, 20);
            this.btnYeniOdeme.Name = "btnYeniOdeme";
            this.btnYeniOdeme.Size = new System.Drawing.Size(180, 40);
            this.btnYeniOdeme.TabIndex = 0;
            this.btnYeniOdeme.Text = "YENİ ÖDEME YAP";
            this.btnYeniOdeme.UseVisualStyleBackColor = false;
            this.btnYeniOdeme.Click += new System.EventHandler(this.btnYeniOdeme_Click);
            // 
            // gridMaaslar
            // 
            this.gridMaaslar.AllowUserToAddRows = false;
            this.gridMaaslar.AllowUserToDeleteRows = false;
            this.gridMaaslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMaaslar.BackgroundColor = System.Drawing.Color.White;
            this.gridMaaslar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMaaslar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMaaslar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMaaslar.ColumnHeadersHeight = 40;
            this.gridMaaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMaaslar.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridMaaslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMaaslar.EnableHeadersVisualStyles = false;
            this.gridMaaslar.Location = new System.Drawing.Point(0, 60);
            this.gridMaaslar.MultiSelect = false;
            this.gridMaaslar.Name = "gridMaaslar";
            this.gridMaaslar.ReadOnly = true;
            this.gridMaaslar.RowHeadersVisible = false;
            this.gridMaaslar.RowTemplate.Height = 35;
            this.gridMaaslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMaaslar.Size = new System.Drawing.Size(1000, 460);
            this.gridMaaslar.TabIndex = 2;
            // 
            // FrmMaasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridMaaslar);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaasListesi";
            this.Text = "FrmMaasListesi";
            this.Load += new System.EventHandler(this.FrmMaasListesi_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMaaslar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.DataGridView gridMaaslar;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnYeniOdeme;
    }
}