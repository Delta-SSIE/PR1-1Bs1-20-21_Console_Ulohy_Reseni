using System;

namespace _09_Rekurze_040_Jsou_vsechna_kladna
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] pole1 = { 1.2, 3.65, 4.28, 1.1, 2.8, -1.2 };
            double[] pole2 = { -1.2, 3.65, 4.28, 1.1, 2.8, -1.2, 4.2 };
            double[] pole3 = { 1.2, 3.65, 4.28, 1.1, 2.8 };
            double[] pole4 = { 1 };
            double[] pole5 = { 0 };

            Console.WriteLine(VsechnaKladna(pole1)); //false
            Console.WriteLine(VsechnaKladna(pole2)); //false
            Console.WriteLine(VsechnaKladna(pole3)); //true
            Console.WriteLine(VsechnaKladna(pole4)); //true
            Console.WriteLine(VsechnaKladna(pole5)); //false
        }

        static bool VsechnaKladna(double[] pole, int pozice = 0)
        {
            if (pozice == pole.Length)
                return true; //vlezl jsem za poslední člen, tím pádem nemohu najít něco nezáporného, končím bez hlášení chyby

            return pole[pozice] > 0 && VsechnaKladna(pole, pozice + 1); //vrátím zna je tento prvek kladný a zároveň i všechny za ním
        }
    }
}
