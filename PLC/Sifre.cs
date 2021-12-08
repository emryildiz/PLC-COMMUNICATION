using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace PLC
{
   
    public partial class Sifre : Form
    {
        public Form1 form;
        Veritabani db = new Veritabani();
        public Sifre()
        {
            int dil = db.DilAyar();
            if (dil == 1)
                Resources.Localization.Culture = new CultureInfo("en-US");

            InitializeComponent();
            Localization();
        }
        private void Localization()
        {
            lblSifre.Text = Resources.Localization.Sifre;
            this.Text = Resources.Localization.Giris;
            btnSifre.Text = Resources.Localization.Giris;
        }
        private void AyarlarAc()
        {
           
            if(db.GirisKontrol(txtSifre.Text))
            {
                form.openChildForm(new Ayarlar());
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                txtSifre.Clear();
            }


        }
        private void btnSifre_Click(object sender, EventArgs e)
        {
            AyarlarAc();
        }
        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSifre.PerformClick();
        }
    }
}
