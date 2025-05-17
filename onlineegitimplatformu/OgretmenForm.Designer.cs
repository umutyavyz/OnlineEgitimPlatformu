namespace OnlineEgitimPlatformu
{
    partial class OgretmenForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenForm));
            this.lstKurslar = new System.Windows.Forms.ListBox();
            this.txtNotEkle = new System.Windows.Forms.TextBox();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.lstKayitliOgrenciler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYeniKurs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstKurslar
            // 
            this.lstKurslar.FormattingEnabled = true;
            this.lstKurslar.ItemHeight = 16;
            this.lstKurslar.Location = new System.Drawing.Point(16, 50);
            this.lstKurslar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstKurslar.Name = "lstKurslar";
            this.lstKurslar.Size = new System.Drawing.Size(479, 244);
            this.lstKurslar.TabIndex = 0;
            this.lstKurslar.SelectedIndexChanged += new System.EventHandler(this.lstKurslar_SelectedIndexChanged);
            // 
            // txtNotEkle
            // 
            this.txtNotEkle.Location = new System.Drawing.Point(16, 356);
            this.txtNotEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotEkle.Multiline = true;
            this.txtNotEkle.Name = "txtNotEkle";
            this.txtNotEkle.Size = new System.Drawing.Size(479, 58);
            this.txtNotEkle.TabIndex = 2;
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Location = new System.Drawing.Point(16, 426);
            this.btnNotEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(147, 37);
            this.btnNotEkle.TabIndex = 3;
            this.btnNotEkle.Text = "Not Ekle";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // lstKayitliOgrenciler
            // 
            this.lstKayitliOgrenciler.FormattingEnabled = true;
            this.lstKayitliOgrenciler.ItemHeight = 16;
            this.lstKayitliOgrenciler.Location = new System.Drawing.Point(501, 50);
            this.lstKayitliOgrenciler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstKayitliOgrenciler.Name = "lstKayitliOgrenciler";
            this.lstKayitliOgrenciler.Size = new System.Drawing.Size(279, 244);
            this.lstKayitliOgrenciler.TabIndex = 4;
            this.lstKayitliOgrenciler.SelectedIndexChanged += new System.EventHandler(this.lstKayitliOgrenciler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kurslar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kayıtlı Öğrenciler";
            // 
            // btnYeniKurs
            // 
            this.btnYeniKurs.Location = new System.Drawing.Point(19, 305);
            this.btnYeniKurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeniKurs.Name = "btnYeniKurs";
            this.btnYeniKurs.Size = new System.Drawing.Size(147, 37);
            this.btnYeniKurs.TabIndex = 7;
            this.btnYeniKurs.Text = "Yeni Kurs Ekle";
            this.btnYeniKurs.UseVisualStyleBackColor = true;
            this.btnYeniKurs.Click += new System.EventHandler(this.btnYeniKurs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::onlineegitimplatformu.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(504, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 171);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // OgretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYeniKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKayitliOgrenciler);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.txtNotEkle);
            this.Controls.Add(this.lstKurslar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OgretmenForm";
            this.Text = "Öğretmen Paneli";
            this.Load += new System.EventHandler(this.OgretmenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKurslar;
        private System.Windows.Forms.TextBox txtNotEkle;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.ListBox lstKayitliOgrenciler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniKurs; // Yeni buton tanımlandı
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
