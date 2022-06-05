using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DevExpressTeknikServis.Formlar
{
    public partial class FrrmMarkalar : Form
    {
        public FrrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z =>new
            {
                Marka=z.Key,
                Toplam=z.Count()
                
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl5.Text=db.maksUrunMarka().FirstOrDefault();
            labelControl3.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBLURUN orderby x.SATISFIYAT descending select x.MARKA).FirstOrDefault();


           // chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Beko", 2);
            //chartControl1.Series["Series 1"].Points.AddPoint("toshiba", 1);
            //chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 2);
            //chartControl1.Series[0].LegendTextPattern = "{A}: {V:F1}";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SO1A66F;Initial Catalog=data;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select MARKA, COUNT(*) from TBLURUN group by MARKA", baglanti);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
           baglanti.Close();
            //2. Chart
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TBLKATEGORI.AD,COUNT(*) FROM TBLURUN INNER JOIN TBLKATEGORI ON TBLKATEGORI.ID = TBLURUN.KATEGORI GROUP BY TBLKATEGORI.AD", baglanti);
            SqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
 