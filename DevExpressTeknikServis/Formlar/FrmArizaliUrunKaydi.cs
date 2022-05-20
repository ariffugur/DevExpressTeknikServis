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
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t=new TBLURUNKABUL();
            t.CARI=int.Parse(txtId.Text);
            t.GELISTARIH=DateTime.Parse(txtTarih.Text);
            t.PERSONEL=short.Parse(txtPersonel.Text);
            t.URUNSERINO=txtSeriNo.Text;
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Girişi Yapıldı.");
        }
    }
}
