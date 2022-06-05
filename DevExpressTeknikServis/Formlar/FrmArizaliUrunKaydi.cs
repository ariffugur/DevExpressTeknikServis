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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.GELISTARIH = DateTime.Parse(txtTarih.Text);
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            t.URUNSERINO = txtSeriNo.Text;
            t.URUNDURUMDETAY = "Mesaj Bekliyor";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Girişi Yapıldı.");
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTarih_Click(object sender, EventArgs e)
        {
            txtTarih.Text=DateTime.Now.ToShortDateString();
        }
    }
}
