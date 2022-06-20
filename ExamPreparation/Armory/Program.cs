using System;
using System.Linq;

namespace Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i,j] = chars[j];
                }
                Console.WriteLine();

            }
            
            int rowOfficer = -1;
            int colOfficer = -1;

            int rowMirror1 = -1;
            int colMirror1 = -1;

            int rowMirror2 = -1;
            int colMirror2 = -1;

            bool isNotValid = false; 
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == 'A')
                    {
                       
                        rowOfficer = i;
                        colOfficer = j;
                        matrix[i, j] = '-';
                       
                    }
                    
                    else if (matrix[i, j] == 'M')
                    {
                        if (rowMirror1 != -1 && colMirror1 != -1)
                        {
                            rowMirror2 = i;
                            colMirror2 = j;
                            matrix[rowMirror2, colMirror2] = '-';
                        }
                        else
                        {
                            rowMirror1 = i;
                            colMirror1 = j;
                            matrix[i, j] = 'N';
                        }
                        
                    }
                }
            }
            int sumCoins = 0;
            string direction = Console.ReadLine();
            while (sumCoins < 65)
            {
                if (direction == "up")
                {
                    rowOfficer--;
                    if (IsValid(rowOfficer, colOfficer, size))
                    {
                        char next = matrix[rowOfficer, colOfficer];
                        if (char.IsDigit(next))
                        {
                            matrix[rowOfficer, colOfficer] = '-';
                            sumCoins += (int)char.GetNumericValue(next);

                        }
                        else if (char.IsLetter(next))
                        {
                            matrix[rowMirror1, colMirror1] = '-';
                            rowOfficer = rowMirror2;
                            colOfficer = colMirror2;
                        }
                        

                            
                    }
                    else
                    {
                        isNotValid = true;
                        break;
                    }
                }
                else if (direction == "down")
                {
                    rowOfficer++;
                    if (IsValid(rowOfficer, colOfficer, size))
                    {
                        char next = matrix[rowOfficer, colOfficer];
                        if (char.IsDigit(next))
                        {
                            matrix[rowOfficer, colOfficer] = '-';
                            sumCoins += (int)char.GetNumericValue(next);
                        }
                        else if (char.IsLetter(next))
                        {
                            matrix[rowMirror1, colMirror1] = '-';
                            rowOfficer = rowMirror2;
                            colOfficer = colMirror2;
                        }
                        
                    }
                    else
                    {
                        isNotValid = true;
                        break;
                    }
                }
                else if (direction == "left")
                {
                    colOfficer--;
                    if (IsValid(rowOfficer, colOfficer, size))
                    {
                        char next = matrix[rowOfficer, colOfficer];
                        if (char.IsDigit(next))
                        {
                            matrix[rowOfficer, colOfficer] = '-';
                            sumCoins += (int)char.GetNumericValue(next);
                        }
                        else if (char.IsLetter(next))
                        {
                            matrix[rowMirror1, colMirror1] = '-';
                            rowOfficer = rowMirror2;
                            colOfficer = colMirror2;
                        }
                        
                    }
                    else
                    {
                        isNotValid = true;
                        break;
                    }
                }
                else if (direction == "right")
                {
                    colOfficer++;
                    if (IsValid(rowOfficer, colOfficer, size))
                    {
                        char next = matrix[rowOfficer, colOfficer];
                        if (char.IsDigit(next))
                        {
                            matrix[rowOfficer, colOfficer] = '-';
                            sumCoins += (int)char.GetNumericValue(next);
                        }
                        else if (char.IsLetter(next))
                        {
                            matrix[rowMirror1, colMirror1] = '-';
                            rowOfficer = rowMirror2;
                            colOfficer = colMirror2;
                        }
                        
                    }
                    else
                    {
                        isNotValid = true;
                        break;
                    }
                }
                direction = Console.ReadLine();
            }
            if (isNotValid)
            {
                Console.WriteLine("I do not need more swords!");
            }
            else
            {
                matrix[rowOfficer,colOfficer] = 'A';
            }
            if (sumCoins >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }
            Console.WriteLine($"The king paid {sumCoins} gold coins.");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }


        }
        public static bool IsValid(int row, int col, int size) => row >= 0 && row < size && col >= 0 && col < size;
    }
}
