using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class NumDecoding
    {
        //Time complexity O(n)
        //Space complexity O(n)
        //A key transalting alphabet characters to their respective order numbers eg A => 1 B, 2 is used to code and decode
        
        public int NumDecodingSol(string s) 
        {
            if (s[0] == '0') 
            {
                return 0; 
            }
            int n = s.Length;
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++) 
            {
                int oneDigit = Int32.Parse(s.Substring(i-1, 1));
                int twoDigits = Int32.Parse(s.Substring(i-2, 2));

                if (oneDigit >= 1) 
                {
                    dp[i] += dp[i - 1];
                }
                if (twoDigits >= 10 && twoDigits <= 26)
                {
                    dp[i] += dp[i - 2];  
                }
            }
            Console.WriteLine(dp[n]);
            return dp[n];
        }
    }
}
