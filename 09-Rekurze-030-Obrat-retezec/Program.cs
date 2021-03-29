using System;

namespace _09_Rekurze_030_Obrat_retezec
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Obrat("Hello World!")); //vypíše !dlroW olleH
        }

        static string Obrat(string retezec)
        {
            if (retezec.Length == 0)
                return ""; //řetězec má délku nula, není co obracet, vrátím prázdný řetězec a končím

            return retezec[retezec.Length - 1] + Obrat(retezec.Substring(0, retezec.Length - 1)); //vrátím poslední znak + obrácený podřetězec bez posledního znaku
            
            // v nejnovější verzi jazyka C# lze místo pozledního řádku použít zjednodušenou syntaxi pro index/range
            return retezec[^1] + Obrat(retezec[0..^1]); //zápis odkud .. kam, ^1 znamená "jeden od konce"
        }
    }
}
