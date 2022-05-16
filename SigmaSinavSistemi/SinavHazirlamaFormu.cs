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
using System.IO;

namespace SigmaSinavSistemi
{
    public partial class SinavHazirlamaFormu : Form
    {
        public SinavHazirlamaFormu()
        {
            InitializeComponent();
        }

        string yolDegeri;
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        string imagepath;
        private void bttn_image_Click(object sender, EventArgs e)
        {
            if (dosyabulma.ShowDialog() == DialogResult.OK)
            {

                soruimage.Image = Image.FromFile(dosyabulma.FileName);
                imagepath = dosyabulma.FileName;

                System.IO.StreamReader sr = new
           System.IO.StreamReader(dosyabulma.FileName);
                string[] s = (dosyabulma.FileName.ToString()).Split('\\');
                int count = s.Length;
                MessageBox.Show(s[count - 1]);
                yolDegeri = s[count - 1];
            }
        }

        private void bttn_eklesoru_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();

           







            
             connect.Open();
                
             SqlCommand komut = new SqlCommand("insert into Sorular (yol,dogru_cevap,cevap1,cevap2,cevap3) values(@yol,@dogru_cevap,@cevap1,@cevap2,@cevap3)", connect);

            
            komut.Parameters.AddWithValue("@dogru_cevap", cevapd_txt.Text);
            komut.Parameters.AddWithValue("@yol", yolDegeri);
            komut.Parameters.AddWithValue("@cevap1", cevap1_txt.Text);
            komut.Parameters.AddWithValue("@cevap2", cevap2_txt.Text);
            komut.Parameters.AddWithValue("@cevap3", cevap3_txt.Text);
            komut.ExecuteNonQuery();
             connect.Close();


             MessageBox.Show("Soru Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                
           



        }
    }
}
