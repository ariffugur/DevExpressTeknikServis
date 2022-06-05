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

            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunId = int.Parse(id.ToString());
            var degerler = db.TBLURUNKABUL.Find(urunId);
            degerler.URUNDURUMDETAY = comboBox1.Text;
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

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string id;
        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            richTxtBoxArizaDetay.Text = id;
        }
    }
}
