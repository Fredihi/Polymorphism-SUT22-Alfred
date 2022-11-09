using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_SUT22_Alfred
{
    public class Circle : Geometry
    {
        public double Radius;

        public Circle()
        {
            Radius = 4;
        }
        //A method that we can override to act differently
        public override double Area()
        {
            return Radius * Radius * 3.14;
        }
    }
}
