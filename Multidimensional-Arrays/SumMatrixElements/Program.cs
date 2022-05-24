
namespace SumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int rows = int.Parse(input[0]);
            int cows = int.Parse(input[1]);
            int[,] matrix = new int[rows, cows];
            for (int row = 0; row < rows ; row++)
            {
                int[] intput1  = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cow = 0; cow < cows ; cow++)
                {
                    matrix[row, cow] = intput1[cow];
                }
            }
            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine($"{rows}\n{cows}\n{sum}");


        }
    }
}