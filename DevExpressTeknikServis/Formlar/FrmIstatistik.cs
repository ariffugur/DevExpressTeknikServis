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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text =db.TBLURUN.Count().ToString();
            labelControl3.Text =db.TBLKATEGORI.Count().ToString();
            labelControl7.Text =db.TBLURUN.Sum(x=>x.STOK).ToString();
            labelControl19.Text =(from x  in db.TBLURUN orderby x.STOK descending select x.AD).FirstOrDefault();
            labelControl15.Text =(from x  in db.TBLURUN orderby x.STOK ascending select x.AD).FirstOrDefault();
        }
    }
}
