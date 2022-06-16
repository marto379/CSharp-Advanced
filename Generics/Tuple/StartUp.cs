using System;

namespace Tuple
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var city = personInfo[2];

            var nameAndBeer = Console.ReadLine().Split();
            var name = nameAndBeer[0];
            var littersBeer = int.Parse(nameAndBeer[1]);

            var numbersInput = Console.ReadLine().Split();
            var intNum = int.Parse(numbersInput[0]);
            var doubleNum = double.Parse(numbersInput[1]);

            Touple<string, string> firstTuple = new Touple<string, string>(fullName, city);
            Touple<string,int> secondTuple = new Touple<string, int>(name,littersBeer);
            Touple<int,double> thirdTuple = new Touple<int, double>(intNum, doubleNum);

            Console.WriteLine($"{firstTuple}\n{secondTuple}\n{thirdTuple}");


        }
    }
}
