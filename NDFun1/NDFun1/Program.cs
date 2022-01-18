using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDFun1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda:");
            String vardas = Console.ReadLine();

            Console.WriteLine("Iveskite Amziu:");
            int amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite megstama double skaiciu:");
            double skaicius = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Tavo vardas yra {vardas}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Tavo amzius yra {amzius}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Tavo skaicius yra {skaicius}");

            Console.ReadLine();
        }
    }
}
