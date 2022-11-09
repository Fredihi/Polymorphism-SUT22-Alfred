using System;

namespace Polymorphism_SUT22_Alfred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Geometry rectangle  = new Rectangle();
            Console.WriteLine("Arean på rektangeln är {0}cm", rectangle.Area());

            Geometry square = new Square();
            Console.WriteLine("Arean på fyrkanten är {0}cm", square.Area());

            Geometry circle = new Circle();
            Console.WriteLine("Arean på cirkeln är {0}cm", circle.Area());
        }
    }
}
