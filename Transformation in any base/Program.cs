using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Transformation_in_any_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Transform2(15000, 6));
        }
        //C++ algorithm; Use BigInteger for a greater range
        public static BigInteger Transform(int nr, int Base)
        {
            BigInteger newNr = new BigInteger();
            long remainder = 0;
            long power = 1; //10^0
            while (nr!=0)
            {
                remainder = nr % Base;
                newNr += remainder * power;
                power *= 10;
                nr /= Base;
            }
            return newNr; 
        }
        //using string opperation
        public static string Transform2(int nr, int Base)
        {
            string newNr = "";
            while (nr != 0)
            {
                newNr += (nr % Base).ToString();
                nr /= Base;
            }
            char[] charArr = newNr.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

    }
}
