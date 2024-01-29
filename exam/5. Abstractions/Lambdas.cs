using System;
using System.Collections.Generic;
using System.Linq;

namespace exam._5._Abstractions
{
    
    public static class Lambdas
    {
        
        // CLASS FOR LIST
        public class Person
        {
            private int _age;
            
            public Person(int age)
            {
                _age = age;
            }
            
            public int Age
            {
                get => _age;
            }
        }
        
        // LIST
        public static List<Person> People = new List<Person>
        {
            new Person(age: 24),
            new Person(age: 21),
            new Person(age: 32)
        };

        // DELEGATE
        public delegate void MyDelegate();
        public delegate void MyBoolDelegate(int i);
        
        // ACTION
        public static Action MyAction;
        
        // TEST
        public static void Test()
        {
            MyDelegate myDelegate = () => { Console.WriteLine("Hello from Lambda Expression"); };
            myDelegate();
            
            MyBoolDelegate myBoolDelegate = i => { Console.WriteLine(i < 5); };
            myBoolDelegate(2);

            MyAction = () => { Console.WriteLine("Hello from Action."); };
            MyAction();

            People.OrderBy(person => person.Age).ToList().ForEach(person => Console.WriteLine(person.Age));
        }

    }
    
}