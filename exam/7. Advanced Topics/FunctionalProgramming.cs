using System;
using System.Collections.Generic;
using System.Linq;

namespace exam._7._Advanced_Topics
{
    
    public static class FunctionalProgramming
    {
        
        // CLASS FOR LIST
        public class Person
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
        public static List<Person> People = new List<Person>
        {
            new Person("Hans", 35),
            new Person("Bob", 21),
            new Person("Alice", 18),
            new Person("Kasper", 5)
        };
        
        // IMPERATIVE SYNTAX
        public static void ImperativeSyntax()
        {
            foreach (var person in People)
            {
                string name = person.Name;
                Console.WriteLine(name);
            }
        }
        
        // FUNCTIONAL SYNTAX
        public static void FunctionalSyntax()
        {
            People.Select(person => person.Name).ToList().ForEach(name => Console.WriteLine(name));
            Console.WriteLine(TernaryStatement(6));
        }

        public static string TernaryStatement(int i)
        {
            return (i < 6) ? "Less than six." : "Six or more.";
        }

    }
    
}