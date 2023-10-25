/* Author: John Alexander Gutierrez Gaviria
   Date: 10/24/2023 9:35 PM*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ROWS_DECLARATOR = 3,
                      COLS_DECLARATOR = 5;
            int[,] matrix = new int[ROWS_DECLARATOR, COLS_DECLARATOR];

            populateMatrix(matrix);

            Console.WriteLine("Matrix");
            displayMatrix(matrix);
            Console.WriteLine("\nLargest number in the matrix: {0}", largestElement(matrix));

            Console.ReadLine();
        }

        public static int largestElement(int[,] matrix)
        {
            int largestElement = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > largestElement)
                    {
                        largestElement = matrix[i, j];
                    }
                }
            }
            return largestElement;
        }

        public static void populateMatrix(int[,] matrix)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = randomNumber.Next(200);
                }
            }
        }

        public static void displayMatrix(int[,] matrix)
        {
            string output = "[";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                output += "[ ";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output += $"{matrix[i, j],3} ";
                }
                output += "]";
                output += (matrix.GetUpperBound(0) != i) ? "\n " : "";
            }
            output += "]";
            Console.WriteLine(output);
        }
    }
}
