using System;
using System.Collections.Generic;
using System.Linq;

namespace exam._6._Language_Independent_Query
{
    
    public static class Methods
    {
        // CLASS FOR LIST
        private class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        
        // LIST TO MODIFY
        private static List<Person> _people = new List<Person>
        {
            new Person("Bob", 25),
            new Person("Alice", 30),
            new Person("Hans", 51),
            new Person("Kasper", 5)
        };
        
        // METHODS CHAINING
        public static void Test()
        {
            var resultSet2 = _people
                .Where(person => person.Age > 25)
                .OrderBy(person => person.Name)
                .Select(person => person.Name);
            foreach (var element in resultSet2)
            {
                Console.WriteLine(element);
            }
        }

    }
    
}