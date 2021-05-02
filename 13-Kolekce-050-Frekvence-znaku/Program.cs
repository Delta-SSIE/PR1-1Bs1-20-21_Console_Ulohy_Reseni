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
            Console.WriteLine(text);

        }
    }
}
