using System;
using System.Linq;

namespace exam._3._Arrays_and_Generics
{
    
    public static class ArraysIndexers
    {

        // AGGREGATE FUNCTIONS
        public static void AggregateFunctions()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            int[] alsoNumbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
        }
        
        // STATIC FUNCTIONS
        public static void StaticFunctions()
        {
            int[] numbers = new int[5] { 5, 3, 4, 1, 2 };
            int[] copy = new int[5];
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Array.Copy(numbers, copy, 5);
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", copy));
        }

        // MULTI-DIMENSIONAL ARRAYS
        public static void MultiDimArrays()
        {
            // JAGGED
            int[][] jaggedArray =
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 1, 2, 3, 4 }
            };
            // FIXED
            int[,] multiDimArray =
            {
                { 1, 2, 3 },
                { 1, 2, 3 },
                { 1, 2, 3 }
            };
            Console.WriteLine($"[0][0]: {jaggedArray[0][0]}\n[1][3]: {jaggedArray[1][3]}\n[2][1]: {jaggedArray[2][1]}");
            Console.WriteLine($"[0,0]: {multiDimArray[0,0]}\n[1,1]: {multiDimArray[1,1]}\n[2,2]: {multiDimArray[2,2]}");
        }
        
    }
    
}