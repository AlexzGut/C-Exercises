/* Author: John Alexander Gutierrez Gaviria
   Date: 10/24/2023 10:45 AM */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[5, 3];
            int[,] matrixB = new int[3, 2];

            populateMatrix(matrixA);
            Console.WriteLine("Matrix A");
            displayMatrix(matrixA);

            populateMatrix(matrixB);
            Console.WriteLine("\nMatrix B");
            displayMatrix(matrixB);

            Console.WriteLine("\nProduct of Matrix A * Matrix B");
            displayMatrix(matrixMultiplication(matrixA, matrixB));
            Console.ReadLine();
        }

        public static void populateMatrix(int[,] matrix)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = randomNumber.Next(101);
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

        public static int[,] matrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            int[,] product = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            if (matrixA.GetLength(1) == matrixB.GetLength(0)) {
                int result = 0;
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++) // columns
                    {
                        result = 0;
                        for (int k = 0; k < matrixB.GetLength(0); k++) // rows
                        {
                            result += matrixA[i, k] * matrixB[k, j];
                        }
                        product[i, j] = result;
                    }
                    
                }
                return product;
            } 
            else
            {
                return product;
            }         
        }
    }
}
