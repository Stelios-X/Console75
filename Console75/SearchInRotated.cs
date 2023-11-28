using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class SearchInRotated
    {
        //vanAmsen solution
        //Binary Search solution
        //The given array is sorted with distinct values. It is rotated at some unknown pivot.
        //A modified binary search is performed. By comparing the middle element to the left and right elements,
        //it can be determined if the left or right half of the array is sorted. Based on this information,
        //the search can be performed on the sorted half of the array.
        //Time Complexity O(log n)
        //Space Complexity O(1)
        public int SearchInRotatedSol(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] >= nums[left])
                {
                    if (target >= nums[left] && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                else
                {
                    if (target <= nums[right] && target > nums[mid])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

            }

            return -1;
        }
    }
}
