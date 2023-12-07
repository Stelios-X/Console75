using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class HammingWeight
    {
        //Time Complexity O(1)
        //Space Complexity O(1)
        public int HammingWeightSol(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n & (n - 1);
            }
            //Console.WriteLine($"HammingWeight: {count}");
            return count;
        }   
    }
}
