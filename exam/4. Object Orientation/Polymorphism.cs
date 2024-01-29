using System;

namespace exam._4._Object_Orientation
{
    
    public static class Polymorphism
    {

        // SUPER-CLASS
        public class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a generic shape.");
            }
        }
        
        // SUB-CLASS 1
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle.");
            }
        }
        
        // SUB-CLASS 2
        public class Square : Shape
        {
            public override void Draw()
            {  
                Console.WriteLine("Drawing a square.");
            }
        }

        // POLYMORPHIC METHOD
        public static void DrawShape(Shape shape)
        {
            shape.Draw();
        }
        
    }
    
}