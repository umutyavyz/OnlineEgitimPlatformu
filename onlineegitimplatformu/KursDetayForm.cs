using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OnlineEgitimPlatformu
{
    public partial class KursDetayForm : Form
    {
        private int dersId;
        public KursDetayForm(int dersId)
        {
            InitializeComponent();
            this.dersId = dersId; // parametreyi al ve sınıf değişkenine ata
        }

        private void KursBilgileriniYukle(Kurs kurs)
        {

        }

        private void OgrencileriYukle()
        {
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

            lstOgrenciler.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                lstOgrenciler.Items.Add(row["Isim"].ToString());
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KursDetayForm_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();

            string query = @"SELECT DersAdi, Konu, Egitmenler.AdSoyad AS EgitmenAdi
                     FROM Dersler
                     JOIN Egitmenler ON Dersler.EgitmenID = Egitmenler.EgitmenID
                     WHERE DersID = @dersId";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@dersId", dersId)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                lblKursAdi.Text = row["DersAdi"].ToString();
                lblUzmanlik.Text = row["Konu"].ToString();
                lblEgitmen.Text = row["EgitmenAdi"].ToString();

                // Notları listele
                NotlariYukle();
            }
            else
            {
                MessageBox.Show("Ders detayları bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    


    private void NotlariYukle()
        {
            string notQuery = "SELECT Icerik FROM Notlar WHERE DersID = @dersId";
            SqlParameter[] notParams = new SqlParameter[]
            {
        new SqlParameter("@dersId", dersId)
            };

            DataTable notlar = DatabaseHelper.ExecuteQuery(notQuery, notParams);

            lstbNotlar.Items.Clear();
            foreach (DataRow row in notlar.Rows)
            {
                lstbNotlar.Items.Add(row["Icerik"].ToString());
            }
        }

    } }