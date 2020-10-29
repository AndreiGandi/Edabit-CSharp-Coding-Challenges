using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_the_Input_Factorial_of_an_Integer
{
    //Create a function that checks if a given integer is exactly the factorial of an integer or not. true if it is, false otherwise.
    class Program
    {
        //isFactorial(2) ➞ true
        // 2 = 2 * 1 = 2!
        //isFactorial(27) ➞ false

        //isFactorial(24) ➞ true
        // 24 = 4 * 3 * 2 * 1 = 4!
        static void Main(string[] args)
        {
            Console.WriteLine(isFactorial(27));
        }
        public static bool isFactorial(int n)
        {
            int fact = 1;
            for(int i=1; i<=n; i++)
            {
                fact *= i;
                if (fact == n) return true;
                if (fact > n) break;
            }
            return false;
        }
    }
}
