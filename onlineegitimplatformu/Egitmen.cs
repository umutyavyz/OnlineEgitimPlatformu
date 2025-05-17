namespace OnlineEgitimPlatformu
{
    public class Egitmen
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string UzmanlikAlani { get; set; }

        public Egitmen(int id, string ad, string uzmanlikAlani)
        {
            Id = id;
            Ad = ad;
            UzmanlikAlani = uzmanlikAlani;
        }
    }
}