using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_SUT22_Alfred
{
    public class Square : Geometry
    {
        public double Side;
        
        public Square()
        {
            Side = 4.3;
        }
        //A method that we can override to act differently
        public override double Area()
        {  
            return Side * Side;
        }
    }
}
