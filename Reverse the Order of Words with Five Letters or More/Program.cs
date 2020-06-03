using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_the_Order_of_Words_with_Five_Letters_or_More
{
    class Program
    {
        //Reverse("Reverse") ➞ "esreveR"
        //Reverse("This is a typical sentence.") ➞ "This is a lacipyt .ecnetnes"
        //Reverse("The dog is big.") ➞ "The dog is big."
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("This is a typical sentence."));
        }
        public static string Reverse(string str)
        {
            string result = "";
            string[] elements = str.Split(' ');
            for (int i = 0; i < elements.Length; i++)
            {
                char[] temp = new char[elements[i].Length];
                if (elements[i].Length >= 5)
                {
                    temp = elements[i].ToCharArray();
                    Array.Reverse(temp);
                    result += new string(temp) + " ";
                }
                else result += elements[i] + " ";


            }
            return result.Remove(result.Length - 1);
        }
    }
}
