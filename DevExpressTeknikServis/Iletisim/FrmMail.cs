﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace DevExpressTeknikServis.Iletisim
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mail=new MailMessage();
            string frommail = "gonderici";
            string sifre = "sifremail";
            string alici = txtAlici.Text;
            string konu = txtKonu.Text;
            string icerik = txtIcerik.Text;
            mail.From=new MailAddress(frommail);
            mail.To.Add(alici);
            mail.Subject = konu;
            mail.Body = icerik;
            mail.IsBodyHtml = true;
            SmtpClient smtp=new SmtpClient("smtp.gmail.com",587);
            smtp.Credentials=new NetworkCredential(frommail,sifre);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("Mail gönderildi!");
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
