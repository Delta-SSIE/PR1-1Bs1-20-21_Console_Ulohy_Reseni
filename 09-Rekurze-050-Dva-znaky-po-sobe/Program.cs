using System;

namespace _09_Rekurze_050_Dva_znaky_po_sobe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Dvojznak("midday")); //'d'
            Console.WriteLine(Dvojznak("tommorrow")); //'m'
            Console.WriteLine(Dvojznak("today")); //'\0' - není vidět
        }
        public static char Dvojznak(string retezec)
        {
            if (retezec.Length < 2) //už nemám dva znaky, vracím \0, které znamená nenalezeno
                return '\0';

            else if (retezec[0] == retezec[1]) //první znak je stejný jako druhý, vrátím ho
                return retezec[0];

            else
                return Dvojznak(retezec.Substring(1)); //zkrátím o 1 a vrátím to, co se najde na kratším řetězci
        }
    }
}
