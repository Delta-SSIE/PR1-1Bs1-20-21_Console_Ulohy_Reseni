using System;
using System.Collections.Generic;

namespace _13_Kolekce_020_List_Nasobky
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", Nasobky(90, 100)));
            //mělo by vypsat 92, 93, 94, 98, 99, 100

            Console.WriteLine(String.Join(", ", Nasobky(10000, 10010)));
            //mělo by vypsat 10000, 10004, 10005, 10006, 10010
        }

        public static int[] Nasobky(int min, int max)
        {
            List<int> cisla = new List<int>();
            for (int i = min; i <= max; i++)
            {
                if (i % 6 != 0 && (i % 2 == 0 || i % 3 == 0))
                    cisla.Add(i);
            }
            return cisla.ToArray();
        }
    }
}
