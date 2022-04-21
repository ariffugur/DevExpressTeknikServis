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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            FrmYeniUrun fr=new FrmYeniUrun();
            //fr.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db=new DbTeknikServisEntities();
            TBLURUN t=new TBLURUN();
            t.AD=txtUrunAdi.Text;
            t.MARKA=txtMarka.Text;
            t.KATEGORI=byte.Parse(txtKategori.Text);
            t.ALISFIYAT=decimal.Parse(txtAlisFiyati.Text);
            t.SATISFIYAT=decimal.Parse(txtSatisFiyati.Text);
            t.STOK=short.Parse(txtStok.Text);
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi!");

        }
    }
}
