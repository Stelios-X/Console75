using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    //This class returns the product of the array except the current element
    //Time Complexity O(n)
    //Space Complexity O(n)
    public class SelfProduct
    {
        
        public int[] SelfProductSol(int[] nums) 
        {
            int n = nums.Length;
            int[] preProduct = new int[n];
            int[] postProduct = new int[n];

            //preProduct[i] contains the product of all item from 0 to [i-1]
            preProduct[0] = 1;
            for (int i = 1; i < n; i++)
            {
                preProduct[i] = preProduct[i - 1] * nums[i - 1];
            }

            //postProduct[i] contains the product of all item from n-1 to [i+1]
            postProduct[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                postProduct[i] = postProduct[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = preProduct[i] * postProduct[i];
            }

            return nums;
        }
    }
    
}
