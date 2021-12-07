using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using S7.Net;

namespace PLC
{
    public partial class AnaSayfaList : Form
    {
        public Form1 form;
        DataTable dt = new DataTable();
        Veritabani db = new Veritabani();
        Plc x;
        public AnaSayfaList()
        {
            InitializeComponent();
        }
        
        public void okuma()
        {
            x = form.plc;
            okumaBg.RunWorkerAsync();


        }
        /// <summary>
        /// GRAFİK FORMUNU OLUŞTURUR
        /// </summary>
        /// <param name="e"></param>
        private void grafikFormOlustur(DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                FormGrafik f1 = new FormGrafik();
                f1.adres = dt.Rows[e.RowIndex][2].ToString();
                f1.isim = dt.Rows[e.RowIndex][1].ToString();
                f1.form = this.form;
                f1.plc = form.plc;
                form.openChildForm(f1);
            }

        }
        private void AnaSayfaList_Load(object sender, EventArgs e)
        {


            x = form.plc;
            dt = db.VeriCek();
            DataGridViewTextBoxColumn isimClmn = new DataGridViewTextBoxColumn();
            isimClmn.HeaderText = "İsim";
            dataGridView1.Columns.Add(isimClmn);

            DataGridViewTextBoxColumn degerClmn = new DataGridViewTextBoxColumn();
            degerClmn.HeaderText = "Değer";
            dataGridView1.Columns.Add(degerClmn);
            okuma();

        }
        private void okumaBg_DoWork(object sender, DoWorkEventArgs e)
        {
            if (form.baglanti)
            {
                while (true)
                {
                    if (Application.OpenForms["AnaSayfaList"] == null)
                        break;
                    if (dataGridView1.Rows.Count == 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string adres = dt.Rows[i][2].ToString();
                            string baslik = dt.Rows[i][1].ToString();
                            dataGridView1.Rows.Add(baslik, x.Read(adres));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            try
                            {

                                string adres = dt.Rows[i][2].ToString();
                                string baslik = dt.Rows[i][1].ToString();
                                dataGridView1.Rows[i].Cells[1].Value = x.Read(adres);
                                dataGridView1.Rows[i].Cells[0].Value = baslik;
                            }
                            catch
                            {
                                break;
                            }

                        }

                    }
                }
            }

        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            grafikFormOlustur(e);
        }
    }
}
