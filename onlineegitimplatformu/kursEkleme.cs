using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineEgitimPlatformu;

namespace onlineegitimplatformu
{
    public partial class kursEkleme : Form
    {
        private OgretmenForm ogretmenForm;

        public kursEkleme(OgretmenForm form)
        {
            InitializeComponent();
            ogretmenForm = form; // gelen referansı yerel değişkene ata
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            string kursAdi = txtKursAd.Text.Trim();
            string egitmenAd = txtOgretici.Text.Trim();
            string uzmanlik = txtUzmanlik.Text.Trim();
            string konu = txtKonu.Text.Trim();

            if (string.IsNullOrEmpty(kursAdi) || string.IsNullOrEmpty(egitmenAd) || string.IsNullOrEmpty(konu) || string.IsNullOrEmpty(uzmanlik))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Eğitmen zaten var mı kontrol et
            string egitmenQuery = "SELECT EgitmenID FROM Egitmenler WHERE AdSoyad = @ad";
            SqlParameter[] egitmenParam = new SqlParameter[]
            {
    new SqlParameter("@ad", egitmenAd)
            };

            DataTable egitmenTable = DatabaseHelper.ExecuteQuery(egitmenQuery, egitmenParam);
            int egitmenId;

            if (egitmenTable.Rows.Count > 0)
            {
                // Eğitmen zaten var
                egitmenId = Convert.ToInt32(egitmenTable.Rows[0]["EgitmenID"]);
            }
            else
            {
                // Eğitmen yoksa yeni eğitmen ekle
                string rastgeleSifre = "1234"; // Gerekirse Random ile oluştur
                string insertEgitmenQuery = @"
        INSERT INTO Egitmenler (AdSoyad, Sifre, UzmanlikAlani)
        OUTPUT INSERTED.EgitmenID
        VALUES (@ad, @sifre, @uzmanlik)";

                SqlParameter[] yeniEgitmenParam = new SqlParameter[]
                {
        new SqlParameter("@ad", egitmenAd),
        new SqlParameter("@sifre", rastgeleSifre),
        new SqlParameter("@uzmanlik", uzmanlik)
                };

                DataTable yeniEgitmenTable = DatabaseHelper.ExecuteQuery(insertEgitmenQuery, yeniEgitmenParam);
                egitmenId = Convert.ToInt32(yeniEgitmenTable.Rows[0]["EgitmenID"]);
            }

            // Kursu ekle
            string insertQuery = "INSERT INTO Dersler (DersAdi, EgitmenID, Konu) VALUES (@adi, @egitmenId, @konu)";
            SqlParameter[] parameters = new SqlParameter[]
            {
    new SqlParameter("@adi", kursAdi),
    new SqlParameter("@egitmenId", egitmenId),
    new SqlParameter("@konu", konu)
            };

            int result = DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);

            if (result > 0)
            {
                MessageBox.Show("Kurs ve eğitmen başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ogretmenForm.KurslariYukle(); // OgretmenForm üzerindeki liste güncelleniyor
                txtKursAd.Clear();
                txtOgretici.Clear();
                txtKonu.Clear();
                txtUzmanlik.Clear();
            }
            else
            {
                MessageBox.Show("Kurs eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void kursEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
