using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_SUT22_Alfred
{
    public class Rectangle : Geometry
    {
        public double Height;
        public double Base;

        public Rectangle()
        {
            Height = 5;
            Base = 2.5;
        }
        //A method that we can override to act differently
        public override double Area()
        {
            return Base * Height;
        }
    }
}
