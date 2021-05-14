using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Kolekce_060_Dictionary_Morse_Zpetny_preklad
{
    class MorseDecoder
    {
        private Dictionary<string, char> _table;

        public MorseDecoder()
        {
            FillTable();
        }

        public string Decode(string message)
        {
            string[] letters = message.Split('/');
            string translated = "";
            foreach (string morseLetter in letters)
            {
                if (morseLetter.Length > 0)
                    translated += DecodeChar(morseLetter);
                else
                    translated += ' ';
            }
            return translated;
        }

        public char DecodeChar(string str)
        {
            try
            {
                return _table[str];
            }
            catch (Exception)
            {
                return '?';
            }
        }

        private void FillTable()
        {
            _table = new Dictionary<string, char>();
            _table["-----"] = '0';
            _table[".----"] = '1';
            _table["..---"] = '2';
            _table["...--"] = '3';
            _table["....-"] = '4';
            _table["....."] = '5';
            _table["-...."] = '6';
            _table["--..."] = '7';
            _table["---.."] = '8';
            _table["----."] = '9';
            _table[".-"] = 'a';
            _table["-..."] = 'b';
            _table["-.-."] = 'c';
            _table["-.."] = 'd';
            _table["."] = 'e';
            _table["..-."] = 'f';
            _table["--."] = 'g';
            _table["...."] = 'h';
            _table[".."] = 'i';
            _table[".---"] = 'j';
            _table["-.-"] = 'k';
            _table[".-.."] = 'l';
            _table["--"] = 'm';
            _table["-."] = 'n';
            _table["---"] = 'o';
            _table[".--."] = 'p';
            _table["--.-"] = 'q';
            _table[".-."] = 'r';
            _table["..."] = 's';
            _table["-"] = 't';
            _table["..-"] = 'u';
            _table["...-"] = 'v';
            _table[".--"] = 'w';
            _table["-..-"] = 'x';
            _table["-.--"] = 'y';
            _table["--.."] = 'z';
            _table["/"] = ' ';
            _table["-.-.--"] = '!';
            _table[".-.-.-"] = '.';
            _table["--..--"] = ';';
        }
    }
}
