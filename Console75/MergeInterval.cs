using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MergeInterval
    {
        /*Time ComplexityO(n log n), where n is the number of intervals. This is because we are sorting the intervals, 
         * which takes O(n log n) time, and then iterating over them, which takes O(n) time.
         * 
         * Space Complexity  O(N), where N is the number of intervals. 
         * This is due to the additional space used for the merged intervals list.
         * 
         * 
         * Given an array of intervals where intervals[i] = [start_i, end_i], merge all overlapping intervals, 
         * and return an array of the non-overlapping intervals that cover all the intervals in the input.
         * 
         * We can solve this problem by first sorting the intervals by their start times. 
         * Then, we iterate over the sorted intervals and merge any overlapping intervals.
         
         */

        public int[][] MergeIntervalSol(int[][] intervals)
        {

            //If the input is empty, then an empty list is returned
            if (!intervals.Any()) 
            {
                return new int [0][];
            }

            //Sort the intervals by start time
            Array.Sort (intervals, (a,b) => a[0].CompareTo(b[0]));

            var merged = new List<int[]>();
            foreach (var interval in intervals)
            {
                //If the list of merged intervals is empty or if the current
                //interval doesn't overlap with the previous, append it
                if (!merged.Any() || merged.Last()[1] < interval[0])
                {
                    merged.Add(interval);
                }
                //Otherwise there is an overlap, so we merge the current and previous intervals
                else 
                {
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }
            }  
            return merged.ToArray();
        }   
    }
}
