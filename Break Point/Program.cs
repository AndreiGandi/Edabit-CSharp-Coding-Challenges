using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Point
{
    class Program
    {
        //A number has a breakpoint if it can be split in a way where the digits on the left side and the digits on the right side sum to the same number.

        //For instance, the number 35190 can be sliced between the digits 351 and 90, since 3 + 5 + 1 = 9 and 9 + 0 = 9. 
        //On the other hand, the number 555 does not have a breakpoint(you must split between digits).


        static void Main(string[] args)
        {
            Console.WriteLine(BreakPoint(35190)); //true
            Console.WriteLine(BreakPoint(-35190)); //true
            Console.WriteLine(BreakPoint(1034)); //true
            Console.WriteLine(BreakPoint(112)); //true
            Console.WriteLine(BreakPoint(343)); //false

        }
        public static bool BreakPoint(int num)
        {

            string sNum = num.ToString();

            //Validations
            if (sNum.Contains("-"))
                sNum = sNum.Replace("-", "");
            if (sNum.Length < 2)
                return false;

            string left = "";
            string right = "";
            for(int index = 1; index < sNum.Length; index++)
            {
                left = sNum.Substring(0, index);
                right = sNum.Substring(index);
                if (Sum(int.Parse(left)) == Sum(int.Parse(right)))
                    return true;
            }
            return false;
        }
        public static int Sum(int nr)
        {
            int sum = 0;
            while(nr != 0)
            {
                sum += nr % 10;
                nr /= 10;
            }
            return sum;
        }
    }
}
