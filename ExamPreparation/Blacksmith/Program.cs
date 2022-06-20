using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> steels = new Queue<int>(input);
            Stack<int> carbons = new Stack<int>(input2);

            Dictionary<string, int> swords = new Dictionary<string, int>
            {

                {"Broadsword",0},
                {"Sabre",0},
                {"Katana",0},
                {"Shamshir",0},
                {"Gladius",0}
            };

            int numSwords = 0;

            while (steels.Count > 0 && carbons.Count > 0)
            {
                int currSteel = steels.Peek();
                int currCarbon = carbons.Peek();
                int mixSum = currSteel + currCarbon;
                if (mixSum == 70)
                {
                    numSwords++;
                    swords["Gladious"]++;
                    steels.Dequeue();
                    carbons.Pop();
                }
                else if (mixSum == 80)
                {
                    numSwords++;
                    swords["Shamshir"]++;
                    steels.Dequeue();
                    carbons.Pop();
                }
                else if (mixSum == 90)
                {
                    numSwords++;
                    swords["Katana"]++;
                    steels.Dequeue();
                    carbons.Pop();
                }
                else if (mixSum == 110)
                {
                    numSwords++;
                    swords["Sabre"]++;
                    steels.Dequeue();
                    carbons.Pop();
                }
                else if (mixSum == 150)
                {
                    numSwords++;
                    swords["Broadsword"]++;
                    steels.Dequeue();
                    carbons.Pop();
                }
                else
                {
                    steels.Dequeue();
                    currCarbon += 5;
                    carbons.Pop();
                    carbons.Push(currCarbon);
                }
            }
            if (numSwords > 0)
            {
                Console.WriteLine($"You have forged {numSwords} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steels.Count == 0)
            {
                Console.WriteLine("Steel left: none");
                
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steels)}");
            }
            if (carbons.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
               
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbons)}");
            }

            SortedDictionary<string, int> sorted = new SortedDictionary<string, int>(swords);

            foreach (var sword in sorted)
            {
                if (sword.Value > 0)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
                
            }

        }
    }
}
