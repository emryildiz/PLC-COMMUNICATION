using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using S7.Net;
using System.Data;
using System.Globalization;

namespace PLC
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Degisken Tanimlamalari
        public bool baglanti = false;
        static string ipAdresi = "";
        private string cputype;
        private short rack;
        private short slot;
        AnaSayfaList ana = new AnaSayfaList();
        public Plc plc;
        Form activeForm;
        Veritabani db = new Veritabani();

        public Form1()
        {
            int dil = db.DilAyar();
            if(dil == 1)
                Resources.Localization.Culture = new CultureInfo("en-US");


            DataTable dt = db.PlcAyarOku();
            cputype = dt.Rows[0][2].ToString();
            ipAdresi = dt.Rows[0][1].ToString();
            rack = Convert.ToInt16(dt.Rows[0][3]);
            slot = Convert.ToInt16(dt.Rows[0][4]);
            switch (cputype)
            {
                case "S7200":
                    plc = new Plc(CpuType.S7200, ipAdresi, rack, slot);
                    break;
                case "S7300":
                    plc = new Plc(CpuType.S7300, ipAdresi, rack, slot);
                    break;
                case "S7400":
                    plc = new Plc(CpuType.S7400, ipAdresi, rack, slot);
                    break;
                case "S71200":
                    plc = new Plc(CpuType.S71200, ipAdresi, rack, slot);
                    break;
                case "S71500":
                    plc = new Plc(CpuType.S71500, ipAdresi, rack, slot);
                    break;
            }

            InitializeComponent();
            
        }
        
        //Fonksiyonlar
        
        private void MouseHoverButton(Button buton)
        {
            buton.BackColor = Color.Orange;
        }
        private void MouseLeaveButton(Button buton)
        {
            buton.BackColor = Color.FromArgb(34, 34, 34);
        }
        private void CikisMoverHoverButton(Button buton)
        {
            buton.BackColor = Color.Red;
        }
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(childForm);
            this.contentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            headerLBL.Text = childForm.Text;
        }


        private void Localization()
        {
            btnAnasayfa.Text = Resources.Localization.Anasayfa;
            ayarlarBtn.Text   = Resources.Localization.Ayarlar;
            btnCikis.Text = Resources.Localization.Cikis;
            btnYazma.Text = Resources.Localization.Yazma;
        }

        //Eventler
        private void Form1_Load(object sender, EventArgs e)
        {
            Localization();
            ana.form = this;
            this.Text = string.Empty;
            this.ControlBox = false;
            openChildForm(ana);
            txtIP.Text = Resources.Localization.Baglaniyor+"...";
            txtIP.ForeColor = Color.FromArgb(234, 119, 4);
            this.Focus();
            loadBg.RunWorkerAsync();


        }
        private void btnYazma_Click(object sender, EventArgs e)
        {
            Yazma y = new Yazma();
            y.form = this;
            openChildForm(y);
        }
        private void btnAyarlar_MouseEnter(object sender, EventArgs e)
        {
            MouseHoverButton(ayarlarBtn);
        }
        private void btnYazma_MouseEnter(object sender, EventArgs e)
        {

            MouseHoverButton(btnYazma);
        }
        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {

            CikisMoverHoverButton(btnCikis);
        }
        private void btnAyarlar_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveButton(ayarlarBtn);
        }
        private void btnYazma_MouseLeave(object sender, EventArgs e)
        {

            MouseLeaveButton(btnYazma);
        }
        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {

            MouseLeaveButton(btnCikis);
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void headerLBL_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfaList ana = new AnaSayfaList();
            ana.form = this;
            this.Text = string.Empty;
            this.ControlBox = false;
            openChildForm(ana);

        }
        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveButton(btnAnasayfa);
        }
        private void btnAnasayfa_MouseEnter(object sender, EventArgs e)
        {
            MouseHoverButton(btnAnasayfa);
        }
        private void headerLBL_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void pictureLogo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            Sifre sifre = new Sifre();
            sifre.form = this;
            sifre.Show();
        }
        private void loadBg_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                plc.Open();
                txtIP.Text = ipAdresi;
                txtIP.ForeColor = Color.FromArgb(20, 90, 50);
                btnYazma.Enabled = true;
                this.baglanti = true;
                ana.okuma();
            }
            catch
            {
                txtIP.Text = Resources.Localization.BaglantiYok+"!";
                txtIP.ForeColor = Color.FromArgb(146,43,33);
                this.baglanti = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resources.Localization.Culture = new CultureInfo("en-US");
            Localization();
        }
    }

}
