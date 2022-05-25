using System;

namespace PascalTrpiangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int row = 0; row < n; row++)
            {
                jagged[row] = new int[row + 1];
                jagged[row][0] = 1;
                for (int cow = 1; cow < row; cow++)
                {
                    jagged[row][cow] = jagged[row - 1][cow - 1] + jagged[row - 1][cow];
                }
                jagged[row][row] = 1;
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(String.Join(" ", jagged[row]));
            }

        }
    }
}
