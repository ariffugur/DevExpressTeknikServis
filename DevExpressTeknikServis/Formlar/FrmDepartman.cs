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
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA
                           };

            gridControl1.DataSource = degerler.ToList();
            labelControl12.Text=db.TBLDEPARTMAN.Count().ToString();
            labelControl18.Text=db.TBLPERSONEL.Count().ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t=new TBLDEPARTMAN();
            if(txtAd.Text.Length<=50&& txtAd.Text!=""&& richTxtBoxAciklama.Text.Length >= 1) { 
            t.AD = txtAd.Text;
            t.ACIKLAMA = richTxtBoxAciklama.Text;
            db.TBLDEPARTMAN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Departman Kaydedildi!","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Departman Kaydedildilemedi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
