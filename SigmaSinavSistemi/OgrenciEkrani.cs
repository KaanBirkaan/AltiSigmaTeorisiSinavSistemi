using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaSinavSistemi
{
    public partial class OgrenciEkrani : Form
    {
        public string yazi;
        public OgrenciEkrani()
        {
            InitializeComponent();
        }

        private void bttn_ayarlar_Click(object sender, EventArgs e)
        {

        }

        private void OgrenciEkrani_Load(object sender, EventArgs e)
        {
            hoslbl.Text = "Hoşgeldin " + yazi;

            lbl_Tarih.Text = "TARİH" + DateTime.Now.Date.ToString();
        }

        private void bttn_snvgir_Click(object sender, EventArgs e)
        {
            SinavEkrani snv = new SinavEkrani();
            snv.ShowDialog();
        }
    }
}
