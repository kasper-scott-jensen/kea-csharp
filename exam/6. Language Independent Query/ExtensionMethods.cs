using System;
using System.Collections.Generic;
using System.Linq;

namespace exam._6._Language_Independent_Query
{
    
    public static class ExtensionMethods
    {
        
        // LISTS TO MODIFY
        private static List<string> _fruits = new List<string> { "apple", "orange", "banana" };

        // EXTENSION METHODS
        public static void Test()
        {

            // FILTER
            var filteredFruits = _fruits.Where(fruit => fruit != "apple");
            foreach (var fruit in filteredFruits)
            {
                Console.WriteLine(fruit);
            }
            
            // PROJECTION
            var uppercaseFruits = _fruits.Select(fruit => fruit.ToUpper());
            foreach (var fruit in uppercaseFruits)
            {
                Console.WriteLine(fruit);
            }
            
            // SORTING
            var sortedFruits = _fruits.OrderBy(fruit => fruit);
            foreach (var fruit in sortedFruits)
            {
                Console.WriteLine(fruit);
            }
            
            // CUSTOM
            string randomString = "this is a random string";
            Console.WriteLine(randomString.ReverseRandomString());

        }
        
        public static string ReverseRandomString(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        
    }
    
}