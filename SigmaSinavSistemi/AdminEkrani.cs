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
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        public void KayitlariListele()
        {
            connect.Open();
            string listele = "Select * From Bilgi";

            SqlCommand komut = new SqlCommand(listele, connect);

            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt); // sorgu sonucu gelen bilgileri table nesnesinin içine doldur

            ListeGrid.DataSource = dt;
            connect.Close();

        }

        private void bttn_listele_Click(object sender, EventArgs e)
        {
            KayitlariListele();

        }

        private void bttn_arama_Click(object sender, EventArgs e)
        {
            connect.Open();
            string ara = "Select * From Bilgi Where username=@username";
            SqlCommand komut = new SqlCommand(ara, connect);

            komut.Parameters.AddWithValue("@username", ara_txt.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();

            da.Fill(dt);
            ListeGrid.DataSource = dt;
            connect.Close();
        }
        public void usersil (int id)
        {
            connect.Open();
        string sil = "Delete  From Bilgi Where id= @id";
        SqlCommand komut = new SqlCommand(sil, connect);

            komut.Parameters.AddWithValue("id", id);

            komut.ExecuteNonQuery();
            connect.Close();

        
        }

        private void bttn_sil_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow drow in ListeGrid.SelectedRows)// Listenen gridde seçili olan satıra göre silme işlemi yap
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                usersil(id);
                MessageBox.Show("Silindi");
                KayitlariListele();
            }
        }
        int i = 0;
        private void bttn_guncelle_Click(object sender, EventArgs e)
        {
            {
                connect.Open();
                
                string guncelleme = ("Update Bilgi Set username=@username, sifre =@sifre , KayitTuru=@KayitTuru where id=@id");


                SqlCommand komut = new SqlCommand(guncelleme, connect);
                


                komut.Parameters.AddWithValue("@username", kultxt.Text);
                komut.Parameters.AddWithValue("@sifre", siftxt.Text);
                  if (kytturu_cmb.Text == "Öğrenci")
                {
                    komut.Parameters.AddWithValue("@KayitTuru", "1");
                }
                else if (kytturu_cmb.Text == "Öğretmen")
                {

                    komut.Parameters.AddWithValue("@KayitTuru", "2");

                }
                komut.Parameters.AddWithValue("@id", ListeGrid.Rows[i].Cells[0].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncellendi");
                connect.Close();
                KayitlariListele();
            }
        }

        private void ListeGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            kultxt.Text = ListeGrid.Rows[i].Cells[1].Value.ToString();
            siftxt.Text = ListeGrid.Rows[i].Cells[2].Value.ToString();
            if (ListeGrid.Rows[i].Cells[2].Value.ToString() == "3")
            {
                kytturu_cmb.Text = "Öğrenci";
            }
            else if (ListeGrid.Rows[i].Cells[2].Value.ToString() == "2")
            {
                kytturu_cmb.Text = "Öğretmen";
            }
        }
    }
}
