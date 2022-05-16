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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private void button1_Click(object sender, EventArgs e)

        {
            connect.Open();
            string guncelsif = ("Update Bilgi Set sifre =@sifre where username=@username");


            SqlCommand komut = new SqlCommand(guncelsif, connect);
            

            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            komut.Parameters.AddWithValue("@username",textBox1.Text);
            komut.ExecuteNonQuery();
            connect.Close();
        }
    }
}
