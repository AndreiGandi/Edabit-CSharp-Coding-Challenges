using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_the_String_is_a_Palindrome
{
    class Program
    {
        //IsPalindrome("Neuquen") ➞ true
        //IsPalindrome("Not a palindrome") ➞ false
        //IsPalindrome("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!") ➞ true

        //Should be case insensitive.
        //Special characters(punctuation or spaces) should be ignored.
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!"));
        }
        public static bool IsPalindrome(string str)
        {
            string cuttedStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetterOrDigit(str[i]))
                    cuttedStr += Char.ToLower(str[i]);
            }
            string temp = cuttedStr;

            char[] reversedStr = temp.ToCharArray();
            Array.Reverse(reversedStr);
            if (cuttedStr == new string(reversedStr))
                return true;



            return false;
        }
    }
}
