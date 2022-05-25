using System;
using System.Linq;

namespace MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCows = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = rowsAndCows[0];
            int cols = rowsAndCows[1];

            int[,] matrix = new int[rows, cols];
            long maxSum = long.MinValue;
            int x = -1;
            int y = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];

                }
            }
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {

                    long currNum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currNum > maxSum)
                    {
                        maxSum = currNum;
                        x = row;
                        y = col;
                        
                    }

                }

            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[x,y]} {matrix[x,y + 1]} {matrix[x,y + 2]}\n" +
                $"{matrix[x+1,y]} {matrix[x+1,y + 1]} {matrix[x +1,y+2]} \n" +
                $"{matrix[x +2,y]} {matrix[x + 2,y+1]} {matrix[x+2,y+2]} ");
        }
    }
}
