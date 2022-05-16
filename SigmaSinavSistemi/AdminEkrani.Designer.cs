
namespace SigmaSinavSistemi
{
    partial class AdminEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminBaslik = new System.Windows.Forms.Label();
            this.AdminAdi = new System.Windows.Forms.Label();
            this.Adminsifre = new System.Windows.Forms.Label();
            this.AdminTur = new System.Windows.Forms.Label();
            this.kultxt = new System.Windows.Forms.TextBox();
            this.siftxt = new System.Windows.Forms.TextBox();
            this.bttn_guncelle = new System.Windows.Forms.Button();
            this.bttn_listele = new System.Windows.Forms.Button();
            this.ListeGrid = new System.Windows.Forms.DataGridView();
            this.ara_txt = new System.Windows.Forms.TextBox();
            this.bttn_arama = new System.Windows.Forms.Button();
            this.bttn_sil = new System.Windows.Forms.Button();
            this.kytturu_cmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminBaslik
            // 
            this.AdminBaslik.AutoSize = true;
            this.AdminBaslik.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminBaslik.Location = new System.Drawing.Point(206, 24);
            this.AdminBaslik.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AdminBaslik.Name = "AdminBaslik";
            this.AdminBaslik.Size = new System.Drawing.Size(209, 39);
            this.AdminBaslik.TabIndex = 0;
            this.AdminBaslik.Text = "Yönetici Paneli";
            // 
            // AdminAdi
            // 
            this.AdminAdi.AutoSize = true;
            this.AdminAdi.Location = new System.Drawing.Point(22, 110);
            this.AdminAdi.Name = "AdminAdi";
            this.AdminAdi.Size = new System.Drawing.Size(118, 26);
            this.AdminAdi.TabIndex = 1;
            this.AdminAdi.Text = "Kullanıcı Adı";
            // 
            // Adminsifre
            // 
            this.Adminsifre.AutoSize = true;
            this.Adminsifre.Location = new System.Drawing.Point(22, 151);
            this.Adminsifre.Name = "Adminsifre";
            this.Adminsifre.Size = new System.Drawing.Size(52, 26);
            this.Adminsifre.TabIndex = 2;
            this.Adminsifre.Text = "Şifre";
            // 
            // AdminTur
            // 
            this.AdminTur.AutoSize = true;
            this.AdminTur.Location = new System.Drawing.Point(22, 190);
            this.AdminTur.Name = "AdminTur";
            this.AdminTur.Size = new System.Drawing.Size(98, 26);
            this.AdminTur.TabIndex = 3;
            this.AdminTur.Text = "Kayıt Türü";
            // 
            // kultxt
            // 
            this.kultxt.Location = new System.Drawing.Point(160, 103);
            this.kultxt.Name = "kultxt";
            this.kultxt.Size = new System.Drawing.Size(133, 33);
            this.kultxt.TabIndex = 4;
            // 
            // siftxt
            // 
            this.siftxt.Location = new System.Drawing.Point(160, 144);
            this.siftxt.Name = "siftxt";
            this.siftxt.Size = new System.Drawing.Size(133, 33);
            this.siftxt.TabIndex = 5;
            // 
            // bttn_guncelle
            // 
            this.bttn_guncelle.BackColor = System.Drawing.Color.Lime;
            this.bttn_guncelle.Location = new System.Drawing.Point(435, 103);
            this.bttn_guncelle.Name = "bttn_guncelle";
            this.bttn_guncelle.Size = new System.Drawing.Size(115, 33);
            this.bttn_guncelle.TabIndex = 7;
            this.bttn_guncelle.Text = "Güncelle";
            this.bttn_guncelle.UseVisualStyleBackColor = false;
            this.bttn_guncelle.Click += new System.EventHandler(this.bttn_guncelle_Click);
            // 
            // bttn_listele
            // 
            this.bttn_listele.BackColor = System.Drawing.Color.Aqua;
            this.bttn_listele.Location = new System.Drawing.Point(435, 142);
            this.bttn_listele.Name = "bttn_listele";
            this.bttn_listele.Size = new System.Drawing.Size(115, 33);
            this.bttn_listele.TabIndex = 8;
            this.bttn_listele.Text = "Listele";
            this.bttn_listele.UseVisualStyleBackColor = false;
            this.bttn_listele.Click += new System.EventHandler(this.bttn_listele_Click);
            // 
            // ListeGrid
            // 
            this.ListeGrid.BackgroundColor = System.Drawing.Color.White;
            this.ListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeGrid.Location = new System.Drawing.Point(27, 322);
            this.ListeGrid.Name = "ListeGrid";
            this.ListeGrid.Size = new System.Drawing.Size(468, 184);
            this.ListeGrid.TabIndex = 9;
            this.ListeGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListeGrid_CellMouseClick);
            // 
            // ara_txt
            // 
            this.ara_txt.Location = new System.Drawing.Point(135, 283);
            this.ara_txt.Name = "ara_txt";
            this.ara_txt.Size = new System.Drawing.Size(133, 33);
            this.ara_txt.TabIndex = 11;
            // 
            // bttn_arama
            // 
            this.bttn_arama.Location = new System.Drawing.Point(27, 283);
            this.bttn_arama.Name = "bttn_arama";
            this.bttn_arama.Size = new System.Drawing.Size(102, 33);
            this.bttn_arama.TabIndex = 12;
            this.bttn_arama.Text = "Ara";
            this.bttn_arama.UseVisualStyleBackColor = true;
            this.bttn_arama.Click += new System.EventHandler(this.bttn_arama_Click);
            // 
            // bttn_sil
            // 
            this.bttn_sil.BackColor = System.Drawing.Color.Red;
            this.bttn_sil.Location = new System.Drawing.Point(435, 181);
            this.bttn_sil.Name = "bttn_sil";
            this.bttn_sil.Size = new System.Drawing.Size(115, 35);
            this.bttn_sil.TabIndex = 13;
            this.bttn_sil.Text = "Sil";
            this.bttn_sil.UseVisualStyleBackColor = false;
            this.bttn_sil.Click += new System.EventHandler(this.bttn_sil_Click);
            // 
            // kytturu_cmb
            // 
            this.kytturu_cmb.FormattingEnabled = true;
            this.kytturu_cmb.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretmen"});
            this.kytturu_cmb.Location = new System.Drawing.Point(160, 194);
            this.kytturu_cmb.Name = "kytturu_cmb";
            this.kytturu_cmb.Size = new System.Drawing.Size(133, 34);
            this.kytturu_cmb.TabIndex = 14;
            // 
            // AdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 538);
            this.Controls.Add(this.kytturu_cmb);
            this.Controls.Add(this.bttn_sil);
            this.Controls.Add(this.bttn_arama);
            this.Controls.Add(this.ara_txt);
            this.Controls.Add(this.ListeGrid);
            this.Controls.Add(this.bttn_listele);
            this.Controls.Add(this.bttn_guncelle);
            this.Controls.Add(this.siftxt);
            this.Controls.Add(this.kultxt);
            this.Controls.Add(this.AdminTur);
            this.Controls.Add(this.Adminsifre);
            this.Controls.Add(this.AdminAdi);
            this.Controls.Add(this.AdminBaslik);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminEkrani";
            this.Text = "AdminEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.ListeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminBaslik;
        private System.Windows.Forms.Label AdminAdi;
        private System.Windows.Forms.Label Adminsifre;
        private System.Windows.Forms.Label AdminTur;
        private System.Windows.Forms.TextBox kultxt;
        private System.Windows.Forms.TextBox siftxt;
        private System.Windows.Forms.Button bttn_guncelle;
        private System.Windows.Forms.Button bttn_listele;
        private System.Windows.Forms.DataGridView ListeGrid;
        private System.Windows.Forms.TextBox ara_txt;
        private System.Windows.Forms.Button bttn_arama;
        private System.Windows.Forms.Button bttn_sil;
        private System.Windows.Forms.ComboBox kytturu_cmb;
    }
}