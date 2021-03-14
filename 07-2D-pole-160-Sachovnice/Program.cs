using System;

namespace _07_2D_pole_160_Sachovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] sachovnice = VytvorSachovnici();
            VykresliSachovnici(sachovnice);

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Tah(sachovnice, 'E', 2, 'E', 4);
            VykresliSachovnici(sachovnice);

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Tah(sachovnice, 'E', 7, 'E', 5);
            VykresliSachovnici(sachovnice);

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Tah(sachovnice, 'G', 1, 'F', 3);
            VykresliSachovnici(sachovnice);

            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Tah(sachovnice, 'B', 8, 'C', 6);
            VykresliSachovnici(sachovnice);

        }

        static void VykresliSachovnici(char[,] sachovnice)
        {
            Console.WriteLine();
            for (int radek = 7; radek >= 0; radek--)
            {
                Console.Write("  ");
                for (int sloupec = 0; sloupec < 8; sloupec++)
                {
                    if (JeBile(radek, sloupec))
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.Write(sachovnice[sloupec, radek] + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }

        static bool JeBile(int radek, int sloupec)
        {
            return (radek + sloupec) % 2 == 0;
        }

        static char[,] VytvorSachovnici()
        {
            char[,] sachovnice = new char[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    sachovnice[i, j] = ' ';
                }
            }

            sachovnice[0, 0] = sachovnice[0, 7] = sachovnice[7, 0] = sachovnice[7, 7] = 'R'; //veze
            sachovnice[1, 0] = sachovnice[1, 7] = sachovnice[6, 0] = sachovnice[6, 7] = 'N'; //jezdci
            sachovnice[2, 0] = sachovnice[2, 7] = sachovnice[5, 0] = sachovnice[5, 7] = 'B'; //strelci
            sachovnice[3, 0] = sachovnice[3, 7] = 'Q'; //kralovny
            sachovnice[4, 0] = sachovnice[4, 7] = 'K'; //kralove

            for (int i = 0; i < 8; i++)
            {
                sachovnice[i, 1] = 'p';
                sachovnice[i, 6] = 'p';
            }

            return sachovnice;
        }

        static void Tah(char[,] sachovnice, char sloupecZ, int radekZ, char sloupecKam, int radekKam)
        {
            sachovnice[sloupecKam - 'A', radekKam - 1] = sachovnice[sloupecZ - 'A', radekZ - 1];
            sachovnice[sloupecZ - 'A', radekZ - 1] = ' ';
        }
    }
}
