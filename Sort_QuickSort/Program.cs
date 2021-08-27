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

                TODO: Fix
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
            int[] sortedArray = QuickSort(dataToSort, 0, dataToSort.Length-1);

            // Return Text
            return "Sorted: " + ArrayToString(sortedArray) + "\n------------------";
	    }
        static int[] QuickSort(int[] intArray, int left, int right)
        {
            StopWatchHandler stopwatch = new();
            Console.WriteLine("Timer Started => Sorting");
            stopwatch.StartStopWatch();

            int startIndex = 0;
            int endIndex = intArray.Length-1;
            int top = -1;
            int[] stack = new int[intArray.Length];

            stack[++top] = startIndex;
            stack[++top] = endIndex;

            while (top >= 0)
            {
                endIndex = stack[top--];
                startIndex = stack[top--];

                int p = Partition(intArray, startIndex, endIndex);

                if (p-1 > startIndex)
                {
                    stack[++top] = startIndex;
                    stack[++top] = p - 1;
                }

                if (p + 1 < endIndex)
                {
                    stack[++top] = p+1;
                    stack[++top] = endIndex;
                }
            }

            stopwatch.StopStopWatch();
            Console.WriteLine(stopwatch.GetTime());
            return intArray;
        }

        static int Partition(int[] intArray, int left, int right) {
            int x = intArray[right];
	        int i = (left-1);
            int temp = 0;

            for (int j = left; j <= right - 1; ++j)
            {
                if (intArray[j] <= x)
                {
                    ++i;
                    temp = intArray[i];
                    intArray[i] = intArray[j];
                    intArray[j] = temp;
                }
            }

            temp = intArray[i+1];
            intArray[i+1] = intArray[right];
            intArray[right] = temp;

	        return (i + 1);
        }

        static void Swap(int x, int y) {
            int temp = x;
            x = y;
            y = temp;
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
