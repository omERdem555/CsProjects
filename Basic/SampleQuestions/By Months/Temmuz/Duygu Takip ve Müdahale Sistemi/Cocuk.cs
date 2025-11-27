using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duygu_Takip_ve_Müdahale_Sistemi
{
    internal class Cocuk : Insan
    {
        public Cocuk(string? ıD, string? ad, int yas,Durumlar guncelDurum) : base(ıD, ad, yas, guncelDurum)
        {
        }

        public override void TepkiVer(string tepki, string birim = "Cocuk")
        {
            Console.WriteLine($"Cocuk {GuncelDurum}'a {tepki} duyduğunu ve ");
            MudaheleYap(birim);
            Console.Write("mesajını verdi");
        }
    }
}
