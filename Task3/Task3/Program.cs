using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first array in format \"1,2,3,4\"");
            int[] firstArray = StringToIntArray(Console.ReadLine());

            Console.WriteLine("Insert second array in format \"1,2,3,4\"");
            int[] secondArray = StringToIntArray(Console.ReadLine());

            Console.WriteLine("Result is: " + string.Join(",", FindIntersections(firstArray, secondArray)));
        }

        static int[] StringToIntArray(String stringArray)
        {
            List<int> result = new List<int>();
            foreach(String item in stringArray.Split(",")) {
                result.Add(int.Parse(item));
            }

            return result.ToArray();
        }

        static int[] FindIntersections(int[] firstArray, int[] secondArray)
        {
            int[] firstArraySorted = new int[firstArray.Length];
            int[] secondArraySorted = new int[secondArray.Length];

            Array.Copy(firstArray, 0, firstArraySorted, 0, firstArray.Length);
            Array.Copy(secondArray, 0, secondArraySorted, 0, secondArray.Length);

            Array.Sort(firstArraySorted);
            Array.Sort(secondArraySorted);

            List<int> result = new List<int>();

            int firstArrayIndex = 0;
            int secondArrayIndex = 0;

            while(firstArrayIndex < firstArraySorted.Length && secondArrayIndex < secondArraySorted.Length)
            {
                if (firstArraySorted[firstArrayIndex] == secondArraySorted[secondArrayIndex])
                {
                    result.Add(firstArraySorted[firstArrayIndex]);
                    firstArrayIndex++;
                    secondArrayIndex++;
                    continue;
                }
                if (firstArraySorted[firstArrayIndex] < secondArraySorted[secondArrayIndex])
                {
                    firstArrayIndex++;
                } else if (firstArraySorted[firstArrayIndex] > secondArraySorted[secondArrayIndex])
                {
                    secondArrayIndex++;
                }
            }
            return result.ToArray();
        }
    }
}
