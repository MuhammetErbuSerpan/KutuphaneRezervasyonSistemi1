namespace KutuphaneRezervasyonSistemi1.DataStructures
{
    // Rezervasyonlar için kullandığımız kuyruk
    internal class MyQueue<T>
    {
        // Kuyruğun başı 
        private Node<T> on;

        // Kuyruğun sonu
        private Node<T> arka;

        // Kuyruğun içine giren eleman sayısına bakıyoruz
        private int adet;

        // En başta kuyruk boş
        public MyQueue()
        {
            on = null;
            arka = null;
            adet = 0;
        }

        // Yeni eleman ekleme
        public void Ekle(T veri)
        {
            Node<T> yeni = new Node<T>(veri);

            // Kuyrukta eleman yoksa başla son aynı
            if (on == null)
            {
                on = yeni;
                arka = yeni;
            }
            else
            {
                // Boş değilse sona ekliyoruz
                arka.Next = yeni;
                arka = yeni;
            }

            adet++;
        }

        // İlk giren çıkar ile eleman çıkıyor
        public T Cikar()
        {
            // Eleman yoksa null
            if (on == null)
            {
                return default(T);
            }

            // Baştaki elemanı alıyoruz
            T veri = on.Data;
            on = on.Next;
            adet--;

            // Eğer kuyruk boşaldıysa arkayı da temizliyoruz
            if (on == null)
            {
                arka = null;
            }

            return veri;
        }

        // Kuyruktaki kişi sayısını döndürür
        public int AdetGetir()
        {
            return adet;
        }

        // Kuyruk bos mu diye kontrol yapılır
        public bool BosMu()
        {
            return adet == 0;
        }
    }
}