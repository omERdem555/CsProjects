using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Aralık2024_Kodları
{
    public class Personel : Şirket
    {
        public Personel(string? ad, string? soyad, string? departman, decimal maas)
        {
            Ad = !string.IsNullOrEmpty(ad) ? ad : "Varsayılan Ad";
            Soyad = !string.IsNullOrEmpty(soyad) ? soyad : "Varsayılan Soyad";
            Departman = !string.IsNullOrEmpty(departman) ? departman : "Varsayılan Departman";
            Maas = (maas >= 0) ? maas : 0;
        }

        internal string? Ad { get; set; }
        internal string? Soyad { get; set; }
        internal string? Departman { get; set; }
        internal decimal Maas { get; set; }

        public override string ToString()
        {
            return $"{Ad}, {Soyad} {Departman}'da {Maas} ile çalışıyor.";
        }
    }
    public class Şirket 
    {
        List<Personel> PersonelListesi = new List<Personel>();
        public static decimal ToplamM = 0;
        public void PersonelEkle(Personel personel)
        {
            if (personel == null) throw new ArgumentNullException();

            PersonelListesi.Add(personel);
            ToplamM += personel.Maas;
            Console.WriteLine($"{personel.Ad} başarıyla eklenmiştir.");
        }
        public void PersonelSil(Personel personel)
        {
            if (personel == null) throw new ArgumentNullException(nameof(personel));

            if (PersonelListesi.Remove(personel))
            {
                ToplamM -= personel.Maas;
                Console.WriteLine($"{personel.Ad} başarıyla silinmiştir.");
            }
            else
            {
                Console.WriteLine("Personel listede bulunamadı.");
            }
        }

        public void DepartmanaGoreListele(string departman)
        {
            if(PersonelListesi.Count == 0) throw new ArgumentNullException();

            if(departman == null) throw new ArgumentNullException();

            foreach (Personel personel in PersonelListesi)
            {
                if(personel.Departman == departman)
                    Console.WriteLine(personel);
            }
        }
        public void TumPersonelleriListele()
        {
            if (PersonelListesi.Count == 0)
            {
                Console.WriteLine("Şirketin personel listesi boş.");
            }
            else
            {
                Console.WriteLine("Şirketteki tüm personeller:");
                foreach (Personel personel in PersonelListesi)
                {
                    Console.WriteLine(personel);
                }
            }
        }

        public void MaasGuncelle(Personel personel, decimal yeniMaas)
        {
            if (personel == null) throw new ArgumentNullException(nameof(personel));
            if (yeniMaas < 0) throw new ArgumentOutOfRangeException(nameof(yeniMaas));

            ToplamM -= personel.Maas;
            personel.Maas = yeniMaas;
            ToplamM += yeniMaas;

            Console.WriteLine($"{personel.Ad} adlı personelin maaşı {yeniMaas} olarak güncellenmiştir.");
        }
        public void ToplamMaas()
        {
            Console.WriteLine($"Şirkette çalışan herkesin toplam maaşı: {ToplamM}");
        }
    }
}
