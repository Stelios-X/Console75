using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ValidAnagram
    {
        /*
         * Time Complexity O(n) where n is the length of the strings and we consider the space used by the frequency table 
         * as constant because the table’s size remains the same irrespective of the size of 
         * the string (as the number of possible characters is fixed).
         * 
         * Space Complexity O(1)
         * 
         * The problem “Valid Anagram” (LeetCode No 242) asks us to determine if two given strings are anagrams of each other. 
         * An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
         * typically using all the original letters exactly once. For example, the word “cinema” is an anagram of “iceman”.
         * 
         * A simple and efficient solution to this problem is to use a frequency count approach. We can create a frequency count
         * of all the characters in the first string, and then for every character in the second string,
         * we decrement its count in our frequency table. If at any point, the count becomes negative or after checking 
         * all characters in the second string, some characters in the first string have a non-zero count, 
         * we conclude that the two strings are not anagrams of each other. Otherwise, they are anagrams.


         */

        public bool ValidAnagramSol(string s, string t) 
        {
            //If the lengths are not equal, they cannot be anagrams
            if (s.Length != t.Length) 
            {
                return false;
            }

            //Frequency count array
            int[] count = new int[26];

            //Increment count for characters in s
            for (int i = 0; i < s.Length; i++) 
            {
                count[s[i] - 'a']++;
            }

            //Decrement count for characters in t
            for (int i = 0; i < t.Length; i++)
            {
                if (--count[t[i] - 'a'] < 0) 
                {
                    return false;
                }
            }

            //If we reach here, strings are anagrams
            return true;

        }
    }
}
