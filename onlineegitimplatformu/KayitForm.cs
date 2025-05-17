using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineEgitimPlatformu
{
    public partial class KayitForm : Form
    {
       

        public KayitForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string isim = txtAd.Text.Trim();
            string email = txtMail.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aynı e-mail ile daha önce kayıt yapılmış mı kontrol et
            string checkQuery = "SELECT * FROM Ogrenci WHERE Email = @Email";
            SqlParameter[] checkParams = {
    new SqlParameter("@Email", email)
};

            DataTable existing = DatabaseHelper.ExecuteQuery(checkQuery, checkParams);
            if (existing.Rows.Count > 0)
            {
                MessageBox.Show("Bu e-posta adresi zaten kayıtlı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni öğrenci ekleme
            string insertQuery = "INSERT INTO Ogrenci (Isim, Email, Sifre) VALUES (@Isim, @Email, @Sifre)";
            SqlParameter[] insertParams = {
    new SqlParameter("@Isim", isim),
    new SqlParameter("@Email", email),
    new SqlParameter("@Sifre", sifre)
};

            int result = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
            if (result > 0)
            {
                MessageBox.Show("Kayıt başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAd.Clear();
                txtMail.Clear();
                txtSifre.Clear();
            }
            else
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            
        }
    }
}