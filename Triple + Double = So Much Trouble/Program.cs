using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple___Double___So_Much_Trouble
{
    class Program
    {
        //Create a function that takes two integers and returns true if a number repeats three times in a row at any place in num1 AND that same number repeats two times in a row in num2.
        //Trouble(451999277, 41177722899) ➞ true
        //Trouble(1222345, 12345) ➞ false
        //Trouble(666789, 12345667) ➞ true
        //Trouble(33789, 12345337) ➞ false
        static void Main(string[] args)
        {
            Console.WriteLine(Trouble(1222345, 12345));
        }
        public static bool Trouble(long num1, long num2)
        {
            char nr = ' ';
            string nr1 = num1.ToString();
            string nr2 = num2.ToString();
            for (int i = 0; i < nr1.Length - 2; i++)
            {
                if (nr1[i] == nr1[i + 1] && nr1[i] == nr1[i + 2])
                {
                    nr = nr1[i];
                }
            }
            if (nr != ' ')
            {
                for (int j = 0; j < nr2.Length - 1; j++)
                {
                    if (nr2[j] == nr && nr2[j + 1] == nr)
                        return true;
                }
            }
            else return false;
            return false;
        }
    }
}
