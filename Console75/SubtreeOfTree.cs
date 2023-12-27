using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class SubtreeOfTree
    {
        /*
         * Time Complexity O(M * N) in the worst case, where M is the number of nodes in tree s, and N is the number of nodes in tree t.
         * 
         * Space Complexity O(min(M, N)) in the worst case, where M is the number of nodes in tree s, 
         * and N is the number of nodes in tree t. The space is used for the recursive call stack.
         * 
         * Given two non-empty binary trees s and t, check whether tree t has exactly the same structure and node values with
         * a subtree of s. A subtree of s is a tree that consists of a node in s and all of this node's descendants. 
         * The tree s could also be considered as a subtree of itself.
         * 
         * The code uses a recursive approach to check if tree t is a subtree of tree s.
           The IsSameTree function checks if two trees are exactly the same.
           The IsSubtree function recursively checks if the current subtree of s is the same as tree t or if t is a subtree of the left or right subtree of s.
         * 
         */


        public bool IsSubtree(TreeNode s, TreeNode t) 
        {
            if (s == null) 
            {
                return false;
            }

            //Check if the current subtree matches the target tree
            if (IsSameTree(s,t)) 
            {
                return true;
            }

            //Recusively check the left and right subtrees
            return IsSubtree(s.left,t) || IsSubtree(s.right, t);
        }

        private bool IsSameTree(TreeNode s, TreeNode t) 
        {
            if (s == null && t == null) 
            {
                return true;
            }
            if (s == null || t == null) 
            {
                return false;
            }

            //Check if the current nodes have the same value
            if (s.val != t.val) 
            {
                return false;
            }

            //Recusively check the left and right subtrees
            return IsSameTree(s.left, t.left) && IsSameTree(s.right, t.right);
        }

    }
}
