using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input line where you want to remove symbols");
            String stringForClearUp = Console.ReadLine();
            
            Console.WriteLine("Please input symbols that you want to remove");
            String symbolsToRemove = Console.ReadLine();

            Console.WriteLine("Result is: " + RemoveSimillarSimbols(stringForClearUp, symbolsToRemove));
        }

        private static String RemoveSimillarSimbols(String stringWhereRemove, String symbolsToRemove)
        {
            List<char> result = new List<char>();
            ;
            char[] symbolsToRemoveArray = symbolsToRemove.ToCharArray();

            foreach(char item in stringWhereRemove.ToCharArray())
            {
                if (symbolsToRemove.IndexOf(item) < 0)
                {
                    result.Add(item);
                }
            }
            return string.Join("", result);
        }
    }
}
