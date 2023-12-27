using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class SmallestElement
    {
        /*
         * Time Complexity O(N), where N is the number of nodes in the binary tree. The in-order traversal visits each node once.
         * 
         * Space Complexity O(N) due to the space used for the result list during the in-order traversal.
         * 
         * Given the root of a binary search tree (BST) and an integer k, return the kth smallest element in the BST.
         * 
         * The code uses an in-order traversal to create a list of elements in ascending order.
           The KthSmallest function then returns the kth element from this list.
         * 
         */

        public int KthSmallest(TreeNode root, int k) 
        {
            //Use an in-order traversal to get the kth smallest element
            List<int> inorderList = new List<int>();    
            InOrderTraversal(root, inorderList);

            //Return the kth element from the inorder list
            return inorderList[k -1];

        }

        private void InOrderTraversal(TreeNode node, List<int> result) 
        {
            //Base case: If the node is null, return
            if (node == null) 
            {
                return;
            }

            //Traverse the left subtree
            InOrderTraversal(node.left, result);

            //Visit the current node (add to the result list)
            result.Add(node.val);

            //Traverse the right subtree
            InOrderTraversal(node.right, result);
        }
    }
}
