using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Hesap1
    {
        public Hesap1(int bakiye)
        {
            if (bakiye >= 0)
            {
                Bakiye = bakiye;
            }
            else
            {
                Console.WriteLine("Bakiye negatif olamaz. Varsayılan bakiye 0 olarak ayarlandı.");
                Bakiye = 0;
            }
        }

        private int Bakiye { get; set; }

        public void ParaYatir(int miktar)
        {
            if (miktar > 0)
            {
                Bakiye += miktar;
                Console.WriteLine($"Başarıyla {miktar} TL yatırdınız. Mevcut bakiye: {Bakiye} TL.");
            }
            else
            {
                Console.WriteLine("Negatif bir miktar yatırma işlemi gerçekleştirilemez.");
            }
        }

        public void ParaCek(int miktar)
        {
            if (miktar > 0)
            {
                if (Bakiye >= miktar)
                {
                    Bakiye -= miktar;
                    Console.WriteLine($"Başarıyla {miktar} TL çektiniz. Mevcut bakiye: {Bakiye} TL.");
                }
                else
                {
                    Console.WriteLine($"Bakiyeniz yetersiz. Mevcut bakiye: {Bakiye} TL.");
                }
            }
            else
            {
                Console.WriteLine("Negatif bir miktar çekme işlemi gerçekleştirilemez.");
            }
        }
    }
}
