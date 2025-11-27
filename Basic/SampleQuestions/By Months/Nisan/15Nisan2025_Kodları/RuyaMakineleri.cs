namespace _15Nisan2025_Kodları
{

    sealed class RuyaYoneticiSistemi
    {
        public static List<RuyaMakinasi> MakinelerListesi;
        static RuyaYoneticiSistemi()
        {
            Console.WriteLine("Sistem hazir hale gecmistir.");
            MakinelerListesi = new List<RuyaMakinasi>();
        }

        public void MakineEkle(RuyaMakinasi ruyaMakinasi)
        {
            if (!MakinelerListesi.Contains(ruyaMakinasi))
            {
                MakinelerListesi.Add(ruyaMakinasi);
                Console.WriteLine($"{ruyaMakinasi.Ad} basariyla eklenmistir.");
            }
            else
                Console.WriteLine("Eklemeye calistiginiz makine sistemde zaten bulunmaktadir.");
        }
        public void MakineCikar(RuyaMakinasi ruyaMakinasi)
        {
            if(MakinelerListesi.Contains(ruyaMakinasi))
            {
                Console.WriteLine($"{ruyaMakinasi.Ad} basariyla listeden silinmistir.");
                MakinelerListesi.Remove(ruyaMakinasi);
            }
            else
                Console.WriteLine("Silmeye calistiginiz makine sistemde bulunmamaktadir.");
        }
        public void MakineYonet(RuyaMakinasi ruyaMakinasi, string gorev)
        {
            if(ruyaMakinasi.Gorev != gorev)
            {
                ruyaMakinasi.Gorev = gorev;
                Console.WriteLine($"{ruyaMakinasi.Ad} basariyla istenilen {gorev} gorevine baslamistir.");
            }
            else
                Console.WriteLine("Bu makine zaten istenilen gorevi yapmaktadır.");
        }
    }


    interface IHayalYarat
    {
        public void Hayal();
    }

    interface IRuhHaliDegistir
    {
        public void RuhHali(string ruh);
    }

    interface IZihinYorumla
    {
        public void ZihinYorumla();
    }

    abstract class RuyaMakinasi : IHayalYarat, IRuhHaliDegistir, IZihinYorumla
    {
        protected RuyaMakinasi(string ad, string model, int uretimYili, string gorev)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "MakineAd";
            Model = !string.IsNullOrEmpty(model) ? model : "MakineModel";
            UretimYili = (uretimYili > 0 ) ? uretimYili : 0;
            Gorev = !string.IsNullOrEmpty(gorev) ? gorev : "MakineGorev";

            Console.WriteLine("Bir ruya makinesi goreve hazir haldedir");
        }

        public string Ad { get; set; }
        public string Model { get; set; }
        public int UretimYili { get; set; }
        public string Gorev { get; set; }

        public virtual void Hayal()
        {
            Console.WriteLine("Hayal ediliyor");
        }

        public abstract void RuhHali(string ruh);

        public virtual void ZihinYorumla()
        {
            Console.WriteLine("Zihin Yorumlanıyor");
        }
    }

    class Kabus : RuyaMakinasi
    {
        public Kabus(string ad, string model, int uretimYili, string gorev) : base(ad, model, uretimYili, gorev)
        {
            Console.WriteLine("Kabus ruya makinesi goreve hazirdir.");
        }

        public override void RuhHali(string ruh)
        {
            Console.WriteLine("Ruh hali suan yerinde degil");
        }
    }

    class TatliRuya : RuyaMakinasi
    {
        public TatliRuya(string ad, string model, int uretimYili, string gorev) : base(ad, model, uretimYili, gorev)
        {
            Console.WriteLine("Tatli ruya makinesi goreve hazirdir.");
        }

        public override void RuhHali(string ruh)
        {
            Console.WriteLine("Suna keyfi yerinde");
        }
    }

    class ZihinOyunu : RuyaMakinasi
    {
        public ZihinOyunu(string ad, string model, int uretimYili, string gorev) : base(ad, model, uretimYili, gorev)
        {
            Console.WriteLine("Zihin oyunu oynatmak icin ruya makinesi hazırdır");
        }

        public override void RuhHali(string ruh)
        {
            Console.WriteLine("Karmasık bir ruh hali icinde");
        }
    }

    class GercekciRuya : RuyaMakinasi
    {
        public GercekciRuya(string ad, string model, int uretimYili, string gorev) : base(ad, model, uretimYili, gorev)
        {
            Console.WriteLine("Gercekci ruya olusturmak icin ruya makinesi goreve hazir");
        }

        public override void RuhHali(string ruh)
        {
            Console.WriteLine("Gercekle ruyayi ayirt edemiyor");
        }
    }
}
