using System;

namespace Treeuple
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var nameCity = Console.ReadLine().Split();
            var fullName = $"{nameCity[0]} {nameCity[1]}";
            var street = nameCity[2];
            var city = nameCity.Length > 4 ? $"{nameCity[3]} {nameCity[4]}" : nameCity[3];

            var nameAgeDrunk = Console.ReadLine().Split();
            var name = nameAgeDrunk[0];
            var age = int.Parse(nameAgeDrunk[1]);
            bool isDrunk = nameAgeDrunk[2] == "drunk" ?  true : false;

            var nameBank = Console.ReadLine().Split();
            string nameP = nameBank[0];
            double num = double.Parse(nameBank[1]);
            string bankName = nameBank[2];

            Treeuple<string, string, string> firstTreeuple = new Treeuple<string, string, string>(fullName,street,city);
            Treeuple<string,int,bool> secondTreeuple = new Treeuple<string, int, bool>(name,age,isDrunk);
            Treeuple<string, double, string> thirdTreeiple = new Treeuple<string, double, string>(nameP, num, bankName);

            Console.WriteLine($"{firstTreeuple}\n{secondTreeuple}\n{thirdTreeiple}");



        }
    }
}
