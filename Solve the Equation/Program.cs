using System;
using System.Data;

namespace Solve_the_Equation
{
    class Program
    {
        //Create a function that takes an equation(e.g. "1+1"), and returns the answer.
        //        Equation("1+1") ➞ 2
        //        Equation("7*4-2") ➞ 26
        //        Equation("1+1+1+1+1") ➞ 5
        static void Main(string[] args)
        {
            Console.WriteLine(Equation("7*4-2"));
        }
        public static int Equation(string s)
        {
            string result = new DataTable().Compute(s, null).ToString();
            return int.Parse(result);
        }
    }
}
