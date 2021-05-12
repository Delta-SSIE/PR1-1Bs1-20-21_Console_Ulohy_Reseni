using System;
using System.Collections.Generic;

namespace _13_Kolekce_030_List_Nacitani
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mojecisla = NactiCisla();
            Console.WriteLine(String.Join(", ", mojecisla));
        }

        static int[] NactiCisla ()
        {
            Console.WriteLine("Zadávej celá čísla, příkaze q ukončíš");

            List<int> cisla = new List<int>();

            while (true)
            {
                Console.Write("Číslo: ");
                string nacteno = Console.ReadLine();
                if (nacteno.ToLower() == "q")
                    break;

                try
                {
                    int cislo = int.Parse(nacteno);
                    cisla.Add(cislo);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Toto není celé číslo");
                }
            }

            return cisla.ToArray();

        }
    }
}
