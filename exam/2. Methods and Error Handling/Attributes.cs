using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace exam._2._Methods_and_Error_Handling
{
    
    
    public static class Attributes
    {

        public static void AttributeAndValidation()
        {
            Person person = new Person("Kasper", 50, "kasperscott94@gmail.com", "91743642");
            bool validity = Person.Validate(person);
            Console.WriteLine("Person validity: " + validity);
        }

    }
    
    // CLASS WITH EXAMPLE ATTRIBUTES AND VALIDATION
    public class Person
    {
        
        // ATTRIBUTES
        [Required] public string Name { get; set; }
        [Range(1, 99)] public int Age { get; set; }
        [EmailAddress] public string Email { get; set; }
        [Phone] public string Phone { get; set; }
        
        public Person(string name, int age, string email, string phone)
        {
            Name = name;
            Age = age;
            Email = email;
            Phone = phone;
        }

        // VALIDATION METHOD
        public static bool Validate(Person person)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(person);
            return Validator.TryValidateObject(person, context, results, true);
        }
        
    }
    
}