using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class AlienDictionary
    {
        //Time Complexity O(C), where C is the total number of characters in the input words.
        //Space Complexity O(1) because the size of the alphabet is constant (26 lowercase letters in English),
        //and the space used by the dictionaries is proportional to the size of the alphabet, not the number of characters in the words.
        //
        //There is an alien language that employs the English alphabet. Unknown to you is the order of the letters.
        //You are given a list of strings, words form the dictionary where words are sorted lexicographically according to the rules of
        //the alien language. Derive the order of the letters in this language and return it. If a given input is invalid,
        //return an empty string. The solution employs Topological Sort:
        public string AlienDicSol(string[] words) 
        {
            Dictionary<char, HashSet<char>> graph = new Dictionary<char, HashSet<char>>();
            Dictionary<char, int> inDegree = new Dictionary<char, int>();

            //Initialize the graph and inDegree
            foreach (string word in words) 
            {
                foreach (char c in word) 
                {
                    if (!graph.ContainsKey(c)) 
                    {
                        graph[c] = new HashSet<char>();
                        inDegree[c] = 0;
                    }
                }
            }

            //Build the graph and update the inDegree
            for (int i = 0; i < words.Length - 1; i++) 
            {
                string word1 = words[i];
                string word2 = words[i + 1];
                for (int j = 0; j < Math.Min(word1.Length, word2.Length); j++) 
                {
                    char parent = word1[j]; 
                    char child = word2[j];

                    if (parent != child) 
                    {
                        if (!graph[parent].Contains(child)) 
                        {
                            graph[parent].Add(child);
                            inDegree[child]++;
                        }
                        break;
                    }
                    //Checking for invalid input
                    if (j + 1 == word2.Length && word1.Length > word2.Length) 
                    {
                        return "";
                    }
                }
            }
            //Collect nodes with inDegrees of 0
            Queue<char> queue = new Queue<char>();
            foreach(char c in inDegree.Keys) 
            {
                if (inDegree[c] == 0)
                { 
                    queue.Enqueue(c);
                }
            }

            //Topological Sort
            StringBuilder sb = new StringBuilder();
            while (queue.Count > 0) 
            {
                char c = queue.Dequeue();
                sb.Append(c);

                foreach (char child in graph[c]) 
                {
                    inDegree[child]--;
                    if (inDegree[child] == 0) 
                    {
                        queue.Enqueue(child);
                    }
                }
            }
            //Checking if all nodes are visited
            return sb.Length == inDegree.Count ? sb.ToString() : "";
        }
    }
}
