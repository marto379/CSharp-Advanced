using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            //First, you will be given a sequence representing steel. 
            int[] steel = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Afterward, you will be given another sequence representing carbon.
            int[] carbon = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //You should start from the first steel -> FIFO
            Queue<int> queueSteel = new Queue<int>(steel);
            //and try to mix it with the last carbon.
            Stack<int> stackCarbon = new Stack<int>(carbon);

            // Трябва да съхраняваме произведените мечове от вид
            // Запис име на меч -> брой
            Dictionary<string, int> swords = new Dictionary<string, int>
            {
                {"Gladius", 0 },
                {"Shamshir", 0 },
                {"Katana", 0 },
                {"Sabre", 0 },
                {"Broadsword", 0 }
            };

           
            int totalSwords = 0; // За отпечатването ни трябва общия брой мечове, като има изкован ++
            while (queueSteel.Count > 0 && stackCarbon.Count > 0)
            {
                int currentSteel = queueSteel.Peek();
                int currentCarbon = stackCarbon.Peek();
                int sum = currentSteel + currentCarbon;

                if (sum == 70)
                {
                    //Изработваме Gladius
                    swords["Gladius"]++;
                    totalSwords++;
                    queueSteel.Dequeue(); // премахваме първият елемент от опашката
                    stackCarbon.Pop(); // премахваме най горния елемент от стека
                }
                else if (sum == 80)
                {
                    //Изработваме Shamshir
                    swords["Shamshir"]++;
                    totalSwords++;
                    queueSteel.Dequeue(); // премахваме първият елемент от опашката
                    stackCarbon.Pop(); // премахваме най горния елемент от стека
                }
                else if (sum == 90)
                {
                    //Изработваме Katana
                    swords["Katana"]++;
                    totalSwords++;
                    queueSteel.Dequeue(); // премахваме първият елемент от опашката
                    stackCarbon.Pop(); // премахваме най горния елемент от стека
                }
                else if (sum == 110)
                {
                    //Изработваме Sabre
                    swords["Sabre"]++;
                    totalSwords++;
                    queueSteel.Dequeue(); // премахваме първият елемент от опашката
                    stackCarbon.Pop(); // премахваме най горния елемент от стека
                }
                else if (sum == 150)
                {
                    //Изработваме Broadsword
                    swords["Broadsword"]++;
                    totalSwords++;
                    queueSteel.Dequeue(); // премахваме първият елемент от опашката
                    stackCarbon.Pop(); // премахваме най горния елемент от стека
                }
                else
                {
                    //Ако не изработваме меч
                    queueSteel.Dequeue();
                    currentCarbon += 5;
                    stackCarbon.Pop();
                    stackCarbon.Push(currentCarbon);
                }
            }
           
            if (totalSwords > 0)
            {
                Console.WriteLine($"You have forged {totalSwords} swords.");
            }
            else
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            }

            
            if (queueSteel.Count == 0)
            {
                Console.WriteLine($"Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: " + String.Join(", ", queueSteel));
            }

           
            if (stackCarbon.Count == 0)
            {
                Console.WriteLine($"Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: " + String.Join(", ", stackCarbon));
            }

           

            SortedDictionary<string, int> sortedSwords = new SortedDictionary<string, int>(swords);

            // на сортирания речник разпечатваме само тези мечове оито имат изработен такъв
            foreach (var keyValuePair in sortedSwords)
            // ако не го сортираме преди това може->
            //  foreach (var keyValuePair in sortedSwords.OrdderBy(pair => pair.key))
            {
                if (keyValuePair.Value > 0)
                {
                    Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
                }
            }
        }
    }
}