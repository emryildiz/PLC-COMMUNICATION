using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace PLC
{
    public partial class FormGrafik : Form
    {
        public Form1 form;
        public string adres;
        public string isim;
        public Plc plc;
        Grafik g = new Grafik();
        RollingPointPairList listPointsOne = new RollingPointPairList(30);
        public FormGrafik()
        {
            InitializeComponent();
        }
        Stopwatch watch = new Stopwatch();
        private void Deger1Form_Load(object sender, EventArgs e)
        {

            this.plc = form.plc;
            //Baslik Ayarlama
            g.BaslikAyarla("", GrafikControl);
            //Eksen Baslik İsimleri Belirleme
            g.EksenIsımleriBelirle("Zaman(MiliSaniye)", isim, GrafikControl);




            watch.Start();
            backgroundWorker1.RunWorkerAsync();



        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            object sayi;
            sayi = plc.Read(adres);
            var veri = Convert.ToDouble(sayi);
            listPointsOne.Add(Convert.ToInt32(watch.Elapsed.TotalMilliseconds), Convert.ToDouble(veri));
            if (GrafikControl.GraphPane != null)
                GrafikControl.GraphPane.AddCurve(null, listPointsOne, Color.Red, SymbolType.None);

            GrafikControl.Invalidate();
            GrafikControl.AxisChange();
            GrafikControl.Refresh();
            System.Threading.Thread.Sleep(1);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (GrafikControl.GraphPane != null)
                GrafikControl.GraphPane.CurveList.Clear();
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
