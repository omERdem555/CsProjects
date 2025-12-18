using OrnekSorular;
using System.Runtime.Intrinsics.X86;

internal class Sorular
{
    private static void Main(string[] args)
    {
        //soru1();

        //soru2();

        //soru3();

        //soru4(); // Kalıtım

        //soru5();

        //soru6();

        //soru7();

        //soru8();

        //soru9();

        //soru10();

    }

    private static void soru10()
    {
        var b1 = new Bilgisayar("Dell", "Inspiron");
        var b2 = new Bilgisayar("HP", "Pavilion", 3);
    }

    private static void soru9()
    {
        var o1 = new Oyun("GTA", "Macera");
    }

    private static void soru8()
    {
        var t1 = new Telefon("Redmi", "Note10", 3500);
        var t2 = new Telefon("Huawei", "Mate10", -250);
    }

    private static void soru7()
    {
        var Ders1 = new Ders("Matematik", 2, "Ali");
        var Ders2 = new Ders("Türkçe", 4, "Akif");
    }

    private static void soru6()
    {
        var personel1 = new Personel();
        personel1.Ad = "Ahmet";
        personel1.Soyad = "Tuna";
        personel1.PersonelMaasi(100);
        personel1.MaasArttir(100);

        var personel2 = new Personel();
        personel2.Ad = "Şakir";
        personel2.Soyad = "Yılmaz";
        personel2.PersonelMaasi(-200);
    }

    private static void soru5()
    {
        var kitap1 = new Kitap();
        kitap1.SayfaSayisi = 35;
        kitap1.KitapAd = "Genç Werther'in Acıları";
        kitap1.YazarAd = "Goethe";
        Console.WriteLine($"{kitap1.KitapAd}, {kitap1.YazarAd}, {kitap1.SayfaSayisi}");
    }

    private static void soru4()
    {
        var hayvan = new Hayvan();
        hayvan.SesCikar();

        var kedi = new Kedi();
        kedi.SesCikar();

        var kopek = new Kopek();
        kopek.SesCikar();
    }

    private static void soru3()
    {
        var a1 = new Araba("Marka1", "Model1", 1000);
        Console.WriteLine(a1);
        var a2 = new Araba("Marka2", "Model2", 2000);
        Console.WriteLine(a2);
    }

    private static void soru2()
    {
        var h1 = new BankAccount(234, 15);
        h1.ParaEkle(234, 100);
        h1.ParaCek(234, 10);
        h1.ParaCek(123, 15);
        h1.ParaCek(234, 200);
    }

    static void soru1()
    {
        var o1 = new Ogrenci("Ahmet", "Tuna", 123);

        Console.WriteLine(o1);
    }
}