/* Author: John Alexander Gutierrez Gaviria
   Date: 10/24/2023 10:42 PM */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ROWS_DECLARATOR = 3,
                      COLS_DECLARATOR = 5;
            int[,] matrix = new int[ROWS_DECLARATOR, COLS_DECLARATOR];
            int elementToSearch = 15;
            string coordinates = String.Empty;

            populateMatrix(matrix);

            Console.WriteLine("Matrix");
            displayMatrix(matrix);

            coordinates = searchMatrix(matrix, elementToSearch);
            Console.WriteLine("\nSearching for ocurrences of the number: {0}", elementToSearch);
            Console.WriteLine("Coordinates of ocurrences: {0}", coordinates);

            Console.ReadLine();
        }

        // search an element in the matrix and returnsa string with the coordinates(row, col) of all occurrences of the element.
        public static string searchMatrix(int[,] matrix, int element)
        {
            string coordinates = "[ ";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (element == matrix[i, j])
                    {
                        coordinates += $"({i},{j}) ";
                    }
                }
            }
            coordinates += "]";
            return coordinates;
        }

        // populates the matrix from left to right and top to bottom
        public static void populateMatrix(int[,] matrix)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = randomNumber.Next(100);
                }
            }
        }

        public static void displayMatrix(int[,] matrix)
        {
            string output = "[";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                output += "[";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output += $"{matrix[i, j],3}";
                }
                output += " ]";
                output += (matrix.GetUpperBound(0) != i) ? "\n " : "";
            }
            output += "]";
            Console.WriteLine(output);
        }

    }
}
