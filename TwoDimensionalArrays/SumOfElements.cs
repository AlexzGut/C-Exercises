/* Author: John Alexander Gutierrez Gaviria
 * Date: 10/23/2023 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5,5];
            populateTwoDimensionalArray(numbers);
            displayTwoDimensionalArray(numbers);
            Console.WriteLine("\nThe sum of all the elements in the two-dimensional array is: {0}", sum(numbers));
            Console.ReadLine();

        }

        public static void populateTwoDimensionalArray(int[,] array)
        {
            Random randomNumber = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = randomNumber.Next(100);
                }
            }
        }

        public static int sum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }

        public static void displayTwoDimensionalArray(int[,] array)
        {
            string output = "[";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                output += "[ ";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    output += $"{array[i, j],2} ";
                }
                output += "]";
                output += (array.GetUpperBound(0) != i) ? "\n " : "";
            }
            output += "]";
            Console.WriteLine("Two-dimensional Array\n{0}", output);
        }
    }
}
