using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class SameTree
    {
        /*
         * Time Complexity O(N), where N is the total number of nodes in the smaller of the two trees. The algorithm visits each node once.
         * 
         * Space Complexity O(H), where H is the height of the smaller of the two trees. 
         * In the worst case (a skewed tree), the space complexity is O(N). 
         * In the best case (a balanced tree), the space complexity is O(log N).
         * 
         * Given two binary trees, write a function to check if they are the same or not. 
         * Two binary trees are considered the same if they are structurally identical and the nodes have the same value.
         * 
         * The code uses a recursive approach to check if two trees are the same.
           The base case checks if both nodes are null, in which case they are considered the same.
           If the nodes are not null and have the same value, the function recursively checks the left and right subtrees.
           If at any point the nodes are different or one is null while the other is not, the trees are not the same.
         */

        public bool SameTreeSol(TreeNode p, TreeNode q) //Inherits from TreeNode Class 
        {
            //Base case: Both nodes are null, so they are the same
            if (p == null && q == null) 
            {
                return true;
            }

            //Check if the nodes are not null and have the same value
            if (p != null && q != null && p.val == q.val) 
            {
                //Recusively check the left and right subtrees
                return SameTreeSol(p.left, q.left) && SameTreeSol(p.right, q.right);

            }

            //Nodes are either different or one is null while the other is not
            return false;
        }
    }
}
