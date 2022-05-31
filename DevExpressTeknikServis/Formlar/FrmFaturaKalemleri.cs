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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "") { 
            int id = Convert.ToInt32(txtId.Text);

            var degerler = (from u in db.TBLFATURADETAY

                            select new

                            {


                                u.URUN,

                                u.ADET,

                                u.FIYAT,

                                u.TUTAR,

                                u.FATURAID

                            }).Where(x => x.FATURAID == id);

            gridControl1.DataSource = degerler.ToList();
            }
            else
            {
                var degerler = from u in db.TBLFATURADETAY.Where(u => u.TBLFATURABILGI.SERI == txtSeriNo.Text || u.TBLFATURABILGI.SIRANI == txtSiraNo.Text)
                               select new
                               {
                                   u.URUN,

                                   u.ADET,

                                   u.FIYAT,

                                   u.TUTAR,

                                   u.FATURAID
                               };
                gridControl1.DataSource = degerler.ToList();
            }

        }
    }
}
