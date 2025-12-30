using KutuphaneRezervasyonSistemi1.DataStructures;

namespace KutuphaneRezervasyonSistemi1.Models
{
    // Kitapların bilgisini tutar
    internal class Kitap
    {
        public string Ad;
        public string Yazar;
        public string ISBN;
        public string Kategori;

        // Kitabın mevcut durumu(birisi almış mı almamıış mı)
        public bool Musait;

        // Ödünç alınma sayısı
        public int OduncSayisi;

        // Kitabın rezervasyon kuyruğu 
        public MyQueue<Ogrenci> RezervasyonKuyrugu;

        // Kitabın genel bilgilerini verdiğimiz nokta
        public Kitap(string ad, string yazar, string isbn, string kategori)
        {
            Ad = ad;
            Yazar = yazar;
            ISBN = isbn;
            Kategori = kategori;

            Musait = true;
            OduncSayisi = 0;
            RezervasyonKuyrugu = new MyQueue<Ogrenci>();
        }

        // Listelerde kitabın adının gözükmesi için
        public override string ToString()
        {
            return Ad;
        }
    }
}