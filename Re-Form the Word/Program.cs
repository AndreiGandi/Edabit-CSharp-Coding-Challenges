using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Form_the_Word
{
    class Program
    {
        //A word has been split into a left part and a right part.Re-form the word by adding both halves together, changing the first character to an uppercase letter.
        //GetWord("seas", "onal") ➞ "Seasonal"
        //GetWord("comp", "lete") ➞ "Complete"
        //GetWord("lang", "uage") ➞ "Language"

        static void Main(string[] args)
        {
            Console.WriteLine(GetWord("seas", "onal"));

        }


        public static string GetWord(string left, string right)
        {
            var firstLetter = char.ToUpper(left[0]);
            return firstLetter.ToString() + left.Substring(1, left.Length - 1) + right;
        }
    }
}
