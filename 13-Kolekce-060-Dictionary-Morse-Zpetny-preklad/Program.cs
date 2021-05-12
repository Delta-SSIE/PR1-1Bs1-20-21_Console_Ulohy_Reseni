using System;

namespace _13_Kolekce_060_Dictionary_Morse_Zpetny_preklad
{
    class Program
    {
        static void Main(string[] args)
        {
            MorseDecoder decoder = new MorseDecoder();
            Console.WriteLine(decoder.Decode(".-/..../---/.---//-.../---/-..././a"));
        }

    }
}
