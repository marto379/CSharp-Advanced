using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
               foreach (string s in input)
                {
                    set.Add(s); 
                }
            }
            Console.WriteLine(string.Join(" ",set));
        }
    }
}
