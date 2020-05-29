using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeating_Letters_N_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Repeat("mice", 5));
        }
        public static string Repeat(string str, int num)
        {
            string result = "";
            for(int i = 0; i<str.Length; i++)
            {
                for(int j = 1; j<=num; j++)
                {
                    result += str[i];
                }
            }



            return result;
        }
    }
}
