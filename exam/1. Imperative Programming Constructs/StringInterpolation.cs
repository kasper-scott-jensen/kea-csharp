using System;

namespace exam._1._Imperative_Programming_Constructs
{
    
    public static class StringInterpolation
    {

        // BASIC INTERPOLATION
        public static void Basic()
        {
            string name = "Alice";
            int age = 30;
            string message = $"Hello, my name is {name} and I am {age} years old.";
            Console.WriteLine(message);
        }

        // EXPRESSIONS
        public static void Expression()
        {
            int x = 10;
            int y = 20;
            string result = $"The sum of {x} and {y} is {x + y}.";
            Console.WriteLine(result);
        }

        // FORMATTING
        public static void Formatting()
        {
            double pi = Math.PI;
            string formatted = $"The value of pi is approximately {pi:F2}.";
            Console.WriteLine(formatted);

        }

        // OBJECTS
        public static void Objects()
        {   
            var person = new { Name = "Bob", Age = 30 };
            string personInfo = $"Name: {person.Name}, Age: {person.Age}.";
            Console.WriteLine(personInfo);
        }

        // METHOD CALLING
        public static void MethodCall()
        {
            int num1 = 10;
            int num2 = 5;
            string result = $"{num1} + {num2} = {Add(num1, num2)}";
            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        
    }
    
}