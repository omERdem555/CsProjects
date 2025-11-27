using System.Threading.Channels;

namespace _11Mart2025_Kodları
{
    public class OrnekClass
    {
        public OrnekClass(int a)
        {
            A = a;
        }

        //public OrnekClass()
        //{
        //    Console.WriteLine("OrnekClass Oluşturulmuştur.");
        //}
        public OrnekClass(int a, int b)
        {
            A = a;
            B = b;
        }
        protected int A { get; set; }
        protected int B { get; set; }
        internal void C(int x)
        {
            Console.WriteLine(x);
        }
        virtual public void D(int x)
        {
            Console.WriteLine(x);
        }

    }
    public class OrnekClass2 : OrnekClass
    {
        public OrnekClass2(int a, int b) : base(a, b)
        {
        }

        //public OrnekClass2()
        //{
        //    Console.WriteLine("OrnekClass2 Oluşturuldu.");
        //}
        public void Yaz()
        {
            Console.WriteLine($"{A} {B}");
        }
        protected void C(int y)
        {
            Console.WriteLine(y);
        }
        public override void D(int x)
        {
            Console.WriteLine(x*x);
        }
    }
    public class OrnekClass3
    {
        internal int A { get; set; }
        protected int B { get; set; }
        public virtual int C { get; set; }
    }
}
