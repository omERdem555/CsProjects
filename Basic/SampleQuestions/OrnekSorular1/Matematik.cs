using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class Matematik
    {
        //private int A;
        //private int B;
        public int Hesapla(int a, int b, char c)
        {
            //A = a;
            //B = b;
            switch (c)
            {
                case '+':
                    return Toplama(a, b); 
                case '-':
                    return Cikartma(a, b); 
                case '*':
                    return Carpma(a, b); 
                case '/':
                    return Bolme(a, b); 
                default:
                    {
                        Console.WriteLine("Girdiğiniz Hesaplama işlemi geçerli değildir!");
                        return -1;
                    }
            }
        }

        public int Toplama(int a, int b)
            { return a + b; }
        public int Cikartma(int a, int b)
            { return a - b; }
        public int Carpma(int a, int b)
            { return a * b; }
        public int Bolme(int a, int b)
        {
            if (b > 0)
                return a / b;
            else
            {
                Console.WriteLine("Bolme işleminde payda 0 olamaz!");
                return 0;
            }
        }
    }
}
