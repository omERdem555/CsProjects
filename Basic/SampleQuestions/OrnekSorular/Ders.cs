using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular
{
    internal class Ders
    {
        public string? DersAdi;
        public byte Kredi;
        public string? HocaAdi;

        public Ders(string? dersAdi, byte kredi, string? hocaAdi)
        {
            DersAdi = dersAdi;
            Kredi = kredi;
            HocaAdi = hocaAdi;
        }
    }
}
