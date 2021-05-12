using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_Kolekce_050_Frekvence_znaku
{
    class Program
    {
        static void Main(string[] args)
        {
            //načtení textu
            string text = System.IO.File.ReadAllText(@"temno.txt");
            //výpis pro kontrolu, smažte si nebo zakomentujte
            //Console.WriteLine(text);


            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char chr in text.ToLower())
            {
                if (!Char.IsLetter(chr))
                    continue;
                //když tam slovo už je
                if (counts.ContainsKey(chr))
                {
                    //přidej 1 k počtu
                    counts[chr]++;
                }
                //jinak slovo zaveď 
                else
                {
                    //s počtem 1
                    counts[chr] = 1;
                }
            }

            int sum = counts.Select(x => x.Value).Sum();

            var sorted = counts.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} ({((double)pair.Value) / sum * 100:0.00}%)");
            }
        }
    }
}
