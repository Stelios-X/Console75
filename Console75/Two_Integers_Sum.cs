using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class Two_Integers_Sum
    {
        //Returns the sum of 2 integers without using + or -
        //Time Complexity O(1)
        //Space Complexity O(1)

        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            Console.WriteLine($"Sum: {a}");
            return a;
        }
    }
}
