using System;
using System.Windows.Forms;
using KutuphaneRezervasyonSistemi1.DataStructures;
using KutuphaneRezervasyonSistemi1.Models;

namespace KutuphaneRezervasyonSistemi1.Forms
{
    public partial class MainForm : Form
    {
        // Öğrenci ve kitap listeleri
        MyLinkedList<Ogrenci> ogrenciler = new MyLinkedList<Ogrenci>();
        MyLinkedList<Kitap> kitaplar = new MyLinkedList<Kitap>();

        // Log tutulması için
        MyStack<Log> loglar = new MyStack<Log>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOrnekVeri_Click(object sender, EventArgs e)
        {
          // Öğrenciler ekleniyor
            ogrenciler.Ekle(new Ogrenci(1, "Erbu Serpan"));
            ogrenciler.Ekle(new Ogrenci(2, "Emirhan Koca"));
            ogrenciler.Ekle(new Ogrenci(3, "Mustafa Kemal"));
            ogrenciler.Ekle(new Ogrenci(4, "Mai Sakurajima"));
            ogrenciler.Ekle(new Ogrenci(5, "Eray Can Özkenar"));
            ogrenciler.Ekle(new Ogrenci(6, "Tuğkan Gönültaş"));
            ogrenciler.Ekle(new Ogrenci(7, "Mert Yılmaz"));
            ogrenciler.Ekle(new Ogrenci(8, "Kim Dokja"));
            ogrenciler.Ekle(new Ogrenci(9, "Sung Jin Woo"));
            ogrenciler.Ekle(new Ogrenci(10, "Arthur Leywin"));
            ogrenciler.Ekle(new Ogrenci(11, "Takanashi Rikka"));
            ogrenciler.Ekle(new Ogrenci(12, "İchigo Kurasaki"));
            ogrenciler.Ekle(new Ogrenci(13, "Son Goku"));



            // Kitaplar ekleniyor
            kitaplar.Ekle(new Kitap("The Authhors Pov", "Entrail_Jl", "862", "Roman"));
            kitaplar.Ekle(new Kitap("Lord Of The Mysteries", "cuttlefish", "1449", "Roman"));
            kitaplar.Ekle(new Kitap("The Beginning After The End", "Turtleme", "561", "Roman"));
            kitaplar.Ekle(new Kitap("Omniscient Reader Viewpoint", "Sing Shong", "547", "Roman"));
            kitaplar.Ekle(new Kitap("Reverend İnsanity", "Gu Zhen Ren", "2334", "Roman"));
            kitaplar.Ekle(new Kitap("Re Zero", "Tappei", "938", "Roman"));
            kitaplar.Ekle(new Kitap("Shadow Slave", "Guiltythree", "2503", "Roman"));
            kitaplar.Ekle(new Kitap("The Primal Hunter", "Zogarth", "1236", "Roman"));
            kitaplar.Ekle(new Kitap("Children of The Holy Emperor", "Zeom", "185", "Roman"));
            kitaplar.Ekle(new Kitap("The Mirror Legacy", "Ji YuEren", "920", "Roman"));
            kitaplar.Ekle(new Kitap("A Regressors Tale of Culvitation", "Tremendous", "780", "Roman"));
            kitaplar.Ekle(new Kitap("Savaş ve Barış", "Lev Tolstoy", "1200", "Roman"));
            kitaplar.Ekle(new Kitap("Return of Mount Hua Sect", "Biga", "1797", "Roman"));
            kitaplar.Ekle(new Kitap("Damn Reincarnation", "Mogma", "177", "Roman"));
          

            // ComboBox'ları temizleme
            cmbOgrenci.Items.Clear();
            cmbKitap.Items.Clear();

            // Öğrencileri ComboBox'a atma sekansı
            var ogrNode = ogrenciler.BasGetir();
            while (ogrNode != null)
            {
                cmbOgrenci.Items.Add(ogrNode.Data);
                ogrNode = ogrNode.Next;
            }

            // Kitapları ComboBox'a yolluyoruz
            var kitapNode = kitaplar.BasGetir();
            while (kitapNode != null)
            {
                cmbKitap.Items.Add(kitapNode.Data);
                kitapNode = kitapNode.Next;
            }

            MessageBox.Show("Örnek veriler yüklendi");
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            // Örnek veri yüklenmemişse
            if (cmbOgrenci.Items.Count == 0 || cmbKitap.Items.Count == 0)
            {
                MessageBox.Show("Önce örnek veri yükleyiniz");
                return;
            }
            // Kitap veya öğrenci seçilmediyse null ata
            if (cmbOgrenci.SelectedItem == null || cmbKitap.SelectedItem == null)
            {
                MessageBox.Show("Önce öğrenci ve kitap seç");
                return;
            }

            Ogrenci secilenOgrenci = (Ogrenci)cmbOgrenci.SelectedItem;
            Kitap secilenKitap = (Kitap)cmbKitap.SelectedItem;

            // Kitap mevcutsa direkt veriyoruz
            if (secilenKitap.Musait)
            {
                secilenKitap.Musait = false;
                secilenKitap.OduncSayisi++;

                loglar.Ekle(new Log(
                    secilenOgrenci.AdSoyad + " adlı öğrenci " +
                    secilenKitap.Ad + " kitabını ödünç aldı"
                ));

                MessageBox.Show("Kitap ödünç verildi");
            }
            else
            {
                // Kitap mevcut değilse kuyruğa alıyoruz
                secilenKitap.RezervasyonKuyrugu.Ekle(secilenOgrenci);

                int sira = secilenKitap.RezervasyonKuyrugu.AdetGetir();

                loglar.Ekle(new Log(
                    secilenOgrenci.AdSoyad + " adlı öğrenci " +
                    secilenKitap.Ad + " kitabı için kuyruğa girdi"
                ));

                MessageBox.Show("Kitap şu an dolu. Kuyruktaki sıran: " + sira);
            }
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            // Örnek veri yüklenmemişse
            if (cmbOgrenci.Items.Count == 0 || cmbKitap.Items.Count == 0)
            {
                MessageBox.Show("Önce örnek veri yükleyiniz");
                return;
            }
            // Kitap seçilmemiş ise
            if (cmbKitap.SelectedItem == null)
            {
                MessageBox.Show("Önce iade edilecek kitabı seç");
                return;
            }

            Kitap secilenKitap = (Kitap)cmbKitap.SelectedItem;

            // Kitap müsait durumda ise
            if (secilenKitap.Musait)
            {
                MessageBox.Show("Bu kitap zaten kütüphanede");
                return;
            }

            //İade gerçekleştiriliyor
            secilenKitap.Musait = true;

            loglar.Ekle(new Log(
                secilenKitap.Ad + " kitabı iade edildi"
            ));

            // Kuyruk varsa sıradaki öğrenciye geçiyoruz
            if (!secilenKitap.RezervasyonKuyrugu.BosMu())
            {
                Ogrenci siradaki = secilenKitap.RezervasyonKuyrugu.Cikar();

                secilenKitap.Musait = false;
                secilenKitap.OduncSayisi++;

                loglar.Ekle(new Log(
                    secilenKitap.Ad + " kitabı sıradaki öğrenciye verildi: " +
                    siradaki.AdSoyad
                ));

                MessageBox.Show("Kitap sıradaki öğrenciye verildi");
            }
            else
            {
                MessageBox.Show("Kitap iade edildi");
            }
        }

