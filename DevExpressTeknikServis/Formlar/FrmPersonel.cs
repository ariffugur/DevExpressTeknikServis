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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON
                           };

            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();
            
            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //1.Personel
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl3.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl6.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl2.Text=ad1+" " + soyad1;
            //2.Personel
            ad2 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl11.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl9.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl16.Text = ad2 + " " + soyad2;
            //3.Personel
            ad3 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl20.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl22.Text = ad3 + " " + soyad3;
            //4.Personel
            ad4 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl24.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl14.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl26.Text = ad4 + " " + soyad4;
        }
    }
}
