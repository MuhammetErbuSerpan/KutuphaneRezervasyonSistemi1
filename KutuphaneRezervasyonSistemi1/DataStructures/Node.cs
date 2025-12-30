namespace KutuphaneRezervasyonSistemi1.DataStructures
{
    // Bağlı liste için kullandığımız düğüm
    internal class Node<T>
    {
        // İçinde tuttuğumuz veri
        public T Data;

        // Bir sonraki düğümü işaretler
        public Node<T> Next;

        // Düğüm oluşturma aşamasında veriyi aldığımız yer
        public Node(T data)
        {
            Data = data;
            // ilk seferde boş oluyor
            Next = null;
        }
    }
}