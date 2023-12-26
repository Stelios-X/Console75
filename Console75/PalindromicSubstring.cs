using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class PalindromicSubstring
    {
        /*
         * Time Complexity O(n^2) where n is the length of the string.
         * 
         * Space Complexity O(n^2)
         * 
         * Given a string, your task is to count how many palindromic substrings in this string. The substrings with different start
         * indexes or end indexes are counted as different substrings even if they consist of the same characters.
         * 
         *  We can solve this problem using dynamic programming. The idea is to use a boolean table dp[n][n] to denote whether 
         *  the substring from index i to j is palindrome. We initialize the table with false values and fill up the diagonal 
         *  with true (since a single character is always a palindrome). Then we fill up the table in a bottom-up manner. 
         *  For each substring of length greater than 1, we check if the first and last characters are the same and 
         *  the substring in between is also a palindrome (which we can find from the table). If these conditions are met, 
         *  we mark the substring as palindrome and increment our counter.
         * 
         */
        public int PalindromicSubstringSol(String s) 
        {
            int n = s.Length;
            bool[,] dp = new bool[n,n];
            int count = 0;

            //Allsubstrings of length 1 are palindromes
            for (int i = 0;i < n; i++, count++ ) 
            {
                dp[i,i] = true;
            }

            for (int len = 2; len <= n; len++) 
            {
                for (int i = 0, j = i + len - 1; j < n; i++, j++ ) 
                {
                    if (s[i] == s[j]) 
                    {
                        //Substring of length2 is palindrome if both characters are the same
                        //For longer substrings, check if the string without the first and last character is a palindrome
                        dp[i, j] = len == 2 || dp[i+1, j-1];
                    }
                    if (dp[i,j]) 
                    {
                        count++; //Increment count if substring is palindrome
                    }
                }
            }

            return count;
        }
    }
}
