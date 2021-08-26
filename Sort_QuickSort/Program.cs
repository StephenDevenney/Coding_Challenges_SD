using System;
using Classes.Data;
using Classes.LargeData;
using Classes.StopWatch;

namespace Sort_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
			    Problem: Sort through array of int using Quick Sort Algorithm.

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
            StopWatchHandler stopwatch = new StopWatchHandler();
            Console.WriteLine("Timer Started => Sorting");
            stopwatch.StartStopWatch();

            int[] sortedArray = QuickSort(dataToSort, 0, dataToSort.Length-1);

            stopwatch.StopStopWatch();
            Console.WriteLine(stopwatch.GetTime());

            // Return Text
            return "Sorted: " + ArrayToString(sortedArray) + "\n------------------";
	    }
        static int[] QuickSort(int[] intArray, int left, int right)
        {
            if (left < right) {
                int pivotIndex = Pivot(intArray, left, right);
                QuickSort(intArray, left, pivotIndex-1);
                QuickSort(intArray, pivotIndex+1, right);
            }

            return intArray;
        }

        static int Pivot(int[] intArray, int left, int right) {
            int shift = left;
            for (int i = left+1; i <= right; i++) {
                if (intArray[i] < intArray[left])
                    Swap(intArray, i, ++shift);
            }

            Swap(intArray, left, shift);
            return shift;
        }

        static void Swap(int[] intArray, int left, int right) {
            int temp = intArray[left];
            intArray[left] = intArray[right];
            intArray[right] = temp;
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
