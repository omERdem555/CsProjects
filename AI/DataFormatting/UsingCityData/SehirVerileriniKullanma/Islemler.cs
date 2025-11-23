namespace SehirVerileriniKullanma
{
    public static class Islemler
    {
        public static void UlkeBilgisiEkle(List<Kisi> kisiler, string ulke)
        {
            foreach (var kisi in kisiler)
            {
                kisi.Ulke = ulke;
            }
        }

        public static void KisiBilgisiEkle(List<Kisi> kisiler, string isim, int yas, double kilo)
        {
            Kisi kisi = new Kisi
            {
                Isim = isim,
                Yas = yas,
                Kilo = kilo
            };
            kisiler.Add(kisi);
        }



        public static void KisiBilgileriniDuzenle(List<Kisi> kisiler, string isim, int yas, double kilo, string ulke)
        {
            UlkeBilgisiEkle(kisiler, ulke);
            KisiBilgisiEkle(kisiler, isim, yas, kilo);
        }

        public static void UlkeleriYazdir(List<Kisi> kisiler)
        {
            // Ulke bilgilerini tekrar edenleri yalnızca bir defa yazdır
            Console.WriteLine("Tekrar eden ulke bilgileri:");
            var distinctUlke = kisiler.Select(p => p.Ulke).Distinct();
            foreach (var U in distinctUlke)
            {
                Console.Write(U + "\t");
            }
            Console.WriteLine();
        }



        public static void KisiBilgileriniYazdir(List<Kisi> kisiler)
        {
            Console.WriteLine("Kişi bilgileri:");
            foreach (var kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }
        }



        public static void KisileriUlkelereGoreYazdir(List <Kisi> kisiler)
        {
            bool[][] Ulkeler = new bool[1][];
        }


    }

}
