using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Mart2025_Kodları
{
    public class Hesap
    {
        public Hesap(int hesapNumarasi, int bakiye)
        {
            if (hesapNumarasi < 0)
            {
                Console.WriteLine("Hesap numarası 0'dan küçük olamaz!\nDefault 0 girilmiştir.");
                HesapNumarasi = 0;
            }
            else
                HesapNumarasi = hesapNumarasi;

            if (bakiye < 0)
            {
                Console.WriteLine("Bakiye 0'dan küçük olamaz!\nDefault 0 girilmiştir.");
                Bakiye = 0;
            }
            else
                Bakiye = bakiye;
        }

        public int HesapNumarasi { get; set; }
        public double Bakiye { get; set; }

        public virtual void ParaYatirma(int hNo, double miktar)
        {
            if (hNo != HesapNumarasi)
            {
                Console.WriteLine("Girdiğiniz hesap numarası eşleşmemektedir.");
                return;
            }

            if (miktar <= 0)
            {
                Console.WriteLine("Negatif veya sıfır miktar hesaba yatırılamaz.");
                return;
            }

            Bakiye += miktar;
            Console.WriteLine("Hesabınızın yeni bakiyesi: " + Bakiye);
        }

        public virtual void ParaCekme(int hNo, double miktar)
        {
            if (hNo != HesapNumarasi)
            {
                Console.WriteLine("Girdiğiniz hesap numarası eşleşmemektedir.");
                return;
            }


            if (miktar < 0)
            {
                Console.WriteLine("Negatif değerde miktar hesaba yatırılamaz.");
                return;
            }

            if (Bakiye - miktar < 0)
            {
                Console.WriteLine("Hesabınızda yeterli miktarda para bulunmamaktadır.\n" +
                    "Mevcut Bakiyeniz: " + Bakiye);
                return;
            }

            Bakiye -= miktar;
            Console.WriteLine("Hesabınızın yeni bakiyesi: " + Bakiye);
        }
    }
    public class BireyselHesap : Hesap
    {
        public BireyselHesap(int hesapNumarasi, int bakiye) : base(hesapNumarasi, bakiye)
        {
        }

        public override void ParaCekme(int hNo, double miktar)
        {
            double fMiktar = miktar * 1.01;
            if (Bakiye - fMiktar < 0)
            {
                Console.WriteLine("Hesabınızda yeterli miktarda para bulunmamaktadır.\n" +
                    "Mevcut Bakiyeniz: " + Bakiye);
            }
            base.ParaCekme(hNo, fMiktar);
        }
    }
    public class TicariHesap : Hesap
    {
        public TicariHesap(int hesapNumarasi, int bakiye) : base(hesapNumarasi, bakiye)
        {
        }

        public override void ParaCekme(int hNo, double miktar)
        {
            if (Bakiye - (miktar + 1000) < 0)
            {
                Console.WriteLine("Hesabınızda en az bin para bulunması gerekmektedir." +
                    "Mevcut Bakiyeniz: " + Bakiye);
            }
            base.ParaCekme(hNo, miktar);
        }
    }
}
