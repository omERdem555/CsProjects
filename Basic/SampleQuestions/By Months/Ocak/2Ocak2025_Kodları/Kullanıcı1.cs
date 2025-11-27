using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ocak2025_Kodları
{
    internal class Kullanıcı1
    {
        public Kullanıcı1(int sifre)
        {
            Sifre = sifre;
        }


        private int Sifre;

        public int sifre
        {
            get { return Sifre; }
            set
            {
                if (value.ToString().Length > 4 && value.ToString().Length < 8)
                {
                    if (int.TryParse(value.ToString(), out value))
                    {
                        Sifre = value;
                    }
                }
            }
        }
    }
}
