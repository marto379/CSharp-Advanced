using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
             var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            int n = queue.Count;

            for (int i = 0; i < n; i++)
            {
                if (queue.Peek() % 2 == 1)
                {
                    queue.Dequeue();
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
            Console.WriteLine(String.Join(", ",queue));
        }
    }
}
