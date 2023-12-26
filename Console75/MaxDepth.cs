using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class MaxDepth
    {
        /*
         *Time Complexity O(N), where N is the number of nodes in the binary tree. The algorithm visits each node once.
         *
         *Space ComplexityO(H), where H is the height of the binary tree. In the worst case (a skewed tree), 
         *the space complexity is O(N). In the best case (a balanced tree), the space complexity is O(log N). 
         *
         *Given the root of a binary tree, return its maximum depth. A binary tree’s maximum depth is the number of nodes along 
         *the longest path from the root node down to the farthest leaf node.
         *
         *The problem can be solved using recursion. We can calculate the maximum depth of the left and right subtrees recursively
         *and return the maximum of the two plus one (for the root node). If the root node is null, we return 0.
         */
        public int MaxDepthSol(TreeNode root)
        {
            if (root == null)
            {
                return 0; // If the root is null, the depth is 0.
            }

            // Recursively calculate the depth of the left and right subtrees
            int leftDepth = MaxDepthSol(root.left);
            int rightDepth = MaxDepthSol(root.right);

            // The maximum depth is the maximum of the left and right subtree depths, plus 1 for the current level.
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
