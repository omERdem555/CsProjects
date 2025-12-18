using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular2
{
    public class Hayvan
    {
        public Hayvan()
        {
            Console.WriteLine("Hayvan dogdu");
        }

        public int Yas { get; set; }
        public void SesCikar()
        {
            Console.WriteLine($"Ses cikar");
        }
    }
    public class Kopek : Hayvan
    {
        public Kopek()
        {
            Console.WriteLine("Kopek dogdu");
        }
        public void Havla()
        {
            Console.WriteLine($"{Yas} Havliyor");
        }
    }
    public class Kedi : Hayvan
    {
        public Kedi()
        {
            Console.WriteLine("Kedi dogdu");
        }
        public void Miyav()
        {
            Console.WriteLine($"{Yas} Miyavla");
        }
    }
    public class VanKedisi : Kedi
    {
        public VanKedisi()
        {
            Console.WriteLine("Van Kedisi dogdu");
        }
    }
    public class AnkaraKedisi : Kedi
    {
        public AnkaraKedisi()
        {
            Console.WriteLine("Ankara Kedisi dogdu");
        }
    }
}
