using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ValidPalindrome
    {
        /*
         * Time Complexity O(n), where n is the length of the string. This is because we are scanning through the string once.
         * 
         * Space Complexity  O(1), as we are not using any extra space that scales with the input size.
         * 
         * 
         * The problem, Valid Palindrome (LeetCode No 125), asks to determine if a given string is a palindrome. 
         * A palindrome is a word, phrase, number, or other sequences of characters that reads the same forward and backward, 
         * ignoring spaces, punctuation, and capitalization.
         * 
         * The solution involves two pointers approach. We initialize two pointers, one at the start of the string, 
         * and the other at the end of the string. We then compare the characters at these pointers. If they are the same, 
         * we move the pointers towards each other and continue the comparison until the pointers meet. If all the comparisons 
         * were successful, the string is a palindrome.
         * 
         */

        public bool ValidPalindromeSol(string s) 
        {
            //Initialize two pointers
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                //Skip non-alphabetical characters
                if (!Char.IsLetterOrDigit(s[start]))
                {
                    start++;
                }
                else if (!Char.IsLetterOrDigit(s[end]))
                {
                    end--;
                }
                else 
                {
                    //Compare characters case-insensitively
                    if (Char.ToLower(s[start]) != Char.ToLower(s[end])) 
                    {
                        return false;
                    }
                    start++;
                    end--;
                }

            }
            return true;
        }
    }
}
