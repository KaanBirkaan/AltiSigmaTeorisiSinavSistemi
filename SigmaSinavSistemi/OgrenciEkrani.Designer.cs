
namespace SigmaSinavSistemi
{
    partial class OgrenciEkrani
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
            this.bttn_ayarlar = new System.Windows.Forms.Button();
            this.ogrhos_lbl = new System.Windows.Forms.Label();
            this.hoslbl = new System.Windows.Forms.Label();
            this.bttn_snvgir = new System.Windows.Forms.Button();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_ayarlar
            // 
            this.bttn_ayarlar.Location = new System.Drawing.Point(12, 153);
            this.bttn_ayarlar.Name = "bttn_ayarlar";
            this.bttn_ayarlar.Size = new System.Drawing.Size(132, 51);
            this.bttn_ayarlar.TabIndex = 0;
            this.bttn_ayarlar.Text = "Ayarlar";
            this.bttn_ayarlar.UseVisualStyleBackColor = true;
            this.bttn_ayarlar.Click += new System.EventHandler(this.bttn_ayarlar_Click);
            // 
            // ogrhos_lbl
            // 
            this.ogrhos_lbl.AutoSize = true;
            this.ogrhos_lbl.Location = new System.Drawing.Point(28, 30);
            this.ogrhos_lbl.Name = "ogrhos_lbl";
            this.ogrhos_lbl.Size = new System.Drawing.Size(0, 13);
            this.ogrhos_lbl.TabIndex = 1;
            // 
            // hoslbl
            // 
            this.hoslbl.AutoSize = true;
            this.hoslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hoslbl.Location = new System.Drawing.Point(35, 29);
            this.hoslbl.Name = "hoslbl";
            this.hoslbl.Size = new System.Drawing.Size(66, 24);
            this.hoslbl.TabIndex = 2;
            this.hoslbl.Text = "label1";
            // 
            // bttn_snvgir
            // 
            this.bttn_snvgir.Location = new System.Drawing.Point(12, 84);
            this.bttn_snvgir.Name = "bttn_snvgir";
            this.bttn_snvgir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bttn_snvgir.Size = new System.Drawing.Size(132, 51);
            this.bttn_snvgir.TabIndex = 3;
            this.bttn_snvgir.Text = "Sınava Gir";
            this.bttn_snvgir.UseVisualStyleBackColor = true;
            this.bttn_snvgir.Click += new System.EventHandler(this.bttn_snvgir_Click);
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(12, 416);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(35, 13);
            this.lbl_Tarih.TabIndex = 4;
            this.lbl_Tarih.Text = "label1";
            // 
            // OgrenciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 453);
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.bttn_snvgir);
            this.Controls.Add(this.hoslbl);
            this.Controls.Add(this.ogrhos_lbl);
            this.Controls.Add(this.bttn_ayarlar);
            this.Name = "OgrenciEkrani";
            this.Text = "OgrenciEkrani";
            this.Load += new System.EventHandler(this.OgrenciEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_ayarlar;
        private System.Windows.Forms.Label ogrhos_lbl;
        private System.Windows.Forms.Label hoslbl;
        private System.Windows.Forms.Button bttn_snvgir;
        private System.Windows.Forms.Label lbl_Tarih;
    }
}