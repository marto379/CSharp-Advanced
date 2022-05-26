using System;
using System.Linq;

namespace MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] arr = Console.ReadLine().Split(); ;
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            string inputCmd = Console.ReadLine();
            while (inputCmd !=  "END")
            {
                string[] commands = inputCmd.Split();
                string command = commands[0];
                if (command != "swap" || commands.Length != 5)
                {
                    Console.WriteLine("Invalid input");
                    inputCmd = Console.ReadLine();
                    continue;

                }
                else
                {
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);  
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);

                    if (row1 < 0 || matrix.GetLength(0) < row1 || matrix.GetLength(0) < row2 || row2 < 0 || col1 < 0 || matrix.GetLength(1) < col1 || matrix.GetLength(1) < col2 || col2 < 0)
                    {
                        Console.WriteLine("Invalid input");
                        inputCmd = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        string item1 = matrix[row1, col1];  
                        string item2 = matrix[row2, col2];
                        matrix[row1, col1] = item2;
                        matrix[row2, col2] = item1;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                        inputCmd = Console.ReadLine();
                    }
                }
            }
            
        }
    }
}
