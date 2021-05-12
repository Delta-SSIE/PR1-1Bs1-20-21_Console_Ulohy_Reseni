using System;
using System.Collections.Generic;

namespace _13_Kolekce_010_List_Filtrovani
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] slova1 = { "Gorila Nížinná", "pelikán", "myš", "kapr", "Slavík obecný" };
            string[] mala1 = JenMala(slova1);
            Console.WriteLine(mala1.Length); //mělo by vypsat 3 
            Console.WriteLine(String.Join(", ", mala1)); //mělo by vypsat vše mimo Gorily a Slavíka

            string[] slova2 = { "Josef", "Eman", "Karel", "Jiří" };
            string[] mala2 = JenMala(slova2);
            Console.WriteLine(mala2.Length); //mělo by vypsat 0 - pole je prázdné        
        }

        public static string[] JenMala(string[] slova)
        {
            List<string> vybrano = new List<string>();
            foreach (string slovo in slova)
            {
                if (slovo == slovo.ToLower())
                    vybrano.Add(slovo);
            }
            return vybrano.ToArray();
        }
    }
}
