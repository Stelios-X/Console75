using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class ConstructBinTree
    {
        /*
         * Time Complexity O(N), where N is the number of nodes in the binary tree. The algorithm visits each node once.
         * 
         * Space Complexity O(N) due to the recursive call stack. The space is used for the dictionary (inorderMap) and the recursion.
         * 
         * Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is 
         * the inorder traversal of the same tree, construct and return the binary tree.
         * 
         * The code builds a binary tree using the given preorder and inorder traversals.
           A dictionary (inorderMap) is used to store the indices of elements in the inorder array for quick lookup.
           The BuildTree function initializes the preorder index and calls the recursive helper function to build the tree.
           The BuildTreeHelper function creates nodes using the preorder values and recursively builds the left and right subtrees.
         * 
         */

        public TreeNode BuildTree(int[] preorder, int[] inorder) 
        {
            //Create a map to store the indices of inorder elements
            Dictionary<int, int> inorderMap = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++) 
            {
                inorderMap[inorder[i]] = i;
            }

            //Initialize the preorder index
            int preorderIndex = 0;

            //Build the tree using recursion
            return BuildTreeHelper(preorder, ref preorderIndex, inorderMap, 0, inorder.Length - 1);

        }

        private TreeNode BuildTreeHelper(int[] preorder, ref int preorderIndex, Dictionary<int, int> inorderMap, int inorderStart, int inorderEnd) 
        {
            //Base case: If the inorder indices are invalid, return null
            if (inorderStart > inorderEnd) 
            {
                return null;
            }

            //Create the current node using the current preorder value 
            TreeNode currentNode = new TreeNode(preorder[preorderIndex++]);

            //Find the index of the current node's value in the inorder array
            int inorderIndex = inorderMap[currentNode.val];

            //Recusively build the left and right subtrees
            currentNode.left = BuildTreeHelper(preorder, ref preorderIndex, inorderMap, inorderStart, inorderIndex - 1);
            currentNode.right = BuildTreeHelper(preorder, ref preorderIndex, inorderMap, inorderIndex + 1, inorderEnd);

            return currentNode;
        }

    }
}
