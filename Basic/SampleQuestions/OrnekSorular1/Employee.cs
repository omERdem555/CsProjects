using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSorular1
{
    public class Employee
    {
        private string? Ad;
        private string? Soyad;
        private Departman? Departman;
        private decimal Maas;
        private DateTime Tarih;

        public Employee(string? ad, string? soyad, Departman? departman, decimal maas, DateTime tarih)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
            if (maas > 0)
                Maas = maas;
            else
                maas = 0;
            Tarih = tarih;
        }

        void CalisanBilgileriniGoster()
        {
            Console.WriteLine($"{Ad} {Soyad} çalışanı {Maas} kadar {Departman} {Tarih}");
        }

        static decimal maasToplam = 0;


    }

    public class Departman
    {
        private string? DepartmanAdi;
        private Employee? DepartmanBaskan;
        private List<Employee>? Calisanlar;

        void DepartmanBilgisiniGoster()
        {
            Console.WriteLine($"{DepartmanAdi} {DepartmanBaskan} {Calisanlar}");
        }

        decimal tMaas = 0;
    }
}
