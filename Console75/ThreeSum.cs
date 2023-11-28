using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ThreeSum
    {
        //Time Complexity O(n^2)
        //Space Complexity O(n)

        public IList<IList<int>> ThreeSumSol(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++) 
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i-1])) 
                {
                    int low = i + 1;
                    int high = nums.Length - 1;
                    int sum = 0 - nums[i];

                    while (low < high)
                    {
                        if (nums[low] + nums[high] == sum)
                        {
                            result.Add(new List<int> { nums[i], nums[low], nums[high] });
                            while (low < high && nums[low] == nums[low + 1]) low++;
                            while (low < high && nums[high] == nums[high - 1]) high--;
                            low++;
                            high--;
                        }
                        else if (nums[low] + nums[high] < sum)
                        {
                            low++;
                        }
                        else
                        {
                            high--;
                        }
                    }   
                }
            }
            Console.WriteLine("result.Count: " + result.Count);
            return result;
        }   


    }
}
