using System;

namespace _05_Pole_070_Dlouhe_retezce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vyzvěte uživatele, aby vám zadal 5 řetězců (např.jmen) a uložte si je do pole.
            //Poté mu vypište ty z jeho řetězců, které mají délku alespoň 6 znaků.        

            int pocet = 5;
            int minDelka = 6;

            Console.WriteLine($"Zadej {pocet} řetězců");

            //založím si pole pro ukládání
            string[] data = new string[pocet];

            //načtu vše
            for (int i = 0; i < pocet; i ++)
            {
                Console.Write($"{i+1}. řetězec: ");
                data[i] = Console.ReadLine();
            }

            Console.WriteLine($"Ze zadaných řetězců jsou alespoň {minDelka}-znakové tyto:");
            
            //vypíšu filtrovaná data
            for (int i = 0; i < pocet; i++)
            {
                string aktualni = data[i];
                if (aktualni.Length >= minDelka)
                    Console.WriteLine(aktualni);
            }

        }
    }
}
