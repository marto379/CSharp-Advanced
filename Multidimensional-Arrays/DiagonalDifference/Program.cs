using System;
using System.Linq;

namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cows = n;
            int[,] matrix = new int[n, n];
            int sumPrimary = 0;
            int sumSecond = 0;

            for (int row = 0; row < n ; row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int cow = 0; cow < cows; cow++)
                {
                    matrix[row,cow] = arr[cow];
                    if (row == cow)
                    {
                        sumPrimary += arr[cow];
                    }
                    if (row + cow == rows - 1)
                    {
                        sumSecond += arr[cow];
                    }

                }
            }
            Console.WriteLine(Math.Abs(sumPrimary - sumSecond));
        }
    }
}
