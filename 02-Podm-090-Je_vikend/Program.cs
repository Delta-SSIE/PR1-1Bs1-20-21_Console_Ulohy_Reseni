using System;

namespace _02_Podm_090_Je_vikend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo dne (1-7): ");
            int cislo = int.Parse(Console.ReadLine());

            if (cislo > 0 && cislo < 6)
            {
                Console.WriteLine("Není víkend.");
            }
            else if (cislo > 5 && cislo < 8)
            {
                Console.WriteLine("Je víkend.");
            }
            else
            {
                Console.WriteLine("Toto není den v týdnu");
            }
        }
    }
}
