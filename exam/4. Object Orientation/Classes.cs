namespace exam._4._Object_Orientation
{
    
    public static class Classes
    {
        
        // NON-STATIC CLASS
        public class NonStaticClass
        {
            private int _property1;
            private string _property2;

            public NonStaticClass(int property1, string property2)
            {
                _property1 = property1;
                _property2 = property2;
            }

            public int Property1
            {
                get => _property1;
                set => _property1 = value;
            }

            public string Property2
            {
                get => _property2;
                set => _property2 = value;
            }
        }
        
        // STATIC CLASS
        public static class StaticClass
        {
            private static int _number;

            public static void AddThis(int numberToAdd)
            {
                _number += numberToAdd;
            }

            public static int GetNumber()
            {
                return _number;
            }
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
        
        // STRUCT
        public struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }
        
    }
    
}