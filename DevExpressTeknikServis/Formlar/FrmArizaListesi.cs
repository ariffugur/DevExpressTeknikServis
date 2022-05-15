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
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               Cari = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                               Personel = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIH,
                               x.CIKISTARIH
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
