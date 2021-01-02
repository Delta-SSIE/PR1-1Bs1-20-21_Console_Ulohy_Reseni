using System;

namespace _05_Pole_040_Podmineny_soucet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uložte si do pole cisla tyto hodnoty:

            //25
            //- 56
            //- 88
            //5
            //10
            //65
            //584
            //- 8
            //- 120
            //186
            int[] cisla = new int[] { 25, -56, -88, 5, 10, 65, 584, -8, -120, 186 };

            //Potom napište program, který sečte všechna, která jsou mezi -10 a 10 a součet vypíše. 
            //Pro vzorová data byste měli dostat odpověď 5 + (-8) = -3

            //proměnná pro součet
            int suma = 0;

            //projdu všechny indexy v poli
            for (int i = 0; i < cisla.Length; i++)
            {
                //když číslo na aktuálním indexu splňuje podmínky
                if (cisla[i] > -10 && cisla[i] < 10)
                    //přičtu ho
                    suma += cisla[i];
            }

            Console.WriteLine($"Součet čísel mezi -10 a 10 je {suma}.");
        }
    }
}
