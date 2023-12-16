using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ClimbingStairs
    {
        //Time complexity O(n)
        //Space complexity O(n)
        //The algorithm states the number of distinct ways one can climb a staircase given that 1 or 2 stairs are climbed at a time.

        public int ClimbingStairsSol(int n) 
        {
            if (n == 1) 
            {
                return 1;
            }
            int[] dp = new int[n+1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++ ) 
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            Console.WriteLine(dp[n]); 
            return dp[n];
        }

    }
}
