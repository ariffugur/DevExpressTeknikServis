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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl4.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }).Where(x => x.STOK < 30).ToList();
            gridControl1.DataSource=(from y in db.TBLCARI select new
            {
                y.AD,
                y.SOYAD,
                y.IL
            }).ToList();
            gridControl3.DataSource=db.urunkategori().ToList();
            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.TARIH)
                         where (x.TARIH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
            gridControl2.DataSource = deger.ToList();
            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5, konu6, ad6;
            konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = konu1 + " - " + ad1;
            konu2 = db.TBLILETISIM.First(x => x.ID == 2).KONU;
            ad2 = db.TBLILETISIM.First(x => x.ID == 2).ADSOYAD;
            labelControl2.Text = konu2 + " - " + ad2;
            konu3 = db.TBLILETISIM.First(x => x.ID ==3).KONU;
            ad3 = db.TBLILETISIM.First(x => x.ID == 3).ADSOYAD;
            labelControl3.Text = konu3 + " - " + ad3;
            konu4 = db.TBLILETISIM.First(x => x.ID ==4).KONU;
            ad4 = db.TBLILETISIM.First(x => x.ID == 4).ADSOYAD;
            labelControl4.Text = konu4 + " - " + ad4;
            konu5 = db.TBLILETISIM.First(x => x.ID ==5).KONU;
            ad5 = db.TBLILETISIM.First(x => x.ID == 5).ADSOYAD;
            labelControl5.Text = konu5 + " - " + ad5;
            konu6 = db.TBLILETISIM.First(x => x.ID ==6).KONU;
            ad6 = db.TBLILETISIM.First(x => x.ID == 6).ADSOYAD;
            labelControl6.Text = konu6 + " - " + ad6;
            konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = konu1 + " - " + ad1;
        }
    }
}
