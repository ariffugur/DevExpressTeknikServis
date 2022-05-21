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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunListesi fr = new Formlar.FrmUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void btnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKategori fr = new Formlar.FrmKategori();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori fr = new Formlar.FrmYeniKategori();
            fr.Show();

        }

        private void btnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmIstatistik fr = new Formlar.FrmIstatistik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnMarkaIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrrmMarkalar fr = new Formlar.FrrmMarkalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariListesi fr = new Formlar.FrmCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariIller fr = new Formlar.FrmCariIller();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();
            fr.Show();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartman fr = new Formlar.FrmDepartman();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniDepartman fr = new Formlar.FrmYeniDepartman();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonel fr = new Formlar.FrmPersonel();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmKurlar fr = new Formlar.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYoutube fr = new Formlar.FrmYoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmNotlar fr = new Formlar.FrmNotlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaListesi fr = new Formlar.FrmArizaListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmUrunSatis fr = new Formlar.FrmUrunSatis();
            fr.Show();
        }

        private void btnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmSatislar fr = new Formlar.FrmSatislar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunKaydi fr = new Formlar.FrmArizaliUrunKaydi();
            fr.Show();
        }

        private void btnArizaliUrunAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetaylar fr = new Formlar.FrmArizaDetaylar();
            fr.Show();
        }

        private void btnArizaliUrunDetaylari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaliUrunlerinDetayListesi fr = new Formlar.FrmArizaliUrunlerinDetayListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQRCode fr = new Formlar.FrmQRCode();
            fr.Show();
        }
    }
}
