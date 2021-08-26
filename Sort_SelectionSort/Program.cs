using System;
using Classes.Data;
using Classes.LargeData;
using Classes.StopWatch;

namespace Sort_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
			    Problem: Sort through array of int using Selection Sort Algorithm.

			    int arrays are fed in through a static class in the classes folder.
                
                20 Elements => Data.UnsortedData, Data.UnsortedDataRepeated, Data.SortedData,
                100,000 Elements => LargeData.UnsortedData, LargeData.UnsortedDataRepeated, LargeData.SortedData.
		    */

            // Call Solution
            foreach (int[] intArray in Data.UnsortedData)
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
            int[] sortedArray = SelectionSort(dataToSort);
            // Return Text
            return "Sorted: " + ArrayToString(sortedArray) + "\n------------------";
	    }
        static int[] SelectionSort(int[] intArray)
        {
            StopWatchHandler stopwatch = new StopWatchHandler();
            Console.WriteLine("Timer Started => Sorting");
            stopwatch.StartStopWatch();
            
            for (int i = 0; i < intArray.Length-1; i++)
            {
                int minimum = i;
                for(int j = i+1; j < intArray.Length; j++)
                    if(intArray[j] < intArray[minimum]) 
                        minimum = j;
            
                int temp = intArray[i]; 
                intArray[i] = intArray[minimum];
                intArray[minimum] = temp;
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
