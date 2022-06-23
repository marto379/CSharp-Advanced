using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffects = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] bombCasing = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Dictionary<string, int> bombs = new Dictionary<string, int>
            {
                {"Datura Bombs",0 },
                {"Cherry Bombs",0 },
                {"Smoke Decoy Bombs",0 },
            };

            Queue<int> effects = new Queue<int>(bombEffects);
            Stack<int> casing = new Stack<int>(bombCasing);

            //bool isFill = false;

            while (effects.Any() && casing.Any())
            {
                var currEff = effects.Peek();
                var currCasing = casing.Peek();

                int sum = currEff + currCasing;

                if (sum == 40)
                {
                    bombs["Datura Bombs"]++;
                    effects.Dequeue();
                    casing.Pop();
                }
                else if (sum == 60)
                {
                    bombs["Cherry Bombs"]++;
                    effects.Dequeue();
                    casing.Pop();
                }
                else if (sum == 120)
                {
                    bombs["Smoke Decoy Bombs"]++;
                    effects.Dequeue();
                    casing.Pop();
                }
                else
                {
                    if (IsFill(bombs))
                    {
                        break;
                    }
                    casing.Pop();
                    casing.Push(currCasing - 5);
                }
               
            }
            if (IsFill(bombs))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            var hasEffects = effects.Any() ? $"Bomb Effects: {string.Join(", ", effects)}" : $"Bomb Effects: empty";
            var hasCasing = casing.Any() ? $"Bomb Effects: {string.Join(", ", casing)}" : $"Bomb Casings: empty";

            Console.WriteLine(hasEffects);
            Console.WriteLine(hasCasing);

            foreach (var item in bombs.OrderBy(b => b.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
        static bool IsFill(Dictionary<string,int> bombs)
        {
           var filled = bombs.All(x => x.Value >= 3);
            return filled;
        }
    }
}
