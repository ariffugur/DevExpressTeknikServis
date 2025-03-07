﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressTeknikServis.Formlar
{
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t=new TBLURUN();
            t.AD=txtUrunAdi.Text;
            t.MARKA=txtMarka.Text;
            t.ALISFIYAT=decimal.Parse(txtAlisFiyati.Text);
            t.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.SATISFIYAT=decimal.Parse(txtSatisFiyati.Text);
            t.STOK=short.Parse(txtStok.Text);
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi!");

        }

        private void txtUrunAdi_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            txtUrunAdi.Focus();
        }
    }
}
