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
        private void FrmCariListesi_Load(object sender, EventArgs e)
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
            labelControl12.Text=db.TBLCARI.Count().ToString();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();
       
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            secilen=int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TBLILCELER
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir
                                                 }).Where(z=>z.sehir==secilen).ToList();
        }
    }
}
