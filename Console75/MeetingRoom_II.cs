using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MeetingRoom_II
    {
        /*
         * Time Complexity O(n log n) due to the sorting operation and the operations on the priority queue.
         * Space Complexity O(n) as we use a priority queue to keep track of end times.
         * 
         * Given an array of meeting time intervals where intervals[i] = [starti, endi], find the minimum number of conference rooms required.
         * 
         * 
         * The idea is to sort the intervals by start time, then use a priority queue (min-heap) to keep track of end times.
         * When a new interval starts before the earliest ending meeting, we need a new room.
         
         */

        public int MeetingRoom_IISol(int[][] intervals) 
        {
            //Sort intervals by start time
            Array.Sort(intervals, (a,b) => a[0] - b[0]);

            //Initialize a priority queue to keep track of end times
            var endTimes = new SortedSet<int[]>
                (
                    Comparer<int[]>.Create((a,b) => a[0] != b[0] ? a[0] - b[0] : a[1] - b[1])
                );

            //Add the end time to the first meeting
            endTimes.Add(new[] { intervals[0][1], 0 });

            for (int i = 1; i < intervals.Length; i++) 
            {
                //If the first meeting starts after the earliest meeting, remove that meeting from the queue
                if (intervals[i][0] >= endTimes.Min[0]) 
                {
                    endTimes.Remove(endTimes.Min);
                }

                //Add the current meeting's end to the queue
                endTimes.Add(new[] { intervals[i][1], i });
            }
            //The size of the queue is the minimum number of rooms required
            return endTimes.Count;
        }
    }
}
