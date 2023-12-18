using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console75
{

        public class CloneGraph
        {

        //Time Complexity O(V + E) where V is the number of nodes (vertices) and E is the number of edges in the graph
        //Space Complexity O(V)
        //Given a reference of a Node in a connected undirected graph, return a deep copy (clone) of the graph.
        //Note that each node in the graph contains a value and a list of its neighbors 
        //This class makes a reference to The Node.sc class 

        public Node CloneGraphSol(Node node) 
            {
                if (node == null) 
                {
                    return null;
                }
                Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
                Queue<Node> queue = new Queue<Node>();

                //Enqueue the first node
                queue.Enqueue(node);
                visited[node] = new Node(node.val);

                while (queue.Count > 0) 
                {
                    Node current = queue.Dequeue();

                    foreach (var neighbor in current.neighbors) 
                    {
                        if (!visited.ContainsKey(neighbor)) 
                        {
                            visited[neighbor] = new Node(neighbor.val);
                            queue.Enqueue(neighbor);
                        }
                        visited[current].neighbors.Add(visited[neighbor]);
                    }
                }
                return visited[node];
            }

        }
}
