using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ValidateSearchTree
    {
        /*
         * Time Complexity O(N), where N is the number of nodes in the binary tree. The algorithm visits each node once.
         * 
         * Space Complexity O(H), where H is the height of the binary tree. The space is used for the recursive call stack. 
         * In the worst case (skewed tree), H can be equal to N, but in a balanced tree, H is log(N).
         * 
         * Given the root of a binary tree, determine if it is a valid binary search tree (BST). A valid BST is defined as follows:
           The left subtree of a node contains only nodes with keys less than the node's key.
           The right subtree of a node contains only nodes with keys greater than the node's key.
           Both the left and right subtrees must also be binary search trees.
         *
         *The code uses a recursive approach to validate whether a binary tree is a valid BST.
          The IsValidBST function serves as the entry point, calling the recursive helper function with an initial valid range.
          The IsValidBSTHelper function checks if the current node's value is within the valid range and recursively validates the left and right subtrees.
         */

        public bool IsValidBST(TreeNode root) 
        {
            //Use a helper function to perform recusive validation
            return IsValidBSTHelper(root, long.MinValue, long.MaxValue); 

        }

        private bool IsValidBSTHelper(TreeNode node, long lowerBound, long upperBound) 
        {
            //Base case: If the node is null, it is a valid BST(empty subtree)
            if (node  == null) 
            {
                return true;
            }

            //Check if the current node's value is within the valid range
            if (node.val <= lowerBound || node.val >= upperBound) 
            {
                return false;
            }

            //Recusively check the left and right subtrees
            return IsValidBSTHelper(node.left, lowerBound, node.val) && IsValidBSTHelper(node.right, node.val, upperBound);

        }
    }
}
