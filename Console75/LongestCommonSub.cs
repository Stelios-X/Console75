using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class LongestCommonSub
    {
        //Time Complexity O(m * n)
        //Space Complexity O(m * n)
        //The algorithm takes 2 strings and returns the length of their longest common subsequence. 
        public int LongestCommonSub_Sol( string text1, string text2) 
        {
            int m = text1.Length;
            int n = text2.Length;
            int [,] dp = new int[m +1, n+1];
            for (int i = 1; i <= m; i++) 
            {
                for (int j = 1; j <= n; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j] + 1;
                    }
                    else 
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }    
            }
            //Console.WriteLine(dp[m,n]);
            return dp[m,n];
        }
    }
}