        private void btnLogGoster_Click(object sender, EventArgs e)
        {
            // Listeyi temizlenir
            lstLoglar.Items.Clear();

            // Sboşalana kadar loglar çekilir
            while (!loglar.BosMu())
            {
                lstLoglar.Items.Add(loglar.Cikar());
            }
        }

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            // Eğer arama kutusu boşsa uyarı veriyoruz ki kullanıcı fark etsin
            if (txtKitapAra.Text.Trim() == "")
            {
                MessageBox.Show("Aranacak kitap adını yaz");
                return;
            }

            string aranan = txtKitapAra.Text.ToLower();
            lstAramaSonuc.Items.Clear();

            bool bulundu = false;

            // Kitap listesinde dolaşıyoruz
            var kitapNode = kitaplar.BasGetir();
            while (kitapNode != null)
            {
                // Kitap adı aranan kelimeyi içeriyor mu
                if (kitapNode.Data.Ad.ToLower().Contains(aranan))
                {
                    lstAramaSonuc.Items.Add(kitapNode.Data);
                    bulundu = true;
                }

                kitapNode = kitapNode.Next;
            }

            if (!bulundu)
            {
                lstAramaSonuc.Items.Add("Kitap bulunamadı");
            }
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            // Liste temizlendi
            lstListeleme.Items.Clear();

            // Kitap listesi geziliyor
            var kitapNode = kitaplar.BasGetir();
            while (kitapNode != null)
            {
                Kitap k = kitapNode.Data;

                // Kitap bilgilerini tek satırda gösteriliyor
                lstListeleme.Items.Add(
                    k.Ad + " | " +
                    k.Yazar + " | " +
                    (k.Musait ? "Müsait" : "Dolu") +
                    " | Ödünç: " + k.OduncSayisi
                );

                kitapNode = kitapNode.Next;
            }
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            // Listeyi temizlendi
            lstListeleme.Items.Clear();

            // Öğrenci listesi geziliuor
            var ogrNode = ogrenciler.BasGetir();
            while (ogrNode != null)
            {
                lstListeleme.Items.Add(ogrNode.Data);
                ogrNode = ogrNode.Next;
            }
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            lstIstatistik.Items.Clear();

            // Önce kitapları diziye aktarılıyor (listeyi sıralamak için)
            Kitap[] kitapDizi = new Kitap[kitaplar.AdetGetir()];

            int i = 0;
            var node = kitaplar.BasGetir();
            while (node != null)
            {
                kitapDizi[i] = node.Data;
                i++;
                node = node.Next;
            }

            // Bubble Sort büyükten küçüğe ödünç alınma sayısına göre sıralanıyor
            for (int a = 0; a < kitapDizi.Length - 1; a++)
            {
                for (int b = 0; b < kitapDizi.Length - a - 1; b++)
                {
                    if (kitapDizi[b].OduncSayisi < kitapDizi[b + 1].OduncSayisi)
                    {
                        Kitap gecici = kitapDizi[b];
                        kitapDizi[b] = kitapDizi[b + 1];
                        kitapDizi[b + 1] = gecici;
                    }
                }
            }

            // İlk 5 kitabı listelidik
            int limit = kitapDizi.Length < 5 ? kitapDizi.Length : 5;

            for (int j = 0; j < limit; j++)
            {
                lstIstatistik.Items.Add(
                    (j + 1) + ". " +
                    kitapDizi[j].Ad +
                    " (Ödünç: " + kitapDizi[j].OduncSayisi + ")"
                );
            }
        }

        private void IblKitap_Click(object sender, EventArgs e)
        {

        }

        private void lstLoglar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstIstatistik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}