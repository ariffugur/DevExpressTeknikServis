namespace DevExpressTeknikServis.Formlar
{
    partial class FrmArizaDetaylar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaDetaylar));
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.richTxtBoxArizaDetay = new System.Windows.Forms.RichTextBox();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(12, 304);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 38);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(213, 21);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Arızalı Ürün Kaydı Açıklama";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 3);
            this.panel4.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 72;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = "Tarih:";
            this.txtTarih.Location = new System.Drawing.Point(12, 117);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTarih.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.txtTarih.Properties.Appearance.Options.UseFont = true;
            this.txtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.txtTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.MaskSettings.Set("mask", "d");
            this.txtTarih.Size = new System.Drawing.Size(100, 26);
            this.txtTarih.TabIndex = 71;
            this.txtTarih.Click += new System.EventHandler(this.dateEdit2_Click);
            // 
            // richTxtBoxArizaDetay
            // 
            this.richTxtBoxArizaDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.richTxtBoxArizaDetay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTxtBoxArizaDetay.ForeColor = System.Drawing.SystemColors.Window;
            this.richTxtBoxArizaDetay.Location = new System.Drawing.Point(12, 202);
            this.richTxtBoxArizaDetay.Name = "richTxtBoxArizaDetay";
            this.richTxtBoxArizaDetay.Size = new System.Drawing.Size(335, 96);
            this.richTxtBoxArizaDetay.TabIndex = 3;
            this.richTxtBoxArizaDetay.Text = "Arıza Detayları";
            this.richTxtBoxArizaDetay.Click += new System.EventHandler(this.richTxtBoxArizaDetay_Click);
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.EditValue = "Seri No:";
            this.txtSeriNo.Location = new System.Drawing.Point(12, 67);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.txtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSeriNo.Size = new System.Drawing.Size(100, 26);
            this.txtSeriNo.TabIndex = 73;
            this.txtSeriNo.Click += new System.EventHandler(this.txtSeriNo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 73;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ürün Kaydoldu",
            "Parça Bekliyor",
            "Mesaj Bekliyor",
            "İptal Edildi",
            "Fiyat Verildi"});
            this.comboBox1.Location = new System.Drawing.Point(12, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 29);
            this.comboBox1.TabIndex = 74;
            // 
            // FrmArizaDetaylar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(367, 437);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.richTxtBoxArizaDetay);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaDetaylar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArizaDetaylar";
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private System.Windows.Forms.RichTextBox richTxtBoxArizaDetay;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}