using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Word_Length
{
    //Create a function that takes in a sentence and returns the average length of each word in that sentence.
    //Round your result to two decimal places.

    //AverageWordLength("A B C.") ➞ 1.00
    //AverageWordLength("What a gorgeous day.") ➞ 4.00
    //AverageWordLength("Dude, this is so awesome!") ➞ 3.80


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AverageWordLength("Dude, this is so awesome!"));
        }
        public static double AverageWordLength(string str)
        {
            double count = 0;
            string[] strArr = str.Split(' ');
            foreach(var item in strArr)
            {
                if (char.IsPunctuation(item[item.Length - 1]))
                    count += item.Length - 1;
                else count += item.Length;
            }
            double avg = Math.Round((count / strArr.Length), 2);
             

            return /*Convert.ToDouble(String.Format("{0:0.00}", avg))*/ avg;
                

        }

    }
}
