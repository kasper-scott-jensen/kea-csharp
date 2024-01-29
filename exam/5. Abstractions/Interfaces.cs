using System;

namespace exam._5._Abstractions
{
    
    public class Interfaces
    {

        // INTERFACE
        public interface IShape
        {
            void Draw();
            double CalculateArea();
        }

        // CLASS IMPLEMENTATION
        public class Circle : IShape
        {
            private double _radius;

            public Circle(double radius)
            {
                _radius = radius;
            }

            public void Draw()
            {
                Console.WriteLine("Drawing a circle.");
            }

            public double CalculateArea()
            {
                return Math.PI * Math.Pow(_radius, 2);
            }
        }
        
        // TEST
        public static void Test()
        {
            IShape circle = new Circle(5.2);
            circle.Draw();
            Console.WriteLine("Area: " + circle.CalculateArea());
        }
        
    }
    
}