using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MinWindowSub
    {
        /*
         * Time Complexity O(N), where N is the length of the string s, because in the worst case we might end up 
         * visiting every element twice, once by end pointer and once by start pointer.
         * 
         * Space Complexity O(1), because we are using a fixed space for the counter array.
         * 
         * The problem, Minimum Window Substring (LeetCode No 76), asks to find the smallest substring in a given string s 
         * that contains all the characters of another string t. If there is no such window in s that covers all characters in t, 
         * return an empty string. If there are multiple such minimum-length windows, you are guaranteed that there will always be
         * only one unique minimum-length window.
         * 
         * 
         * The solution uses the sliding window technique. We maintain two pointers, start and end, and a counter to track 
         * the characters of t in s. We move the end pointer to find a valid window and when a valid window is found,
         * we move the start pointer to find a smaller window. We keep track of the minimum window size and update it 
         * whenever a smaller valid window is found.
         * 
         */

        public string MinWindowSubSol(string s, string t) 
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) 
            {
                return "";
            }

            int[] counter = new int[128];
            foreach (char c in t)
            {
                counter[c]++;
            }

            int start = 0;
            int end = 0;
            int head = 0;
            int length = int.MaxValue;
            int count = t.Length;

            while (end < s.Length)
            {
                if (counter[s[end++]]--> 0) 
                {
                    count--;
                }
                while (count == 0)
                {
                    if (end - start < length) 
                    {
                        length = end - (head = start);
                    }

                    if (counter[s[start++]]++ == 0) 
                    {
                        count++;
                    }
                }
            }
            return length == int.MaxValue ? "" : s.Substring(head, length);
        }
    }
}
