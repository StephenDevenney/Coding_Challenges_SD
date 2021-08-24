using System;
using System.Linq;
using Classes.Data;

namespace Sort_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
			    Problem: Sort through array of int using Bubble Sort Algorithm.

			    int arrays are fed in through a static class in the classes folder.
		    */

            // Call Solution
            foreach (int[] intArray in Data.UnsortedData)
            {
                Console.WriteLine(Solution(intArray));
            }
        }

        #region SOLUTION
        static string Solution(int[] unsortedData)
	    {
            return ReturnString();
	    }
        static string ReturnString()
        {
            return "";
        }
        #endregion
    }
}
