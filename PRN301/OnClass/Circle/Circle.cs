
using Circle;
using System;


namespace OOP_Circle{
     class Circle : GeometricObject
    {
        
        public double Radius { get; set; }

        public Circle(double Radius)
        {

            this.Radius = Radius;

        }
        public double Perimeter
        {
            get => Radius * 2 * Math.PI;
        }
        //biến thay thế
        public double Area
        {
            get => Radius * Radius * Math.PI;    }
        public override String ToString()
        {
            Console.WriteLine("Circle Radius: " + Radius);
            Console.WriteLine("Circle Perimeter: " + Perimeter);
            Console.WriteLine("Circle Area: " + Area);

        }
    }
}
