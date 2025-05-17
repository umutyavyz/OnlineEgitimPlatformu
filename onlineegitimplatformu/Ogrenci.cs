public class Ogrenci
{
    public int OgrenciID { get; set; }
    public string AdSoyad { get; set; }
    public string Email { get; set; }

    // Parametresiz constructor gerekli
    public Ogrenci() { }

    // Eğer istersen parametreli constructor da ekleyebilirsin:
    public Ogrenci(int id, string adSoyad, string email)
    {
        OgrenciID = id;
        AdSoyad = adSoyad;
        Email = email;
    }
}