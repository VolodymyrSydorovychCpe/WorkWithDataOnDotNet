using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        private static String stringForClearUp;

        private static String symbolsToRemove;

        static void Main(string[] args)
        {
            Console.WriteLine("Please input line where you want to remove symbols");
            stringForClearUp = Console.ReadLine();
            
            Console.WriteLine("Please input symbols that you want to remove");
            symbolsToRemove = Console.ReadLine();

            RemoveSimillarSimbols();

            Console.WriteLine("Result is: " + stringForClearUp);
        }

        private static void RemoveSimillarSimbols()
        {
            List<char> result = new List<char>();
            char[] symbolsToRemoveArray = symbolsToRemove.ToCharArray();

            foreach(char item in stringForClearUp.ToCharArray())
            {
                if (symbolsToRemove.IndexOf(item) < 0)
                {
                    result.Add(item);
                }
            }
            stringForClearUp = string.Join("", result);
        }
    }
}
