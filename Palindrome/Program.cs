using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("racecar: " + Solution("racecar"));
            Console.WriteLine("level: " + Solution("level"));
            Console.WriteLine("radar: " + Solution("radar"));
            Console.WriteLine("java: " + Solution("java"));
            Console.WriteLine("html: " + Solution("html"));
        }

        #region SOLUTION
        static bool Solution(string palindromeCheck)
        {
            string reverseSide = "";
            for (int i = palindromeCheck.Length-1; i >= 0; i--)
                reverseSide += palindromeCheck[i];

            if (palindromeCheck == reverseSide)
                return true;
            else
                return false;
        }
        #endregion
    }
}
