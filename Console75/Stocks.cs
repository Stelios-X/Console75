using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class Stocks
    {
        //Daisy001 solution 
        //Time Complexity O(n)
        //Space Complexity O(1)
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            //Console.Write(maxProfit);
            return maxProfit;
        }

    }
}
