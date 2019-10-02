using HaromszogekSzoftverfejleszto.Tarolo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogekSzoftverfejleszto
{
    class Program
    {
        static void Main(string[] args)
        {
            Haromszogek h = new Haromszogek();
            h.beolvas();
            Console.WriteLine("Háromszögek száma:" + h.getHaromszogekSzama());
            Console.WriteLine("Adja meg a háromszög sorszámát:");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            if (h.szerkeszthetoE(sorszam))
                Console.WriteLine("A háromszog szerkeszthető.");
            else Console.WriteLine("A háromszög nem szerkeszthető.");
            
            Console.WriteLine(h.getSzerkeszthetoHaromszogekOsszterulete() + " a szerkeszthető háromszögek összterülete.");
            Console.ReadKey();
        }
    }
}
