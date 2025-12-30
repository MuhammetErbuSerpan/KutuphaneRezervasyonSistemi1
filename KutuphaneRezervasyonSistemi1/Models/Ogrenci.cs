namespace KutuphaneRezervasyonSistemi1.Models
{
    // Öğrenci bilgilerini tuttuğumuz sınıf
    internal class Ogrenci
    {
        public int Id;
        public string AdSoyad;

        public Ogrenci(int id, string adSoyad)
        {
            Id = id;
            AdSoyad = adSoyad;
        }

        // Listelerde düzgün görünsün diye
        public override string ToString()
        {
            return Id + " - " + AdSoyad;
        }
    }
}