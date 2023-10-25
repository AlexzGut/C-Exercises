/* Author: John Alexander Gutierrez Gaviria
   Date: 10/24/2023 10:12 PM*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE_DECLARATOR = 3;
            int[,] matrix = new int[SIZE_DECLARATOR, SIZE_DECLARATOR];
            
            populateMatrix(matrix);
            
            Console.WriteLine("Matrix");
            displayMatrix(matrix);

            Console.WriteLine("\nSum of elements");
            Console.WriteLine("Primary Diagonal: {0}", primaryDiagonalSum(matrix));

            Console.WriteLine("Secondary Diagonal: {0}", secondaryDiagonalSum(matrix));

            Console.ReadLine();
        }

        public static int primaryDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        public static int secondaryDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, matrix.GetUpperBound(0) - i];
            }
            return sum;
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
