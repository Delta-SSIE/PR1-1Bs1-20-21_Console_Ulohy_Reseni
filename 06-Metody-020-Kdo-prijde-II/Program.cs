using System;

namespace _06_Metody_020_Kdo_prijde_II
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = Prijde("Karel"); //zde uložím návratovou hodnotu do proměnné
            Console.WriteLine(text);
        }
        public static string Prijde(string jmeno)
        {
            return $"Přijde také {jmeno}.";
        }
    }
}
