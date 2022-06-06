using System;
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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        void liste()
        {
            var degerler = from x in db.TBLCARI
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.IL,
                               x.ILCE,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            liste();
            labelControl12.Text = db.TBLCARI.Count().ToString();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();
            labelControl16.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            labelControl14.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TBLILCELER
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir
                                                 }).Where(z => z.sehir == secilen).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.IL = lookUpEdit1.Text;
            t.ILCE = lookUpEdit2.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Cari Eklendi!");
            liste();


        }
    }
}
