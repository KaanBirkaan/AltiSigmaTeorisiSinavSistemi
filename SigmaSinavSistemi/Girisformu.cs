using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    class Girisformu
    {

        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        SqlCommand komut;
        SqlDataReader oku;
        AdminEkrani yeni = new AdminEkrani();
        SinavHazirlamaFormu yeni1 = new SinavHazirlamaFormu();
        OgrenciEkrani yeni2 = new OgrenciEkrani();



        public SqlDataReader Giris (TextBox GirisKullanici, TextBox GirisSifre)
        {
            connect.Open();
            komut = new SqlCommand();
            komut.Connection = connect;
            komut.CommandText = "select *from Bilgi where username = '"+GirisKullanici.Text+"'";
            oku = komut.ExecuteReader();
            if (oku.Read()==true)
            {
                if (GirisSifre.Text == oku["sifre"].ToString())
                {
                    MessageBox.Show("GİRİŞ BAŞARILI");
                    if("3" == oku["Kayitturu"].ToString())
                    {

                        yeni.ShowDialog();
                        
                    }
                    else if ("2" == oku["Kayitturu"].ToString())
                    {
                        yeni1.ShowDialog();
                    }
                    else if ("1" == oku["Kayitturu"].ToString())
                    {


                        yeni2.yazi = GirisKullanici.Text;
                        yeni2.ShowDialog();


                    }



                }
                else
                {
                    MessageBox.Show("ŞİFRENİZİ KONTROL EDİNİZ","Hata 1");
                    
                }
                
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz ", "Hata 2");
                

            }
            connect.Close();
            return oku;


        }

        

    }
}
