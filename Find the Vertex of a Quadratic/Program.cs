using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Vertex_of_a_Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = FindVertex(1, 0, 25);
            Console.Write("[");
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.Write("]");
        }
        public static double[] FindVertex(int a, int b, int c)
        {
            double[] coordonate = new double[2];
            coordonate[0] = Math.Round(((double)(-b)/(2*a)), 2);
            coordonate[1] = Math.Round((coordonate[0]*coordonate[0]*a + b*coordonate[0] +c), 2);
            return coordonate;
        }
    }
}
