using System;
using Classes.Data;
using Classes.LargeData;
using Classes.StopWatch;

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
            foreach (int[] intArray in LargeData.UnsortedData)
            {
                Console.WriteLine(Solution(intArray));
            }
        }

        #region SOLUTION
        static string Solution(int[] dataToSort)
	    {
            // Print Unsorted Array
            Console.WriteLine("\nUnsorted: " + ArrayToString(dataToSort));
            // Sort Array
            int[] sortedArray = bubbleSort(dataToSort);
            // Return Text
            return "Sorted: " + ArrayToString(sortedArray) + "\n------------------";
	    }
        static int[] bubbleSort(int[] intArray)
        {
            StopWatchHandler stopwatch = new StopWatchHandler();
            Console.WriteLine("Timer Started => Sorting");
            stopwatch.StartStopWatch();
            
            for (int i=0; i < intArray.Length-1; i++)
                for (int j=0; j < intArray.Length-i-1; j++)
                    if (intArray[j] > intArray[j + 1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }

            stopwatch.StopStopWatch();
            Console.WriteLine(stopwatch.GetTime());
            return intArray;       
        }
        static string ArrayToString(int[] intArray)
        {
            string returnString = "";
            for (int i=0; i < 3; i++) 
                if(i != 2)
                    returnString += intArray[i] + ", ";
                else
                    returnString += intArray[i] + ". . . ";

            return returnString;
        }
        #endregion
    }
}
