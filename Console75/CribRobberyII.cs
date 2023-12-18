using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class CribRobberyII
    {
        //Time complexity O(n)
        //Space complexity O(1)
        //Given an array of houses in a circle with each element referring to the amount in each house
        //You can't bob adjascent houses, what's the possible highest amount attainable from the heist

        public int CribRob(int[] nums) 
        {
            if (nums.Length == 0) 
            {
                return 0;
            }
            if (nums.Length == 1) 
            {
                return nums[0];
            }
            return Math.Max(Rob(nums, 0, nums.Length - 2), Rob(nums, 1, nums.Length - 1));
        }

        private int Rob(int[] nums, int start, int end) 
        {
            int prevMax = 0, currMax = 0;
            for (int i = start; i <= end; i++) 
            {
                int temp = currMax;
                currMax = Math.Max(prevMax + nums[i], currMax);
                prevMax = temp;
            }
            return currMax; 
        }
    }
}
