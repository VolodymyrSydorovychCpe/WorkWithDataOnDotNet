using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Task1
{
    class AnimalCounter
    {
        const int rabbitLagsNumber = 4;
        const int duckLagsNumber = 2;
        public static List<Tuple<int, int>> CountAnimals(int lagsNumber)
        {
            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            int maxPossibleNumberOfRabbits = lagsNumber / rabbitLagsNumber;

            for (int rabbitsNumber = maxPossibleNumberOfRabbits; rabbitsNumber > 0; rabbitsNumber--)
            {
                int ducksNumber = (lagsNumber - rabbitsNumber * rabbitLagsNumber) / duckLagsNumber;
                result.Add(new Tuple<int, int>(rabbitsNumber, ducksNumber));
            }
            return result;
        }

        internal static bool IsValidNumberOfLags(int lagsNumber)
        {
            return lagsNumber % 2 == 0;
        }
    }
}
