using System;
using System.Linq;

namespace PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int rows = N;
            int cows = N;
            int[,] matrix = new int[rows,cows];
            int sumDiagonal = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cow = 0; cow < cows; cow++)
                {
                    matrix[row, cow] = arr[cow];
                    if (row == cow)
                    {
                        sumDiagonal += arr[cow];
                    }
                }
            }
            Console.WriteLine(sumDiagonal);
            
        }
    }
}
