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
    public partial class Ayarlar : Form
    {
        Veritabani db = new Veritabani();

        public Ayarlar()
        {
            int dil = db.DilAyar();
            if (dil == 1)
                Resources.Localization.Culture = new CultureInfo("en-US");
          
            InitializeComponent();
            Localization();
        }
        private void Localization()
        {
            this.Text = Resources.Localization.Ayarlar;

            grpEkle.Text = Resources.Localization.Ekle;
            grpSil.Text = Resources.Localization.Sil;
            grpSifre.Text = Resources.Localization.Sifre;
            grpIp.Text = Resources.Localization.PlcAyar;

            lblİsim.Text = Resources.Localization.İsim+":";
            lblAdres.Text = Resources.Localization.Adres+":";
            chkWritable.Text = Resources.Localization.Yazilabilir+":";
            ekleBtn.Text = Resources.Localization.Ekle;

            lblSil.Text = Resources.Localization.İsim+":";
            btnSil.Text = Resources.Localization.Sil;

            lblIp.Text = Resources.Localization.IpAdresi+":";
            btnIp.Text = Resources.Localization.Degistir;

            lblSifre.Text = Resources.Localization.Sifre + ":";
            btnSifre.Text = Resources.Localization.Degistir;

            btnTumunuSıl.Text = Resources.Localization.TumunuSil;

        }
        private void CmbDoldur()
        {
            cmbSil.Items.Clear();
            DataTable dt = db.VeriCek();
            for(int i = 0;i<dt.Rows.Count;i++)
            {
                string adi = dt.Rows[i][1].ToString();
                cmbSil.Items.Add(adi);
            }
        }
        private void PLCAyarDoldur()
        {
            DataTable dt = db.PlcAyarOku();
            string cputype = dt.Rows[0][2].ToString();
            string ip = dt.Rows[0][1].ToString();
            string rack = dt.Rows[0][3].ToString();
            string slot = dt.Rows[0][4].ToString();
            if (cputype == "S7200")
                comCpu.SelectedIndex = 0;

            if (cputype == "S7300")
                comCpu.SelectedIndex = 1;

            if (cputype == "S7400")
                comCpu.SelectedIndex = 2;

            if (cputype == "S71200")
                comCpu.SelectedIndex = 3;

            if (cputype == "S71500")
                comCpu.SelectedIndex = 4;

            txtIp.Text = ip;
            txtRack.Text = rack;
            txtSlot.Text = slot;
        }
        
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            int dil = db.DilAyar();
            if (dil == 1)
                cmbDil.SelectedIndex = 1;
            else
                cmbDil.SelectedIndex = 0;

            CmbDoldur();
            PLCAyarDoldur();
        }
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            try
            {

                db.AdresEkle(txtİsim.Text,txtAdres.Text,chkWritable.Checked);
                MessageBox.Show("Başarıyla Eklendi");
                txtİsim.Clear();
                txtAdres.Clear();
                CmbDoldur();
            }
            catch(Exception hata)
            {
                MessageBox.Show("Eklerken bir Hatayla Karşılaşıldı"+Environment.NewLine+hata);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {

                db.AdresSil(cmbSil.Text);
                CmbDoldur();
                cmbSil.SelectedIndex = 0;


                MessageBox.Show(cmbSil.Text + " isimli veri başarıyla silindi");
            }
            catch
            {

                MessageBox.Show("Silerken bir Hatayla Karşılaşıldı");
            }
        }
        private void btnIp_Click(object sender, EventArgs e)
        {
            try
            {
                string cputype=string.Empty;
                if (comCpu.SelectedIndex == 0)
                    cputype = "S7200";

                if (comCpu.SelectedIndex == 1)
                    cputype = "S7300";

                if (comCpu.SelectedIndex == 2)
                    cputype = "S7400";

                if (comCpu.SelectedIndex == 3)
                    cputype = "S71200";

                if (comCpu.SelectedIndex == 4)
                    cputype = "S71500";



                db.PLCAyarGuncelle(cputype,txtIp.Text,Convert.ToInt32(txtRack.Text),Convert.ToInt32(txtSlot.Text));
                MessageBox.Show("PLC Ayarları Başarıyla Güncellendi");
            }
            catch
            {
                MessageBox.Show("PLC Ayarları Güncelleme Başarısız Oldu");
            }
        }
        private void btnSifre_Click(object sender, EventArgs e)
        {
            try
            {
                db.SifreGuncelle(txtSifre.Text);
                txtSifre.Clear();
                MessageBox.Show("Şifre Başarıyla Güncellendi");
            }
            catch
            {
                MessageBox.Show("Şifre Güncelleme Başarısız Oldu");

            }
        }
        private void btnTumunuSıl_Click(object sender, EventArgs e)
        {
            
            try
            {
                db.TumunuSil();
                MessageBox.Show("Tüm Verileri Başarıyla Silindi.");
            }
            catch
            {
                MessageBox.Show("Veriler Silinemedi");
            }
           

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbDil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDil.SelectedIndex == 0)
            {
                db.DilDegistir(0);
            }
            else
            {
                db.DilDegistir(1);
            }
        }
    }
}
