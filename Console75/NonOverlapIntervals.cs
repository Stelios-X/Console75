using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    /*
     * Time complexity O(N log N), where N is the number of intervals. This is due to the sorting step.
     * Space complexityO(1) since the algorithm uses a constant amount of space regardless of the input size.
     * 
     * 
     * Given a collection of intervals, find the minimum number of intervals you need to remove 
     * to make the rest of the intervals non-overlapping
     * 
     * The code sorts the intervals based on their end times and then iterates through the sorted intervals.
       It counts the number of overlapping intervals and keeps track of the end time of the current non-overlapping interval.
       The result is the minimum number of intervals to be removed to make the rest non-overlapping.
     
     */
    public class NonOverlapIntervals
    {
        public int EraseOverlapInt(int[][] intervals) 
        {
            if (intervals == null || intervals.Length <= 1) 
            {
                return 0; //No removal needed for 0 or 1 interval
            }
            //Sort intervals based on their end time
            Array.Sort(intervals, (a,b) => a[1].CompareTo(b[1]));

            int removals = 0;
            int end = intervals[0][1];

            //Iterate through sorted intervals and count overlapping intervals
            for (int i = 1; i < intervals.Length; i++) 
            {
                if (intervals[i][0] < end)
                {
                    removals++;
                }
                else 
                {
                    end = intervals[i][1];     
                }
            }
            return removals;

        }
    }
}
