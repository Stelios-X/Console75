using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class InsertInterval
    {
        /*Time Complexity O(n), where n is the number of intervals. 
         * This is because we are iterating over all the intervals in the worst case.
         * Space Complexity  O(n), due to the space required for the result list.
         * 
         * Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary). 
         * You may assume that the intervals were initially sorted according to their start times.
         * 
         * We can solve this problem by iterating over the intervals and checking if the new interval overlaps with 
         * the current interval. If it does, we merge them. Otherwise, we add the current interval to the result.
         
         */

        public int[][] InsertIntervalSol(int[][] intervals, int[] newInterval) 
        {
            List<int[]> result = new List<int[]>();

            foreach (var interval in intervals) 
            {
                if (newInterval == null || interval[1] < newInterval[0])
                {
                    //Current interval ends before new interval starts
                    result.Add(interval);
                }
                else if (interval[0] > newInterval[1])
                {
                    //Current interval starts after new interval ends. No overlap
                    result.Add(newInterval);
                    result.Add(interval);
                    newInterval = null;
                }
                else 
                {
                    //Overlap, Merge the current interval into the new interval 
                    newInterval[0] = Math.Min(interval[0], newInterval[0]);
                    newInterval[1] = Math.Min(interval[1], newInterval[1]);

                }
            }
            if (newInterval != null) 
            {
                //Add the last interval
                result.Add(newInterval);
            }
            return result.ToArray();
        }
    }
}
