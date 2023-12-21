using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console75
{
    public class RotateImage
    {
        /*
         * Time Complexity O(n^2), where n is the number of rows or columns in the matrix. 
         * This is because the code performs two nested loops over the matrix elements.
         * 
         * Space Complexity  O(1) since the algorithm uses only a constant amount of extra space regardless of the input size.
         * 
         * The code first transposes the matrix by swapping elements across the main diagonal.
           After transposing, it reverses each row to achieve the desired rotation effect
         * 
         */

        public void RotateImageSol(int[][] matrix) 
        {
            int n = matrix.Length;
            //Transpose the matrix

            for (int i = 0; i < n; i++ ) 
            {
                for (int j = i + 1; j < n; j++) 
                {
                    //Swap matrix[i][j] and matrix[j][i]
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            //Reverese each row of the transposed matrix
            for (int i = 0; i < n; i++) 
            {
                Array.Reverse(matrix[i]);
            }
        }
    }
}
