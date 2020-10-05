using System;

namespace _02_Podm_060_Den_v_tydnu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo dne (1-7): ");
            int cislo = int.Parse(Console.ReadLine());

            string den;

            if (cislo == 1)
            {
                den = "pondělí";
            } 
            else if (cislo == 2)
            {
                den = "úterý";
            }
            else if (cislo == 3)
            {
                den = "středa";
            }
            else if (cislo == 4)
            {
                den = "čtvrtek";
            }
            else if (cislo == 5)
            {
                den = "pátek";
            }
            else if (cislo == 6)
            {
                den = "sobota";
            }
            else
            {
                den = "neděle";
            }

            Console.WriteLine($"Dnes je {den}.");
        }
    }
}
