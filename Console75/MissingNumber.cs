using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MissingNumber
    {
        //Time complexity O(n)
        //Space complexity O(n)
        //This algorithm takes a range of continuous numbers in an array and identifies the missing digit
        public int MissingNumberSol(int[] nums) 
        {
            int missing = nums.Length;
            for (int i = 0; i < nums.Length; i++) 
            {
                missing ^= i ^ nums[i];
            }
            Console.WriteLine(missing);
            return missing;
        }
    }
}
