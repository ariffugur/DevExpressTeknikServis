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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {

            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANI,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               Cari = u.TBLCARI.AD + u.TBLCARI.SOYAD,
                               Personel = u.TBLPERSONEL.AD + u.TBLPERSONEL.SOYAD
                           };

            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

    
        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANI,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               Cari = u.TBLCARI.AD +" "+ u.TBLCARI.SOYAD,
                               Personel = u.TBLPERSONEL.AD +" "+ u.TBLPERSONEL.SOYAD
                           };

            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t=new TBLFATURABILGI();
            t.SERI = txtSeri.Text;
            t.SIRANI = txtSira.Text;
            t.TARIH = Convert.ToDateTime(txtTarih.Text);
            t.SAAT = txtSaat.Text;
            t.VERGIDAIRE = txtVergiDairesi.Text;
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Başarıyla Kaydedilmiştir.");

           
        }
       
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopUp fr = new FrmFaturaKalemPopUp();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtSeri.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            txtSira.Text = gridView1.GetFocusedRowCellValue("SIRANI").ToString();
            txtTarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            db.TBLFATURABILGI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLFATURABILGI.Find(id);
            deger.SERI = txtSeri.Text;
            deger.SIRANI = txtSira.Text;
            deger.VERGIDAIRE = txtVergiDairesi.Text;
            deger.TARIH = DateTime.Parse(txtTarih.Text);
            db.SaveChanges();
            MessageBox.Show("Fatura Listesi Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
