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
    public partial class FrmFaturaKalemPopUp : Form
    {
        public FrmFaturaKalemPopUp()
        {
            InitializeComponent();
        }
        public int id;
        private void FrmFaturaKalemPopUp_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = db.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TBLFATURABILGI.Where(x => x.ID == id).ToList();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.pdf";
            gridControl1.ExportToPdf(path);

        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Xls";
            gridControl1.ExportToXls(path);
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
