using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OnlineEgitimPlatformu
{
    public partial class OgretmenGirisForm : Form
    {
        public int OgretmenID { get; private set; }
        public string OgretmenAd { get; private set; }

        public OgretmenGirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM Egitmenler WHERE AdSoyad = @ad AND Sifre = @sifre";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ad", ad),
                new SqlParameter("@sifre", sifre)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                OgretmenID = Convert.ToInt32(result.Rows[0]["EgitmenID"]);
                OgretmenAd = result.Rows[0]["AdSoyad"].ToString();

                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ad veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OgretmenGirisForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
        }

        private void OgretmenGirisForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
