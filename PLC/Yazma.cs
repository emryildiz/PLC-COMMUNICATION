using S7.Net;
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
    public partial class Yazma : Form
    {
        public Form1 form;

        DataTable dt = new DataTable();
        Veritabani db = new Veritabani();
        public Yazma()
        {
            int dil = db.DilAyar();
            if (dil == 1)
                Resources.Localization.Culture = new CultureInfo("en-US");
            this.Text = Resources.Localization.Yazma;
            InitializeComponent();
        }
        /// <summary>
        /// PLC'ye Veri Yazar
        /// </summary>
        /// <param name="e"></param>
        private void veriYaz(DataGridViewCellEventArgs e)
        {
            string adres = dt.Rows[e.RowIndex][e.ColumnIndex + 1].ToString();
            string deger = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            form.plc.Write(adres, Convert.ToUInt32(deger));

            okuma();
        }
        
        /// <summary>
        /// DataGridView Doldurur
        /// </summary>
        private void okuma()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string adres = dt.Rows[i][2].ToString();
                string baslik = dt.Rows[i][1].ToString();
                dataGridView1.Rows.Add(baslik, form.plc.Read(adres));
            }

        }

        private void Yazma_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn isimClmn = new DataGridViewTextBoxColumn();
            isimClmn.HeaderText = Resources.Localization.İsim;
            dataGridView1.Columns.Add(isimClmn);

            DataGridViewTextBoxColumn degerClmn = new DataGridViewTextBoxColumn();
            degerClmn.HeaderText = Resources.Localization.Deger;
            dataGridView1.Columns.Add(degerClmn);
            dt = db.YazmaOku();
            okuma();

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            veriYaz(e);
        }
        
    }
}
