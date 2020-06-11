using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Coding_Challenge_2
{
    class Program
    {
        //3 ➞ 21
        //9 ➞ 2221
        //17 ➞ 22221
        //24 ➞ 22228
        static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc(24));
        }
        public static int MysteryFunc(int num)
        {
            string nr = "";
            int Prod = 1;
            while (true)
            {
                
                if (Prod * 2 <= num)
                {
                    nr += "2";
                    Prod *= 2; continue;
                }
                else { nr += (num - Prod).ToString(); break; }
            }
            return Convert.ToInt32(nr);
        }
    }
}
