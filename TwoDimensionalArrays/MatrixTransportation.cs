/* Author: John Alexander Gutierrez Gaviria
   Date: 10/24/2023 9:20 PM*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTransportation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ROWS_DECLARATOR = 5,
                      COLS_DECLARATOR = 2;
            int[,] matrixA = new int[ROWS_DECLARATOR, COLS_DECLARATOR];

            Console.WriteLine("Original Matrix");
            populateMatrix(matrixA);
            displayMatrix(matrixA);

            Console.WriteLine("\nTransposed Matrix");
            displayMatrix(transposeMatrix(matrixA));

            Console.ReadLine();
        }

        public static int[,] transposeMatrix(int[,] matrix)
        {
            // Number of rows of the original matrix will be the number of columns in the transposed matrix.
            // Number of columns of the original matrix will be the number of rows in the transposed matrix.
            int[,] transposedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    transposedMatrix[col, row] = matrix[row, col];
                }
            }

            return transposedMatrix;
        }

        public static void populateMatrix(int[,] matrix)
        {
            Random randomNumber = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = randomNumber.Next(100);
                }
            }
        }

        public static void displayMatrix(int[,] matrix)
        {
            string output = "[";
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                output += "[ ";
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    output += $"{matrix[row, col],2} ";
                }
                output += "]";
                output += (matrix.GetUpperBound(0) != row) ? "\n " : "";
            }
            output += "]";
            Console.WriteLine(output);
        }
    }
}
