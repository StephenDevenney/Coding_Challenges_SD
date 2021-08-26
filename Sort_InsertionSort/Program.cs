using System;
using Classes.Data;
using Classes.LargeData;
using Classes.StopWatch;

namespace Sort_InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
			    Problem: Sort through array of int using Insertion Sort Algorithm.

			    int arrays are fed in through a static class in the classes folder.

                20 Elements => Data.UnsortedData, Data.UnsortedDataRepeated, Data.SortedData,
                100,000 Elements => LargeData.UnsortedData, LargeData.UnsortedDataRepeated, LargeData.SortedData.
		    */

            // Call Solution
            foreach (int[] intArray in LargeData.SortedData)
            {
                // Console.WriteLine(Solution(intArray));
                Solution(intArray);
            }
        }

        #region SOLUTION
        static string Solution(int[] dataToSort)
	    {
            // Print Unsorted Array
            // Console.WriteLine("\nUnsorted: " + ArrayToString(dataToSort));
            // Sort Array
            int[] sortedArray = SelectionSort(dataToSort);
            // Return Text
            return "Sorted: " + ArrayToString(sortedArray) + "\n------------------";
	    }
        static int[] SelectionSort(int[] intArray)
        {
            StopWatchHandler stopwatch = new StopWatchHandler();
            // Console.WriteLine("Timer Started => Sorting");
            stopwatch.StartStopWatch();
            
            for(int i=1; i < intArray.Length; i++) {
                int next = intArray[i];
                int j = i;
                while(j > 0 && intArray[j-1] > next) {
                    intArray[j] = intArray[j-1];
                    j--;
                }
                intArray[j] = next;
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
