using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = coordinates[0];
            int cols = coordinates[1];
            char[,] matrix = new char[rows, cols];

            string input = Console.ReadLine();
            var queue = new Queue<char>(input);

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = queue.Peek(); 
                        queue.Enqueue(queue.Dequeue());

                    }
                }
                else
                {
                    for (int col = cols-1; col >= 0; col--)
                    {
                        matrix[row, col] = queue.Peek();
                        queue.Enqueue(queue.Dequeue());
                    }
                }
                
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
