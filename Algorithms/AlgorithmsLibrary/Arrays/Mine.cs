namespace AlgorithmsLibrary.Arrays
{
    /// <summary>
    /// Minesweeper Game
    /// </summary>
    public class Mine
    {
        /// <summary>
        /// Implement a function that assigns correct numbers in a field of Minesweeper, 
        /// which is represented as a 2 dimensional array.
        /// Example: The size of the field is 3x4, 
        ///          and there are bombs at the positions [0, 0] (row index = 0, column index = 0) 
        ///          and [0, 1] (row index = 0, column index = 1).
        /// 
        /// Then, the resulting field should be:
        ///  [-1, -1, 1, 0]
        ///  [ 2,  2, 1, 0]
        ///  [ 0,  0, 0, 0]
        ///  
        /// Your function should return the resulting 2D array after taking the following three arguments:
        /// 1) bombs: A list of bomb locations.  Given as an array of arrays.  
        ///    Example: [[0, 0], [0, 1]] ([row index = 0, column index = 0], [row index = 0, column index = 1].  
        ///    Assume that there are no duplicates.
        /// 2) num_rows: The number of rows in the resulting field.
        /// 3) num_columns: The number of columns in the resulting field. 
        /// 
        /// In the resulting field:
        ///   -1 represents that there is a bomb in that location. 
        ///    1, 2, 3... etc.represents that there are 1, 2, 3... etc. bombs in the surrounding cells(including diagonally adjacent cells).
        ///    0 represents that there are no bombs in the surrounding cells.
        /// </summary>
        /// <param name="mine"></param>
        /// <param name="numRows"></param>
        /// <param name="numCols"></param>
        /// <returns></returns>
        public int[,] Minesweeper(int[][] mine, int numRows, int numCols)
        {
            int[,] field = new int[numRows, numCols];
            foreach(int[] arr in mine)
            {
                int row = arr[0];
                int col = arr[1];

                field[row, col] = -1;

                for (int i=row -1; i < row+2; i++)
                {       
                    for (int j = col-1; j < col+2; j++)
                    {
                        if (i >= 0 && i < numRows && j >= 0 && j < numCols && field[i, j] != -1)
                            field[i, j]++;
                    }
                }
            }

            return field;
        }

}

}

  
