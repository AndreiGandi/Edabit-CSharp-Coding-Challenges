using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentagonal_Number
{
    class Program
    {
        //Write a function that takes a positive integer num and calculates how many dots exist in a pentagonal shape around the center dot on the Nth iteration
        static void Main(string[] args)
        {
            //Console.WriteLine(pentagonal(1)); //1
            //Console.WriteLine(pentagonal(2)); //6
            Console.WriteLine(pentagonal(3)); //16
            //Console.WriteLine(pentagonal(8));//31
        }
        public static int pentagonal(int num)
        {
            int Sum = 1;
            for(int i = 1; i<=num; i++)
            {
                Sum += (i - 1) * 5;
            }
            return Sum;
        }

    }
}
