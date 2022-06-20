using System;
using System.Linq;

namespace TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeMatrix, sizeMatrix];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] arr = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
            int countBlack = 0;
            int countSummer = 0;
            int countWhite = 0;
            int eaten = 0;

            string commands = Console.ReadLine();
            while (commands != "Stop the hunt")
            {
                string command = commands.Split()[0];
                int row = int.Parse(commands.Split()[1]);
                int col = int.Parse(commands.Split()[2]);

                if (command == "Collect")
                {
                    char truffel = matrix[row, col];
                    matrix[row, col] = '-';
                    if (IsValid(row,col,sizeMatrix))
                    {
                        if (truffel == 'B')
                        {
                            countBlack++;
                        }
                        else if (truffel == 'W')
                        {
                            countWhite++;
                        }
                        else if (truffel == 'S')
                        {
                            countSummer++;
                        }

                    }
                }
                else if (command == "Wild_Boar")
                {
                    string direction = commands.Split()[3];
                    if (direction == "up")
                    {
                        while (IsValid(row,col,sizeMatrix))
                        {
                            if (IsEaten(row,col,matrix))
                            {
                                eaten++;
                            }
                            row -= 2;
                        }
                    }
                    else if (direction == "down")
                    {
                        while (IsValid(row, col, sizeMatrix))
                        {
                            if (IsEaten(row, col, matrix))
                            {
                                eaten++;
                            }
                            row += 2;
                        }
                    }
                    else if (direction == "right")
                    {
                        while (IsValid(row, col, sizeMatrix))
                        {
                            if (IsEaten(row, col, matrix))
                            {
                                eaten++;
                            }
                            col += 2;
                        }
                    }
                    else if (direction == "left")
                    {
                        while (IsValid(row,col,sizeMatrix))
                        {
                            if (IsEaten(row, col, matrix))
                            {
                                eaten++;
                            }
                        }
                        
                        col -= 2;
                    }
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine($"Peter manages to harvest {countBlack} black, {countSummer} summer, and {countWhite} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eaten} truffles.");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsValid(int row,int col, int size)
        {
            if (row >= 0 && row < size && col >= 0 && col < size)
            {
                return true;
            }
            return false;
        }
        public static bool IsEaten(int row,int col, char[,] matrix)
        {
            char currSymbol = matrix[row, col];
            if (currSymbol != '-')
            {
                matrix[row, col] = '-';
                return true;
            }
            return false;
        }
    }
}
