using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Kitap1
    {
        private string? Ad;
        private string? Yazar;
        private int SayfaSayisi;

        private int OkunanSayfa = 0;

        public Kitap1(string? ad, string? yazar, int sayfaSayisi)
        {
            Ad = ad;
            Yazar = yazar;
            if (sayfaSayisi > 0)
                SayfaSayisi = sayfaSayisi;
            else
            {
                Console.WriteLine("Kitabın sayfa sayısı negatif olamaz!");
                SayfaSayisi = 0;
            }
        }

        public void SayfaOku(int Sayfa)
        {
            if(Sayfa < 0)
                Console.WriteLine("Negatif sayıda sayfa okunamaz");
                
            if (Sayfa < SayfaSayisi - OkunanSayfa)
                OkunanSayfa += Sayfa;
            else
                Console.WriteLine($"Bu kitapta {Sayfa} kadar sayfa kalmamıştır.");
        }

        public bool TamamlandiMi()
        {
            if (OkunanSayfa == SayfaSayisi)
            {
                Console.WriteLine("Kitabı tamamen bitirdin");
                return true;
            }
            else
            {
                Console.WriteLine($"Kitabın bitmesine {SayfaSayisi - OkunanSayfa} kadar sayfa kaldı");
                return false;
            }
        }
    }
}
