using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Aralık2024_Kodları
{
    using System;
    using System.Collections.Generic;

    public class Mağaza
    {
        private List<Ürün> UrunListesi = new List<Ürün>();
        public void UrunEkle(Ürün ürün)
        {
            if (ürün == null)
            {
                Console.WriteLine("Boş bir ürün eklenemez!");
                return;
            }

            var mevcutUrun = UrunListesi.Find(u => u.UrunAdi == ürün.UrunAdi);
            if (mevcutUrun != null)
            {
                mevcutUrun.Stok += ürün.Stok;
                Console.WriteLine($"{ürün.UrunAdi} zaten stokta var. Stok güncellendi: {mevcutUrun.Stok}");
            }
            else
            {
                UrunListesi.Add(ürün);
                Console.WriteLine($"{ürün.UrunAdi} başarıyla eklendi.");
            }
        }
        public void StokAzalt(string urunAdi, byte miktar)
        {
            if (string.IsNullOrEmpty(urunAdi))
            {
                Console.WriteLine("Ürün adı boş olamaz!");
                return;
            }

            var ürün = UrunListesi.Find(u => u.UrunAdi == urunAdi);
            if (ürün != null)
            {
                if (ürün.Stok >= miktar)
                {
                    ürün.Stok -= miktar;
                    Console.WriteLine($"{ürün.UrunAdi} stoktan {miktar} adet çıkarıldı. Kalan stok: {ürün.Stok}");
                }
                else
                {
                    Console.WriteLine($"{ürün.UrunAdi} stok yetersiz. Mevcut stok: {ürün.Stok}");
                }
            }
            else
            {
                Console.WriteLine($"{urunAdi} isimli ürün stokta bulunamadı.");
            }
        }

        // Stok Kontrolü
        public void StokKontrol()
        {
            if (UrunListesi.Count == 0)
            {
                Console.WriteLine("Mağazada hiçbir ürün bulunmamaktadır.");
                return;
            }

            Console.WriteLine("Stok Adedi 5'ten Az Olan Ürünler:");
            int adet = 0;

            foreach (var ürün in UrunListesi)
            {
                if (ürün.Stok < 5)
                {
                    Console.WriteLine(ürün);
                    adet++;
                }
            }

            if (adet == 0)
            {
                Console.WriteLine("Hiçbir ürünün stok adedi 5'ten az değildir.");
            }
        }
    }

    public class Ürün
    {
        private static int urunSayaci = 1;
        internal string UrunAdi { get; set; }
        internal byte Fiyat { get; set; }
        internal byte Stok { get; set; }
        public Ürün(string? urunAdi, byte fiyat, byte stok)
        {
            UrunAdi = !string.IsNullOrEmpty(urunAdi) ? urunAdi : $"Ürün {urunSayaci++}";
            Fiyat = fiyat > 0 ? fiyat : (byte)1; 
            Stok = stok > 0 ? stok : (byte)1;   

            if (fiyat == 0)
            {
                Console.WriteLine($"Fiyat sıfır girdiğiniz için varsayılan olarak 1 atandı.");
            }
            if (stok == 0)
            {
                Console.WriteLine($"Stok sıfır girdiğiniz için varsayılan olarak 1 atandı.");
            }
        }
        public override string ToString()
        {
            return $"Ürün: {UrunAdi} | Fiyat: {Fiyat} | Stok: {Stok}";
        }
    }
}
