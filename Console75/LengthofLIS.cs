﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class LengthofLIS
    {
        //Time complexity O(n^2)
        //Space complexity O(n)
        //This algorithm returns the longest increasing subsequence of items in an array

        public int LengthofLIS_Sol(int[] nums) 
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int[] dp = new int[nums.Length];
            dp[0] = 1;

            int maxans = 1;
            for (int i = 1; i < dp.Length; i++) 
            {
                int maxval = 0;
                for (int j = 0; j < i; j++) 
                {
                    if (nums[i] > nums[j]) 
                    {
                        maxval = Math.Max(maxval, dp[j]);
                    }
                }
                dp[i] = maxval + 1;
                maxans = Math.Max(maxans, dp[i]);
            }
            Console.WriteLine(maxans);
            return maxans;
        }

    }
}
