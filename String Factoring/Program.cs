using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Factoring
{
    class Program
    {
        //Given the complete factorization of a number, create a function that converts this array of factors to a string.
        //To illustrate: 24's complete factorization is [2, 2, 2, 3], which should be converted to "2^3 x 3".

            //StringFactor(new int[] { 2, 2, 2, 3, 3 }) ➞ "2^3 x 3^2"
            //StringFactor(new int[] { 2, 7 }) ➞ "2 x 7"
            //StringFactor(new int[] { 2, 3, 3 }) ➞ "2 x 3^2"

        static void Main(string[] args)
        {
            Console.WriteLine(StringFactor(new int[] { 2, 2, 2, 3, 3 }));
        }
        public static string StringFactor(int[] arr)
        {
            string sFactor = "";
            Dictionary<int, int> dict = new Dictionary<int, int>();

            bool[] visited = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (visited[i] == true)
                    continue; 
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                dict.Add(arr[i], count);
            }
            foreach(var item in dict)
            {
                if (item.Value == 1)
                    sFactor += item.Key.ToString() + " x ";
                else
                    sFactor += item.Key.ToString() + "^" + item.Value.ToString() + " x ";
            }
            return sFactor.Remove(sFactor.Length-3, 3);

        }
    }
}
