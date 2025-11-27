using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Nisan2025_Kodları
{

    interface IKutuphaneIslemleri
    {
        public void KitapEkleme(Kitap kitap, string sifre, int adet);
        public void KitapOduncAlma(int isbn, string sifre);
        public void KitapIadeEtme(int isbn, string sifre);
        public void KitapYazdır(int isbn);

    }
    interface IUyeIslemleri
    {
        public void UyeEkleme(Uye u);
        public void UyeSilme(Uye u);
    }
    public partial class Uye
    {
        public Uye(string ad, string soyad, string sifre)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "defaut ad";
            Soyad = !string.IsNullOrEmpty(soyad) ? soyad : "default soyad";
            Sifre = !string.IsNullOrEmpty(sifre) ? sifre : "default sifre";
        }
    }
    public partial class Uye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
    }
    public class KutuphaneYoneticisi : IKutuphaneIslemleri, IUyeIslemleri
    {

        public static List<Kitap> Kitaplar;
        public static List<Uye> Uyeler;

        static KutuphaneYoneticisi()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }

        public void KitapEkleme(Kitap kitap, string sifre, int adet)
        {
            Uye arananUye = null;
            foreach (var uye in Uyeler)
            {
                if (uye.Sifre == sifre)
                {
                    arananUye = uye;
                    break;
                }
            }
            if (arananUye != null)
            {
                Kitaplar.Add(kitap);
                kitap.Adet += adet;
                Console.WriteLine("Kitap başarıyla eklenmiştir!");
            }
            else
                Console.WriteLine("Böyle bir üye bulunamadı!");

        }

        public void KitapIadeEtme(int isbn, string sifre)
        {
            Uye arananUye = null;
            foreach (var uye in Uyeler)
            {
                if (uye.Sifre == sifre)
                {
                    arananUye = uye;
                    break;
                }
            }

            Kitap arananKitap = null;
            if (arananUye != null)
            {
                foreach (var kitap in Kitaplar)
                {
                    if (kitap.ISBN == isbn)
                    {
                        arananKitap = kitap;
                        Console.WriteLine("İade edilecek kitap kayıtlıdır.");
                        arananKitap.Adet++;
                        Console.WriteLine($"Kitabın yeni adedi: {arananKitap.Adet}");
                        break;
                    }
                }
                return;
            }
            else
                Console.WriteLine("Böyle bir üye bulunamadı!");
            if (arananKitap == null)
                Console.WriteLine("İade edilecek kitap kayıtlı değildir!");

        }

        public void KitapOduncAlma(int isbn, string sifre)
        {
            Uye arananUye = null;
            foreach (var uye in Uyeler)
            {
                if (uye.Sifre == sifre)
                {
                    arananUye = uye;
                    break;
                }
            }

            Kitap arananKitap = null;
            if (arananUye != null)
            {
                foreach (var kitap in Kitaplar)
                {
                    if (kitap.ISBN == isbn)
                    {
                        arananKitap = kitap;
                        Console.WriteLine("Ödünç alınacak kitap kayıtlıdır.");
                        arananKitap.Adet--;
                        Console.WriteLine($"Kitabın yeni adedi: {arananKitap.Adet}");
                        break;
                    }
                }
                return;
            }
            else
                Console.WriteLine("Böyle bir üye bulunamadı!");
            if (arananKitap == null)
                Console.WriteLine("Ödünç alınacak kitap kayıtlı değildir!");
        }

        public void KitapYazdır(int isbn)
        {
            Kitap arananKitap = null;
            foreach (Kitap kitap in Kitaplar)
            {
                if (kitap.ISBN == isbn)
                {
                    arananKitap = kitap;
                    break;
                }
            }

            Console.WriteLine($"Kitabın Adı: {arananKitap.KitapAdi}\n" +
                $"Yazarın Adı: {arananKitap.YazarAdi}\n" +
                $"Kitabın Adedi: {arananKitap.Adet}");
        }

        public void UyeEkleme(Uye u)
        {
            Uye uyeArama = null;
            foreach (Uye uye in Uyeler)
            {
                if (u == uye)
                {
                    uyeArama = uye;
                    break;
                }
            }
            if (uyeArama == null)
                Uyeler.Add(u);
            else
                Console.WriteLine("Böyle bir kullanıcı zaten bulunmaktadır!");
        }

        public void UyeSilme(Uye u)
        {
            Uye uyeArama = null;
            foreach (Uye uye in Uyeler)
            {
                if (u == uye)
                {
                    uyeArama = uye;
                    break;
                }
            }
            if (uyeArama != null)
                Uyeler.Remove(u);
            else
                Console.WriteLine("Böyle bir kullanıcı bulunmamaktadır!");
        }
    }


    abstract public class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public readonly int ISBN;
        public int Adet;
        public static int ToplamKitapSayisi;
        public Kitap(string kitapAdi, string yazarAdi, int ıSBN)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            ISBN = ıSBN;
        }
        ~Kitap()
        {
            Console.WriteLine("Kitap Kaldırılmıştır!");
        }

        static Kitap()
        {
            ToplamKitapSayisi = 0;
        }

        public virtual void BilgiGoster()
        {
            Console.WriteLine($"Kitabın Adı: {KitapAdi}\n" +
                $"Yazarın Adı: {YazarAdi}\n" +
                $"Kitabın ISBN no: {ISBN}\n" +
                $"Adeti: {Adet}");
        }
    }

    public class Roman : Kitap
    {
        public Roman(string kitapAdi, string yazarAdi, int ıSBN) : base(kitapAdi, yazarAdi, ıSBN)
        {
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster();
        }
    }

    public class DersKitabı : Kitap
    {
        public DersKitabı(string kitapAdi, string yazarAdi, int ıSBN) : base(kitapAdi, yazarAdi, ıSBN)
        {
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster();
        }
    }

    public class Dergi : Kitap
    {
        public Dergi(string kitapAdi, string yazarAdi, int ıSBN) : base(kitapAdi, yazarAdi, ıSBN)
        {
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster();
        }
    }
}
