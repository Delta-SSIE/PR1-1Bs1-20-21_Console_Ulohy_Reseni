using System;

namespace _05_Pole_060_Ceho_je_vic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uložte si do pole cisla tyto hodnoty:

            //-20
            //11
            //0
            //10
            //- 7
            //12
            //- 83
            //0
            //0
            //15

            int[] cisla = { -20, 11, 0, 10, -7, 12, -83, 0, 0, 15 };

            //Potom napište program, který odpoví, zda je v poli víc záporných hodnot. kladných hodnot, nebo zda je jich stejně. Vyzkoušejte změnou zadání pole, že program opravdu funguje.

            int kladna = 0;
            int zaporna = 0;
            
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] > 0)
                    kladna++;
                else if (cisla[i] < 0)
                    zaporna++;
            }

            if (kladna > zaporna)
                Console.WriteLine("Kladných je v poli víc");
            else if (zaporna > kladna)
                Console.WriteLine("Záporných je v poli víc");
            else
                Console.WriteLine("Kladných je v poli stejně jako záporných");


            //Alternativní řešení
            int ukazatel = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] > 0)
                    ukazatel++;
                else if (cisla[i] < 0)
                    ukazatel--;
            }

            if (ukazatel > 0)
                Console.WriteLine("Kladných je v poli víc");
            else if (ukazatel < 0)
                Console.WriteLine("Záporných je v poli víc");
            else
                Console.WriteLine("Kladných je v poli stejně jako záporných");
        }
    }
}
