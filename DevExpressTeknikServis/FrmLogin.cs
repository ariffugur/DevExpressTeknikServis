using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressTeknikServis
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu=from x in db.TBLADMIN where x.KULLANICIAD==textBox1.Text && x.SIFRE==textBox2.Text select x;
            if (sorgu.Any())
            {
                Form1 frm=new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
