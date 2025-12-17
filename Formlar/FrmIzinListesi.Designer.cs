namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmIzinListesi
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
            this.btnReddet = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnYeniIzin = new System.Windows.Forms.Button();
            this.gridIzinler = new System.Windows.Forms.DataGridView();
            this.pnlUst.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIzinler)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(138, 25);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "İzin Hareketleri";
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAlt.Controls.Add(this.btnReddet);
            this.pnlAlt.Controls.Add(this.btnOnayla);
            this.pnlAlt.Controls.Add(this.btnYeniIzin);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 520);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1000, 80);
            this.pnlAlt.TabIndex = 1;
            // 
            // btnReddet
            // 
            this.btnReddet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReddet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnReddet.FlatAppearance.BorderSize = 0;
            this.btnReddet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReddet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReddet.ForeColor = System.Drawing.Color.White;
            this.btnReddet.Location = new System.Drawing.Point(830, 20);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(150, 40);
            this.btnReddet.TabIndex = 2;
            this.btnReddet.Text = "REDDET";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnOnayla.FlatAppearance.BorderSize = 0;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(660, 20);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(150, 40);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnYeniIzin
            // 
            this.btnYeniIzin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnYeniIzin.FlatAppearance.BorderSize = 0;
            this.btnYeniIzin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniIzin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYeniIzin.ForeColor = System.Drawing.Color.White;
            this.btnYeniIzin.Location = new System.Drawing.Point(20, 20);
            this.btnYeniIzin.Name = "btnYeniIzin";
            this.btnYeniIzin.Size = new System.Drawing.Size(150, 40);
            this.btnYeniIzin.TabIndex = 0;
            this.btnYeniIzin.Text = "İZİN İSTE";
            this.btnYeniIzin.UseVisualStyleBackColor = false;
            this.btnYeniIzin.Click += new System.EventHandler(this.btnYeniIzin_Click);
            // 
            // gridIzinler
            // 
            this.gridIzinler.AllowUserToAddRows = false;
            this.gridIzinler.AllowUserToDeleteRows = false;
            this.gridIzinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIzinler.BackgroundColor = System.Drawing.Color.White;
            this.gridIzinler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridIzinler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIzinler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridIzinler.ColumnHeadersHeight = 40;
            this.gridIzinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridIzinler.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridIzinler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridIzinler.EnableHeadersVisualStyles = false;
            this.gridIzinler.Location = new System.Drawing.Point(0, 60);
            this.gridIzinler.MultiSelect = false;
            this.gridIzinler.Name = "gridIzinler";
            this.gridIzinler.ReadOnly = true;
            this.gridIzinler.RowHeadersVisible = false;
            this.gridIzinler.RowTemplate.Height = 35;
            this.gridIzinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIzinler.Size = new System.Drawing.Size(1000, 460);
            this.gridIzinler.TabIndex = 2;
            // 
            // FrmIzinListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridIzinler);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzinListesi";
            this.Text = "FrmIzinListesi";
            this.Load += new System.EventHandler(this.FrmIzinListesi_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIzinler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.DataGridView gridIzinler;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnYeniIzin;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Button btnOnayla;
    }
}