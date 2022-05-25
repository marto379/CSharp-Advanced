using System;
using System.Linq;

namespace JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArr[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commands = input.Split();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int cow = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (row >= 0 && row < jaggedArr.Length && cow >= 0 && cow < jaggedArr[row].Length)
                {
                    if (command == "Add")
                    {
                        jaggedArr[row][cow] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jaggedArr[row][cow] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

            }
            foreach (int[] row in jaggedArr)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
