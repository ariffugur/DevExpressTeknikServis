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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }

        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            chartControl1.Series[0].LegendTextPattern = "{A}: {V:F1}";
            chartControl1.Series["Series 1"].Points.AddPoint("Manisa", 23);
            chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 56);
            chartControl1.Series["Series 1"].Points.AddPoint("Aydın", 18);
            chartControl1.Series["Series 1"].Points.AddPoint("Antalya",34);

        }
    }
}
