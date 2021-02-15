using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Demo
{
    abstract class Shape
    {
        public abstract string Name { get; set; }
        public abstract int NumberOfSides { get; set; }
        public abstract bool Is_3Dimensional { get; set; }

        public abstract double Area(double x);
        public abstract double Perimeter(params double[] sides);

        public virtual double Volume()
        {
            throw new NotImplementedException();
        }

        public virtual double SurfaceArea()
        {
            throw new NotImplementedException();
        }
    }
}
