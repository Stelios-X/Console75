using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class FindMinRotation
    {
        //inderbindra solution
        //Given the sorted rotated array nums of unique elements, return the minimum element of this array.
       //Time Complexity O(log n)
       //Space Complexity O(1)

        public int FindMinRotation_Sol(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;
            while (left < right)
            {
                mid = left + (right - left) / 2;
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return nums[left];
        }
    }
}
