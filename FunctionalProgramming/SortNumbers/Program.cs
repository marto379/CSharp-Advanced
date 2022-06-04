using System;
using System.Linq;

namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string,int> parse = (string str) => int.Parse(str);
            string tokens = Console.ReadLine();
            int[] nums = tokens.Split(", ").Select(parse).ToArray();
            Console.WriteLine(nums.Count() + "\n" + nums.Sum());
            
        }
    }
}
