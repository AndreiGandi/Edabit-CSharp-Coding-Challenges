using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Major_Sum
{
    //Create a function that takes an integer array and return the biggest between positive sum, negative sum, or 0s count. The major is understood as the greatest absolute.
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = { -4, -8, -12, -3, 4, 7, 1, 3, 0, 0, 0, 0 }; //=> 10
			//Positive sum = 1 + 2 + 3 + 4 = 10
			//Negative sum = (-3) + (-2) = -5
			//0s count = 2(there are two zeros in array)
			Console.WriteLine(MajorSum(arr));

		}
		public static int MajorSum(int[] arr)
		{
			int sumP = 0;
			int sumN = 0;
			int nr0s = 0;
			foreach (var item in arr)
			{
				if (item > 0) sumP += item;
				else if (item < 0) sumN += item;
				else nr0s++;
			}
			if (sumP > Math.Abs(sumN) && sumP > nr0s) return sumP;
			else if (Math.Abs(sumN) > sumP && Math.Abs(sumN) > nr0s) return sumN;
			else return nr0s;
		}
	}
}
