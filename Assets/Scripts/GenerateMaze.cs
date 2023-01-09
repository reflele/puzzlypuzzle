using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public class GenerateMaze
    {
        
        public int[,] CreateMatrixOfTwos(int rows, int columns)
        {
            
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 2;
                }
            }

            return matrix;
            
        }

        
        public void removeBlock(int value, int[,] matrix)
        {
            int removedBlocks = 0;
            int width = matrix.GetLength(0);
            int length = matrix.GetLength(1);
            int row = (value - 1) / length;
            int col = (value - 1) % length;

            // if (matrix[row, col] != 0)
            // {
                matrix[row, col] = 0;
                // removedBlocks++;
                // Console.Write("removedBlocks: " + removedBlocks);
            // }
            // else
            // {
            //     removeBlock(value,matrix);
            // }
        }

        public int randomNumber(int width, int length)
        {
            int maxNumber = (width * length) + 1;
            int randomNumber = UnityEngine.Random.Range(1, maxNumber);
            return randomNumber;
        }

        public int[,] PadEdges(int[,] input) {
            int rows = input.GetLength(0);
            int cols = input.GetLength(1);

            // Create a new array with one extra row at the top and bottom and one extra column at the left and right
            int[,] padded = new int[rows + 2, cols + 2];

            // Initialize the left and right columns to 2
            for (int i = 0; i < rows + 2; i++) {
                padded[i, 0] = 2;
                padded[i, cols + 1] = 2;
            }

            // Initialize the top and bottom rows to the original top and bottom rows
            for (int j = 0; j < cols; j++) {
                padded[0, j + 1] = input[0, j];
                padded[rows + 1, j + 1] = input[rows - 1, j];
            }

            // Copy the rest of the original array into the padded array
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    padded[i + 1, j + 1] = input[i, j];
                }
            }

            return padded;
        }


        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j < matrix.GetLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }
        }


        

        // Depth-first search function to check if there is a connected path of 0's from the bottom to the top
        public bool DFS(int[,] matrix, int row, int col)
        {
            // Create a stack to store the positions to visit
            Stack<int[]> stack = new Stack<int[]>();

            // Push the starting position onto the stack
            stack.Push(new int[] { row, col });

            // Create a 2D boolean array to store the visited positions
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            // While the stack is not empty
            while (stack.Count > 0)
            {
                // Pop the top position from the stack
                int[] position = stack.Pop();
                row = position[0];
                col = position[1];

                // Check if the current position is out of bounds or the value is not 0
                if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1) ||
                    matrix[row, col] != 0 || visited[row, col])
                {
                    continue;
                }

                // Mark the current position as visited
                visited[row, col] = true;

                // Check if the top position is the top row
                if (row == 0)
                {
                    return true;
                }

                // Push the top, right, bottom, and left positions onto the stack
                stack.Push(new int[] { row - 1, col });
                stack.Push(new int[] { row, col + 1 });
                stack.Push(new int[] { row + 1, col });
                stack.Push(new int[] { row, col - 1 });
            }

            // Return false if no path is found
            return false;
        }

        public bool IsSolvable(int[,] matrix)
        {
            // Check if the matrix is empty or null
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }

            // Get the number of rows and columns in the matrix
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Check if the matrix has a connected path of 0's from the bottom to the top
            for (int col = 0; col < cols; col++)
            {
                if (matrix[rows - 1, col] == 0)
                {
                    if (DFS(matrix, rows - 1, col))
                    {
                        return true;
                    }
                }
            }

            // Return false if no path is found
            return false;
        }


        

    }

}