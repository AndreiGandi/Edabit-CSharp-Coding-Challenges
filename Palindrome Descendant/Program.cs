using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Descendant
{
    //A number may not be a palindrome, but its descendant can be.A number's direct child is created by summing each pair of adjacent digits to create the digits of the next number.
    //For instance, 123312 is not a palindrome, but its next child 363 is, where: 3 = 1 + 2; 6 = 3 + 3; 3 = 1 + 2.
    //Create a function that returns true if the number itself is a palindrome or any of its descendants down to 2 digits(a 1-digit number is trivially a palindrome).


    //PalindromeDescendant(11211230) ➞ false
    //// 11211230 ➞ 2333 ➞ 56
    //palindromeDescendant(13001120) ➞ true
    //// 13001120 ➞ 4022 ➞ 44
    //PalindromeDescendant(23336014) ➞ true
    //// 23336014 ➞ 5665
    //PalindromeDescendant(11) ➞ true
    //// Number itself is a palindrome.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeDescendant(11));
        }
        public static bool PalindromeDescendant(int num)
        {
            bool palindrome = false;
            string newNum = "";
            while (num > 9)
            { 
                if(isPalindrome(num))
                {
                    palindrome = true;
                    break;
                }
                else if(!isPalindrome(num) && num<100)
                {
                    palindrome = false; break;
                }
                else
                {

                    string numStr = num.ToString();
                    newNum = "";
                    for (int i=0; i<numStr.Length-1; i+=2)
                    {
                        newNum += (Convert.ToInt32(numStr[i].ToString()) + Convert.ToInt32(numStr[i + 1].ToString())).ToString();
                    }
                }
                num = Convert.ToInt32(newNum);
                //Console.WriteLine(num);
            } 

            return palindrome;
        }
        public static bool isPalindrome(int nr)
        {
            int temp = nr;
            string reversNr = "";
            while(temp != 0)
            {
                int r = temp % 10;
                temp /= 10;
                reversNr += r.ToString();
            }
            if (nr.ToString() == reversNr)
                return true;
            return false;
        }
    }
}
