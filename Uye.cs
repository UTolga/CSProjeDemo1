namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNo { get; set; }
        public List<Kitap> OduncAldigiKitaplar { get; private set; }

        public Uye(string ad, string soyad, int uyeNo)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNo = uyeNo;
            OduncAldigiKitaplar = new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.MevcutDurum == Durum.OduncAlabilir)
            {
                kitap.DurumGuncelle(Durum.OduncVerildi);
                OduncAldigiKitaplar.Add(kitap);
                Console.WriteLine($"{Ad} {Soyad} kitabı ödünç aldı: {kitap.Baslik}");
            }
            else
            {
                Console.WriteLine("Bu kitap şu an ödünç alınamaz.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncAldigiKitaplar.Contains(kitap))
            {
                kitap.DurumGuncelle(Durum.OduncAlabilir);
                OduncAldigiKitaplar.Remove(kitap);
                Console.WriteLine($"{Ad} {Soyad} kitabı iade etti: {kitap.Baslik}");
            }
            else
            {
                Console.WriteLine("Bu kitabı iade edemezsiniz, çünkü ödünç almamışsınız.");
            }
        }

        public void OduncAldigiKitaplariListele()
        {
            Console.WriteLine($"{Ad} {Soyad} tarafından ödünç alınan kitaplar:");
            foreach (var kitap in OduncAldigiKitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik}");
            }
        }
    }
}
