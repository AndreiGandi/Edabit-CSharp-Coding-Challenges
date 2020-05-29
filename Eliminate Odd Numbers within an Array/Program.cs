using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eliminate_Odd_Numbers_within_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = NoOdds(arr);
        }
        //NoOdds([1, 2, 3, 4, 5, 6, 7, 8]) ➞ [2, 4, 6, 8]
        public static int[] NoOdds(int[] arr)
        {
            //Sau pot folosit o lista List<int> si convertita in array


            int evenElements = 0;
            for(int j = 0; j<arr.Length; j++)
            {
                if (arr[j] % 2 == 0) evenElements++;
            }
            int[] evenArr = new int[evenElements];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2==0)
                {
                    
                    evenArr[index] = arr[i];
                    index++;
                }
            }


                return evenArr;
        }
    }
}
