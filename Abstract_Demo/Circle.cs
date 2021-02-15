using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Demo
{
    class Circle : Shape
    {
        public override string Name { get; set; } = "Circle";
        public override int NumberOfSides { get; set; } = 0;
        public override bool Is_3Dimensional { get; set; } = false;

        public override double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter(params double[] sides) // if the shape is a circle then enter in the radius
        {
            return Math.PI * sides[0] * 2;
        }

        public override double Volume()
        {
            return 0;
        }

        public override double SurfaceArea()
        {
            Console.WriteLine("Please enter the radius");
            var r = double.Parse(Console.ReadLine());

            var c = new Circle();
            return c.Area(r);
        }
    }
}
