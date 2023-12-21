using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class WordSearch
    {
        /*
         * Time Complexity O(m * n * 4^k), where m and n are the dimensions of the board, and k is the length of the word. 
         * The factor of 4^k comes from the four possible directions in each recursive call.
         * 
         * Space Complexity O(k), where k is the length of the word. This is the maximum depth of the recursive call stack.
         * 
         * 
         * Given a 2D board and a word, find if the word exists in the grid. The word can be constructed from letters of sequentially
         * adjacent cells, where "adjacent" cells are horizontally or vertically neighboring. 
         * The same letter cell may not be used more than once.
         * 
         * 
         * The code uses Depth-First Search (DFS) to explore the possible paths in the grid to match the given word.
            It starts from each cell on the board, looking for the starting point of the word.
            The DFS function explores neighboring cells recursively, marking visited cells along the way.
            After exploration, the original state of the board is restored.
         */

        public bool WordSearchSol(char[][] board, string word) 
        {
            int m = board.Length;
            int n = board[0].Length;

            //Iterate through the board to find the starting point of the word
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    if (board[i][j] == word[0]) 
                    {
                        //Use DFS to check if the word can be formed from this starting point
                        if (DFS(board, i, j, word, 0)) 
                        {
                            return true;
                        }

                    }
                }
            }
            return false;
        }

        private bool DFS(char[][] board, int i, int j, string word, int index) 
        {
            if (index == word.Length) 
            {
                //All characters of the word have been matched 
                return true;
            }

            if (i < 0 || i>= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[index]) 
            {
                //Out of bounds or mismatch characters
                return false;
            }

            //Mark the current cell as visited
            char originalChar = board[i][j];
            board[i][j] = '#';

            //Explore neighborhood cells in DFS
            bool found = DFS(board, i + 1, j, word, index + 1) ||
                         DFS(board, i - 1, j, word, index + 1) ||
                         DFS(board, i, j + 1, word, index + 1) ||
                         DFS(board, i, j - 1, word, index + 1);

            //restore the original character after exploration
            board[i][j] = originalChar;

            return found;
        }
    }
}
