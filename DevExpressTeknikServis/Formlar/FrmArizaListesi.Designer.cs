namespace DevExpressTeknikServis.Formlar
{
    partial class FrmArizaListesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaListesi));
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.filteringUIContext1 = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(2, 74);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(669, 51);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = resources.GetString("labelControl10.Text");
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(4, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(401, 47);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Arızalı Ürün İstatistikleri";
            // 
            // chartControl1
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "0.999906049796322;0;0.0137073549861255;0;0.011963748151904;0.488082107261485;-0.8" +
    "72715718491048;0;-0.00669031470660935;0.872797718014425;0.488036251848096;0;0;0;" +
    "0;1";
            this.chartControl1.Diagram = simpleDiagram3D1;
            this.chartControl1.Location = new System.Drawing.Point(0, 131);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.View = pie3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.View = pie3DSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(807, 329);
            this.chartControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1097, 836);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(45)))), ((int)(((byte)(234)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(104)))), ((int)(((byte)(226)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Location = new System.Drawing.Point(1370, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 177);
            this.panel2.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 47);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "584";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(217, 25);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tadilatı Bitmiş Ürün Sayısı";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(10, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 47);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Beko";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(219, 25);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Mevcut Arızalı Ürün Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(235)))));
            this.panel4.Controls.Add(this.labelControl7);
            this.panel4.Controls.Add(this.labelControl8);
            this.panel4.Location = new System.Drawing.Point(1641, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 177);
            this.panel4.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(10, 79);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(138, 47);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Monster";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(12, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(226, 25);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Parça Bekleyen Ürün Sayısı";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.chartControl1);
            this.panelControl1.Location = new System.Drawing.Point(1099, 365);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(807, 460);
            this.panelControl1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(166)))), ((int)(((byte)(131)))));
            this.panel3.Controls.Add(this.labelControl5);
            this.panel3.Controls.Add(this.labelControl6);
            this.panel3.Location = new System.Drawing.Point(1099, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 177);
            this.panel3.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel6.Controls.Add(this.labelControl13);
            this.panel6.Controls.Add(this.labelControl14);
            this.panel6.Location = new System.Drawing.Point(1370, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 177);
            this.panel6.TabIndex = 17;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(10, 79);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 47);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "584";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(12, 12);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(173, 25);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "Toplam Marka Sayısı";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.panel7.Controls.Add(this.labelControl15);
            this.panel7.Controls.Add(this.labelControl16);
            this.panel7.Location = new System.Drawing.Point(1641, 182);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 177);
            this.panel7.TabIndex = 19;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(10, 79);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(138, 47);
            this.labelControl15.TabIndex = 1;
            this.labelControl15.Text = "Monster";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(12, 12);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(185, 25);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "En Fazla Arızalı Marka";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.panel8.Controls.Add(this.labelControl17);
            this.panel8.Controls.Add(this.labelControl18);
            this.panel8.Location = new System.Drawing.Point(1099, 182);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(265, 177);
            this.panel8.TabIndex = 18;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(12, 55);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(82, 47);
            this.labelControl17.TabIndex = 1;
            this.labelControl17.Text = "Beko";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(12, 12);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(166, 25);
            this.labelControl18.TabIndex = 0;
            this.labelControl18.Text = "Arızalı Ürünler Kasa";
            // 
            // FrmArizaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 837);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmArizaListesi";
            this.Text = "FrmArizaListesi";
            this.Load += new System.EventHandler(this.FrmArizaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
    }
}