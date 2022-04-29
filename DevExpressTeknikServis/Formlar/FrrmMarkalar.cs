﻿using System;
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
            labelControl3.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBLURUN orderby x.SATISFIYAT descending select x.MARKA).FirstOrDefault();
        }
    }
}
 