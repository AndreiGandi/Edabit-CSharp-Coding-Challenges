using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Letters_With_Position_In_Alphabet
{
    class Program
    {
        //AlphabetIndex("Wow, does that work?")
        //➞ "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11"
        //AlphabetIndex("The river stole the gods.")
        //➞ "20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19"
        //AlphabetIndex("We have a lot of rain in June.")
        //➞ "23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5"
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetIndex("Wow, does that work?"));
        }
        public static string AlphabetIndex(string str)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<str.Length; i++)
            {
                for(int j = 0; j<letters.Length; j++)
                {
                    if(Char.ToLower(str[i]) == letters[j])
                    {
                        sb.Append((j+1).ToString()+" ");
                    }
                }
            }
            return sb.ToString().Remove(sb.Length-1);
        }

        public static string AlphabetIndex_V2(string str)
        {
            var alphabet = "_abcdefghijklmnopqrstuvwxyz";
            var indexStr = new StringBuilder();

            foreach (char c in str.ToLower())
            {
                if (Char.IsLetter(c))
                {
                    indexStr.Append(alphabet.IndexOf(c) + " ");
                }
            }

            return indexStr.ToString().Trim();
        }
    }
}
