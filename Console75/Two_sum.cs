using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class Two_sum
    {
        //Wahidustoz solution - using the hash table
        //Time Complexity O(n)
        //Space Complexity O(n)
        public int[] TwoSumSol(int[] nums, int target) 
        {
            var pairs = new Dictionary<int, int>();
            for (int i=0; i<nums.Length; i++) 
            {
                if (pairs.ContainsKey(target - nums[i]))
                {
                    //Console.Write("Found");
                    return new int[] { pairs[target - nums[i]], i };
                }
                else 
                {
                    pairs.TryAdd(nums[i], i);
                }
            }
            //return new int[] { };
            //Console.Write("NOT Found");
            return default;
        }



        
        /*public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            int i = 0;
            int j = 0;
            bool found = false;
            while (i < nums.Length && !found)
            {
                j = i + 1;
                while (j < nums.Length && !found)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        found = true;
                    }
                    j++;
                }
                i++;
            }
            return result;
        } */  

    }
}
