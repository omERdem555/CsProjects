namespace _6Nisan2025_Kodları
{
    public abstract class UzayAraci : IEnerjiUret, IVeriTopla, IOrtamiIncele
    {
        protected UzayAraci(string? modelAdi, int uretimYili, string? gorev, string ıslem)
        {
            ModelAdi = modelAdi;
            UretimYili = uretimYili;
            Gorev = gorev;
            Islem = ıslem;
        }

        public string? ModelAdi { get; set; }
        protected int UretimYili { get; set; }
        public string? Gorev { get; set; }
        public string Islem { get; set; }

        public abstract void EnerjiUretme();

        public abstract void OrtamKosuluIncele();

        public abstract void VeriToplama();

    }

    interface IEnerjiUret
    {
        public virtual void EnerjiUretme()
        {

        }
    }
    interface IVeriTopla
    {
        public abstract void VeriToplama();
    }
    interface IOrtamiIncele
    {
        public abstract void OrtamKosuluIncele();
    }


    public class YildizliGozlemAraci : UzayAraci
    {
        public YildizliGozlemAraci(string? modelAdi, int uretimYili, string? gorev, string ıslem) : base(modelAdi, uretimYili, gorev, ıslem)
        {
        }

        ~YildizliGozlemAraci()
        {
            Console.WriteLine("YildizliGozlemAraci parcalandi");
        }


        public override void EnerjiUretme()
        {
            Console.WriteLine($"{this.ModelAdi} enerji üretti");
        }

        public override void OrtamKosuluIncele()
        {
            Console.WriteLine("YildizliGozlemAraci ortam kosullarini inceledi");
        }

        public override void VeriToplama()
        {
            Console.WriteLine("YildizliGozlemAraci veri topladı");
        }
    }
    public class GezegenKesifAraci : UzayAraci
    {
        public GezegenKesifAraci(string? modelAdi, int uretimYili, string? gorev, string ıslem) : base(modelAdi, uretimYili, gorev, ıslem)
        {
        }

        ~GezegenKesifAraci()
        {
            Console.WriteLine("GezegenKesifAraci havaya uctu");
        }
        public override void EnerjiUretme()
        {
            Console.WriteLine($"{this.ModelAdi} enerji üretti");
        }
        public override void OrtamKosuluIncele()
        {
            Console.WriteLine("GezegenKesifAraci ortam kosullarını inceledi");
        }
        public override void VeriToplama()
        {
            Console.WriteLine("GezegenKesifAraci veri topladi");
        }
    }
    public class AsteroitMadencilikAraci : UzayAraci
    {
        public AsteroitMadencilikAraci(string? modelAdi, int uretimYili, string? gorev, string ıslem) : base(modelAdi, uretimYili, gorev, ıslem)
        {
        }

        ~AsteroitMadencilikAraci()
        {
            Console.WriteLine("AsteroitMadencilikAraci parca parca oldu");
        }
        public override void EnerjiUretme()
        {
            Console.WriteLine($"{this.ModelAdi} enerji üretti");
        }
        public override void OrtamKosuluIncele()
        {
            Console.WriteLine("AsteroitMadencilikAraci ortam kosullarını inceledi");
        }

        public override void VeriToplama()
        {
            Console.WriteLine("AsteroitMadencilikAraci veri topladi");
        }

    }
    public class DerinUzayIletisimAraci : UzayAraci
    {
        public DerinUzayIletisimAraci(string? modelAdi, int uretimYili, string? gorev, string ıslem) : base(modelAdi, uretimYili, gorev, ıslem)
        {
        }

        ~DerinUzayIletisimAraci()
        {
            Console.WriteLine("DerinUzayIletisimAraci imha edildi");
        }
        public override void EnerjiUretme()
        {
            Console.WriteLine($"{this.ModelAdi} enerji üretti");
        }
        public override void OrtamKosuluIncele()
        {
            Console.WriteLine("DerinUzayIletisimAraci ortam kosullarini inceledi");
        }
        public override void VeriToplama()
        {
            Console.WriteLine("DerinUzayIletisimAraci veri topladi");
        }
    }



    interface IUzayKesifSistemiable
    {
        public void AracEkle(UzayAraci uzayAraci);
        public void AracCikar(UzayAraci uzayAraci);
        public void AracIslem(UzayAraci uzayAraci, string islem);
        public void AracGorevYonet(UzayAraci uzayAraci, string gorev);
    }
    public sealed class UzayKesifSistemi : IUzayKesifSistemiable
    {
        public static List<UzayAraci> Araclar;
        static UzayKesifSistemi()
        {
            Araclar = new List<UzayAraci>();
        }


        public void AracEkle(UzayAraci uzayAraci)
        {
            if (Araclar.Contains(uzayAraci)) 
            {
                Console.WriteLine("Eklenmek istenen arac zaten sistemde bulunuyor.");
            }
            else
            {
                Araclar.Add(uzayAraci);
                Console.WriteLine("Arac basariyla eklenmistir.");
            }

        }
        public void AracCikar(UzayAraci uzayAraci)
        {
            if (Araclar.Contains(uzayAraci))
            {
                Console.WriteLine("Eklenmek istenen arac zaten sistemde bulunuyor.");
            }
            else
            {
                Araclar.Add(uzayAraci);
                Console.WriteLine("Arac basariyla eklenmistir.");
            }
        }
        public void AracGorevYonet(UzayAraci uzayAraci, string gorev)
        {
            uzayAraci.Gorev = gorev;
            Console.WriteLine($"{uzayAraci.ModelAdi} uzay aracina {gorev} basariyla verilmistir.");
        }
        public void AracIslem(UzayAraci uzayAraci, string islem)
        {
            uzayAraci.Islem = islem;
            Console.WriteLine($"{uzayAraci.ModelAdi} uzay aracina {islem} basariyla verilmistir.");
        }
    }
}
