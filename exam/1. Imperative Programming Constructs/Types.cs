using System;

namespace exam._1._Imperative_Programming_Constructs
{
    
    public static class Types
    {

        // TYPE CONVERSION
        public static void TypeConversion()
        {
            // IMPLICIT
            int intValue = 32;
            double doubleValue = intValue;
            Console.WriteLine(doubleValue);
            // PARSING
            string strValue = "123";
            int parsedInt = int.Parse(strValue);
            Console.WriteLine(parsedInt);
            // CASTING
            double doubleNumber = 3.14;
            int castedInt = (int)doubleNumber;
            Console.WriteLine(castedInt);
        }

        // TYPE CHECKING / TYPE MATCHING
        public static void TypeChecking()
        {
            object value = "HelloWorld";
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

        // SAFE CASTING (AS OPERATOR)
        public static void SafeCasting()
        {
            object obj = "Hello";
            string str = obj as string;
            if (str != null)
            {
                Console.WriteLine($"Successfully casted: {str}");
            }
            else
            {
                Console.WriteLine("Casting failed");
            }
        }

        // TYPEOF GETTYPE
        public static void TypeOf()
        {
            string text = "Hello";
            if (text.GetType() == typeof(string))
            {
                Console.WriteLine("The actual type matches the expected type.");
            }
        }
        
        // TYPE CLASS
        public static void TypeInformation()
        {
            Type stringType = typeof(string);
            Console.WriteLine($"Full Name: {stringType.FullName}");
            Console.WriteLine($"Is Value Type: {stringType.IsValueType}");
            Console.WriteLine($"Is Array: {stringType.IsArray}");
        }
        
    }
    
}