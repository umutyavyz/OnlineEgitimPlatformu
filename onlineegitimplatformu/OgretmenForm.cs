using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using onlineegitimplatformu;

namespace OnlineEgitimPlatformu
{
    public partial class OgretmenForm : Form
    {
        
        public OgretmenForm()
        {
            InitializeComponent();
            InitializeData();
            LoadCourses();
        }


        public void KurslariYukle()
        {
            lstKurslar.Items.Clear(); // varsa önce temizle

            string query = @"SELECT DersAdi FROM Dersler";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                lstKurslar.Items.Add(row["DersAdi"].ToString());
            }
        }

        private void InitializeData()
        {
            
        }

        private void LoadCourses()
        {
           
        }

        private void lstKurslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKurslar.SelectedItem == null) return;

            // Seçilen kursun DersID'sini al
            string selectedItem = lstKurslar.SelectedItem.ToString();
            int dersId = int.Parse(selectedItem.Split('-')[0].Trim());

            string query = @"
        SELECT Ogrenci.Isim 
        FROM OgrenciKurslar 
        JOIN Ogrenci ON OgrenciKurslar.OgrenciID = Ogrenci.OgrenciID
        WHERE OgrenciKurslar.DersID = @dersId";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@dersId", dersId)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            lstKayitliOgrenciler.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                lstKayitliOgrenciler.Items.Add(row["Isim"].ToString());
            }
        }

        private void btnKursDetay_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            if (lstKurslar.SelectedItem == null || string.IsNullOrWhiteSpace(txtNotEkle.Text))
            {
                MessageBox.Show("Lütfen bir kurs seçin ve not içeriğini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen dersin ID'sini al
            string selectedItem = lstKurslar.SelectedItem.ToString();
            int dersId = int.Parse(selectedItem.Split('-')[0].Trim());

            string icerik = txtNotEkle.Text.Trim();

            string insertQuery = "INSERT INTO Notlar (DersID, Icerik) VALUES (@dersID, @icerik)";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@dersID", dersId),
        new SqlParameter("@icerik", icerik)
            };

            int result = DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
            if (result > 0)
            {
                MessageBox.Show("Not başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNotEkle.Clear();
            }
            else
            {
                MessageBox.Show("Not eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYeniKurs_Click(object sender, EventArgs e)
        {
            kursEkleme form = new kursEkleme(this); // this = mevcut OgretmenForm
            form.ShowDialog();
        }

        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            



            string query = @"SELECT DersID, DersAdi FROM Dersler";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            lstKurslar.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string item = $"{row["DersID"]} - {row["DersAdi"]}";
                lstKurslar.Items.Add(item);
            }
        }

        private void lstKayitliOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
