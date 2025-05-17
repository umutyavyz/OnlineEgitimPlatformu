using System.Collections.Generic;

namespace OnlineEgitimPlatformu
{
    public class Kurs
    {
        public static int ToplamKursSayisi { get; private set; }

        public int Id { get; set; }
        public string Ad { get; set; }
        public Egitmen Egitmen { get; set; }
        public string Aciklama { get; set; }
        public List<Ogrenci> KayitliOgrenciler { get; set; }
        public List<string> Notlar { get; set; } // Öğretmen tarafından paylaşılan notlar

        public Kurs(int id, string ad, Egitmen egitmen, string aciklama)
        {
            Id = id;
            Ad = ad;
            Egitmen = egitmen;
            Aciklama = aciklama;
            KayitliOgrenciler = new List<Ogrenci>();
            Notlar = new List<string>();
            ToplamKursSayisi++;
        }
    }
}
