using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Circle_and_Two_Squares
{
    class Program
    {
        //Create a function, that takes an integer(radius of the circle) and returns the difference of the areas of the two squares.

        //square_areas_difference(5) ➞ 50
        //square_areas_difference(6) ➞ 72
        //square_areas_difference(7) ➞ 98



        static void Main(string[] args)
        {
            Console.WriteLine(square_areas_difference(5));
        }

        public static int square_areas_difference(int radius)
        {
            int bigSquareArea = (int)Math.Pow((2 * radius), 2);
            int smallSquareArea = (int)(Math.Pow(radius * Math.Sqrt(2), 2));

            return bigSquareArea - smallSquareArea;


        }
    }
}
