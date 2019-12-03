using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please imput number consisted from not more than 4 digits");
            int inputNumber = int.Parse(Console.ReadLine());
            if (!IsValidNumber(inputNumber))
            {
                Console.WriteLine("Your number is too long");
                return;
            }

            int[,] powMatrix = PreparePowMatrix(10, 4);
            Console.WriteLine("Result is: " + string.Join(",", GetAllArmstrongNumberLowerOrEqual(inputNumber, powMatrix)));            
        }

        static Boolean IsValidNumber(int number)
        {
            return number / 10000 < 1;
        }

        static int[,] PreparePowMatrix(int lines, int rows)
        {
            int[,] powMatrix = new int[4, 10];
            for (int i = 0; i < rows; i++)
            {
                for (int y = 0; y < lines; y++)
                {
                    powMatrix[i, y] = (int)Math.Pow(y, i + 1);
                }
            }
            return powMatrix;
        }

        private static int[] GetAllArmstrongNumberLowerOrEqual(int inputNumber, int[,] powMatrix)
        {
            List<int> result = new List<int>();
            for (int armstrongCandidate = 0; armstrongCandidate <= inputNumber; armstrongCandidate++)
            {
                if (IsArmstrongNumber(armstrongCandidate, powMatrix))
                {
                    result.Add(armstrongCandidate);
                }
            }
            return result.ToArray();
        }

        private static bool IsArmstrongNumber(int armstrongCandidate, int[,] powMatrix)
        {
            int[] digits = SplitNumberToDigits(armstrongCandidate);
            int x = 0;
            foreach (int item in digits)
            {
                x += powMatrix[digits.Length - 1, item];
            }
            return armstrongCandidate == x;
        }

        private static int[] SplitNumberToDigits(int armstrongCandidate)
        {
            List<int> result = new List<int>();
            foreach (char item in armstrongCandidate.ToString().ToCharArray())
            {
                result.Add(int.Parse(item.ToString()));
            }
            return result.ToArray();
        }
    }
}
