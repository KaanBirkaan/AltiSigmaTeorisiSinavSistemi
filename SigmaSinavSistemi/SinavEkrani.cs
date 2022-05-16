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
using System.Runtime.InteropServices;

namespace SigmaSinavSistemi
{
    public partial class SinavEkrani : Form
    {
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        Sorular SorularSinifi = new Sorular();
        int ekrandakiSoruID = 1;
        string dogruCevap;
        int cektiginSorununID;
        DataSet ds;
        public SinavEkrani()
        {
            InitializeComponent();
        }
        int saniye = 0;
        int dakika = 0;
        
        private void SinavEkrani_Load(object sender, EventArgs e)
        {
            ekrandakiSoruID = 1;
       
        

            SoruyuEkranaIsle(ekrandakiSoruID);

                lbl_dakika.Text = "0";
                timer1.Interval = 1000;
                timer1.Start();


        }

        public void SoruyuEkranaIsle(int soruID)
        {
          
            ds = SorularSinifi.SorulariCek(soruID);
              dogruCevap = ds.Tables[0].Rows[0]["dogru_cevap"].ToString();
            string cevap1 = ds.Tables[0].Rows[0]["cevap1"].ToString();
            string cevap2 = ds.Tables[0].Rows[0]["cevap2"].ToString();
            string cevap3 = ds.Tables[0].Rows[0]["cevap3"].ToString();
            string soruFotosu = ds.Tables[0].Rows[0]["yol"].ToString();
               cektiginSorununID = int.Parse(ds.Tables[0].Rows[0]["soru_id"].ToString());
            MessageBox.Show("BEN BUNU ÇEKERİM YA"+cektiginSorununID);
            lbl_sorusayi.Text = "SORU" + " " + (ekrandakiSoruID);


            radbtn_a.Text = cevap1;
            radbtn_b.Text = cevap2;
            radbtn_c.Text = cevap3;
            radbtn_d.Text = dogruCevap;
            pictureBox1.ImageLocation = soruFotosu;
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();

            string cevapguncelleme = ("Update Sorular Set kacDefaBildi=@kacDefaBildi, CozduguTarih=@CozduguTarih , CikicakTarih=@CikicakTarih where soru_id=@soru_id");

            SigmaFormulu formulAta = new SigmaFormulu();
            formulAta.TarihGuncelle(cektiginSorununID);
            SqlCommand komut = new SqlCommand(cevapguncelleme, connect);

            RadioButton rb = null;

            if (radbtn_a.Checked == true)
            {
                rb = radbtn_a;
            }
            else if (radbtn_b.Checked == true)
            {
                rb = radbtn_b;
            }
            else if (radbtn_c.Checked == true)
            {
                rb = radbtn_c;
            }
            else if (radbtn_d.Checked == true)
            {
                rb = radbtn_d;


            }

            if (rb.Text == dogruCevap)
            {
                MessageBox.Show("Doğru cevap verdiniz");

            }

            ekrandakiSoruID++;
            if (ekrandakiSoruID == 11)
            {
                MessageBox.Show("sınavınız bitmiştir");
            }
            else
            {
                SoruyuEkranaIsle(ekrandakiSoruID);
            }
           
           
            connect.Close();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lbl_saniye.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                lbl_dakika.Text = "0";
                lbl_dakika.Text = dakika.ToString();
                saniye = 0;
            }
            if (dakika == 10)
            {
                timer1.Stop();
                MessageBox.Show("SÜRE BİTTİ , SINAV SONLANDIRILDI");
                this.Close();
                OgrenciEkrani o = new OgrenciEkrani();
                o.Show();
            }
        }

        private void bttn_btr_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
