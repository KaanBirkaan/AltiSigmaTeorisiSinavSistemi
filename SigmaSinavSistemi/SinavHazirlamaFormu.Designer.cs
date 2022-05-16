
namespace SigmaSinavSistemi
{
    partial class SinavHazirlamaFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.soruimage = new System.Windows.Forms.PictureBox();
            this.bttn_image = new System.Windows.Forms.Button();
            this.dosyabulma = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cevap1_txt = new System.Windows.Forms.TextBox();
            this.cevap3_txt = new System.Windows.Forms.TextBox();
            this.cevap2_txt = new System.Windows.Forms.TextBox();
            this.cevapd_txt = new System.Windows.Forms.TextBox();
            this.bttn_eklesoru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soruimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz Soru Hazırlama";
            // 
            // soruimage
            // 
            this.soruimage.Location = new System.Drawing.Point(12, 62);
            this.soruimage.Name = "soruimage";
            this.soruimage.Size = new System.Drawing.Size(863, 432);
            this.soruimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soruimage.TabIndex = 1;
            this.soruimage.TabStop = false;
            // 
            // bttn_image
            // 
            this.bttn_image.Location = new System.Drawing.Point(965, 446);
            this.bttn_image.Name = "bttn_image";
            this.bttn_image.Size = new System.Drawing.Size(148, 48);
            this.bttn_image.TabIndex = 2;
            this.bttn_image.Text = "İmage Ekle";
            this.bttn_image.UseVisualStyleBackColor = true;
            this.bttn_image.Click += new System.EventHandler(this.bttn_image_Click);
            // 
            // dosyabulma
            // 
            this.dosyabulma.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(917, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1. CEVAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(920, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "2.CEVAP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(920, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "3.CEVAP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(917, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DOĞRU CEVAP";
            // 
            // cevap1_txt
            // 
            this.cevap1_txt.Location = new System.Drawing.Point(1033, 201);
            this.cevap1_txt.Name = "cevap1_txt";
            this.cevap1_txt.Size = new System.Drawing.Size(100, 20);
            this.cevap1_txt.TabIndex = 7;
            // 
            // cevap3_txt
            // 
            this.cevap3_txt.Location = new System.Drawing.Point(1033, 281);
            this.cevap3_txt.Name = "cevap3_txt";
            this.cevap3_txt.Size = new System.Drawing.Size(100, 20);
            this.cevap3_txt.TabIndex = 7;
            // 
            // cevap2_txt
            // 
            this.cevap2_txt.Location = new System.Drawing.Point(1033, 237);
            this.cevap2_txt.Name = "cevap2_txt";
            this.cevap2_txt.Size = new System.Drawing.Size(100, 20);
            this.cevap2_txt.TabIndex = 7;
            // 
            // cevapd_txt
            // 
            this.cevapd_txt.Location = new System.Drawing.Point(1033, 317);
            this.cevapd_txt.Name = "cevapd_txt";
            this.cevapd_txt.Size = new System.Drawing.Size(100, 20);
            this.cevapd_txt.TabIndex = 7;
            // 
            // bttn_eklesoru
            // 
            this.bttn_eklesoru.Location = new System.Drawing.Point(949, 62);
            this.bttn_eklesoru.Name = "bttn_eklesoru";
            this.bttn_eklesoru.Size = new System.Drawing.Size(130, 64);
            this.bttn_eklesoru.TabIndex = 8;
            this.bttn_eklesoru.Text = "Soruyu Kaydet";
            this.bttn_eklesoru.UseVisualStyleBackColor = true;
            this.bttn_eklesoru.Click += new System.EventHandler(this.bttn_eklesoru_Click);
            // 
            // SinavHazirlamaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 565);
            this.Controls.Add(this.bttn_eklesoru);
            this.Controls.Add(this.cevapd_txt);
            this.Controls.Add(this.cevap2_txt);
            this.Controls.Add(this.cevap3_txt);
            this.Controls.Add(this.cevap1_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_image);
            this.Controls.Add(this.soruimage);
            this.Controls.Add(this.label1);
            this.Name = "SinavHazirlamaFormu";
            this.Text = "SinavHazirlamaFormu";
            ((System.ComponentModel.ISupportInitialize)(this.soruimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox soruimage;
        private System.Windows.Forms.Button bttn_image;
        private System.Windows.Forms.OpenFileDialog dosyabulma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cevap1_txt;
        private System.Windows.Forms.TextBox cevap3_txt;
        private System.Windows.Forms.TextBox cevap2_txt;
        private System.Windows.Forms.TextBox cevapd_txt;
        private System.Windows.Forms.Button bttn_eklesoru;
    }
}