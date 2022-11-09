using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_SUT22_Alfred
{
    public class Geometry
    {
        public double _radius;

        //Creates a virtual method that we can override in other classes
        public virtual double Area()
        {
            double area = 0;
            return area;
        }
    }
}
