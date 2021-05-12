using System;
using System.Collections.Generic;

namespace _13_Kolekce_040_Dictionary_Slovnik
{
    class Program
    {

        enum Mode { Learn, Translate }
        static void Main(string[] args)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            Mode mode = Mode.Learn;
            Console.WriteLine("Učicí a překládací režim přepnete příkazem '-', příkaz '*' program ukončí.");

            while (true)
            {
                if (mode == Mode.Learn)
                {
                    string en;
                    do {
                        Console.Write("Zadejte slovo anglicky: ");
                        en = Console.ReadLine().Trim();
                    } while (en.Length == 0);
                    
                    if (en == "-")
                    {
                        mode = Mode.Translate;
                        Console.WriteLine("Zapnut režim překladu");
                        continue;
                    }
                    else if (en == "*")
                    {
                        break;
                    }

                    string cs;
                    do
                    {
                        Console.Write("Zadejte slovo česky: ");
                        cs = Console.ReadLine().Trim();
                    } while (cs.Length == 0);

                    dictionary[en] = cs;
                }

                else

                {
                    string en;
                    do
                    {
                        Console.Write("Jaké anglické slovo chcete přeložit: ");
                        en = Console.ReadLine().Trim();
                    } while (en.Length == 0);

                    if (en == "-")
                    {
                        mode = Mode.Learn;
                        Console.WriteLine("Zapnut režim učení");
                        continue;
                    }
                    else if (en == "*")
                    {
                        break;
                    }

                    try
                    {
                        Console.WriteLine("Česky: " + dictionary[en]);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Toto slovo nemám uloženo");
                    }
                
                }
            }
        }
    }
}
