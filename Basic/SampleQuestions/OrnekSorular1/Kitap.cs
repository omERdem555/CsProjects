using System;

internal class Kitap
{
    private string KitapAdi;
    private string YazarAdi;
    private int YayinYili;
    private int SayfaSayisi;
    public Kitap(string kitapAdi, string yazarAdi, int yayinYili, int sayfaSayisi)
    {
        KitapAdi = kitapAdi ?? "Yok";  // Eğer kitap adı null ise "Yok" olarak atama yap
        YazarAdi = yazarAdi ?? "Yok";  // Eğer yazar adı null ise "Yok" olarak atama yap
        if (yayinYili > 0 && yayinYili <= DateTime.Now.Year) // Geçerli bir yayın yılı kontrolü
            YayinYili = yayinYili;
        else
        {
            Console.WriteLine("Geçerli bir yayın yılı girilmelidir.");
            YayinYili = 0;
        }
        SayfaSayisi = sayfaSayisi >= 0 ? sayfaSayisi : 0; // Sayfa sayısı negatif olamaz
    }
    public void KitapBilgileriniGoster()
    {
        Console.WriteLine($"Kitap2 Adı: {KitapAdi}, Yazar: {YazarAdi}, Yayımlandığı Yıl: {YayinYili}, Sayfa Sayısı: {SayfaSayisi}");
    }
    public void SayfaSayisiniGüncelle(int yeniSayfaSayisi)
    {
        SayfaSayisi = yeniSayfaSayisi >= 0 ? yeniSayfaSayisi : SayfaSayisi; // Sayfa sayısı negatif olamaz
        Console.WriteLine($"Yeni Sayfa Sayısı: {SayfaSayisi}");
    }
    public int KitapYasiHesapla()
    {
        int yas = DateTime.Now.Year - YayinYili;
        return yas > 0 ? yas : 0; // Eğer kitap henüz yayımlanmadıysa 0 yaş döndürsün
    }
}