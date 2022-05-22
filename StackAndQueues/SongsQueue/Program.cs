using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));

            while (queue.Count > 0)
            {
                string input = Console.ReadLine();
                string[] cmdArr = input.Split();
                string command = cmdArr[0];

                if (command == "Add")
                {
                    string newSong = input.Substring(4);
                    if (!queue.Contains(newSong))
                    {
                        queue.Enqueue(newSong);
                    }
                    else
                    {
                        Console.WriteLine($"{newSong} is already contained!");
                    }
                }
                else if (command == "Play")
                {
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine(String.Join(", ", queue));
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
