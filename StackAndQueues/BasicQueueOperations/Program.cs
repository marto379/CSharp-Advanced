using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = numbers[0];
            int S = numbers[1];
            int X = numbers[2];
            int[] digits = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(digits[i]);
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(X))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = Console.ForegroundColor;
                Console.WriteLine("true");
               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(queue.Min());
            }


        }
    }
}
