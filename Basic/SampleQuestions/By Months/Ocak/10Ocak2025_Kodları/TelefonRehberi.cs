using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Ocak2025_Kodları
{
    enum Rehber
    {
        Ekle = 1,
        Sil,
        Ara,
        Listele,
        Çıkış
    }
    internal class TelefonRehberi
    {

        Dictionary<long, string> Kişiler;

        public TelefonRehberi(Dictionary<long, string> kişiler)
        {
            Kişiler = kişiler;
            new Dictionary<long, string>();
        }
        public static void Ekle(Dictionary<long, string> kişi)
        {
            if (!Kişiler.ContainsKey(kişi.Keys.First()))
            {
                Kişiler.Add(kişi.Keys.First(), kişi.Values.First());
            }
            else
                throw new Exception("Bu kişi zaten rehberde kayıtlıdır.");
        }
        public static void Sil(Dictionary<long, string> kişi)
        {
            if (Kişiler.Remove(kişi.Keys.First()))
            {
            }
            else throw new Exception("Böyle bir kişi bulunamamaktadır");
        }
        public static void Ara(Dictionary<long, string> kişi)
        {
            if (Kişiler.ContainsKey(kişi.Keys.First()))
            {
                Console.WriteLine($"{kişi.Values} telefon numarsı: {kişi.Keys}");
            }
            else throw new Exception("Böyle bir kişi bulunamamaktadır");
        }
        public void Listele()
        {
            if (Kişiler.Count != 0)
            {
                foreach (var kişi in Kişiler)
                {
                    Console.WriteLine($"{kişi.Value} {kişi.Key}");
                }
            }
        }
    }

}

