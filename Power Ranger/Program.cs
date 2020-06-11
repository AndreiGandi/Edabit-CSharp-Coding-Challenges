using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Ranger
{
    //PowerRanger(2, 49, 65) ➞ 2
    //// 2 squares (n^2) lie between 48 and 65, 49 (7^2) and 64 (8^2)
    //PowerRanger(3, 1, 27) ➞ 3
    //// 3 cubes (n^3) lie between 1 and 27, 1 (1^3), 8 (2^3) and 27 (3^3)
    //PowerRanger(10, 1, 5) ➞ 1
    //// 1 value raised to the 10th power lies between 1 and 5, 1 (1^10)
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(PowerRanger(10,1,5));
        }
        public static int PowerRanger(int power, int min, int max)
        {
            int count = 0;
            for (int i = 1; Math.Pow(i, power) <= max; i++)
            {
                if (Math.Pow(i, power) <= max && Math.Pow(i, power) >= min)
                    count++;
            }
            return count;
        }
    }
}
