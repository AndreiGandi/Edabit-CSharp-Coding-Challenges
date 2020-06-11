using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_a_Binary_String
{
    class Program
    {
        //reversedBinaryInteger(10) ➞ 5
        //// 10 = 1010 -> 0101 = 5
        //reversedBinaryInteger(12) ➞ 3
        //// 12 = 1100 -> 0011 = 3
        //reversedBinaryInteger(25) ➞ 19
        //// 25 = 11001 -> 10011 = 19
        //reversedBinaryInteger(45) ➞ 45
        //// 45 = 101101 -> 101101 = 45
        static void Main(string[] args)
        {
            Console.Write(reversedBinaryInteger(10));
        }
        public static int reversedBinaryInteger(int num)
        {
            string numBinary = "";
            while (num != 0)
            {
                numBinary += (num % 2).ToString();
                num /= 2;
            }
            int numDecimal = 0;
            int power = numBinary.Length-1;

            foreach(var s in numBinary)
            {
                numDecimal += (int)(double.Parse(s.ToString()) * Math.Pow(2, power));
                power--;
            }
            return numDecimal;
        }

        //Using Convert Methods
        //public static int reversedBinaryInteger(int num)
        //{
        //    string binary = Convert.ToString(num, 2);
        //    char[] characters = binary.ToCharArray();

        //    Array.Reverse(characters);

        //    return Convert.ToInt32(new string(characters), 2);
        //}
    }
}
