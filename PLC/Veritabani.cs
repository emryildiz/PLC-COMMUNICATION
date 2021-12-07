using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace PLC
{
    class Veritabani
    {
        static string connectionString = "Data Source = Ayarlar.db; Version=3;Count Changes = off; Journal Mode = off; Pooling=true;Cache Size = 10000; Page Size = 4096; Synchronous=off";
        SQLiteConnection baglanti = new SQLiteConnection(connectionString);
        public Veritabani()
        {

        }
        public void AdresSil(string text)
        {
            string komut = "DELETE FROM Adresler WHERE İsim=@İsim";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);
            cmd.Parameters.AddWithValue("@İsim", text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public void AdresEkle(string isim, string adres, bool chk)
        {
            baglanti.Close();
            string komut = "INSERT INTO Adresler(İsim,Adres,Yazilabilir) values(@İsim,@Adres,@Yazilabilir)";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@İsim", isim);
            cmd.Parameters.AddWithValue("@Adres", adres);
            if (chk)
                cmd.Parameters.AddWithValue("@Yazilabilir", 1);
            else
                cmd.Parameters.AddWithValue("@Yazilabilir", 0);

            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable VeriCek()
        {
            string komut = "Select * from Adresler";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);
            baglanti.Open();
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        public void SifreGuncelle(string text)
        {
            string komut = "UPDATE Sifre SET Pass=@Sifre Where ID='1'";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@Sifre", text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public void PLCAyarGuncelle(string cputype,string ip,int rack,int slot)
        {
            string komut = "UPDATE PLC SET CPUType=@CpuType, IP=@Ip, Rack=@Rack, Slot=@Slot Where ID='1'";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("@CpuType", cputype);
            cmd.Parameters.AddWithValue("@Ip", ip);
            cmd.Parameters.AddWithValue("@Rack", rack);
            cmd.Parameters.AddWithValue("@slot", slot);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public void TumunuSil()
        {
            string komut = "DELETE FROM Adresler WHERE İsim=@İsim";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);
            DataTable dt = VeriCek();
            baglanti.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string adi = dt.Rows[i][1].ToString();
                cmd.Parameters.AddWithValue("@İsim", adi);
                cmd.ExecuteNonQuery();
            }
            baglanti.Close();

        }
        public DataTable PlcAyarOku()
        {
            string komut = "Select * from PLC";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);
            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        public bool GirisKontrol(string text)
        {
            string komut = "Select Pass from Sifre";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);
            baglanti.Open();
            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (text == dr["Pass"].ToString())
                {
                    baglanti.Close();
                    return true;
                }
            }


            baglanti.Close();
            return false;

        }
        public DataTable YazmaOku()
        {
            DataTable dt = new DataTable();

            SQLiteConnection baglanti = new SQLiteConnection(connectionString);
            string komut = "Select * from Adresler where Yazilabilir='" + 1 + "'";
            SQLiteCommand cmd = new SQLiteCommand(komut, baglanti);

            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);


            baglanti.Close();
            return dt;
        }




    }
}
