using System;
using System.Collections.Generic;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string, int>> wardrobe = new Dictionary<string,Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                string[] clothes = input[1].Split(",");
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }
                    wardrobe[color][clothes[j]]++;
                }
            }
            string[] itemToFind = Console.ReadLine().Split();
            string colorToFind = itemToFind[0];
            string clothToFind = itemToFind[1];

            foreach (var colors in wardrobe)
            {
                string color = colors.Key;
                Console.WriteLine($"{color} clothes:");
                Dictionary<string, int> clothes = colors.Value;
                foreach (var cloth in clothes)
                {
                    if (colorToFind == colors.Key && clothToFind == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                   
                }
                    
                
            }
        }
    }
}
