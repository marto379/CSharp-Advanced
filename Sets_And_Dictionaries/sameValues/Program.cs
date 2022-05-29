using System;
using System.Collections.Generic;
using System.Linq;

namespace sameValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double,int> values = new Dictionary<double, int>();
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                double currNum = arr[i];
                if (!values.ContainsKey(currNum))
                {
                    values.Add(currNum,0);
                }
                values[currNum]++;
            }
            foreach (var item in values)
            {
                double num = item.Key;
                int count = item.Value;
                Console.WriteLine($"{num} - {count} times");
            }

        }
    }
}
