using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (name != "End")
            {
                if (name != "Paid")
                {
                    queue.Enqueue(name);
                    
                }
                else
                {
                    Console.WriteLine(String.Join("\n",queue));
                    queue.Clear();
                }
                name = Console.ReadLine();
            } 
            Console.WriteLine($"{queue.Count} people remaining.");
            
        }
    }
}
