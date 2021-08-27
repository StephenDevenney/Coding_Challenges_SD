using System;
using Classes.Data;
using Classes.LargeData;
using Classes.StopWatch;

namespace Sort_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
			    Problem: Sort through array of int using Merge Sort Algorithm.

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
            StopWatchHandler stopwatch = new();
            // Console.WriteLine("Timer Started => Sorting");
            stopwatch.StartStopWatch();

            int[] sortedArray = MergeSort(dataToSort);

            stopwatch.StopStopWatch();
            Console.WriteLine(stopwatch.GetTime());
            // Return Text
            return "Sorted: " + ArrayToString(sortedArray) + "\n------------------";
	    }

        public static int[] MergeSort(int[] intArray)
        {
            int[] left;
            int[] right;
            int[] result = new int[intArray.Length]; 
            if (intArray.Length <= 1)
                return intArray;              
            int midPoint = (intArray.Length) / 2;  
            left = new int[midPoint];
            if (intArray.Length % 2 == 0)
                right = new int[midPoint];  
            else
                right = new int[midPoint + 1];  
            for (int i = 0; i < midPoint; i++)
                left[i] = intArray[i];   
            int x = 0;
            for (int i = midPoint; i < intArray.Length; i++)
            {
                right[x] = intArray[i];
                x++;
            }  

            left = MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right);  
            return result;
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;  
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)  
                { 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }  
            }
            return result;
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
