using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[numRows][];

            for (int row = 0; row < numRows; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int row = 0; row < numRows - 1; row++)
            {

                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArr = command.Split();
                string action = cmdArr[0];
                if (action == "Add")
                {
                    int row = int.Parse(cmdArr[1]);
                    int col = int.Parse(cmdArr[2]);
                    int value = int.Parse(cmdArr[3]);

                    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                    
                    
                }
                else if (action == "Subtract")
                {
                    int row = int.Parse(cmdArr[1]);
                    int col = int.Parse(cmdArr[2]);
                    int value = int.Parse(cmdArr[3]);

                    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }
                
            }
            foreach (var item in matrix)
            {
                Console.WriteLine(String.Join(" ",item));
            }
        }
    }
}
