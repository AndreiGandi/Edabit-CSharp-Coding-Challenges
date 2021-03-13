using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_All_Bigrams_Exist
{
    class Program
    {
        //You are given an input array of bigrams, and an array of words.
        //Write a function that returns true if every single bigram from this array can be found at least once in an the list of words.

        //CanFind(new string[] { "at", "be", "th", au" }, new string[] { "beautiful", "the", "hat" }) ➞ true
        //CanFind(new string[] { "ay", "be", "ta", cu" }, new string[] { "maybe", "beta", "abet", "course" }) ➞ false
        //// "cu" does not exist in any of the words.
        //CanFind(new string[] { "th", "fo", "ma", or" }, new string[] { "the", "many", "for", "forest" }) ➞ true
        //CanFind(new string[] { "oo", "mi", "ki", la" }, new string[] { "milk", "chocolate", "cooks" }) ➞ false

        static void Main(string[] args)
        {
            Console.WriteLine(CanFind(new string[] { "at", "be", "th", "au" }, new string[] { "beautiful", "the", "hat"}));
            Console.WriteLine(CanFind(new string[] { "ay", "be", "ta", "cu" }, new string[] { "maybe", "beta", "abet", "course" }));
            Console.WriteLine(CanFind(new string[] { "th", "fo", "ma", "or" }, new string[] { "the", "many", "for", "forest" }));
        }
        public static bool CanFind(string[] bigrams, string[] words)
        {
            
            if (words.Count() == 0)
                return false;
            bool checker;
            for (int i=0; i<bigrams.Length; i++)
            {
                checker = false;
                for(int j = 0; j<words.Length; j++)
                {
                    if (words[j].Contains(bigrams[i]))
                        checker = true;
                }
                if (!checker)
                    return false;
            }
            return true;
        }
    }
}
