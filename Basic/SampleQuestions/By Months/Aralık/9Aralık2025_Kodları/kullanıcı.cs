using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Aralık2025_Kodları
{
    public class kullanıcı
    {
        public kullanıcı(string kullanıcıAdı, int sifre)
        {
            KullanıcıAdı = kullanıcıAdı;
            if (sifre.ToString().Length >= 4 && sifre.ToString().Length <= 8)
                if (int.TryParse(sifre.ToString(), out sifre))
                    Sifre = sifre;
        }

        public string KullanıcıAdı { get; set; }
        public int Sifre { get; set; }

    }
}
