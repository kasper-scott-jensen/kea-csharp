using System;

namespace exam._1._Imperative_Programming_Constructs
{
    
    public static class PatternMatching
    {

        // TYPE MATCHING
        public static void TypeMatching()
        {
            object value = "string";
            if (value is string stringValue)
            {
                Console.WriteLine($"The value is a string: {stringValue}");
            }
            else if (value is int intValue)
            {
                Console.WriteLine($"The value is an int: {intValue}");
            }
            else
            {
                Console.WriteLine("Unknown type");
            }
        }
        
        // PROPERTY MATCHING
        public static void PropertyMatching()
        {
            var person = new { Name = "Bob", Age = 32 };
            if (person is { Name: "Bob" } bob)
            {
                Console.WriteLine($"Found Bob, age: {bob.Age}");
            }
        }

        // SWITCH PATTERN MATCHING
        public static void Switch()
        {
            object item = "string";
            string message = item switch
            {
                string str => $"String value: {str}",
                int num => $"Integer value: {num}",
                _ => "Unknown value"
            };
            Console.WriteLine(message);
        }

        // COMBINATIONS
        public static void Combinations()
        {
            object item = 42;
            if (item is int intValue && intValue > 0)
            {
                Console.WriteLine($"Positive integer: {intValue}");
            }
        }
        
    }
    
}