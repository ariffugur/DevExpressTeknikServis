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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=db.TBLDEPARTMAN.ToList();
            labelControl12.Text=db.TBLDEPARTMAN.Count().ToString();
            labelControl18.Text=db.TBLPERSONEL.Count().ToString();
        }
    }
}
