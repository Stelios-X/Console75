using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class LongestCons
    {
        //Time Complexity O(n)
        //Space Complexity O(n)
        //Given an unsorted array of integers, find the length of the longest consecutive elements sequence
        public int LongestConsSol(int[] nums) 
        {
            if (nums == null || nums.Length == 0) 
            {
                return 0;
            }

            HashSet<int> numSet = new HashSet<int>(nums);
            int longStreak = 0; 

            foreach (int num in numSet) 
            {
                //Starts counting from the smallest number of a streak
                if (!numSet.Contains(num - 1)) 
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    //Count consecutive elements in the increasing order
                    while (numSet.Contains(currentNum + 1)) 
                    {
                        currentNum++;
                        currentStreak++;
                    }
                    longStreak = Math.Max(longStreak, currentStreak);
                }

            }
            return longStreak;
        }    
    }
}
