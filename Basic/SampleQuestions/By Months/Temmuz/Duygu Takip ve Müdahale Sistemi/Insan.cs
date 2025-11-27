using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duygu_Takip_ve_Müdahale_Sistemi
{
    internal class Insan: ITepkiVer, IMudaheleYap
    {
        public Insan(string? ıD, string? ad, int yas, Durumlar guncelDurum)
        {
            ID = !string.IsNullOrEmpty(ıD) ? ıD : throw new ArgumentNullException(nameof(ıD), "ID boş olamaz.");
            Ad = !string.IsNullOrEmpty(ad) ? ad : throw new ArgumentNullException(nameof(ad), "Ad boş olamaz.");
            Yas = (yas > 0) ? yas : throw new ArgumentException(nameof(yas), "Yaş değeri 0'dan büyük olmak zorundadır.");
            GuncelDurum = guncelDurum;
        }

        public string? ID { get; set; }
        public string? Ad { get; set; }
        public int Yas { get; set; }
        public Durumlar GuncelDurum { get; set; }

        public void MudaheleYap(string birim)
        {
            switch (GuncelDurum)
            {
                case Durumlar.Mutlu:
                    Console.Write($"{birim} mutlu olduğunda destekleyici bir tepki verilir.");
                    break;
                case Durumlar.Üzgün:
                    Console.Write($"{birim} üzgün olduğunda teselli edici bir tepki verilir.");
                    break;
                case Durumlar.Kaygılı:
                    Console.Write($"{birim} kaygılı olduğunda rahatlatıcı bir tepki verilir.");
                    break;
                case Durumlar.Kızgın:
                    Console.Write($"{birim} kızgın olduğunda sakinleştirici bir tepki verilir.");
                    break;
                case Durumlar.Korkmuş:
                    Console.Write($"{birim} korkmuş olduğunda güven verici bir tepki verilir.");
                    break;
                case Durumlar.Sıkılmış:
                    Console.Write($"{birim} sıkılmış olduğunda eğlendirici bir tepki verilir.");
                    break;
                case Durumlar.Şaşırmış:
                    Console.Write($"{birim} şaşırmış olduğunda açıklayıcı bir tepki verilir.");
                    break;
                case Durumlar.Rahatlamış:
                    Console.Write($"{birim} rahatlamış olduğunda destekleyici bir tepki verilir.");
                    break;
                case Durumlar.Endişeli:
                    Console.Write($"{birim} endişeli olduğunda sakinleştirici bir tepki verilir.");
                    break;
                case Durumlar.İlgisiz:
                    Console.Write($"{birim} ilgisiz olduğunda dikkat çekici bir tepki verilir.");
                    break;
                case Durumlar.Umutlu:
                    Console.Write($"{birim} umutlu olduğunda teşvik edici bir tepki verilir.");
                    break;
                case Durumlar.HayalKırıklığınaUğramış:
                    Console.Write($"{birim} hayal kırıklığına uğradığında destekleyici bir tepki verilir.");
                    break;
                case Durumlar.MotivasyonEksikliği:
                    Console.Write($"{birim} motivasyon eksikliği yaşadığında teşvik edici bir tepki verilir.");
                    break;
                case Durumlar.Yorgun:
                    Console.Write($"{birim} yorgun olduğunda dinlendirici bir tepki verilir.");
                    break;
                default:
                    Console.Write("Bilinmeyen bir durum için müdahale yapılamadı.");
                    break;
            }
        }

        public virtual void TepkiVer(string tepki, string birim = "Insan")
        {
            Console.WriteLine($"İnsan {GuncelDurum}'a {tepki} duyduğunu ve ");
            MudaheleYap(birim);
            Console.Write("mesajını verdi");
        }

    }
}
