using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class TreeMaxPathSum
    {
        /*
         * Time Complexity O(N), where N is the number of nodes in the tree. The algorithm visits each node once.
         * 
         * Space ComplexityO(H), where H is the height of the tree. In the worst case (a skewed tree), 
         * the space complexity is O(N). In the best case (a balanced tree), the space complexity is O(log N). 
         * 
         * Given a binary tree, find the maximum path sum. The path may start and end at any node in the tree and 
         * can move only up and down the tree.
         * 
         * The code uses a recursive approach to find the maximum path sum.
           The MaxPathDown function is a helper function that calculates the maximum path sum for a subtree rooted at the current node.
           The global maxSum variable is updated during the traversal to keep track of the maximum path sum.
           At each node, the function calculates the maximum path sum considering both left and right subtrees and the current node.
           The result is the maximum path sum for the entire tree.
         * 
         */

        private int maxSum = int.MinValue;

        public int MaxPathSum(TreeNode root) //External class TreeNode
        {
            //Start the recusive traversal
            MaxPathDown(root);

            return maxSum;
        }

        private int MaxPathDown(TreeNode node) 
        {
            //Base case: If the node is null return 0
            if (node == null) 
            {
                return 0;
            }

            //Recusively calculate the maximum path  sum for the left and right subtrees
            int left = Math.Max(0, MaxPathDown(node.left));
            int right = Math.Max(0, MaxPathDown(node.right));

            //Update the global maximum path sum considering the current node
            maxSum = Math.Max(maxSum, left + right + node.val);

            //Return the maximum path sum from the current node to its parent
            return Math.Max(left,right) + node.val;
        }

    }
}
