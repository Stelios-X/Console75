using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class Node
    {
        public int val;
        public List<Node> neighbors;

        public Node(int val)
        {
            this.val = val;
            this.neighbors = new List<Node>();
        }
    }
}
