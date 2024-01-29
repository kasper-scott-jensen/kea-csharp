using System;

namespace exam._2._Methods_and_Error_Handling
{
    
    public static class TuplesDeconstructors
    {

        // BASIC EXAMPLES
        public static void TupleExample()
        {
            Tuple<string, string> t1 = new Tuple<string, string>("Hello", "World");
            var t2 = Tuple.Create("Hello", "World");
            Console.WriteLine($"T1 has item 1: {t1.Item1} and item 2: {t1.Item2}");
            Console.WriteLine($"T2 has item 1: {t2.Item1} and item 2: {t2.Item2}");
        }
        
        // DECONSTRUCTION
        public static void Deconstruction()
        {
            Tuple<string, string> t = new Tuple<string, string>("Hello", "World");
            (string s1, string s2) = t;
            Console.WriteLine($"Tuple deconstructed into s1: {s1} and s2: {s2}");
        }
        
        // NAMED PARAMETERS / EXPLICIT PROPERTIES
        public static void NamedParameters()
        {
            var t = GetNamedParametersTuple(1, 1);
            Console.WriteLine($"First item is {t.FirstNumber}. Second item is {t.SecondNumber}");
        }

        static (int FirstNumber, int SecondNumber) GetNamedParametersTuple(int a, int b)
        {
            int x = a + b;
            int y = a - b;
            return (FirstNumber: x, SecondNumber: y);
        }
        
    }
    
}