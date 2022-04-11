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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {

            var degerler = db.TBLURUN.ToList();
            gridControl1.DataSource = degerler;
            lookUpEdit1.Properties.DataSource = db.TBLKATEGORI.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN t=new TBLURUN();
            t.AD=txtUrunAdi.Text;
            t.MARKA=txtMarka.Text;
            t.ALISFIYAT=decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT=decimal.Parse(txtSatisFiyat.Text);
            t.STOK = short.Parse (txtStok.Text);
            t.DURUM = false;
            t.KATEGORI=byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.ToList();
            gridControl1.DataSource = degerler;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text=gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAdi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtMarka.Text=gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtAlisFiyat.Text=gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            txtSatisFiyat.Text=gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtStok.Text=gridView1.GetFocusedRowCellValue("STOK").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtID.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = txtUrunAdi.Text;
            deger.MARKA = txtMarka.Text;
            deger.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            deger.STOK = short.Parse(txtStok.Text);
            deger.KATEGORI=byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
