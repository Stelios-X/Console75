using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ContainsDuplicate
    {
        //madwolf18 solution - This approach removes any duplicates and
        //then compares the length of the original array to the length of the array with duplicates removed.
        //If the lengths are different, then there were duplicates.
        //Time Complexity O(n)
        //Space Complexity O(n)

        
        public bool ContainsDuplicateSol(int[] nums)
        {
            var set = new HashSet<int>(nums);
            return set.Count != nums.Length;
        }
        

        /*Alternatives
        public bool ContainsDuplicateSol(int[] nums) 
        {
            return nums.Length != nums.Distinct().Count();
            return (nums.Distinct().Count()!=nums.Length);
        } 
        */
    }
}
