using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PLC
{
    
    

    class Grafik
    {
        /// <summary>
        /// Grafik Panel Başlık İsmi Ayarla
        /// </summary>
        /// <param name="baslik">Başlık İsmi</param>
        /// <param name="grafik">ZedGrapControl'ü</param>
        public void BaslikAyarla(string baslik, ZedGraph.ZedGraphControl grafik)
        {
            grafik.GraphPane.Title.Text = baslik;
        }

        /// <summary>
        ///Eksen Basliklarinin İsimlerini Belirleme
        /// </summary>
        /// <param name="xEkseni">X Ekseni Baslik İsmi</param>
        /// <param name="yEkseni">Y Ekseni Baslik İsmi</param>
        /// <param name="grafik">ZedGrapControl'ü</param>
        public void EksenIsımleriBelirle(string xEkseni, string yEkseni, ZedGraph.ZedGraphControl grafik)
        {
            grafik.GraphPane.XAxis.Title.Text = xEkseni;
            grafik.GraphPane.YAxis.Title.Text = yEkseni;
            grafik.Invalidate();
            grafik.AxisChange();
            grafik.Refresh();
        }

        /// <summary>
        ///X Ekseni Maximum ve Minimum Deger Ayarlama.
        ///(Maximum degeri 0 girilirse max sonsuz olur.)
        /// </summary>
        /// <param name="min">Minimum Değer</param>
        /// <param name="max">Maximum Değer</param>
        /// <param name="grafik">ZedGraphControl'ü</param>
        public void XEkseniMaxMinBelirleme(double min, double max, ZedGraph.ZedGraphControl grafik)
        {
           
            grafik.GraphPane.XAxis.Scale.Min = min;
            if (max != 0)
                grafik.GraphPane.XAxis.Scale.Max = max;


        }

        /// <summary>
        ///Y Ekseni Maximum ve Minimum Deger Ayarlama.
        ///(Maximum degeri 0 girilirse max sonsuz olur.)
        /// </summary>
        /// <param name="min">Minimum Değer</param>
        /// <param name="max">Maximum Değer</param>
        /// <param name="grafik">ZedGraphControl'ü</param>
        public void YEkseniMaxMinBelirleme(double min, double max, ZedGraph.ZedGraphControl grafik)
        {
            grafik.GraphPane.YAxis.Scale.Min = min;
            if (max != 0)
                grafik.GraphPane.YAxis.Scale.Max = max;


        }
        
        
      


    }
}
