namespace SehirVerileriniKullanma
{
    static class Veriler
    {
        public static List<Kisi> Kisiler { get; set; } = new List<Kisi>
        {
            new Kisi { Isim = "Ahmet", Yas = 30, Kilo = 70, Ulke = "Türkiye" },
            new Kisi { Isim = "Mehmet", Yas = 25, Kilo = 80, Ulke = "Fransa" },
            new Kisi { Isim = "Ayşe",  Yas = 28, Kilo = 60, Ulke = "Italya" },
            new Kisi { Isim = "Fatma", Yas = 22, Kilo = 55, Ulke = "Ispanya" },
            new Kisi { Isim = "Ali", Yas = 35, Kilo = 90, Ulke = "ABD" },
            new Kisi { Isim = "Zeynep", Yas = 27, Kilo = 65, Ulke = "Almanya" },
            new Kisi { Isim = "Hasan", Yas = 32, Kilo = 75, Ulke = "Yunanistan" },
            new Kisi { Isim = "Hüseyin", Yas = 29, Kilo = 85, Ulke = "Rusya" },
            new Kisi { Isim = "Elif", Yas = 24, Kilo = 50, Ulke = "Kanada" },
            new Kisi { Isim = "Emre", Yas = 31, Kilo = 78, Ulke = "Ingiltere" },
            new Kisi { Isim = "Selin", Yas = 26, Kilo = 68, Ulke = "Türkiye" },
            new Kisi { Isim = "Burak", Yas = 33, Kilo = 82, Ulke = "Fransa" },
            new Kisi { Isim = "Cem", Yas = 21, Kilo = 72, Ulke = "Italya" },
            new Kisi { Isim = "Derya", Yas = 23, Kilo = 58, Ulke = "Ispanya" },
            new Kisi { Isim = "Ege", Yas = 34, Kilo = 88, Ulke = "ABD" },
            new Kisi { Isim = "Furkan", Yas = 30, Kilo = 77, Ulke = "Almanya" },
            new Kisi { Isim = "Gizem", Yas = 28, Kilo = 62, Ulke = "Yunanistan" },
            new Kisi { Isim = "Hakan", Yas = 36, Kilo = 95, Ulke = "Rusya" },
            new Kisi { Isim = "Irem", Yas = 25, Kilo = 66, Ulke = "Kanada" },
            new Kisi { Isim = "Jale", Yas = 29, Kilo = 74, Ulke = "Ingiltere" },
            new Kisi { Isim = "Kaan", Yas = 31, Kilo = 80, Ulke = "Türkiye" },
            new Kisi { Isim = "Lara", Yas = 27, Kilo = 64, Ulke = "Fransa" },
            new Kisi { Isim = "Mert", Yas = 22, Kilo = 70, Ulke = "Italya" },
        };


        public static void UlkeleriYazdir()
        {
            // Ulke bilgilerini tekrar edenleri yalnızca bir defa yazdır
            Console.WriteLine("Tekrar eden ulke bilgileri:");
            var distinctUlke = Kisiler.Select(p => p.Ulke).Distinct();
            foreach (var U in distinctUlke)
            {
                Console.Write(U + "\t");
            }
            Console.WriteLine();
        }


        public static void KisiBilgileriniYazdir()
        {
            Console.WriteLine("Kişi bilgileri:");
            foreach (var kisi in Kisiler)
            {
                Console.WriteLine(kisi);
            }
        }

        enum Ulkeler
        {
            Türkiye,
            Fransa, 
            Italya,
            Ispanya,
            ABD,
            Almanya,
            Yunanistan,
            Rusya,
            Kanada,
            Ingiltere
        }

        public static void KisileriUlkelereGoreYazdir()
        {

            int[][] varMi = new int[22][];
            Console.WriteLine("İsim\tTürkiye Fransa  Italya  Ispanya ABD     Almanya Yunanistan      Rusya   Kanada  Ingiltere");
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    foreach (var kisi in Kisiler)
                    {
                        if(kisi.Ulke.Equals(Ulkeler)
                    }
                }
            }
        }

    }
}