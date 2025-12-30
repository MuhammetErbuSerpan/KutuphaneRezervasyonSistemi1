namespace KutuphaneRezervasyonSistemi1.Models
{
    // İşlemlerin log kaydının tutullduğu yer
    internal class Log
    {
        public string Aciklama;
        public string Tarih;

        public Log(string aciklama)
        {
            Aciklama = aciklama;
            Tarih = System.DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        public override string ToString()
        {
            return Tarih + " - " + Aciklama;
        }
    }
}