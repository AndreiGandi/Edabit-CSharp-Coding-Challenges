using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_Odd_Length_Words
{
    class Program
    {
        //Given a string, reverse all the words which have odd length.The even length words are not changed.
        //ReverseOdd("Bananas") ➞ "sananaB"
        //ReverseOdd("One two three four") ➞ "enO owt eerht four"
        //ReverseOdd("Make sure uoy only esrever sdrow of ddo length") ➞ "Make sure you only reverse words of odd length"
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseOdd("One two three four"));
        }
        public static string ReverseOdd(string str)
        {
            string[] words = str.Split(' ');
            string result = "";
            foreach (var word in words)
            {
                if (word.Length % 2 == 0)
                    result += word + " ";
                else
                    result += Reverse(word) + " ";
            }
            return result.TrimEnd();
        }
        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        
    }
}
