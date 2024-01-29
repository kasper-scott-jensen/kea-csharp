using System;

namespace exam._3._Arrays_and_Generics
{
    
    public static class Generics
    {

        // GENERIC METHOD
        public static void GenericMethod<T>(T item)
        {
            Console.WriteLine(item);
        }
        
        // GENERIC CLASS
        public class GenericClass<T>
        {
            private T _content;

            public void Replace(T item)
            {
                _content = item;
            }

            public T GetContent()
            {
                return _content;
            }
        }
        
        // TEST
        public static void Test()
        {
            GenericMethod(5);
            GenericMethod("Hello!");

            var genericClass = new GenericClass<string>();
            genericClass.Replace("Replace this!");
            Console.WriteLine(genericClass.GetContent());
        }
        
    }
    
}