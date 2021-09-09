using System;
using System.Linq;

namespace VersionNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Solution("2.1.2", "1.2");
            Console.WriteLine(result);
        }

        #region SOLUTION
        static int Solution(string v1String, string v2String)
        {
            int[] v1VersionsNumbers = v1String.Split('.').Select(int.Parse).ToArray();
            int[] v2VersionsNumbers = v2String.Split('.').Select(int.Parse).ToArray();
            
            
            int version1Comparison = 0, version2Comparison = 0;
            for (int i = 0, j = 0; (i < v1VersionsNumbers.Length || j < v2VersionsNumbers.Length);)
            {
                while (i < v1VersionsNumbers.Length)
                {
                    version1Comparison = version1Comparison * 10 + (v1VersionsNumbers[i] - 0);
                    i++;
                }
                while (j < v2VersionsNumbers.Length)
                {
                    version2Comparison = version2Comparison * 10 + (v2VersionsNumbers[j] - 0);
                    j++;
                }
            
                if (version1Comparison > version2Comparison)
                    return 1;

                if (version1Comparison < version2Comparison)
                    return -1;
                    
                version1Comparison = version2Comparison = 0;
                i++;
                j++;
            }
            return 0;
        }
        #endregion
    }
}
