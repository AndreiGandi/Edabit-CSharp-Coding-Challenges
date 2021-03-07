using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme_Sum
{
    class Program
    {
        //MemeSum(26, 39) ➞ 515
        // 2+3 = 5, 6+9 = 15
        // 26 + 39 = 515

        //MemeSum(122, 81) ➞ 1103
        // 1+0 = 1, 2+8 = 10, 2+1 = 3
        // 122 + 81 = 1103

        //MemeSum(1222, 30277) ➞ 31499
        static void Main(string[] args)
        {
            //Console.WriteLine(MemeSum(26, 39));
            Console.WriteLine(MemeSum(0, 0));

        }
        public static int MemeSum(int a, int b)
        {
            int Sum = 0;
            string stringSum = "";
            if (a == 0 && b == 0) return 0;
            else if(a>=b)
            {
                while(a!=0)
                {
                    Sum = (a % 10) + (b % 10);
                    a /= 10;
                    b /= 10;
                    stringSum = Sum + stringSum; 
                }
            }
            else
            {
                while (b != 0)
                {
                    Sum = (a % 10) + (b % 10);
                    a /= 10;
                    b /= 10;
                    stringSum = Sum + stringSum;
                }
            }
            return Convert.ToInt32(stringSum);

        }
    }
}
