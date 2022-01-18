using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeliojimoZaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sk = rnd.Next(1, 10);
            
            while (true)
            {
                Console.WriteLine(sk);
                Console.WriteLine("Atspekite skaiciu nuo 1 iki 10:");
                int isk = Convert.ToInt32(Console.ReadLine());
                if (isk > sk)
                {
                    Console.WriteLine($"Slaptas skaicius yra mazesnis ");
                }
                else if (isk < sk)
                {
                    Console.WriteLine($"Slaptas skaicius yra didesnis ");
                }
                else
                    break;
                    
                
                
            }
            Console.WriteLine("Atspejai!!!");
            Console.ReadLine();
            
        }
    }
}
