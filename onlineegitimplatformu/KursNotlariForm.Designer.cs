namespace OnlineEgitimPlatformu
{
    partial class KursNotlariForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KursNotlariForm));
            this.lblKursAdi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lstKurslar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblKursAdi
            // 
            this.lblKursAdi.AutoSize = true;
            this.lblKursAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKursAdi.Location = new System.Drawing.Point(12, 11);
            this.lblKursAdi.Name = "lblKursAdi";
            this.lblKursAdi.Size = new System.Drawing.Size(95, 25);
            this.lblKursAdi.TabIndex = 0;
            this.lblKursAdi.Text = "Kurs Adı";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(17, 370);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 30);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lstKurslar
            // 
            this.lstKurslar.FormattingEnabled = true;
            this.lstKurslar.ItemHeight = 16;
            this.lstKurslar.Location = new System.Drawing.Point(17, 39);
            this.lstKurslar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKurslar.Name = "lstKurslar";
            this.lstKurslar.Size = new System.Drawing.Size(448, 324);
            this.lstKurslar.TabIndex = 3;
            // 
            // KursNotlariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 414);
            this.Controls.Add(this.lstKurslar);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblKursAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KursNotlariForm";
            this.Text = "Kurs Notları";
            this.Load += new System.EventHandler(this.KursNotlariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKursAdi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListBox lstKurslar;
    }
}
