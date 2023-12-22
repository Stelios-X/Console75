using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class CharacterReplacement
    {
        /*
         * Time Complexity O(n), where n is the length of the string. This is because we visit each character in the string once.
         * 
         * Space Complexity O(1), as the maximum number of keys in the hash map is the number of distinct characters in the string,
         * which is at most the size of the alphabet.
         * 
         * Given a string s and an integer k, return the length of the longest substring of s that contains 
         * at most k distinct characters
         * 
         * We can solve this problem using a sliding window approach. We keep track of 
         * the frequency of each character in the current window using a hash map. If the number of distinct characters 
         * in the window exceeds k, we move the left end of the window to the right until we’re back to k distinct characters. 
         * The maximum length of the window during this process is the length of the longest substring with 
         * at most k distinct characters.
         * 
         * 
         * 
         */

        public int CharacterReplacementSol(string s, int k) 
        {
            int[] count = new int[256]; //There are 256 ASCII characters
            int numDistinct = 0;
            int i = 0;
            int maxLength = 0;

            for (int j = 0; j < s.Length; j++) 
            {
                if (count[s[j]]++ == 0) //Increment count [s[j]] 
                {
                    numDistinct++;
                }

                if (numDistinct > k) 
                {
                    while (--count[s[i++]] > 0) //Decrement count[s[i]] and increment i 
                    {

                    }
                    numDistinct--;
                }
                maxLength = Math.Max(maxLength, j - i + 1);
            }
            return maxLength;
        }
    }
}
