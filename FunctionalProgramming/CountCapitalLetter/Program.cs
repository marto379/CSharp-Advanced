using System;
using System.Linq;

namespace CountCapitalLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine().Split().Where(x => char.IsUpper(x[0]) && x.Length > 0)));
        }
    }
}
