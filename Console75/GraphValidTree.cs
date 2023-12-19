using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class GraphValidTree
    {
        /*Time Complexity
         * Space Complexity
         * 
         * 
         * 
         * Given n nodes labeled from 0 to n - 1 and a list of undirected edges (each edge is a pair of nodes),
         * write a function to check whether these edges make up a valid tree.
           A valid tree is a tree that satisfies the following conditions:

                It is a fully connected graph, which means there is a path between every pair of nodes.
                It does not contain any cycles.

        The Solution implements a DFS, The idea is to traverse the graph using DFS and check for the two conditions of a valid tree.
         */


        private Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        public bool GraphValidTreeSol(int n, int[][] edges) 
        {
            //Initialize the graph
            for (int i = 0; i < n; i++) 
            {
                graph[i] = new List<int>();
            }

            //Add edges to the graph
            foreach (var edge in edges) 
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }
            
            HashSet<int> visited = new HashSet<int>();

            //Check if the graph is a valid tree
            if (!DFS(0, -1, visited)) 
            {
                return false;
            }

            //Check if all nodes were visited (i.e., the graph is fully connected)
            return visited.Count == n;
        }

        private bool DFS(int node, int parent, HashSet<int> visited) 
        {
            if (visited.Contains(node)) 
            {
                return false;
            }
            visited.Add(node);

            foreach (var neighbor in graph[node]) 
            {
                if (neighbor != parent && !DFS(neighbor, node, visited)) 
                {
                    return false;
                }
            }
            return true;
        }

    }
}
