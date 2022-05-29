using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                }
                dict[name].Add(grade);

            }

            foreach (var item in dict)
            {
                string grades = string.Join(" ",item.Value.Select(x => x.ToString("f2")));
                Console.WriteLine($"{item.Key} -> {grades} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
