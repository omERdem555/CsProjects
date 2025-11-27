using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duygu_Takip_ve_Müdahale_Sistemi
{
    internal class Yetiskin : Insan
    {
        public Yetiskin(string? ıD, string? ad, int yas,Durumlar guncelDurum) : base(ıD, ad, yas, guncelDurum)
        {
        }

        public override void TepkiVer(string tepki, string birim = "Yetiskin")
        {
            Console.WriteLine($"{birim} {GuncelDurum}'a {tepki} duyduğunu ve ");
            MudaheleYap(birim);
            Console.Write("mesajını verdi");
        }
    }
}
