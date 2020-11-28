using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhyme_Time
{
    class Program
    {
        //Create a function that returns true if two lines rhyme and false otherwise.
        //For the purposes of this exercise, two lines rhyme if the last word from each sentence contains the same vowels.
        //Case insensitive.
        //Here we are disregarding cases like "thyme" and "lime".
        //We are also disregarding cases like "away" and "today" (which technically rhyme, even though they contain different vowels).


        static void Main(string[] args)
        {
            Console.WriteLine(DoesRhyme("Sam I am!", "Green eggs and ham.")); //true;
            Console.WriteLine(DoesRhyme("Sam I am!", "Green eggs and HAM.")); //true;
            Console.WriteLine(DoesRhyme("You are off to the races", "a splendid day.")); //false;
            Console.WriteLine(DoesRhyme("and frequently do?", "you gotta move.")); //false;
        }
        public static bool DoesRhyme(string str1, string str2)
        {
            string word1 = str1.Split(' ')[str1.Split(' ').Length-1];
            string word2 = str2.Split(' ')[str2.Split(' ').Length - 1];
            string vowels1 = "";
            string vowels2 = "";

            foreach(var ch in word1)
            {
                if (IsVowel(ch))
                    vowels1 += ch;
            }
            foreach (var ch in word2)
            {
                if (IsVowel(ch))
                    vowels2 += ch;
            }

            return vowels1.ToLower() == vowels2.ToLower();

        }

        public static bool IsVowel(char ch)
        {
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                return true;
            return false;
        }
    }
}
