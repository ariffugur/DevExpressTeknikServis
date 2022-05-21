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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-4QQ4ANU;Initial Catalog=data;Integrated Security=True");
        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            chartControl1.Series[0].LegendTextPattern = "{A}: {V:F1}";
         
            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new
            {
                IL=z.Key, Toplam=z.Count() }).ToList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,COUNT(*) FROM TBLCARI group by IL", baglanti);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
            {

            };
        }
    }
}
