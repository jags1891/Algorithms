using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.Graphs
{
    /// <summary>
    /// Islands Graph Problems ( Improve)
    /// </summary>
    public class Islands
    {
        private int colCount = 0;
        private int rowCount = 0;
        private int[] adjRows = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
        private int[] adjCols = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

        /// <summary>
        /// Count and return the number of islands in the given 2D Matrix
        /// </summary>
        /// <param name="Matrix">2D Boolean Marrix</param>
        /// <returns></returns>
        public int countIslands(int[,] Matrix)
        {
            colCount = Matrix.GetLength(1);
            rowCount = Matrix.GetLength(0);

            bool[,] visited= new bool[rowCount, colCount];

            int isLandCount = 0;

            for(int row=0; row<rowCount; row++)
            {
                for(int col=0; col < colCount; col++)
                {
                    if (Matrix[row, col] == 1 && !visited[row, col])
                    {
                        DFS(Matrix, row, col, visited);
                        isLandCount++;
                    }
                }
            }

            return isLandCount;
        }

        /// <summary>
        /// Explore all island and updated visited matrix
        /// </summary>
        /// <param name="Matrix"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="visited"></param>
        private void DFS(int[,] Matrix, int row, int col, bool[,] visited)
        {
            visited[row, col] = true;

            for (int i = 0; i < 8; i++)
               if(isSafeToTraverse(Matrix, row+adjRows[i], col+adjCols[i], visited))
                   DFS(Matrix, row + adjRows[i], col + adjCols[i], visited);
        }

        /// <summary>
        /// Make sure we are not travesing out of bounds of matrix and revisiting the same row.
        /// </summary>
        /// <param name="Matrix"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="visited"></param>
        /// <returns></returns>
        private bool isSafeToTraverse(int[,] Matrix, int row, int col, bool[,] visited)
        {
            return ((row >= 0) && (row < rowCount) && (col >= 0) && (col < colCount) && (Matrix[row, col] == 1) && !visited[row, col]);
        }
    }

    
}
