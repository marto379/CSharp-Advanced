using System;
using System.Linq;

namespace SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = nums[0];
            int cows = nums[1];

            string[,] matrix = new string[rows, cows]; ;
            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] arr = Console.ReadLine().Split();
                

                for (int cow = 0; cow < cows; cow++)
                {
                    matrix[row, cow] = arr[cow];
                    
                }
            }
            for (int row = 0; row < rows -1; row++)
            {
                for (int cow = 0; cow < cows -1; cow++)
                {
                    if (matrix[row, cow] == matrix[row + 1, cow] && matrix[row, cow] == matrix[row, cow + 1] && matrix[row, cow] == matrix[row + 1, cow + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
            
        }
    }
}
