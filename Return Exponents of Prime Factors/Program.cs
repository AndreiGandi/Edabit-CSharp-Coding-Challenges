using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Exponents_of_Prime_Factors
{
    class Program
    {
        //You are given a list of prime factors arr and a target.When each number in the list is raised to an appropriate power their product will be equal to the target.
        //Your role is to return the exponents. All these lists will have a length of three.
        //Basically, it is three numbers whose product is equal to challenge.The only difference is what you are expected to return.

        //ProductEqualTarget(new int[] { 2, 3, 5 }, 600) ➞ [3, 1, 2] // Because 2^3*3^1*5^2 = 600
        //ProductEqualTarget(new int[] { 2, 3, 5 }, 720) ➞ [4, 2, 1]// Because 2^4*3^2*5^1 = 720
        static void Main(string[] args)
        {
            int[] test = ProductEqualTarget(new int[] { 2, 3, 5 }, 720);
            Console.WriteLine();
        }
        public static int[] ProductEqualTarget(int[] arr, int target)
        {
            List<int> exponents = new List<int>();
            for(int i=0; i<arr.Length; i++)
            {
                int count = 0;
                while(target % arr[i] == 0)
                {
                    count++;
                    target /= arr[i];
                }
                exponents.Add(count);
            }
            return exponents.ToArray();
        }
    }
}
