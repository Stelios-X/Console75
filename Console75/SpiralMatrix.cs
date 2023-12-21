using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class SpiralMatrix
    {
        /*
         * Time ComplexityO(m*n), where m is the number of rows and n is the number of columns in the matrix.
         * This is because we visit each cell exactly once.
         * 
         * Space Complexity O(1), as we only use a constant amount of space to store our current position and direction.
         * 
         *Given an m x n matrix, return all elements of the matrix in spiral order.
         *
         * We can solve this problem by using a simple iterative approach. We keep track of the current row and column, 
         * and the direction we’re moving in. We start from the top-left corner and move right. When we can’t move right anymore,
         * we move down. When we can’t move down anymore, we move left, and so on. We continue this process 
         * until we’ve visited every cell in the matrix.
         *
         *
         *
         */

        public IList<int> SpiralMatrixSol(int[][] matrix) 
        {
            if (matrix.Length == 0) 
            {
                return new List<int>();
            }

            int top = 0;
            int bottom = matrix.Length - 1;
            int right = matrix[0].Length - 1;
            int left = 0;

            var result = new List<int>();

            while (true)
            {
                //Move right
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }

                if (++top > bottom)
                {
                    break;
                }

                //Move down
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }

                if (--right < left)
                {
                    break;
                }

                //Move left
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }

                if (--bottom < top)
                {
                    break;
                }

                //Move up
                for (int i = bottom; i >= top; i--) 
                {
                    result.Add(matrix[i][left]);
                }

                if (++left > right) 
                {
                    break;
                }
            }
            return result;
        }
    }
}
