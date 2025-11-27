using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _10Ocak2025_Kodları
{
    internal class Kullanıcı
    {
        public Kullanıcı(string? kullaniciAdi, int sifre)
        {
            KullaniciAdi = kullaniciAdi;
            if (int.TryParse(sifre.ToString(), out sifre))
                if (sifre.ToString().Length >= 4 && sifre.ToString().Length <= 8)
                    Sifre = sifre;
                else
                    throw new Exception("Şifrenin uzunluğu 4 ila 8 karakter uzunluğunda olmalıdır\a!");
            else
                throw new Exception("Şifre tamamen ramaklardan oluşmalıdır\a!");
        }

        public string? KullaniciAdi { get; set; }
        public int Sifre { get; set; }
    }
    internal class Toplama
    {
        int tek = 0;
        int cift = 0;
        public void Topla(int[] sayılar)
        {
            foreach (int i in sayılar)
            {
                if (i % 2 == 0)
                    cift += i;
                else
                    tek += i;
            }

            Console.WriteLine($"Verdiğiniz sayılardan çift olanların toplamı: {cift}\n" +
                $"tek olanların toplamı: {tek}");
        }
    }
}
