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
        void liste()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               DEPARTMAN=u.TBLDEPARTMAN.AD
                           };

            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
          liste();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();
            
            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;
            //1.Personel
            ad1 = db.TBLPERSONEL.First(x => x.ID == 9).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 9).SOYAD;
            labelControl3.Text = db.TBLPERSONEL.First(x => x.ID == 9).TBLDEPARTMAN.AD;
            labelControl6.Text = db.TBLPERSONEL.First(x => x.ID == 9).MAIL;
            labelControl2.Text=ad1+" " + soyad1;
            //2.Personel
            ad2 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl11.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl9.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAIL;
            labelControl16.Text = ad2 + " " + soyad2;
            //3.Personel
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl20.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAIL;
            labelControl22.Text = ad3 + " " + soyad3;
            //4.Personel
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl24.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;
            labelControl14.Text = db.TBLPERSONEL.First(x => x.ID == 4).MAIL;
            labelControl26.Text = ad4 + " " + soyad4;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t=new TBLPERSONEL();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyl Kaydedildi!");
            liste();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtID.Text);
            var deger = db.TBLPERSONEL.Find(id);
            deger.AD =txtAd.Text;
            deger.SOYAD = txtSoyad.Text;
            deger.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
