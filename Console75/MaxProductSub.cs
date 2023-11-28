using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MaxProductSub
    {
        //inderbindra solution
        //Given an integer array nums, find the contiguous subarray within an array
        //(containing at least one number) which has the largest product.
        //Time Complexity O(n)
        //Space Complexity O(1)
        public int MaxProductSub_Sol(int[] nums)
        {
            int maxProduct = int. MinValue;
            int leftProduct = 1;
            int rightProduct = 1;
            
            for (int i = 0; i < nums.Length; i++)
            {
                leftProduct *= nums[i];
                rightProduct *= nums[nums.Length - 1 - i];
                maxProduct = Math.Max(maxProduct, Math.Max(leftProduct, rightProduct));
                leftProduct = leftProduct == 0 ? 1 : leftProduct;
                rightProduct = rightProduct == 0 ? 1 : rightProduct;
            }
            Console.WriteLine($"MaxProductSub_Sol: {maxProduct}");
            return maxProduct;
            
        }   
    }
}
