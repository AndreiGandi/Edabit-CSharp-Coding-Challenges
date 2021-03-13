using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeping_Count
{
    class Program
    {
        //Given a number, create a function which returns a new number based on the following rules:
        //    For each digit, replace it by the number of times it appears in the number.
        //    The final instance of the number will be an integer, not a string.

        // DigitCount(136116) ➞ 312332
        // The number 1 appears thrice, so replace all 1s with 3s.
        // The number 3 appears only once, so replace all 3s with 1s.
        // The number 6 appears twice, so replace all 6s with 2s.

        //DigitCount(221333) ➞ 221333
        //DigitCount(136116) ➞ 312332
        //DigitCount(2) ➞ 1

        static void Main(string[] args)
        {
            Console.WriteLine(DigitCount(136116));
        }
        public static long DigitCount(long num)
        {
            StringBuilder sb = new StringBuilder();
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length; i++)
            {
                int count = 0;
                for(int j=0; j<sNum.Length; j++)
                {
                    if (sNum[i] == sNum[j])
                        count++;
                }
                sb.Append(count);
            }
            return Convert.ToInt64(sb.ToString());
        }
    }
}
