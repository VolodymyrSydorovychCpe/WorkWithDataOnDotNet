using System;
using System.Text;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input line where you want to remove symbols");
            StringBuilder stringForClearUp = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Please input symbols that you want to remove");
            String symbolsToRemove = Console.ReadLine();

            RemoveSimillarSimbols(stringForClearUp, symbolsToRemove);

            Console.WriteLine("Result is: " + stringForClearUp);
        }

        private static void RemoveSimillarSimbols(StringBuilder stringForClearUp, String symbolsToRemove)
        {
            foreach (char item in symbolsToRemove.ToCharArray())
            {
                stringForClearUp.Replace(item.ToString(), "");
            }
        }
    }
}
