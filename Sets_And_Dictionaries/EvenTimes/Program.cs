using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> ints = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!ints.ContainsKey(num))
                {
                    ints.Add(num,0);
                }
                ints[num]++;
            }
            Console.WriteLine(ints.First(entry => entry.Value % 2 == 0).Key);
        }
    }
}
