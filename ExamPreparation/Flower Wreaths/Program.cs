using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Flower_Wreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liliesInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] rosesInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Stack<int> lilies = new Stack<int>(liliesInput);
            Queue<int> roses = new Queue<int>(rosesInput);

            int wreaths = 0;
            //List<int> leftFlowers = new List<int>();
            int leftFlowers = 0;

            while (lilies.Any() && roses.Any())
            {

                int currLily = lilies.Peek();
                int curRose = roses.Peek();
                int sum = currLily + curRose;

                if (sum == 15)
                {
                    wreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    var curLil = lilies.Pop();
                    lilies.Push(curLil - 2);
                }
                else 
                {
                    leftFlowers += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }
            if (leftFlowers >= 15)
            {
                while (leftFlowers >= 15)
                {
                    wreaths++;
                    leftFlowers -= 15;
                }
            }
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
