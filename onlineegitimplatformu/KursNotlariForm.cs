using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OnlineEgitimPlatformu
{
    public partial class KursNotlariForm : Form
    {
        private int ogrenciId;

        public KursNotlariForm(int id)
        {
            InitializeComponent();
            ogrenciId = id;
            LoadKurslarim();
        }

        private void LoadKurslarim()
        {
            string query = @"SELECT Dersler.DersAdi, Egitmenler.AdSoyad, Dersler.Konu
                         FROM OgrenciKurslar 
                         JOIN Dersler ON OgrenciKurslar.DersID = Dersler.DersID
                         JOIN Egitmenler ON Dersler.EgitmenID = Egitmenler.EgitmenID
                         WHERE OgrenciKurslar.OgrenciID = @ogrenciID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@ogrenciID", ogrenciId)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            lstKurslar.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string item = $"{row["DersAdi"]} / {row["AdSoyad"]} / {row["Konu"]}";
                lstKurslar.Items.Add(item);
            }
        }



        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapatarak MainForm'a geri dön
        }

        private void KursNotlariForm_Load(object sender, EventArgs e)
        {

        }
    }
}
