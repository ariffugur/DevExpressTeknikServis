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
        }
    }
}
