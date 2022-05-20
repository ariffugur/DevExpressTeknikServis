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
    public partial class FrmArizaliUrunlerinDetayListesi : Form
    {
        public FrmArizaliUrunlerinDetayListesi()
        {
            InitializeComponent();
        }

        private void FrmArizaliUrunlerinDetayListesi_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = (from x in db.TBLURUNTAKIP
                                      select new
                                      {
                                          x.TAKIPID,
                                          x.SERINO,
                                          x.TARIH,
                                          x.ACIKLAMA
                                      }).ToList();
        }
    }
}
