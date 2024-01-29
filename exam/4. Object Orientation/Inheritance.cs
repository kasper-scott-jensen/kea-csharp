using System;

namespace exam._4._Object_Orientation
{
    
    public static class Inheritance
    {

        // SUPER-CLASS
        public class Animal
        {
            public string Name { get; set; }

            public Animal(string name)
            {
                Name = name;
            }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }

            public void Sleep()
            {
                Console.WriteLine($"{Name} is sleeping.");
            }
        }

        // SUB-CLASS
        public class Dog : Animal
        {
            private int _age;
            
            public Dog(string name, int dogYears) : base(name)
            {
                _age = dogYears;
            }

            public void GetDogYears()
            {
                Console.WriteLine($"{Name} is {_age} years old in dog years.");
            }
        }
        
    }
    
}