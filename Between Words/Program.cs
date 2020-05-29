using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //isBetween("apple", "banana", "azure") ➞ true
            Console.WriteLine(isBetween("apple", "banana", "azure"));
        }
        public static bool isBetween(string first, string last, string word)
        {
            List<string> words = new List<string>();
            words.Add(first);
            words.Add(last);
            words.Add(word);
            words.Sort();

            if (words[1] == word)
                return true;
            return false;

        }
        public static bool isBetween_v2(string first, string last, string word)
        {
            if ((string.Compare(word, first) > 0) && (string.Compare(word, last) < 0))
                return true;
            else
                return false;
        }
    }

}
