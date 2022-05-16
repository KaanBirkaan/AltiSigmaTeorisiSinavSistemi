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
    public partial class formgiris : Form
    {
        
        public formgiris()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        private void button2_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sfr = new SifremiUnuttum();
            sfr.ShowDialog();
            
        }

        private void giriskayit_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.ShowDialog();
        }
        Girisformu g = new Girisformu();
        private void btn_giris_Click(object sender, EventArgs e)
        {

            
            g.Giris(txtGirisKullanici, txtGirisSifre);
            


        }

        
    }
}
