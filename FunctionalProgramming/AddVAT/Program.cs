using System;
using System.Linq;

namespace AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVAT = x => x *= 1.2m;

            string tokens = Console.ReadLine();
            decimal[] nums = tokens.Split(", ").Select(decimal.Parse).Select(addVAT).ToArray();
            Array.ForEach(nums, x => Console.WriteLine("{0:f2}",x));
        }
    }
}
