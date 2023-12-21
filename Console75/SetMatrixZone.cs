using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class SetMatrixZone
    {
        /*
         * Time Complexity O(m*n) where m is the number of rows and n the number of columns
         * Space Complexity O(1) because we only use a constant amount of space
         * 
         * 
         */

        public void SetMatrixSentinel(int[][] matrix) 
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            //variable to track of the first row and column neec to be zeroed
            bool firstRowZero = false;
            bool firstColZero = false;

            //Check if the first row needs to be zeroed
            for (int j = 0; j < n; j++ ) 
            {
                if (matrix[0][j] == 0) 
                {
                    firstRowZero = true;
                    break;
                }

            }

            //Check if the first column needs to be zeroed
            for (int i = 1; i < m; i++) 
            {
                for (int j = 1; j < n; j++) 
                {
                    if (matrix[i][j] == 0) 
                    {
                        matrix[i][0] = 0; //Mark the first column
                        matrix[0][j] = 0; //Mark the first row
                    }
                }
            }
            //Set zeros based marks in the first row and column
            for (int i = 1; i < m; i++) 
            {
                for (int j = 1; j < n; j++) 
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0) 
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            //Set zeros in the first row and column if needed
            if (firstRowZero) 
            {
                for (int j = 0; j < n; j++) 
                {
                    matrix[0][j] = 0;
                }
            }

            if (firstColZero) 
            {
                for (int i = 0; i < m; i++) 
                {
                    matrix[i][0] = 0;
                }
            }
        }
    }
}
