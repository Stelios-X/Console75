using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class TreeLevelOrder
    {
        /*
         * Time Complexity O(N), where N is the number of nodes in the tree. The algorithm visits each node once.
         * 
         * Space Complexity O(M), where M is the maximum number of nodes at any level. 
         * In the worst case (a completely skewed tree), the space complexity is O(N). In the best case (a balanced tree), 
         * the space complexity is O(1).
         * 
         * Given a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
         * 
         * The code uses a breadth-first traversal (level-order traversal) to visit each level of the binary tree.
           A queue is used to process nodes level by level.
           For each level, the nodes are dequeued, and their values are added to the current level list.
           The left and right children of each node are enqueued if they exist.
           The current level list is added to the result.
           The process continues until all levels are processed.
         * 
         */

        public IList<IList<int>> LevelOrder(TreeNode root) 
        {
            IList<IList<int>> result = new List<IList<int>>();

            //Base case: If the root is null, return an empty list
            if (root == null) 
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0) 
            {
                int levelSize = queue.Count;
                List<int> currentLevel = new List<int>();

                //Process all nodes at the current level
                for (int i = 0; i < levelSize; i++) 
                {
                    TreeNode currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode.val);

                    //Enqueue left and right children if they exist
                    if (currentNode.left != null) 
                    {
                        queue.Enqueue(currentNode.left);
                    }
                    if (currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }
                //Add the current level to the result
                result.Add(currentLevel);
            }
            return result;
        }

    }
}
