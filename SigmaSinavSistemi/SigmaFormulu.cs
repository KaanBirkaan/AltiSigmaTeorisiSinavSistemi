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

        
        public void TarihGuncelle(int soruID)
        {
            DateTime now = DateTime.Now;
            connect.Open();
            komut = new SqlCommand("UPDATE Sorular SET CozduguTarih = CAST(GETDATE() AS DATE), CikicakTarih = CAST(GETDATE() AS DATE) , kacDefaBildi = kacDefaBildi+1 Where soru_id = '" +soruID+"'", connect);
            komut.ExecuteNonQuery();
            connect.Close();
        }
        public void GelecekTarihiguncelle(int soruID)
        {
            DateTime now = DateTime.Now;
            connect.Open();


            string komut2 = "";

            
            if (kacDefaBildi != 6)
            {

                switch (kacDefaBildi)
                {
                    case 0:

                        komut2 = "DATEADD(DD, 1, CikicakTarih)";
                        break;
                    case 1:
                        komut2 = "DATEADD(WW, 1, CikicakTarih)";

                        break;
                    case 2:
                        komut2 = "DATEADD(MM, 1, CikicakTarih)";

                        break;
                    case 3:
                        komut2 = "DATEADD(MM, 3, CikicakTarih)";

                        break;
                    case 4:
                        komut2 = "DATEADD(MM, 6, CikicakTarih)";

                        break;
                    case 5:
                        komut2 = "DATEADD(YYYY, 1, CikicakTarih)";

                        break;
                }
                komut = new SqlCommand("UPDATE Sorular SET CikicakTarih = " + komut2 + " WHERE soru_id = '" + soruID + "'", connect);

            }
            komut.ExecuteNonQuery();
            connect.Close();
            
        }
        public int[] kacDefaBildif()
        {
            int adet = 0;
            connect.Open();
            SqlCommand guncelle = new SqlCommand("SELECT COUNT(*) FROM Sorular WHERE kacDefaBildi > 0 AND CozduguTarih >= CikicakTarih ", connect);
            adet = (int)guncelle.ExecuteScalar();
            int[] kacdefabildi = new int[adet];
            
            komut = new SqlCommand("SELECT soru_id FROM Sorular WHERE kacDefaBildi > 0 AND CozduguTarih >= CikicakTarih ", connect);
            SqlDataReader oku = komut.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
                kacdefabildi[i] = int.Parse(oku[0].ToString());
                i++;
            }
            connect.Close();
            return kacdefabildi;
        }

    }
}