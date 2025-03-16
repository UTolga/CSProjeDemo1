namespace CSProjeDemo1
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; private set; }
        public List<Uye> Uyeler { get; private set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }

        public void UyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
        }

        public void KutuphaneDurumuGoster()
        {
            Console.WriteLine("Kütüphane Durumu:");

            Console.WriteLine("\nMevcut Kitaplar:");
            foreach (var kitap in Kitaplar)
            {
                Console.WriteLine(kitap);
            }

            Console.WriteLine("\nÜyeler ve Ödünç Aldıkları Kitaplar:");
            foreach (var uye in Uyeler)
            {
                uye.OduncAldigiKitaplariListele();
            }
        }
    }
}
