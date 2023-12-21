﻿using System;
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
            bool isCol = false;
            for (int i = 0; i < matrix.Length; i++) 
            {
                if (matrix[i][0] == 0) 
                {
                    isCol = true;
                }

                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[0][j] = 0;
                        matrix[i][0] = 0;
                    }
                }
            }
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0 ) 
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            if (matrix[0][0] == 0) 
            {
                for (int j = 0; j < matrix[0].Length; j++) 
                {
                    matrix[0][j] = 0;
                }
            }

            if (isCol) 
            {
                for (int i = 0; i < matrix.Length; i++) 
                {
                    matrix[i][0] = 0;
                }
            }
            
        }
    }
}
