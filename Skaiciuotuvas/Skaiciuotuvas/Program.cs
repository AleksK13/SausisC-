using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvas
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "T";    
            
                    while (input=="T")
            {
                
                Console.WriteLine("Iveskite du skaicius");
                Console.WriteLine("Pirmas:");
                int skaicius1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Antras:");
                int skaicius2 = Convert.ToInt32(Console.ReadLine());

                Veiksmai(skaicius1, skaicius2);
                Console.WriteLine("Jeigu norite pakartot paspauskite raide 't'");
                input = Console.ReadLine().ToUpperInvariant();

            }
                    

        

        }
        
        static void Veiksmai(int skaicius1, int skaicius2)
        {
            Console.WriteLine("Koki veiksma norit atlikt?(+,-, *, /)");
            string skaiciuojam = Console.ReadLine();

            if (skaiciuojam == "+")
            {
                Console.WriteLine($"{skaicius1} + {skaicius2} = " + (skaicius1+skaicius2));
            }
            else if ( skaiciuojam== "-")
            {
                Console.WriteLine($"{skaicius1} - {skaicius2} = "  + (skaicius1 - skaicius2));
            }
            else if (skaiciuojam == "*")
            {
                Console.WriteLine($"{skaicius1} * {skaicius2} = " + (skaicius1 * skaicius2));
            }
            else if (skaiciuojam == "/")
            {
                if (skaicius2 == 0)
                {
                    Console.WriteLine($"Is {skaicius2} negalima dalint");
                }
                else
                {
                    double dalyba = (double)skaicius1 / skaicius2;
                    Console.WriteLine($"{skaicius1} / {skaicius2} = {dalyba}");
                }
            }
            else
            {
                Console.WriteLine("Neteisingai pasirinktas veiksmas, pasirinkite teisingai");

            }
        }
            
    }
}
