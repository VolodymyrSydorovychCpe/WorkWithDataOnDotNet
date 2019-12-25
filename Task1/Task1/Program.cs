using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input animals5 lags number");
            int lagsNumber = int.Parse(Console.ReadLine());

            while (!AnimalCounter.IsValidNumberOfLags(lagsNumber))
            {
                Console.WriteLine("Animals can not have odd lags number");
                return;
            }

            List<Tuple<int,int>> result = AnimalCounter.CountAnimals(lagsNumber);

            Console.WriteLine("Posible variants:");
            foreach (Tuple<int, int> resultItem in AnimalCounter.CountAnimals(lagsNumber))
            {
                Console.WriteLine("Rabbits number is {0}, ducks number is {1}", resultItem.Item1, resultItem.Item2);
            }
        }
    }
}
