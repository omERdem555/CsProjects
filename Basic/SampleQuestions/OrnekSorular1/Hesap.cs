using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Hesap
    {
        private decimal Bakiye;

        public Hesap(decimal bakiye)
        {
            if (bakiye > 0)
                Bakiye = bakiye;
            else
            {
                Console.WriteLine("Bir hesap ilk açıldığında borç olamaz!");
                Bakiye = 0;
            }
        }

        public void ParaYatir(decimal Miktar)
        {
            if (Miktar > 0)
            {
                Bakiye += Miktar;
                Console.WriteLine($"Mevcut bakiyeniz: {BakiyeGoster()}");
            }
            else
            {
                Console.WriteLine("Hesabınıza negatif para yatıramazsınız!");
            }
        }

        public void ParaCek(decimal Miktar)
        {
            if (Miktar > 0)
            {
                if (Bakiye - Miktar > 0)
                {
                    Bakiye -= Miktar;
                    Console.WriteLine($"Hesabınızdan {Miktar} para başarıyla çekilmiştir." +
                        $"Yeni bakiyeniz: {BakiyeGoster()}");
                }
                else
                    Console.WriteLine($"Hesabınızda {BakiyeGoster()} kadar para çekecek kadar para yoktur!\nMevcut bakiyeniz: {Bakiye}");
            }
            else
            {
                Console.WriteLine("Negatif bir miktarda para çekilmesi mümkün değildir!");
            }
        }

        private decimal BakiyeGoster()
        {
            return Bakiye;
        }
    }
}
