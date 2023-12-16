using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class BitCounter
    {
        //Time complexity O(n)
        //Space complexity O(n)

        public int[] BitCounterSol(int n) 
        {
            int[] result = new int[n + 1];
            for (int i = 1; i <= n; i++) 
            {
                result[i] = result[i >> 1] + (i & 1);
            }
            return result;
        }
    }
}
