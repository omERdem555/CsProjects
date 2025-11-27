using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Aralık2024_Kodları
{
    public class Urun
    {
        public Urun(string? urunAdi, byte fiyat, string? kategori, byte stok)
        {
            UrunAdi = !string.IsNullOrEmpty(urunAdi) ? urunAdi : "Varsayılan Ürün Adı";
            Fiyat = (fiyat >= 0) ? fiyat : (byte)0;
            Kategori = !string.IsNullOrEmpty(kategori) ? kategori : "Varsayılan Kategori";
            Stok = (stok > 0) ? stok : (byte)0;
        }

        internal string? UrunAdi { get; set; }
        internal int Fiyat { get; set; }
        internal string? Kategori { get; set; }
        internal byte Stok { get; set; }

        public override string ToString()
        {
            return $"{UrunAdi} üründen {Stok} tane vardır." +
                $"Kategori: {Kategori} - Fiyat: {Fiyat}";
        }

    }
    public class Siparis
    {
        List<Urun> MüsteriListesi = new List<Urun>();
        public void SiparisOlustur(string musteriAdi, List<Urun> urunler)
        {
            if (string.IsNullOrEmpty(musteriAdi))
            {
                Console.WriteLine("İsminizi boş giremezsiniz!");
                return;
            }

            if (urunler == null || urunler.Count == 0)
            {
                Console.WriteLine($"Sayın {musteriAdi}, boş bir liste ile sipariş veremezsiniz!");
                return;
            }
            else
            {
                MüsteriListesi.AddRange(urunler);
                Console.WriteLine("Sipariş başarıyla oluşturuldu!");
            }
        }
        public void ToplamFiyatHesapla()
        {
            if (MüsteriListesi.Count == 0)
            {
                Console.WriteLine("Liste boş olduğu için hesaplama yapılamıyor.");
            }
            int tFiyat = MüsteriListesi.Sum(x => x.Fiyat);

            Console.WriteLine($"Müşteri listesinin toplam fiyatı: {tFiyat}");

        }
        /*
        static void Stok()
        {
            foreach (Urun urun in MüsteriListesi)
            {
                if(urun.Stok == 0)
                    MüsteriListesi.Remove(urun);
            }
        }*/
    }
}
