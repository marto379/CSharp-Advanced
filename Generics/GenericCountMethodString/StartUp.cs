using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var numLines = int.Parse(Console.ReadLine());
            var list = new List<string>();

            for (int i = 0; i < numLines; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);

            }
            var box = new Box<string>(list);
            var elementToCompare = Console.ReadLine();
            var count = box.CountOfGreaterElement(list, elementToCompare);
            Console.WriteLine(count);
        }
    }
}
