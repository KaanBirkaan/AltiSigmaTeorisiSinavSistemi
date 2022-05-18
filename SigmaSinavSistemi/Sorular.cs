using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SigmaSinavSistemi
{
    class Sorular
    {
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        private int soruID { get; set; }
        private int kacDefaBildi { get; set; }
        private string soruImage { get; set; }
        private string cevap1 { get; set; }
        private string cevap2 { get; set; }
        private string cevap3 { get; set; }
        private string dogruCevap { get; set; }

        int sorusayisi = 10;

        public DataSet SorulariCek(int id)
        {
            connect.Open();
            string sorgu = "Select Top "+ sorusayisi + " * From Sorular where kacDefaBildi = '0' Order By NewID() ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connect.Close();
            return ds; //geri donus saglandi
        }
        public DataSet SorulariCek2(int id)
        {
            connect.Open();
            string sorgu = "Select Top " + sorusayisi + " * From Sorular where kacDefaBildi > 0 AND CikicakTarih <= GuncelTarih  Order By NewID() ";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connect.Close();
            return ds; //geri donus saglandi
        }








    }
}
