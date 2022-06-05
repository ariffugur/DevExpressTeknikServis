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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = richTxtBoxArizaDetay.Text;
            t.SERINO = txtSeriNo.Text;
            t.TARIH = DateTime.Parse(txtTarih.Text);
            db.TBLURUNTAKIP.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün arıza detayları güncellendi");
        }



        private void dateEdit2_Click(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void richTxtBoxArizaDetay_Click(object sender, EventArgs e)
        {
            richTxtBoxArizaDetay.Text = "";
        }

        private void txtSeriNo_Click(object sender, EventArgs e)
        {
            txtSeriNo.Text = "";
        }

   
    }
}
