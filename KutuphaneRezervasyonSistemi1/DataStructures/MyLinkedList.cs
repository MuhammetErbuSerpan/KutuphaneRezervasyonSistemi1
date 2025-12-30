namespace KutuphaneRezervasyonSistemi1.DataStructures
{
    // Bağlı Liste
    internal class MyLinkedList<T>
    {
        // Listenin başı
        private Node<T> bas;

        // Liste başta boş
        public MyLinkedList()
        {
            bas = null;
        }

        // Listenin sonuna eleman ekliyoruz
        public void Ekle(T veri)
        {
            Node<T> yeni = new Node<T>(veri);

            // Liste boşsa direkt başa atıyoruz
            if (bas == null)
            {
                bas = yeni;
                return;
            }

            // Boş değilse sonuna kadar gidiyoruz
            Node<T> gecici = bas;
            while (gecici.Next != null)
            {
                gecici = gecici.Next;
            }

            // En sona bağlıyoruz
            gecici.Next = yeni;
        }

        // Eleman var mı diye kontrol ediyoruz
        public bool VarMi(T veri)
        {
            Node<T> gecici = bas;

            // Baştan sona geziyoruz
            while (gecici != null)
            {
                if (gecici.Data.Equals(veri))
                {
                    return true;
                }

                gecici = gecici.Next;
            }

            return false;
        }

        // Dışarıdan dolaşabilmek için baş düğümü veriyoruz
        public Node<T> BasGetir()
        {
            return bas;
        }

        // Listedeki eleman sayısını buluyoruz
        public int AdetGetir()
        {
            int sayac = 0;
            Node<T> gecici = bas;

            // Listeyi baştan sona sayıyoruz
            while (gecici != null)
            {
                sayac++;
                gecici = gecici.Next;
            }

            return sayac;
        }
    }
}