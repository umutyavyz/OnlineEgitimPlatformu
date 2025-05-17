namespace OnlineEgitimPlatformu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstKurslar = new System.Windows.Forms.ListBox();
            this.btnKursDetay = new System.Windows.Forms.Button();
            this.btnDersSec = new System.Windows.Forms.Button();
            this.btnKurslarim = new System.Windows.Forms.Button();
            this.lblhosgeldin = new System.Windows.Forms.Label();
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
            // 
            // btnKursDetay
            // 
            this.btnKursDetay.Location = new System.Drawing.Point(16, 303);
            this.btnKursDetay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKursDetay.Name = "btnKursDetay";
            this.btnKursDetay.Size = new System.Drawing.Size(147, 37);
            this.btnKursDetay.TabIndex = 1;
            this.btnKursDetay.Text = "Kurs Detayları";
            this.btnKursDetay.UseVisualStyleBackColor = true;
            this.btnKursDetay.Click += new System.EventHandler(this.btnKursDetay_Click);
            // 
            // btnDersSec
            // 
            this.btnDersSec.Location = new System.Drawing.Point(181, 303);
            this.btnDersSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDersSec.Name = "btnDersSec";
            this.btnDersSec.Size = new System.Drawing.Size(147, 37);
            this.btnDersSec.TabIndex = 2;
            this.btnDersSec.Text = "Ders Seç";
            this.btnDersSec.UseVisualStyleBackColor = true;
            this.btnDersSec.Click += new System.EventHandler(this.btnDersSec_Click);
            // 
            // btnKurslarim
            // 
            this.btnKurslarim.Location = new System.Drawing.Point(344, 303);
            this.btnKurslarim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKurslarim.Name = "btnKurslarim";
            this.btnKurslarim.Size = new System.Drawing.Size(147, 37);
            this.btnKurslarim.TabIndex = 3;
            this.btnKurslarim.Text = "Kurslarım";
            this.btnKurslarim.UseVisualStyleBackColor = true;
            this.btnKurslarim.Click += new System.EventHandler(this.btnKurslarim_Click);
            // 
            // lblhosgeldin
            // 
            this.lblhosgeldin.AutoSize = true;
            this.lblhosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhosgeldin.Location = new System.Drawing.Point(16, 11);
            this.lblhosgeldin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhosgeldin.Name = "lblhosgeldin";
            this.lblhosgeldin.Size = new System.Drawing.Size(15, 20);
            this.lblhosgeldin.TabIndex = 4;
            this.lblhosgeldin.Text = "-";
            this.lblhosgeldin.Click += new System.EventHandler(this.lblhosgeldin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 363);
            this.Controls.Add(this.lblhosgeldin);
            this.Controls.Add(this.btnKurslarim);
            this.Controls.Add(this.btnDersSec);
            this.Controls.Add(this.btnKursDetay);
            this.Controls.Add(this.lstKurslar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Öğrenci Paneli";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKurslar;
        private System.Windows.Forms.Button btnKursDetay;
        private System.Windows.Forms.Button btnDersSec;
        private System.Windows.Forms.Button btnKurslarim;
        private System.Windows.Forms.Label lblhosgeldin;
    }
}
