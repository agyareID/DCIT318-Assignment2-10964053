using System;

namespace AbstractClassesAndMethods
{
    
    abstract class Shape
    {
        
        public abstract double GetArea();
    }

    
    class Circle : Shape
    {
        private double radius;

        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    
    class Rectangle : Shape
    {
        private double length;
        private double width;

        
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        
        
        public override double GetArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Shape circle = new Circle(6.0);
            Shape rectangle = new Rectangle(8.0, 4.0);

            
            Console.WriteLine($"The area of the circle is: {circle.GetArea()}");        
            
            Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}"); 
            
        }
    }
}
