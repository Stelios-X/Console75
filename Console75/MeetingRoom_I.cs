using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MeetingRoom_I
    {
        /*
         Time Complexity O(n log n) due to the sorting operation, where n is the number of meetings.
         Space Complexity O(1) as no additional space is used.
         
         Given an array of meeting time intervals where intervals[i] = [starti, endi], determine if a person could attend all meetings.

         The idea is to sort the intervals by start time. Then, iterate through the intervals and for each one,
         check if it starts before the previous one ends.

         
         */

        public bool MeetingRoom_ISol(int[][] intervals) 
        {
            //Sort the intervals by start time.
            Array.Sort(intervals, (a,b) => a[0] - b[0]);

            //Iterate through the intervals
            for (int i = 1; i < intervals.Length; i++) 
            {
                //If the current intervals starts before the previous one ends, return false
                if (intervals[i][0] < intervals[i - 1][1])
                {
                    return false;
                }
            }

            //If we made it through all the intervals, return true
            return true;
        }
    }
}
