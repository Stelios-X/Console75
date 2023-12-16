using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class CombiSum
    {
        //Time complexity O(n^(target/min))
        //Space complexity O(target/min)
        //

        public IList<IList<int>> CombiSumSol(int[] candidates, int target) 
        {
            var results = new List<IList<int>>();
            Array.Sort(candidates); //The array is sorted first
            Backtrack(results, new List<int>(), candidates, target, 0);
            return results;
        }

        private void Backtrack(IList<IList<int>> list, List<int> tempList, int[] nums, int remain, int start ) 
        {
            if (remain < 0)
            {
                return;
            }
            else if (remain == 0)
            {
                list.Add(new List<int>(tempList));
            }
            else 
            {
                for (int i = start; i < nums.Length; i++) 
                {
                    tempList.Add(nums[i]);
                    Backtrack(list, tempList, nums, remain - nums[i], i); // As opposed to i + 1 coz we can reuse same elements
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }
    }
}
