using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution();
        }

        #region SOLUTION
        static void Solution()
        {
            for(int i=1; i <= 50; i++)
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " (multiple of 3 and 5)");
                else if (i % 3 == 0)
                    Console.WriteLine(i + " (multiple of 3)");
                else if (i % 5 == 0)
                    Console.WriteLine(i + " (multiple of 5)");
                else 
                    Console.WriteLine(i);
        }
        #endregion
    }
}
