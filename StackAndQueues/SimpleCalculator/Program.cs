using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] reversed = input.Split().Reverse
                ().ToArray();
            Stack<string> stack = new Stack<string>(reversed);

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    stack.Push((first + second).ToString());
                }
                else if (operation == "-")
                {
                    stack.Push((first - second).ToString());
                }

            }
            Console.WriteLine(stack.Pop());


        }
    }
}
