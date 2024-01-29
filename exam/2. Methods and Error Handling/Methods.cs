using System;
using System.Runtime.InteropServices;

namespace exam._2._Methods_and_Error_Handling
{
    
    public static class Methods
    {
        //
        public class Student
        {
            public string Name { get; set; }
            public bool Enrolled { get; set; }
        }
        
        // REF MODIFIER (MODIFIES ORIGINAL)
        public static void RefModifier()
        {
            var student = new Student
            {
                Name = "Alice",
                Enrolled = false
            };
            EnrollStudentRef(ref student);
            Console.WriteLine(student.Enrolled);
        }

        static void EnrollStudentRef(ref Student student)
        {
            student.Enrolled = true;
        }
        
        // OUT MODIFIER (MUST PRODUCE VALUE)
        public static void OutModifier()
        {
            Student student;
            EnrollStudentOut(out student);
            Console.WriteLine(student.Enrolled);
        }

        static void EnrollStudentOut(out Student student)
        {
            student = new Student();
            student.Enrolled = true;
        }
        
        // IN MODIFIER (PASSED AS READ-ONLY)
        public static void InModifier()
        {
            var student = new Student
            {
                Name = "Alice",
                Enrolled = false
            };
            EnrollStudentIn(student);
            Console.WriteLine(student.Enrolled);
        }

        static void EnrollStudentIn(in Student student)
        {
            student.Enrolled = true;
            // student = new Student();
        }
        
        // NAMED PARAMETERS
        public static void NamedParameters()
        {
            int x = AddNumber(a: 3, b: 4);
            int y = AddNumber(b: 4, a: 3);
            int z = AddNumber(3, b: 4);
            Console.WriteLine("X: " + x + ", Y: " + y + ", Z: " + z);
        }

        static int AddNumber(int a, int b)
        {
            return a + b;
        }
        
        // OVERLOADING
        public static void Overloading()
        {
            int x = AddAnotherNumber(12, 2);
            int y = AddAnotherNumber(12);
            Console.WriteLine("X: " + x + ", Y: " + y);
        }

        static int AddAnotherNumber(int a, int b)
        {
            return a + b;
        }

        static int AddAnotherNumber(int a)
        {
            return a + 0;
        }
        
        // PARAMS OPERATOR
        public static void ParamsOperator()
        {
            int x = AddParams(12, 6, 8);
            int y = AddParams(12, 6);
            Console.WriteLine("X: " + x + ", Y: " + y);
        }

        static int AddParams(params int[] values)
        {
            int result = 0;
            foreach (var val in values)
            {
                result += val;
            }
            return result;
        }
        
        // DEFAULT VALUES
        public static void DefaultValues()
        {
            int x = AddWithDefault(12);
            int y = AddWithDefault(12, 13);
            Console.WriteLine("X: " + x + ", Y: " + y);
        }

        static int AddWithDefault(int a, int b = 13)
        {
            return a + b;
        }
        
        // OPTIONAL ATTRIBUTE
        public static void OptionalAttribute()
        {
            int x = AddOptional(12);
            int y = AddOptional(12, 13);
            Console.WriteLine("X: " + x + ", Y: " + y);
        }

        static int AddOptional(int a, [Optional] int b)
        {
            return a + b;
        }
        
    }
    
}