using System;
using System.Collections.Generic;

namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dict = new SortedDictionary<string, Dictionary<string, double>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] data = input.Split(',');
                string shopName = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);   
                if (!dict.ContainsKey(shopName))
                {
                    dict.Add(shopName, new Dictionary<string, double>());
                }
                if (!dict[shopName].ContainsKey(product))
                {
                    dict[shopName].Add(product, new double());  
                }
                dict[shopName][product] = price;
            }
            foreach (var dic in dict)
            {
                Console.WriteLine(dic.Key + "->");
                foreach (var item in dic.Value)
                {
                    string prod = item.Key;
                    double price = item.Value;
                    Console.WriteLine($"Product: {prod}, Price: {price}");
                }
            }
        }
    }
}
