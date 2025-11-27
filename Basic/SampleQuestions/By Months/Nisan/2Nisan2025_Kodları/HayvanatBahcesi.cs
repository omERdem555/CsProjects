using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _2Nisan2025_Kodları
{
    interface IHayvanIslemleri
    {
        public void Ekleme(Hayvan hayvan);
        public void Cikarma(Hayvan hayvan);
        public void Besleme(Hayvan hayvan);
        public void Yikama(Hayvan hayvan);
    }
    public class HayvanatBahcesi : IHayvanIslemleri
    {
        public static List<Hayvan> Hayvanlar;
        static public int Adet = 0;
        static HayvanatBahcesi()
        {
            Hayvanlar = new List<Hayvan>();
        }

        public void Besleme(Hayvan hayvan)
        {
            Console.WriteLine($"{hayvan.Ad}, {hayvan.BeslenmeSekli} besleniyor.");
        }

        public void Cikarma(Hayvan hayvan)
        {
            Hayvan arananHayvan = null;
            foreach (Hayvan h in Hayvanlar)
            {
                if (h == hayvan)
                {
                    arananHayvan = h;
                    Console.WriteLine($"Çıkarılmak istenen {hayvan.Ad} bahçede bulunmuştur.");
                    Hayvanlar.Remove(hayvan);
                    break;
                }
            }
            if(arananHayvan == null)
                Console.WriteLine($"Aranan {hayvan.Ad} bahçede bulunamadı!");
        }

        public void Ekleme(Hayvan hayvan)
        {
            Hayvan arananHayvan = null;
            foreach (Hayvan h in Hayvanlar)
            {
                if (h == hayvan)
                {
                    arananHayvan = h;
                    Console.WriteLine($"Eklenmek istenen {h.Ad} bahçede zaten bulunmaktadı!");
                }
            }
            if(arananHayvan == null)
            {
                Hayvanlar.Add(hayvan);
                Console.WriteLine($"{hayvan.Ad} bahçeye eklenmiştir!");
            }
        }

        public void Yikama(Hayvan hayvan)
        {
            Console.WriteLine($"{hayvan.Ad} güzelce yıkanmıştır!");
        }
    }

    interface IBeslenme
    {
        public void Beslenmek();
    }
    interface IUyku
    {
        public void Uyumak();
    }
    interface ISesCikar
    {
        public void SesCikarmak();
    }

    abstract public class Hayvan : IBeslenme, IUyku, ISesCikar
    {
        protected Hayvan(string ad, int yas, string beslenmeSekli)
        {
            Ad = ad;
            Yas = yas;
            BeslenmeSekli = beslenmeSekli;
        }

        public string Ad { get; set; }
        public int Yas { get; set; }
        public string BeslenmeSekli { get; set; }

        public abstract void Beslenmek();

        public abstract void SesCikarmak();

        public void Uyumak()
        {
            Console.WriteLine($"{Ad} uyuyor.");
        }
    }
    public class Kedi : Hayvan
    {
        public Kedi(string ad, int yas, string beslenmeSekli) : base(ad, yas, beslenmeSekli)
        {
        }

        public override void Beslenmek()
        {
            Console.WriteLine($"{Ad} hem etçil hem otçul besleniyor.");
        }

        public override void SesCikarmak()
        {
            Console.WriteLine($"{Ad} miyavladı.");
        }
    }
    public class Kopek : Hayvan
    {
        public Kopek(string ad, int yas, string beslenmeSekli) : base(ad, yas, beslenmeSekli)
        {
        }

        public override void Beslenmek()
        {
            Console.WriteLine($"{Ad} hem etçil hem otçul besleniyor.");
        }

        public override void SesCikarmak()
        {
            Console.WriteLine($"{Ad} havladı.");
        }
    }
    public class Aslan : Hayvan
    {
        public Aslan(string ad, int yas, string beslenmeSekli) : base(ad, yas, beslenmeSekli)
        {
        }

        public override void Beslenmek()
        {
            Console.WriteLine($"{Ad} hem etçil besleniyor.");
        }

        public override void SesCikarmak()
        {
            Console.WriteLine($"{Ad} gürledi.");
        }
    }
    public class Maymun : Hayvan
    {
        public Maymun(string ad, int yas, string beslenmeSekli) : base(ad, yas, beslenmeSekli)
        {
        }

        public override void Beslenmek()
        {
            Console.WriteLine($"{Ad} hem otçul hem etçil besleniyor.");
        }

        public override void SesCikarmak()
        {
            Console.WriteLine($"{Ad} maymun sesi çıkardı.");
        }
    }
    public class Yılan : Hayvan
    {
        public Yılan(string ad, int yas, string beslenmeSekli) : base(ad, yas, beslenmeSekli)
        {
        }

        public override void Beslenmek()
        {
            Console.WriteLine($"{Ad} hem etçil besleniyor.");
        }

        public override void SesCikarmak()
        {
            Console.WriteLine($"{Ad} tısladı.");
        }
    }
}
