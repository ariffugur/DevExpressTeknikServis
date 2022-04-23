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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities(); 
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler=db.TBLKATEGORI.ToList();
            gridControl1.DataSource=degerler;
        }
    }
}
