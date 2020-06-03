using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number
{
    class Program
    {
        //CheckPerfect(6) ➞ true
        //CheckPerfect(28) ➞ true
        //CheckPerfect(496) ➞ true
        //CheckPerfect(97) ➞ false
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPerfect(97));
        }
        public static bool CheckPerfect(int num)
        {
            int Sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0) Sum += i;
            }
            if (Sum == num) return true;
            return false;
        }
    }
}
