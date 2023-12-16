﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class CribRobbery
    {
        //Time complexity O(n)
        //Space complexity O(n)
        //The problem requires the maximum sum that can be robbed from the houses without alerting the police
        //Adjascent houses cannot be robbed
        public int CribRob(int[] nums) 
        {
            if (nums == null || nums.Length == 0) 
            {
                return 0;
            }

            if (nums.Length == 1) 
            {
                return nums[0];
            }
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++) 
            {
                dp[i] = Math.Max(dp[i-1], dp[i-2] + nums[i]);
            }
            return dp[nums.Length - 1];
        }
    }
}
