using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            InitializeComponent();
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
