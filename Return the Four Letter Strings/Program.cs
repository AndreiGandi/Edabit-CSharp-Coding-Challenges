using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_the_Four_Letter_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Ryan", "Kieran", "Jason", "Matt" };
            string[] result = IsFourLetters(arr);
            for (int i = 0; i< result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        //IsFourLetters(["Ryan", "Kieran", "Jason", "Matt"]) ➞ ["Ryan", "Matt"]
        public static string[] IsFourLetters(string[] arr)
        {
            List<string> list = new List<string>();
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i].Length == 4)
                    list.Add(arr[i]);
            }
            return list.ToArray();

        }
    }
}
