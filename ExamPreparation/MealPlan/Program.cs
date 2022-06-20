using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meals = Console.ReadLine().Split().ToArray();
            List<int> dailyCaloriesIntake = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<string> queue = new Queue<string>(meals);
            Stack<int> stack = new Stack<int>(dailyCaloriesIntake);
            int mealsCount = 0;
            while (queue.Count > 0 && stack.Count > 0)
            {
                string currMeal = queue.Peek();
                int currCalsForDay = stack.Peek();

                if (currMeal == "salad")
                {
                    mealsCount++;
                    currCalsForDay -= 350;
                    
                    queue.Dequeue();
                }
                else if (currMeal == "soup")
                {
                    mealsCount++;
                    currCalsForDay -= 490;
                    queue.Dequeue();
                }
                else if (currMeal == "pasta")
                {
                    mealsCount++;
                    currCalsForDay -= 680;
                    queue.Dequeue();
                }
                else if (currMeal == "steak")
                {
                    mealsCount++;
                    currCalsForDay -= 790;
                    queue.Dequeue();
                }
                if (currCalsForDay <= 0)
                {
                    int calsRest = Math.Abs(currCalsForDay);
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        break;
                    }
                    int nextCals = stack.Pop() - calsRest;
                    stack.Push(nextCals);

                }
                else
                {
                    stack.Pop();
                    stack.Push(currCalsForDay);
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine($"John had {mealsCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ",stack)} calories.");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine($"John ate enough, he had {mealsCount} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ",queue)}.");
            }

           
            
        }
    }
}
