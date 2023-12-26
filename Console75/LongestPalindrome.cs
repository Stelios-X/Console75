using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class LongestPalindrome
    {
        /*
         * Time Complexity O(n^2), where n is the length of the string. This is because we need to fill up the dp array, 
         * which has n^2 elements.
         * 
         * Space Complexity O(n^2), due to the space required for the dp array.
         * 
         * The problem is to find the longest palindromic substring from a given string. A palindrome is a word, phrase, number, 
         * or other sequence of characters that reads the same forward and backward, ignoring spaces, punctuation, and capitalization.
         * 
         * The solution uses a dynamic programming approach. We create a 2D boolean array dp where dp[i][j] is true if
         * the substring s[i...j] is a palindrome, and false otherwise. We then iterate over all substrings of s, 
         * updating dp[i][j] and keeping track of the longest palindromic substring we’ve found so far.
         * 
         */
        public string LongestPalindromeSol(string s) 
        {
            int n = s.Length;
            bool[,] dp = new bool[n,n];
            int maxLength = 0;
            string longestPalindrome = "";

            //every single character is a palindrome
            for (int i = 0; i < n; i++ ) 
            {
                dp[i,i] = true;
                maxLength = 1; 
                longestPalindrome = s.Substring(i,1);
            }

            //Check for substring of length 2
            for (int i = 0; i < n - 1; i++) 
            {
                if (s[i] == s[i + 1])
                {
                    dp[i, i+1] = true;
                    maxLength = 2;
                    longestPalindrome = s.Substring(i, 2);
                }   
            }

            //Check for lengths greater than 2
            for (int len = 3; len <= n; len++)
            {
                for (int i = 0; i < n - len + 1; i++)
                {
                    int j = i + len - 1;
                    if (s[i] == s[j] && dp[i + 1, j - 1]) 
                    {
                        dp[i,j] = true;
                        maxLength = len;
                        longestPalindrome = s.Substring(i, len);
                    }
                }
            }
            return longestPalindrome;

        }
    }
}
