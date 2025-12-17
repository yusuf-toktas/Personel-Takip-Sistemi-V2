namespace Personel_Takip_Sistemi.Formlar
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlKart1 = new System.Windows.Forms.Panel();
            this.lblToplamPersonelSayi = new System.Windows.Forms.Label();
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.pnlKart2 = new System.Windows.Forms.Panel();
            this.lblIzindekilerSayi = new System.Windows.Forms.Label();
            this.lblIzindekiler = new System.Windows.Forms.Label();
            this.pnlKart3 = new System.Windows.Forms.Panel();
            this.lblOrtMaasSayi = new System.Windows.Forms.Label();
            this.lblOrtMaas = new System.Windows.Forms.Label();
            this.chartDepartman = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMaas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDashBaslik = new System.Windows.Forms.Label();
            this.pnlKart1.SuspendLayout();
            this.pnlKart2.SuspendLayout();
            this.pnlKart3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKart1
            // 
            this.pnlKart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlKart1.Controls.Add(this.lblToplamPersonelSayi);
            this.pnlKart1.Controls.Add(this.lblToplamPersonel);
            this.pnlKart1.Location = new System.Drawing.Point(30, 60);
            this.pnlKart1.Name = "pnlKart1";
            this.pnlKart1.Size = new System.Drawing.Size(220, 120);
            this.pnlKart1.TabIndex = 0;
            // 
            // lblToplamPersonelSayi
            // 
            this.lblToplamPersonelSayi.AutoSize = true;
            this.lblToplamPersonelSayi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblToplamPersonelSayi.ForeColor = System.Drawing.Color.White;
            this.lblToplamPersonelSayi.Location = new System.Drawing.Point(15, 45);
            this.lblToplamPersonelSayi.Name = "lblToplamPersonelSayi";
            this.lblToplamPersonelSayi.Size = new System.Drawing.Size(38, 45);
            this.lblToplamPersonelSayi.TabIndex = 1;
            this.lblToplamPersonelSayi.Text = "0";
            // 
            // lblToplamPersonel
            // 
            this.lblToplamPersonel.AutoSize = true;
            this.lblToplamPersonel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblToplamPersonel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblToplamPersonel.Location = new System.Drawing.Point(15, 15);
            this.lblToplamPersonel.Name = "lblToplamPersonel";
            this.lblToplamPersonel.Size = new System.Drawing.Size(115, 20);
            this.lblToplamPersonel.TabIndex = 0;
            this.lblToplamPersonel.Text = "Toplam Personel";
            // 
            // pnlKart2
            // 
            this.pnlKart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.pnlKart2.Controls.Add(this.lblIzindekilerSayi);
            this.pnlKart2.Controls.Add(this.lblIzindekiler);
            this.pnlKart2.Location = new System.Drawing.Point(270, 60);
            this.pnlKart2.Name = "pnlKart2";
            this.pnlKart2.Size = new System.Drawing.Size(220, 120);
            this.pnlKart2.TabIndex = 1;
            // 
            // lblIzindekilerSayi
            // 
            this.lblIzindekilerSayi.AutoSize = true;
            this.lblIzindekilerSayi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblIzindekilerSayi.ForeColor = System.Drawing.Color.White;
            this.lblIzindekilerSayi.Location = new System.Drawing.Point(15, 45);
            this.lblIzindekilerSayi.Name = "lblIzindekilerSayi";
            this.lblIzindekilerSayi.Size = new System.Drawing.Size(38, 45);
            this.lblIzindekilerSayi.TabIndex = 1;
            this.lblIzindekilerSayi.Text = "0";
            // 
            // lblIzindekiler
            // 
            this.lblIzindekiler.AutoSize = true;
            this.lblIzindekiler.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblIzindekiler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIzindekiler.Location = new System.Drawing.Point(15, 15);
            this.lblIzindekiler.Name = "lblIzindekiler";
            this.lblIzindekiler.Size = new System.Drawing.Size(121, 20);
            this.lblIzindekiler.TabIndex = 0;
            this.lblIzindekiler.Text = "İzindeki Personel";
            // 
            // pnlKart3
            // 
            this.pnlKart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlKart3.Controls.Add(this.lblOrtMaasSayi);
            this.pnlKart3.Controls.Add(this.lblOrtMaas);
            this.pnlKart3.Location = new System.Drawing.Point(510, 60);
            this.pnlKart3.Name = "pnlKart3";
            this.pnlKart3.Size = new System.Drawing.Size(220, 120);
            this.pnlKart3.TabIndex = 2;
            // 
            // lblOrtMaasSayi
            // 
            this.lblOrtMaasSayi.AutoSize = true;
            this.lblOrtMaasSayi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOrtMaasSayi.ForeColor = System.Drawing.Color.White;
            this.lblOrtMaasSayi.Location = new System.Drawing.Point(15, 45);
            this.lblOrtMaasSayi.Name = "lblOrtMaasSayi";
            this.lblOrtMaasSayi.Size = new System.Drawing.Size(33, 37);
            this.lblOrtMaasSayi.TabIndex = 1;
            this.lblOrtMaasSayi.Text = "0";
            // 
            // lblOrtMaas
            // 
            this.lblOrtMaas.AutoSize = true;
            this.lblOrtMaas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOrtMaas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrtMaas.Location = new System.Drawing.Point(15, 15);
            this.lblOrtMaas.Name = "lblOrtMaas";
            this.lblOrtMaas.Size = new System.Drawing.Size(110, 20);
            this.lblOrtMaas.TabIndex = 0;
            this.lblOrtMaas.Text = "Ortalama Maaş";
            // 
            // chartDepartman
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDepartman.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDepartman.Legends.Add(legend1);
            this.chartDepartman.Location = new System.Drawing.Point(30, 210);
            this.chartDepartman.Name = "chartDepartman";
            this.chartDepartman.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDepartman.Series.Add(series1);
            this.chartDepartman.Size = new System.Drawing.Size(460, 300);
            this.chartDepartman.TabIndex = 3;
            this.chartDepartman.Text = "chart1";
            // 
            // chartMaas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMaas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMaas.Legends.Add(legend2);
            this.chartMaas.Location = new System.Drawing.Point(510, 210);
            this.chartMaas.Name = "chartMaas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMaas.Series.Add(series2);
            this.chartMaas.Size = new System.Drawing.Size(460, 300);
            this.chartMaas.TabIndex = 4;
            this.chartMaas.Text = "chart2";
            // 
            // lblDashBaslik
            // 
            this.lblDashBaslik.AutoSize = true;
            this.lblDashBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDashBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDashBaslik.Location = new System.Drawing.Point(25, 20);
            this.lblDashBaslik.Name = "lblDashBaslik";
            this.lblDashBaslik.Size = new System.Drawing.Size(144, 25);
            this.lblDashBaslik.TabIndex = 5;
            this.lblDashBaslik.Text = "Yönetim Paneli";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.lblDashBaslik);
            this.Controls.Add(this.chartMaas);
            this.Controls.Add(this.chartDepartman);
            this.Controls.Add(this.pnlKart3);
            this.Controls.Add(this.pnlKart2);
            this.Controls.Add(this.pnlKart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.pnlKart1.ResumeLayout(false);
            this.pnlKart1.PerformLayout();
            this.pnlKart2.ResumeLayout(false);
            this.pnlKart2.PerformLayout();
            this.pnlKart3.ResumeLayout(false);
            this.pnlKart3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlKart1;
        private System.Windows.Forms.Label lblToplamPersonelSayi;
        private System.Windows.Forms.Label lblToplamPersonel;
        private System.Windows.Forms.Panel pnlKart2;
        private System.Windows.Forms.Label lblIzindekilerSayi;
        private System.Windows.Forms.Label lblIzindekiler;
        private System.Windows.Forms.Panel pnlKart3;
        private System.Windows.Forms.Label lblOrtMaasSayi;
        private System.Windows.Forms.Label lblOrtMaas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartman;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMaas;
        private System.Windows.Forms.Label lblDashBaslik;
    }
}