using System;

namespace Task4
{
    class Program
    {
        const int defaultValueForRowSum = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Please input matrix size in format \"x,y\" where x - number of rows, y - number of columns");
            String[] inputMatrixSize = Console.ReadLine().Split(",");
            int rowNumber = int.Parse(inputMatrixSize[0]);
            int columnNumber = int.Parse(inputMatrixSize[1]);

            int[,] matrix = GetInputedMatrix(rowNumber, columnNumber);
            int[] result = new int[rowNumber];

            for (int i = 0; i < rowNumber; i++)
            {
                result[i] = GetArraySum(matrix, i, columnNumber);
            }
            Console.Write("Result is: " + string.Join(",", result));
        }        
        private static int[,] GetInputedMatrix(int rowNumber, int columnNumber)
        {
            int[,] matrix = new int[rowNumber, columnNumber];
            for (int i = 0; i < rowNumber; i++)
            {
                Console.WriteLine("Please input row number {0} in format: \"1,2,3,4\"", i);
                String[] arrayLineString = Console.ReadLine().Split(",");
                for (int y = 0; y < columnNumber; y++)
                {
                    matrix[i, y] = int.Parse(arrayLineString[y]);
                }
            }
            return matrix;
        }
        private static int GetArraySum(int[,] matrix, int currentRow, int columnNumber)
        {
            Boolean hasRowNegativeNumber = false;
            int sum = 0;
            for (int i = 0; i < columnNumber; i++)
            {
                int currentItem = matrix[currentRow, i];
                if (hasRowNegativeNumber)
                {
                    sum += currentItem;
                }
                if (currentItem < 0)
                {
                    hasRowNegativeNumber = true;
                }
            }
            return hasRowNegativeNumber ? sum : defaultValueForRowSum;
        }
    }
}
