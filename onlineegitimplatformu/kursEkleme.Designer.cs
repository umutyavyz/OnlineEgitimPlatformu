namespace onlineegitimplatformu
{
    partial class kursEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kursEkleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKursAd = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtOgretici = new System.Windows.Forms.TextBox();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurs Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğretici Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Konu";
            // 
            // txtKursAd
            // 
            this.txtKursAd.Location = new System.Drawing.Point(121, 36);
            this.txtKursAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKursAd.Name = "txtKursAd";
            this.txtKursAd.Size = new System.Drawing.Size(160, 22);
            this.txtKursAd.TabIndex = 3;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(121, 148);
            this.txtKonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(160, 22);
            this.txtKonu.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(141, 180);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 28);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Kurs Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtOgretici
            // 
            this.txtOgretici.Location = new System.Drawing.Point(121, 75);
            this.txtOgretici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOgretici.Name = "txtOgretici";
            this.txtOgretici.Size = new System.Drawing.Size(160, 22);
            this.txtOgretici.TabIndex = 7;
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(121, 107);
            this.txtUzmanlik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(160, 22);
            this.txtUzmanlik.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Uzmanlık Alanı";
            // 
            // kursEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 241);
            this.Controls.Add(this.txtUzmanlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOgretici);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtKursAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "kursEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs Ekle";
            this.Load += new System.EventHandler(this.kursEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKursAd;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtOgretici;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.Label label4;
    }
}