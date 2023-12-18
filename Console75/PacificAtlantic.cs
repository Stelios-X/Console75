using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class PacificAtlantic
    {
        //Time Complexity O(m * n), where m is the number of rows and n is the number of columns in the input matrix.
        //Space Complexity O(m * n)
        //You have an island bordered by the Atlantic Ocean to the bottom and right & Pacific Ocean to the top n left
        //Ths island is divided into grid lines return a grid showing what cells the water will flow into and
        //in what ocean it will end up in given the arguments of the cells representing height above sea level  

        public IList<IList<int>> PacificAtlanticSol(int[][] heights) 
        {
            List<IList<int>> result = new List<IList<int>>();

            if (heights == null || heights.Length == 0 || heights[0].Length == 0) 
            {
                return result;
            }

            int m = heights.Length;
            int n = heights[0].Length;

            bool[,] canReachPacific = new bool[m, n];
            bool[,] canReachAtlantic = new bool[m, n];

            //DFS starting from the top and left borders (Pacific Ocean)
            for (int i = 0; i < m; i++)
            {
                DFS(heights, canReachPacific, i, 0);
            }

            for (int j = 0; j < n; j++) 
            {
                DFS(heights, canReachAtlantic, 0, j);
            }

            //DFS starting from the bottom and right (Atlantic Ocean)
            for (int i = 0; i < m; i++) 
            {
                DFS(heights, canReachAtlantic, i, n - 1);
            }

            for (int j = 0; j < n; j++)
            {
                DFS(heights, canReachAtlantic, m - 1, j);
            }

            //Find common cells that can reach both oceans
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    if (canReachPacific[i,j] && canReachAtlantic[i,j]) 
                    {
                        result.Add(new List<int> {i, j});
                    }
                }
            }
            return result;
        }

        private void DFS(int[][] heights, bool[,] canReach, int i, int j) 
        {
            int m = heights.Length;
            int n = heights[0].Length;

            canReach[i,j] = true;

            int[][] directions = { new int[] {-1, 0 }, new int[] { 1, 0}, new int[] { 0, -1}, new int[] { 0, 1} };

            foreach (var dir in directions) 
            {
                int newRow = i + dir[0];
                int newCol = j + dir[1];

                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && !canReach[newRow, newCol] 
                    && heights[newRow][newCol] >= heights[i][j]) 
                {
                    DFS(heights, canReach, newRow,newCol);
                }
            }
        }
    }
}
