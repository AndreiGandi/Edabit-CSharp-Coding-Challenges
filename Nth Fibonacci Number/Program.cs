using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Nth_Fibonacci_Number
{

    //Create a function to return the Nth number in the Fibonacci sequence as a string.
    //Fibonacci(10) ➞ "55"  1 1 2 3 5 8 13 21 34 55
    //Fibonacci(20) ➞ "6765"
    //Fibonacci(30) ➞ "832040"
    //Fibonacci(40) ➞ "102334155"
    //Fibonacci(50) ➞ "12586269025"
    //Fibonacci(60) ➞ "1548008755920"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(60));
        }
        static BigInteger Fibonacci(int nr)
        {
            BigInteger secondToLast = 1;
            BigInteger last = 1;
            BigInteger Fibo=0;
            for(int i = 3; i<=nr; i++)
            {
                Fibo = secondToLast + last;
                secondToLast = last;
                last = Fibo;
            }
            return Fibo;
        }
    }
}
