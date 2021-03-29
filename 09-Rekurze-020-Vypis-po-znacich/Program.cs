using System;

namespace _09_Rekurze_020_Vypis_po_znacich
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vyznakuj("Hello World!");
        }

        static void Vyznakuj(string retezec)
        {
            if (retezec.Length == 0)
                return; //jsem za posledním znakem, není co psát, končím

            VypisZnak(retezec[0]);//vypíšu první znak
            Vyznakuj(retezec.Substring(1)); //odeberu první znak z řetězce a vypíšu zbytek
        }

        //do této funkce nezasahujte
        static void VypisZnak(char znak)
        {
            Console.Write(znak);
        }
    }
}
