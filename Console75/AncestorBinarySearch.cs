using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class AncestorBinarySearch
    {
        /*
         * Time Complexity O(log N) on average, where N is the number of nodes in the BST.
           In the worst case (skewed tree), the time complexity is O(N).
         * 
         * Space Complexity O(1) as the algorithm uses constant extra space.
         * 
         * Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes p and q in the BST.
           The lowest common ancestor is defined between two nodes p and q as the lowest node in the tree that has both p and q as descendants.
         * 
         * The code uses an iterative approach to traverse the BST and find the lowest common ancestor.
           The loop continues until both nodes p and q are on the same side of the current root.
           The algorithm takes advantage of the BST property to determine the direction to traverse.
         */

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p,TreeNode q) 
        {
            //Traverse the tree
            while (root != null) 
            {
                //If both nodes are on the left side, go left
                if (p.val < root.val && q.val < root.val)
                {
                    root = root.left;
                }
                //If both nodes are  on the right side, go right
                else if (p.val > root.val && q.val > root.val)
                {
                    root = root.right;
                }
                // If one node is on the left and the other on the right, the current node is the LCA
                else 
                {
                    return root;
                }
            }
            return null;
        }
    }
}
