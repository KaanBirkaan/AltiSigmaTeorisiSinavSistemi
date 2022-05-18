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
    public partial class hakkiilebildiğisorular : Form
    {
        static string constring = "Data Source=DESKTOP-V4J96D5\\SQLEXPRESS;Initial Catalog=Kisiler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        Sorular SorularSinifi = new Sorular();
        int ekrandakiSoruID = 1;
        string dogruCevap;
        int hakkiileSorununID;
        DataSet ds;
        int kacdefabildi;

      
       
        public hakkiilebildiğisorular()
        {
            
            InitializeComponent();
           

        }
        int saniye = 0;
        int dakika = 0;

        private void hakkiilebildiğisorular_Load(object sender, EventArgs e)

        {
            ekrandakiSoruID = 1;

            SoruyuEkranaIsle(ekrandakiSoruID);
            lbl_dakika.Text = "0";
            timer1.Interval = 1000;
            timer1.Start();


        }
        public void SoruyuEkranaIsle(int soruID)
        {

            ds = SorularSinifi.SorulariCek2(soruID);
            dogruCevap = ds.Tables[0].Rows[0]["dogru_cevap"].ToString();
            string cevap1 = ds.Tables[0].Rows[0]["cevap1"].ToString();
            string cevap2 = ds.Tables[0].Rows[0]["cevap2"].ToString();
            string cevap3 = ds.Tables[0].Rows[0]["cevap3"].ToString();
            string soruFotosu = ds.Tables[0].Rows[0]["yol"].ToString();
            hakkiileSorununID = int.Parse(ds.Tables[0].Rows[0]["soru_id"].ToString());
            kacdefabildi = int.Parse(ds.Tables[0].Rows[0]["kacDefaBildi"].ToString());

            lbl_sorusayii.Text = "SORU" + " " + (ekrandakiSoruID);


            rbtn_a.Text = cevap1;
            rbtn_b.Text = cevap2;
            rbtn_c.Text = cevap3;
            rbtn_d.Text = dogruCevap;
            pictureBox1.ImageLocation = soruFotosu;


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

        private void bttn_sonraki_Click(object sender, EventArgs e)
        {
            SigmaFormulu formulAta = new SigmaFormulu();
            SigmaFormulu formul2 = new SigmaFormulu();
            SigmaFormulu formul3 = new SigmaFormulu();

            RadioButton rb = null;

            if (rbtn_a.Checked == true)
            {
                rb = rbtn_a;
                formul3.Yanliscevap(hakkiileSorununID);
               

            }
            else if (rbtn_b.Checked == true)
            {
                rb = rbtn_b;
                formul3.Yanliscevap(hakkiileSorununID);

            }
            else if (rbtn_c.Checked == true)
            {
                rb = rbtn_c;
                formul3.Yanliscevap(hakkiileSorununID);

            }
            else if (rbtn_d.Checked == true)
            {
                rb = rbtn_d;
                formulAta.TarihGuncelle(hakkiileSorununID);
                formul2.GelecekTarihiguncelle(hakkiileSorununID);
            }

            if (rb.Text == dogruCevap)
            {

            }

            SoruyuEkranaIsle(ekrandakiSoruID);
        }
    }
}
