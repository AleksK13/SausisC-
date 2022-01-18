using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            Console.WriteLine("Pirmas:");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antras:");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Trecias:");
            int trecias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pirma saliga:");
            if (pirmas>antras && 100>pirmas)
            {
                Console.WriteLine($"1. {antras} < {pirmas} < 100");
            }
            else {
                Console.WriteLine("skaiciai netenkina pirmos saligos");
            }
            

            Console.WriteLine("Antra saliga");
            if (pirmas < antras && antras > 0)
            {
                Console.WriteLine($"1. {pirmas} < {antras} > 0");
            }
            else
            {
                Console.WriteLine("skaiciai netenkina antros saligos");
            }
            Console.WriteLine("Trecia saliga:");
            if (antras<pirmas && pirmas>trecias || 0<pirmas)
            {
                if (antras < pirmas && pirmas > trecias)
                {
                    Console.WriteLine($"1. {antras} < {pirmas} > {trecias}");
                }
                if (0 < pirmas)
                {
                    Console.WriteLine($"2. {pirmas} yra teigiamas");
                }
            }
            else
            {
                Console.WriteLine("skaiciai netenkina trecios saligos");
            }

            Console.WriteLine("Ketvirta saliga:");
            if (5 <= trecias && trecias <= 10 || trecias > pirmas || trecias > antras)
            {
                if(5 <= trecias && trecias <= 10)
                {
                    Console.WriteLine($"1. {trecias} patenka i rezius nuo 5 iki 10");
                }
                if (trecias > pirmas || trecias > antras)
                {
                    
                    if(trecias>pirmas)
                    {
                        Console.WriteLine($"2. {trecias} > {pirmas}");
                    }
                    else if (trecias > antras)
                    {
                        Console.WriteLine($"3. {trecias} > {antras}");
                    }
                }
                 
            }
            else
            {
                Console.WriteLine("skaiciai netenkina ketvirtos saligos");
            }

            Console.ReadLine();
        }
    }
}
