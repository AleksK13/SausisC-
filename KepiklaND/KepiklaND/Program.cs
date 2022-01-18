using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KepiklaND
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek darbuotojas gali iskepti kepalu per valanda?");
            int kiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek darbuotoju turi kepikla?");
            int kepiklu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vieno kepalo savikaina yra:");
            double savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vieno kepalo pardavimo kaina yra:");
            double kaina = Convert.ToDouble(Console.ReadLine());
            int iskepta = 8 * kiekis * kepiklu;
            double pajamos = iskepta * kaina;
            double pelnas = iskepta * (kaina - savikaina);

            Console.WriteLine("Per diena:");
            Console.WriteLine($"Kepalu iskepta {iskepta}");
            Console.WriteLine($"Kepalu savikaina: {savikaina*iskepta} EUR");
            Console.WriteLine($"Kepiklos pajamos pardavus {iskepta} vnt. kepalu: {pajamos} EUR");
            Console.WriteLine($"Pelnas yra: {pelnas} EUR");

            Console.ReadLine();
        }
    }
}
