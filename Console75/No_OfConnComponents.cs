using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class No_OfConnComponents
    {
        /*Time Complexity O(n + e), where n is the number of nodes and e is the number of edges in the graph. 
         * This is because we are iterating over all the nodes and edges in the graph.
         * Space Complexity O(n), due to the space required for the parent array.
         * 
         * Given n nodes labeled from 0 to n - 1 and a list of undirected edges (each edge is a pair of nodes),
         * write a function to find the number of connected components in an undirected graph.

            A connected component of an undirected graph is a subgraph in which any two vertices are connected to each other by a path,
            and which is connected to no additional vertices outside the subgraph.

        The solution  
        We can solve this problem using Union-Find.
        The idea is to iterate over the edges and perform union operations for the nodes that are connected. 
        The number of connected components will be equal to the number of disjoint sets in the graph.
         
         */


        private int[] parent;
        public int No_OfConnComponentsSol(int n, int[][] edges) 
        {
            parent = new int[n];
            for (int i = 0 ; i < n; i++ ) 
            {
                parent[i] = i;
            }

            foreach ( var edge in edges) 
            {
                int root1 = Find(edge[0]);
                int root2 = Find(edge[1]);
                if (root1 != root2) 
                {
                    parent[root1] = root2;  
                    n--;
                }
            }
            return n;

        }
        private int Find(int x) 
        {
            if (parent[x] == x) 
            {
                return x;
            }
            parent[x] = Find(parent[x]);
            return parent[x];
        }
    }
}
