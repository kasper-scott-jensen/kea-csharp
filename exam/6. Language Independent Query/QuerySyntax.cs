using System;
using System.Collections.Generic;
using System.Linq;

namespace exam._6._Language_Independent_Query
{
    
    public static class QuerySyntax
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
        
        // LIST
        private static List<Person> _people = new List<Person>
        {
            new Person("Bob", 41),
            new Person("Alice", 35),
            new Person("Hans", 21),
            new Person("Kasper", 5)
        };
        
        // QUERY
        public static void Test()
        {
            var resultSet =
                from person in _people
                where person.Age < 36
                orderby person.Age descending
                select $"Name: {person.Name}, age: {person.Age}"
            ;
            foreach (var element in resultSet)
            {
                Console.WriteLine(element);
            }
        }

    }
    
}