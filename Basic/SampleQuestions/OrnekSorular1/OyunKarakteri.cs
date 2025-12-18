using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    internal class OyunKarakteri
    {
        public OyunKarakteri(string? ad, byte enerji)
        {
            Ad = string.IsNullOrWhiteSpace(ad) ? "Bot_Ad" : ad;

            if (enerji >= 0 && enerji <= 100)
            {
                Enerji = enerji;
            }
            else
            {
                Console.WriteLine("Enerji düzeyi 0 ile 100 arasında olmalıdır. Varsayılan olarak 100 atanmıştır.");
                Enerji = 100;
            }
        }

        private string? Ad { get; set; }
        private byte Enerji { get; set; }

        public void EnerjiKaybet(byte miktar)
        {
            if (miktar > Enerji)
            {
                Console.WriteLine($"{Ad}, bu kadar enerji kaybedemez. Mevcut enerjisi: {Enerji}");
            }
            else
            {
                Enerji -= miktar;
                Console.WriteLine($"{Ad}, {miktar} enerji kaybetti. Yeni enerji seviyesi: {Enerji}");
            }
        }

        public void EnerjiKazan(byte miktar)
        {
            if (Enerji == 100)
            {
                Console.WriteLine($"{Ad}, zaten maksimum enerji seviyesinde (100). Enerji kazanamaz.");
            }
            else
            {
                byte eskiEnerji = Enerji;
                Enerji = (byte)Math.Min(Enerji + miktar, 100);
                Console.WriteLine($"{Ad}, {miktar} enerji kazandı. Eski enerji: {eskiEnerji}, Yeni enerji: {Enerji}");
            }
        }
    }
}
