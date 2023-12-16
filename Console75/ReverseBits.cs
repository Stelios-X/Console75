using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ReverseBits
    {
        //Time Complexity O(1)
        //Space Complexity O(1)
        //The algorithm returms the reverse bits of a given 32 bit unsigned integer

        public uint ReverseBitsSol(uint n) 
        {
            uint result = 0;
            for (int i = 0; i < 32; i++) 
            {
                result <<= 1;
                if((n & 1) == 1) 
                {
                    result++;
                }
                n >>= 1;
            }
            return result;
        }
    }
}
