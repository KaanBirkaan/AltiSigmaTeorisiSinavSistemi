
namespace SigmaSinavSistemi
{
    partial class SinavEkrani
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radbtn_a = new System.Windows.Forms.RadioButton();
            this.radbtn_b = new System.Windows.Forms.RadioButton();
            this.radbtn_c = new System.Windows.Forms.RadioButton();
            this.radbtn_d = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bttn_btr = new System.Windows.Forms.Button();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_sorusayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radbtn_a
            // 
            this.radbtn_a.AutoSize = true;
            this.radbtn_a.Location = new System.Drawing.Point(63, 523);
            this.radbtn_a.Name = "radbtn_a";
            this.radbtn_a.Size = new System.Drawing.Size(85, 17);
            this.radbtn_a.TabIndex = 5;
            this.radbtn_a.TabStop = true;
            this.radbtn_a.Text = "radioButton1";
            this.radbtn_a.UseVisualStyleBackColor = true;
            // 
            // radbtn_b
            // 
            this.radbtn_b.AutoSize = true;
            this.radbtn_b.Location = new System.Drawing.Point(63, 549);
            this.radbtn_b.Name = "radbtn_b";
            this.radbtn_b.Size = new System.Drawing.Size(85, 17);
            this.radbtn_b.TabIndex = 6;
            this.radbtn_b.TabStop = true;
            this.radbtn_b.Text = "radioButton2";
            this.radbtn_b.UseVisualStyleBackColor = true;
            // 
            // radbtn_c
            // 
            this.radbtn_c.AutoSize = true;
            this.radbtn_c.Location = new System.Drawing.Point(63, 578);
            this.radbtn_c.Name = "radbtn_c";
            this.radbtn_c.Size = new System.Drawing.Size(85, 17);
            this.radbtn_c.TabIndex = 7;
            this.radbtn_c.TabStop = true;
            this.radbtn_c.Text = "radioButton3";
            this.radbtn_c.UseVisualStyleBackColor = true;
            // 
            // radbtn_d
            // 
            this.radbtn_d.AutoSize = true;
            this.radbtn_d.Location = new System.Drawing.Point(63, 603);
            this.radbtn_d.Name = "radbtn_d";
            this.radbtn_d.Size = new System.Drawing.Size(85, 17);
            this.radbtn_d.TabIndex = 8;
            this.radbtn_d.TabStop = true;
            this.radbtn_d.Text = "radioButton4";
            this.radbtn_d.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sonraki";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bttn_btr
            // 
            this.bttn_btr.Location = new System.Drawing.Point(1073, 447);
            this.bttn_btr.Name = "bttn_btr";
            this.bttn_btr.Size = new System.Drawing.Size(105, 52);
            this.bttn_btr.TabIndex = 10;
            this.bttn_btr.Text = "Sınavı Bitir";
            this.bttn_btr.UseVisualStyleBackColor = true;
            this.bttn_btr.Click += new System.EventHandler(this.bttn_btr_Click);
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Location = new System.Drawing.Point(948, 13);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(0, 13);
            this.lbl_dakika.TabIndex = 11;
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Location = new System.Drawing.Point(980, 13);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(35, 13);
            this.lbl_saniye.TabIndex = 12;
            this.lbl_saniye.Text = "label1";
            // 
            // lbl_sorusayi
            // 
            this.lbl_sorusayi.AutoSize = true;
            this.lbl_sorusayi.Location = new System.Drawing.Point(1070, 13);
            this.lbl_sorusayi.Name = "lbl_sorusayi";
            this.lbl_sorusayi.Size = new System.Drawing.Size(35, 13);
            this.lbl_sorusayi.TabIndex = 13;
            this.lbl_sorusayi.Text = "label1";
            // 
            // SinavEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 639);
            this.Controls.Add(this.lbl_sorusayi);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.bttn_btr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radbtn_d);
            this.Controls.Add(this.radbtn_c);
            this.Controls.Add(this.radbtn_b);
            this.Controls.Add(this.radbtn_a);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SinavEkrani";
            this.Text = "SinavEkrani";
            this.Load += new System.EventHandler(this.SinavEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radbtn_a;
        private System.Windows.Forms.RadioButton radbtn_b;
        private System.Windows.Forms.RadioButton radbtn_c;
        private System.Windows.Forms.RadioButton radbtn_d;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bttn_btr;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_sorusayi;
    }
}