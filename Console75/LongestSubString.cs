using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class LongestSubString
    {
        /*
         * Time Complexity O(n), where n is the length of the input string. The algorithm performs a single pass through the string.
         * 
         * Space Complexity O(min(m, n)), where m is the size of the character set (constant) and n is the length of the input string.
         * The space used by the lastIndexMap is bounded by the size of the character set.
         * 
         * Given a string s, find the length of the longest substring without repeating characters.
         * 
         * The code uses a sliding window approach with two pointers (left and right) to track the longest substring without repeating characters.
           It maintains a lastIndexMap to store the last index of each character in the current substring.
           If a character repeats and its last index is greater than or equal to the left pointer, the left pointer is updated to the next position after the last occurrence of the character.
           The maximum length is updated during each iteration.
         * 
         */

        public int LongestSubStringSol(string s) 
        {
            int n = s.Length;
            int maxLength = 0;
            int left = 0;

            Dictionary<char, int> lastIndexMap = new Dictionary<char, int>();

            for (int right = 0; right < n; right++) 
            {
                if (lastIndexMap.ContainsKey(s[right]) && lastIndexMap[s[right]] >= left) 
                {
                    //Update the left pointer if the character is repeated
                    left = lastIndexMap[s[right]] + 1;
                }

                //Update the maximum length
                maxLength = Math.Max(maxLength, right - left + 1);

                //Update the last index of the current character
                lastIndexMap[s[right]] = right;
            }
            return maxLength;

        }
    }
}
