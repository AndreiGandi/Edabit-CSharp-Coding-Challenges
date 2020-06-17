using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_Fractions
{
    class Program
    {
        //Create a function that returns the simplified version of a fraction.
        //Simplify("4/6") ➞ "2/3"
        //Simplify("10/11") ➞ "10/11"
        //Simplify("100/400") ➞ "1/4"
        //Simplify("8/4") ➞ "2"
        static void Main(string[] args)
        {
            Console.WriteLine(Simplify("8/4"));

        }
        public static string Simplify(string str)
        {
            int nominator = 0;
            int denominator = 0;
            string result = "";
            string[] strArr = str.Split('/');
            nominator = Convert.ToInt32(strArr[0]);
            denominator = Convert.ToInt32(strArr[1]);
            if(nominator == denominator)
            {
                result = "1";
            }
            else if(nominator > denominator)
            {
                if (nominator % denominator == 0)
                    result = (nominator / denominator).ToString();
                else
                {
                    int gcd = GCD(nominator, denominator);
                    result = $"{(nominator / gcd).ToString()}/{(denominator / gcd).ToString()}";
                }
            }
            else
            {
                if(denominator%nominator == 0)
                {
                    result = $"1/{denominator / nominator}";
                }
                else
                {
                    int gcd = GCD(denominator, nominator);
                    result = $"{(nominator / gcd).ToString()}/{(denominator / gcd).ToString()}";
                }
            }
            return result;
        }
        public static int GCD(int a, int b)
        {
            while(b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}
