using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class UniquePaths
    {
        //Time Complexity O(m x n)
        //Space Complexity O(n)
        //The program moves arobot about on the acrtesian grid(x,y) given that the robot can only move either down or right
        //& its current location is top left. The aim is to return the number of unique paths that the robot can take to reach
        //the bottom right corner of the screen
        public int UniquePathsSol(int m, int n) 
        {
            int[,] dp = new int[m,n];

            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 1;
                    }
                    else 
                    {
                        dp[i,j] = dp[i -1, j] + dp[i, j -1];    
                    }
                }
            }
            return dp[m - 1, n - 1];
        }
    }
}
