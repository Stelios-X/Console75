using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    //Time complexity O(amount * coins.Length)
    //Space complexity O(amount)
    //Given an arry denomination of coins and a total amount return the fewest number of coins that can meet that amount

    public class CoinChange 
    {
        public int CoinChangeSol(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            Array.Fill(dp, max);
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
               for (int j = 0; j < coins.Length; j++)
               {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
               }
            }
            Console.WriteLine(dp[amount] > amount ? -1 : dp[amount]);
            return dp[amount] > amount? -1 : dp[amount];
        }
    }
}
