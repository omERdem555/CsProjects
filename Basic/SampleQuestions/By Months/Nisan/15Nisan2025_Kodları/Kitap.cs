using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _15Nisan2025_Kodları
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string Turu { get; set; }
        public int StokSayisi { get; set; }
    }


    interface IKullanici
    {
        public void KitapAl(Kitap kitap, int sayi);
        public void KitapVer(Kitap kitap, int sayi);
        public void Listele();
    }

    public class Ogrenci : IKullanici
    {
        public string Ad { get; set; }
        public List<(Kitap, int)> KitapStok;        
        public void KitapAl(Kitap kitap, int sayi)
        {
            Console.WriteLine($"Ogrenci {Ad} kitap aldı: {kitap.KitapAdi}");
        }

        public void KitapVer(Kitap kitap, int sayi)
        {
            throw new NotImplementedException();
        }

        public void Listele()
        {
            throw new NotImplementedException();
        }
    }

    public class Akademisyen : IKullanici
    {
        public void KitapAl(Kitap kitap, int sayi)
        {
            throw new NotImplementedException();
        }

        public void KitapVer(Kitap kitap, int sayi)
        {
            throw new NotImplementedException();
        }

        public void Listele()
        {
            throw new NotImplementedException();
        }
    }
}
