using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SigmaSinavSistemi
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into Bilgi (username,sifre,KayitTuru) values(@username,@sifre,@KayitTuru)";
                SqlCommand komut = new SqlCommand(kayit,connect);

                komut.Parameters.AddWithValue("@username", textBox1.Text);
                
                komut.Parameters.AddWithValue("@sifre", textBox2.Text);
                
               
                if (cmbKayit.Text == "Öğrenci")
                {
                    komut.Parameters.AddWithValue("@KayitTuru", "1");
                }
                else if (cmbKayit.Text == "Öğretmen") {
                   
                    komut.Parameters.AddWithValue("@KayitTuru", "2");

                }

                komut.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("KAYIT EKLENDİ");
            }
            catch(Exception hata)
            {
                MessageBox.Show("hata meydana geldi");
            }

        }
    }
}
