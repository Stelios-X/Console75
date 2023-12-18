using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class JumpGame
    {
        //Time Complexity O(n)
        //Space Complexity O(1)
        //You are given an array of integers. You start off at the first index. The current element represents
        //the jump length possible to get to the next element. Return true if you are able to get to the last index else false 

        public bool CanJump(int[] nums) 
        {
            int lastPos = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i-- ) 
            {
                if (i + nums[i] >= lastPos) 
                {
                    lastPos = i;
                }
            }
            return lastPos == 0;
        }
    }
}
