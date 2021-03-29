using System;

namespace _09_Rekurze_010_Soucet_ctvercu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareSum(1));
            Console.WriteLine(SquareSum(2));
            Console.WriteLine(SquareSum(3));
            Console.WriteLine(SquareSum(45));
        }

        static int SquareSum(int n)
        {
            if (n < 1)
                return 0;
            return n * n + SquareSum(n - 1);
        }
    }
}
