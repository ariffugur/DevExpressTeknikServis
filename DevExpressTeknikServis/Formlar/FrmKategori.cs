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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            metod1();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t=new TBLKATEGORI();
            t.AD=txtAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Kaydedildi.");
        }
        void metod1()
        {
            
                var degerler = from k in db.TBLKATEGORI
                               select new
                               {
                                   k.ID,
                                   k.AD
                               };
                gridControl1.DataSource = degerler.ToList();
            }

        private void btnListele_Click(object sender, EventArgs e)
        {
                metod1();
        }
    }
}
