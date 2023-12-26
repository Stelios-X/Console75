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
         *Time Complexity O(n), where n is the number of nodes in the binary tree. This is because we visit each node exactly once.
         *
         *Space Complexity  O(h), where h is the height of the binary tree. This is because the maximum number of function calls on
         *the call stack at any given time is equal to the height of the binary tree. 
         *
         *Given the root of a binary tree, return its maximum depth. A binary tree’s maximum depth is the number of nodes along 
         *the longest path from the root node down to the farthest leaf node.
         *
         *The problem can be solved using recursion. We can calculate the maximum depth of the left and right subtrees recursively
         *and return the maximum of the two plus one (for the root node). If the root node is null, we return 0.
         */
        public int MaxDepthSol(TreeNode root)  //There's an external class TreeNode
        {
            //If the root node is null, return 0
            if (root == null) 
            {
                return 0;
            }

            //Calculate the maximum depth of the left and right subtrees recusively
            int leftDepth = MaxDepthSol(root.left);
            int rightDepth = MaxDepthSol(root.right);

            //Return the maximumof the two plus one(for the root node)
            return Math.Max(leftDepth, rightDepth) + 1;

        }
    }
}
