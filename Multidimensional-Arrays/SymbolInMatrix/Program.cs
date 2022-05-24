using System;

namespace SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int rows = N;
            int cows = N;

            char[,] matrix = new char[rows, cows];

            for (int row = 0; row < rows; row++)
            {
                char[] ch = Console.ReadLine().ToCharArray();
                for (int cow = 0; cow < cows; cow++)
                {
                    matrix[row, cow] = ch[cow];
                }
            }
            char chToFind = Console.ReadLine()[0];
            for (int row = 0; row < rows; row++)
            {
                for (int cow = 0; cow < cows; cow++)
                {
                    if (matrix[row,cow] == chToFind)
                    {
                        Console.WriteLine($"({row}, {cow})");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{chToFind} does not occur in the matrix");
        }
    }
}
