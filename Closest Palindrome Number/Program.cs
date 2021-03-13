using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Palindrome_Number
{
    class Program
    {
        //Write a function that returns the closest palindrome number to an integer.If two palindrome numbers tie in absolute distance, return the smaller number.
        //If the number itself is a palindrome, return that number.
        //ClosestPalindrome(887) ➞ 888
        //ClosestPalindrome(100) ➞ 99
        //// 99 and 101 are equally distant, so we return the smaller palindrome.
        //ClosestPalindrome(888) ➞ 888
        //ClosestPalindrome(27) ➞ 22
        static void Main(string[] args)
        {
            Console.WriteLine(ClosestPalindrome(27));
        }
        public static int ClosestPalindrome(int num)
        {
            if (IsPalindrome(num)) return num;
            else
            {
                int high = num + 1;
                int low = num - 1;
                while(true)
                {
                    if (IsPalindrome(low)) return low;
                    else low--;
                    if (IsPalindrome(high)) return high;
                    else high++;
                }
            }

        }
        public static bool IsPalindrome(int num)
        {
            int aux = num;
            int reverseNum = 0;
            while (aux != 0)
            {
                reverseNum = reverseNum * 10 + aux % 10;
                aux /= 10;
            }
            if (reverseNum == num)
                return true;
            return false;
        }
        //using strings
        public static bool IsPalindrome(string num)
        {
            char[] letters = num.ToCharArray();
            Array.Reverse(letters);
            string reverseNum = new string(letters);
            if (num == reverseNum)
                return true;
            return false;
        }
    }
}
