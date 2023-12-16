using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class WordBreak
    {
        //Time complexity O(n^2)
        //Space complexity O(n)
        //The algorithm takes 2 arguments a string and a dictionary of strings, true is returned in the event that
        //the passed dictionary can be created by splitting the string 
        public bool WordBreakSol(string s, IList<string> wordDict) 
        {
            var wordDictSet = new HashSet<string>(wordDict);
            var dp = new bool[s.Length + 1];
            dp[0] = true;

            for (int i = 1; i <= s.Length; i++ ) 
            {
                for (int j = 0; j < i; j++) 
                {
                    if (dp[j] && wordDictSet.Contains(s.Substring(j,i - j))) 
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }
            //Console.WriteLine(dp[s.Length]);
            return dp[s.Length];
        }
    }
}
