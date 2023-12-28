using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class WordSearchII
    {
        /*
         * Time Complexity O(N * M * 4^L), where N is the number of rows, M is the number of columns, and L is the maximum length of words.
         * 
         * Space Complexity  O(N * M + W * L), where N is the number of rows, M is the number of columns, 
         * W is the number of words, and L is the maximum length of words.
         * 
         * Given an m x n board of characters and a list of words, find all words in the board.

           Each word must be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally 
           or vertically neighboring. The same letter cell may not be used more than once in a word.
         *
         *The code uses a trie (prefix tree) to efficiently store the given words.
          It explores the board using a depth-first search (DFS) and backtracking approach, checking for valid words using the trie.
          The Explore method performs the DFS and backtracking, marking visited cells with '#'.
          The examples demonstrate the usage of the WordSearchII class with different boards and words.
         */
        public IList<string> FindWords(char[][] board, string[] words)
        {
            List<string> result = new List<string>();
            Trie trie = new Trie();

            //Insert words into the trie
            foreach (string word in words)
            {
                trie.Insert(word);
            }

            //Explore each cell on the board
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++) 
                {
                    Explore(board, i, j, trie, result, new StringBuilder());
                }
            }
            return result;
        }

        private void Explore(char[][] board, int i, int j, Trie trie, List<string> result, StringBuilder current) 
        {
            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] == '#') 
            {
                return; // Out of bounds or already visited
            }

            char original = board[i][j];
            current.Append(original);
            board[i][j] = '#'; //Mark as visited

            string currentWord = current.ToString();
            if (trie.StartsWith(currentWord)) 
            {
                if (trie.StartsWith(currentWord) && trie.StartsWith(currentWord) && !result.Contains(currentWord)) 
                {
                    result.Add(currentWord);
                }

                //Explore neighbouring cells
                Explore(board, i - 1, j, trie, result, current);
                Explore(board, i + 1, j, trie, result, current);
                Explore(board, i, j - 1, trie, result, current);
                Explore(board, i, j + 1, trie, result, current);
            }
            board[i][j] = original; //Backtrack
            current.Length--; //Backtrack
        }
    }
}
