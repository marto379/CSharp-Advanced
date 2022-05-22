using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine().ToLower();
            Stack<int> stack = new Stack<int>(numbers);
            while (input != "end")
            {
                string[] cmdArr = input.ToLower().Split(' ');
                string command = cmdArr[0].ToLower();

                if (command == "add")
                {
                    int num1 = int.Parse(cmdArr[1]);
                    int num2 = int.Parse(cmdArr[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (command == "remove")
                {
                    int numToRemove = int.Parse(cmdArr[1]);
                    if (stack.Count >= numToRemove)
                    {
                        for (int i = 0; i < numToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
