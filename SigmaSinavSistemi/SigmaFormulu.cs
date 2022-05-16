using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Collections;
using System.IO;

namespace SigmaSinavSistemi
{
    class SigmaFormulu : Sorular
    {
        
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        public SqlCommand komut;

        public int soru_id { get; set; }
        
        public int kacDefaBildi { get; set; }
        public DateTime CozduguTarih { get; set; }
        public DateTime CikicakTarih { get; set; }
        
        

        public List<SigmaFormulu> SoruOzellik()
        {
            List<SigmaFormulu> formul = new List<SigmaFormulu>();
            komut = new SqlCommand("SELECT * FROM Sorular", connect);
            connect.Open();
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SigmaFormulu sigma = new SigmaFormulu();
                sigma.soru_id = int.Parse(oku[1].ToString());
                sigma.CozduguTarih = Convert.ToDateTime(oku[2].ToString());
                sigma.CikicakTarih = Convert.ToDateTime(oku[3].ToString());
                sigma.kacDefaBildi = int.Parse(oku[4].ToString());
                formul.Add(sigma);
            }
            connect.Close();
            return formul;  
        }
        public void TarihGuncelle()
        {
            connect.Open();
            komut = new SqlCommand("UPDATE Sorular SET CozduguTarih = CURDATE()", connect);
            komut.ExecuteNonQuery();
            connect.Close();
        }
        public int[] kacDefaBildif()
        {
            int adet = 0;
            connect.Open();
            SqlCommand sayi = new SqlCommand("SELECT COUNT(*) FROM Sigma WHERE Derece > 0 AND CozduguTarih >= CikicakTarih AND Basari = 0", connect);
            adet = (int)sayi.ExecuteScalar();
            int[] kacDefaBildif = new int[adet];
           
            komut = new SqlCommand("SELECT SoruId FROM Sigma WHERE Derece > 0 AND CozduguTarih >= CikicakTarih AND Basari = 0", connect);
            SqlDataReader oku = komut.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
                kacDefaBildif[i] = int.Parse(oku[0].ToString());
                i++;
            }
            connect.Close();
            return kacDefaBildif;
        }
    }
}