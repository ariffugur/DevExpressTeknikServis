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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {

            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANI,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               Cari = u.TBLCARI.AD + u.TBLCARI.SOYAD,
                               Personel = u.TBLPERSONEL.AD + u.TBLPERSONEL.SOYAD
                           };

            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }
    }
}
