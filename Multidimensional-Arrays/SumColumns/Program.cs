using System;
using System.Linq;

namespace SumColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int rows = int.Parse(input[0]);
            int cows= int.Parse(input[1]);

            int[,] matrix = new int[rows, cows];

            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cow = 0; cow < cows; cow++)
                {
                    matrix[row, cow] = arr[cow];
                }
            }
            int columnSum = 0;
            for (int cow = 0; cow < cows; cow++)
            {
                for (int row = 0; row < rows; row++)
                {
                    columnSum += matrix[row, cow];
                }
                Console.WriteLine(columnSum);
                columnSum = 0;  
            }
        }
    }
}
