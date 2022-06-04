using System;
using System.Linq;

namespace SortEvenNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(", ")
                .Select(n => int.Parse(n))
                .Where(n => n % 2 == 0)
                .ToArray();

            Console.WriteLine(String.Join(", ",tokens));
        }
    }
}
