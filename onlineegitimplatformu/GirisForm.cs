using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineEgitimPlatformu
{
    public partial class GirisForm : Form
    {
        public Ogrenci GirisYapanOgrenci { get; set; }

        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            string isim = txtAd.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            string query = "SELECT * FROM Ogrenci WHERE Isim = @isim AND Sifre = @sifre";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@isim", isim),
                new SqlParameter("@sifre", sifre)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                GirisYapanOgrenci = new Ogrenci
                {
                    OgrenciID = Convert.ToInt32(result.Rows[0]["OgrenciID"]),
                    AdSoyad = result.Rows[0]["Isim"].ToString(),  // Kolon ismi veritabanında "Isim" ise
                    Email = result.Rows[0]["Sifre"].ToString()
                };

                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Program.cs burada kontrol eder
                this.Close();
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Lütfen bilgilerinizi kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            OgretmenGirisForm ogretmenGirisForm = new OgretmenGirisForm();
            if (ogretmenGirisForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            // Gerekirse buraya yaz
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Gerekirse buraya yaz
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Gerekirse buraya yaz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.ShowDialog();
        }
    }
}
