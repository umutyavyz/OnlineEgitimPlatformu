using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineEgitimPlatformu
{
    public partial class MainForm : Form
    {
        private int ogrenciId;
        private string ogrenciAd;
        public MainForm(int id, string ogrenciAd)
        {
            InitializeComponent();
            ogrenciId = id;
            LoadDersler();
            this.ogrenciAd = ogrenciAd;
            lblhosgeldin.Text = $"Hoş geldin, {ogrenciAd}!";
        }


        private void LoadDersler()
        {
            string query = @"SELECT Dersler.DersID, DersAdi, Egitmenler.AdSoyad AS EgitmenAdi, Konu
                     FROM Dersler 
                     JOIN Egitmenler ON Dersler.EgitmenID = Egitmenler.EgitmenID";

            var dt = DatabaseHelper.ExecuteQuery(query);
            lstKurslar.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string item = $"{row["DersID"]} - {row["DersAdi"]} / {row["EgitmenAdi"]} / {row["Konu"]}";
                lstKurslar.Items.Add(item);
            }
        }

        private void btnKursDetay_Click(object sender, EventArgs e)
        {

            if (lstKurslar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ders seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = lstKurslar.SelectedItem.ToString();
            int dersId = int.Parse(selectedItem.Split('-')[0].Trim());

            KursDetayForm detayForm = new KursDetayForm(dersId);
            detayForm.ShowDialog();
        }

        private void btnDersSec_Click(object sender, EventArgs e)
        {
            if (lstKurslar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ders seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen dersin ID'sini al
            string selectedItem = lstKurslar.SelectedItem.ToString();
            string dersIdStr = selectedItem.Split('-')[0].Trim();
            int dersId = int.Parse(dersIdStr);

            // Bu dersi veritabanına öğrencinin üzerine ekle
            string checkQuery = "SELECT * FROM OgrenciKurslar WHERE OgrenciID = @ogrenciID AND DersID = @dersID";
            SqlParameter[] checkParams = new SqlParameter[]
            {
        new SqlParameter("@ogrenciID", ogrenciId),
        new SqlParameter("@dersID", dersId)
            };

            DataTable existing = DatabaseHelper.ExecuteQuery(checkQuery, checkParams);

            if (existing.Rows.Count > 0)
            {
                MessageBox.Show("Bu dersi zaten seçtiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string insertQuery = "INSERT INTO OgrenciKurslar (OgrenciID, DersID) VALUES (@ogrenciID, @dersID)";
            int result = DatabaseHelper.ExecuteNonQuery(insertQuery, checkParams);

            if (result > 0)
            {
                MessageBox.Show("Ders başarıyla seçildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKurslarim_Click(object sender, EventArgs e)
        {
            
             KursNotlariForm kurslarimForm = new KursNotlariForm(ogrenciId);
            kurslarimForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void lblhosgeldin_Click(object sender, EventArgs e)
        {

        }
    }
}
