using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class HesapMakinesi
    {
        public decimal Topla(params decimal[] a)
        {
            decimal toplam = 0;
            if (a.Length > 0)
            {
                foreach (var x in a)
                {
                    toplam += x;
                }
            }
            return toplam;
        }

        public decimal Çıkarma(params decimal[] a)
        {
            decimal fark = 0;
            if (a.Length > 0)
            {
                foreach (var x in a)
                {
                    fark -= x;
                }
            }
            return fark;
        }

        public decimal Çarp(params decimal[] a)
        {
            decimal çarp = 1;
            if (a.Length > 0)
            {
                foreach (var x in a)
                {
                    çarp *= x;
                }
            }
            return çarp;
        }

        public decimal Bolme()
        {
            Console.Write("Bölen sayıyı giriniz: ");
            decimal bolen = Convert.ToDecimal(Console.ReadLine());
            if(bolen == 0)
            {
                Console.WriteLine("Bir bölme işleminde bölen sayı 0 olamaz. Varsayılan değer 1 olarak atandı");
                bolen = 1;
            }

            Console.Write("Bölünen sayıyı giriniz: ");
            decimal bolunen = Convert.ToDecimal(Console.ReadLine());

            return bolunen / bolen;
        }

    }
}
