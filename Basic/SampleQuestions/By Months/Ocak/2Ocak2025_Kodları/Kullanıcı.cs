using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    public class Kullanıcı
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private int Yas;

        public Kullanıcı(string ad, string soyad, int yas)
        {
            Ad = ad;
            Soyad = soyad;
            this.yas = yas;
        }

        private int yas
        {
            get { return Yas; }
            set
            {
                if (value > 0 && value < 150)
                {
                    Yas = value;
                    Console.WriteLine(Yas);
                }
                else
                {
                    throw new Exception("0 ile 150 arasında değerler veriniz");
                }
            }
        }

        public void BilgileriGoster()
        {

            Console.WriteLine($" kullanıcı adi: {Ad}  kullanıcısoyadı:{Soyad} kullanıcıyasi{Yas}");
        }

    }
}

