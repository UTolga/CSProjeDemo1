namespace CSProjeDemo1
{
    public interface IUye
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int UyeNo { get; set; }
        List<Kitap> OduncAldigiKitaplar { get; }

        void KitapOduncAl(Kitap kitap);
        void KitapIadeEt(Kitap kitap);
        void OduncAldigiKitaplariListele();
    }
}
