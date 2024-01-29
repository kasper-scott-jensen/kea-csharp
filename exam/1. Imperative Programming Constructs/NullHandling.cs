using System;
using System.Linq;

namespace exam._1._Imperative_Programming_Constructs
{
    
    public static class NullHandling
    {

        // NULLABLE TYPES
        public static void NullableTypes()
        {
            int? nullableInt = null;
            double? nullableDouble = 3.14;
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"Nullable int value: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("Nullable int is null");
            }
        }

        // NULL COALESCING OPERATOR
        public static void NullCoalescingOperator()
        {
            string name = null;
            string displayName = name ?? "Guest";
            Console.WriteLine($"Welcome, {displayName}");
        }

        // NULL CONDITIONAL OPERATOR
        public static void NullConditionalOperator()
        {
            // string result = someObject?.nestedObject?.Property;
        }
        
    }
    
}