using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_Number_is_a_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(122));
        }
        //Converting to string 
        //public static bool IsPalindrome(int num)
        //{
        //    string nr = num.ToString();
        //    char[] reverseNr = nr.ToCharArray();
        //    Array.Reverse(reverseNr);

        //    if (nr == new string(reverseNr))
        //        return true;
        //    return false;
        //}

        //Algoritm
        public static bool IsPalindrome(int num)
        {
            int nr = num;
            int reverseNr = 0;
            while(nr != 0)
            {
                reverseNr = reverseNr * 10 + nr % 10;
                nr /= 10;
            }
            if (num == reverseNr) return true;
            return false;
        }
    }
}
