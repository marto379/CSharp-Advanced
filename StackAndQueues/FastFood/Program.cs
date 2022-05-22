using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int orders = queue.Count();

            Console.WriteLine(queue.Max());
            for (int i = 0; i < orders; i++)
            {
                if (queue.Peek() <= quantity)
                {
                    quantity -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
                    return;
                }

            }
            Console.WriteLine("Orders complete");    

        }
    }
}
