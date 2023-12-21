using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ListNoder
    {
        public int val;
        public ListNoder next;
        public ListNoder(int x) 
        {
            val = x;
            next = null;
        }
    }
}
