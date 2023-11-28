using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MaxSubArray
    {
        //a1997shish solution
        //Given an integer array nums, find the subarray with the largest sum, and return its sum.
        //Time Complexity O(n)
        //Space Complexity O(1)
        public int MaxSub_Sol(int[] a)
        {

            int i = 0, n = a.Length, maxsum = a[0], curr = a[0];

            for (i = 1; i < n; i++)
            {
                // just choose whether to take that element or adding that element to previous sums which is greater we will take that.
                curr = Math.Max(a[i], curr + a[i]);
                maxsum = Math.Max(curr, maxsum);
            }
            return maxsum;
        }


    }
}
