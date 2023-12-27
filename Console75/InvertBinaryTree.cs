using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class InvertBinaryTree
    {
        public TreeNode InvertTreeSol(TreeNode root) //Inherits from TreeNode class
        {
            //Base case: If the root is null, return null
            if (root == null) 
            {
                return null;
            }

            //Swap the left and right children of the current node
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            //Recusively invert the left and right subtrees
            InvertTreeSol(root.left);    
            InvertTreeSol(root.right);

            return root;
        }
    }
}
