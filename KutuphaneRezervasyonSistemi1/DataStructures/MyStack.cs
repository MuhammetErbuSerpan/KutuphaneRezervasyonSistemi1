namespace KutuphaneRezervasyonSistemi1.DataStructures
{
    // Logları tutmak için kullanacağımız stack 
    internal class MyStack<T>
    {
        // Stack'in üstünde bulunan eleman
        private Node<T> ust;

        // Eleman olmadığı için ilk başta boş
        public MyStack()
        {
            ust = null;
        }

        // Eleman eklendiği kısım
        public void Ekle(T veri)
        {
            Node<T> yeni = new Node<T>(veri);

            // Yeni gelenler üstte geçer
            yeni.Next = ust;
            ust = yeni;
        }

        // Son giren çıkar ile elemanlar cıkıyor
        public T Cikar()
        {
            // Eğer stack boşsa null döndürüyoruz
            if (ust == null)
            {
                return default(T);
            }

            // Üstteki elemanı alıyoruz
            T veri = ust.Data;
            ust = ust.Next;

            return veri;
        }

        // Stackta eleman var mı diye kontrol ediyoruz
        public bool BosMu()
        {
            return ust == null;
        }

        // Üstteki elemanı görmek için
        public T UstGetir()
        {
            if (ust == null)
            {
                return default(T);
            }

            return ust.Data;
        }
    }
}