using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class NumberOfIslands
    {
        //Time Complexity O(m * n), where m is the number of rows and n is the number of columns in the grid.
        //Space Complexity O(m * n)
        //Given a 2D grid 1s represent land while 0s represent water return the number of islands given an argument of grid map

        public int NumberOfIslandsSol(char[][] grid) 
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0) 
            {
                return 0;
            }

            int m = grid.Length;
            int n = grid[0].Length;
            int count = 0;

            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    if (grid[i][j] == '1') 
                    {
                        DFS(grid, i,j);
                        count++;
                    }
                }
            }
            return count;

        }

        private void DFS(char[][] grid, int i, int j) 
        {
            int m = grid.Length;
            int n = grid[0].Length;

            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == 0) 
            {
                return;
            }

            grid[i][j] = '0'; //Mark the current cell as visited 
            
            //Recusively visit neighbouring cells
            DFS(grid, i - 1, j);//Up
            DFS(grid, i + 1, j);//Down
            DFS(grid, i, j - 1);//Left
            DFS(grid, i, j + 1);//Right
        }
    }
}
