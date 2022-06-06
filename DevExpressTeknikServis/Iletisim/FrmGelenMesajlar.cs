using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressTeknikServis.Iletisim
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities(); 
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            labelControl12.Text=db.TBLILETISIM.Count().ToString();
            labelControl18.Text=db.TBLILETISIM.Where(x=>x.KONU=="Teşekkür").Count().ToString();
            labelControl16.Text=db.TBLILETISIM.Where(x=>x.KONU=="Rica").Count().ToString();
            labelControl14.Text=db.TBLILETISIM.Where(x=>x.KONU=="Şikayet").Count().ToString();
        }
    }
}
