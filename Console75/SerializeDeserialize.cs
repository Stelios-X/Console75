using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class SerializeDeserialize
    {
        /*
         * Time Complexity for both serialization and deserialization is O(N), where N is the number of nodes in the tree.
         * 
         * Space Complexity O(N) for both serialization and deserialization. The space is used to store the serialized string and the queue during deserialization.
         * 
         * Serialization is the process of converting a data structure or object into a format that can be easily stored and 
         * reconstructed later. Binary tree serialization is often used to store and transmit the structure of a binary tree.

           Design an algorithm to serialize and deserialize a binary tree. There is no restriction on how your 
           serialization/deserialization algorithm should work. You just need to ensure that a binary tree can be serialized to 
           a string, and this string can be deserialized to the original tree structure.
         * 
         */


        //Encodes a tree to a single string
        public string serialize(TreeNode root) 
        {
            StringBuilder sb = new StringBuilder();
            SerializeHelper(root, sb);
            return sb.ToString();
        }

        private void SerializeHelper(TreeNode node, StringBuilder sb) 
        {
            if (node == null) 
            {
                sb.Append("null,");
                return;
            }

            //Serialize the current node's value
            sb.Append(node.val).Append(',');

            //Recusively serialize the left and right subtrees
            SerializeHelper(node.left, sb);
            SerializeHelper(node.right, sb);
        }

        //Decodes your encoded data to a tree
        public TreeNode deserialize(string data) 
        {
            Queue<string> nodes = new Queue<string>(data.Split(','));

            //Deserialize the tree using pre-order trversal
            return DeserializeHelper(nodes);
        }

        private TreeNode DeserializeHelper(Queue<string> nodes) 
        {
            string val = nodes.Dequeue();

            if (val == "null") 
            {
                return null;
            }

            //Create the current node
            TreeNode node = new TreeNode(int.Parse(val));

            //Recusively build the left and right subtrees
            node.left = DeserializeHelper(nodes);
            node.right = DeserializeHelper(nodes);

            return node;
        }

    }
}
